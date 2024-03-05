using BusesUNED_Server.Utilidades;
using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using LibBusesUNED_comun.Red;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading;
using System.Collections.Generic;

namespace BusesUNED_Server.Red
{
    /// <summary>
    /// Clase que representa el servidor de socket. Abstrae  la complejidad del manejo de los sockets
    /// </summary>
    public class ServidorSocket
    {
        // Para escuchar por TCP
        private TcpListener tcpListener;

        // Estado del servidor
        private bool servidorIniciado;

        // Para la bitácora de eventos
        private Bitacora bitacora;
        
        // Para registrar la lista de clientes conectados
        private GestorClientes clientesConectados;

        // Para llevar un hilo que escuche por conexiones cliente
        private Thread hiloEscuchaClientes;

        private ServicioConductor servicioConductor;
        private ServicioRol servicioRol;
        private ServicioRuta servicioRuta;
        private ServicioAutobus servicioAutobus;

        /// <summary>
        /// Constructor por parametros. Permite crear un servidor de sockets que referencia a
        /// la bitácora de la aplicación y a la lista de clientes conectados.
        /// </summary>
        /// <param name="bitacora">La bitácora de la aplicación</param>
        /// <param name="clientesConectados">La lista de clientes conectados</param>
        public ServidorSocket(Bitacora bitacora, GestorClientes clientesConectados)
        {
            this.tcpListener = null;
            this.servidorIniciado = false;

            this.bitacora = bitacora;
            this.clientesConectados = clientesConectados;

            this.servicioConductor = ServicioConductor.ObtenerInstancia();
            this.servicioRol = ServicioRol.ObtenerInstancia();
            this.servicioRuta = ServicioRuta.ObtenerInstancia();
            this.servicioAutobus = ServicioAutobus.ObtenerInstancia();
        }

        /// <summary>
        /// Atributo que indica si el servidor esta iniciado o no
        /// </summary>
        public bool Iniciado
        {
            get { return this.servidorIniciado; }
        }

        /// <summary>
        /// Método que inicia el servidor y escucha por mensajes
        /// </summary>
        public void Iniciar()
        {
            bitacora.registrar("Iniciando servidor");

            // Creamos la IP local y junto con el puerto, creamos un TcpListener
            IPAddress direccionIpLocal = IPAddress.Parse(ConfiguracionConexion.IP);
            this.tcpListener = new TcpListener(direccionIpLocal, ConfiguracionConexion.PUERTO);
            this.servidorIniciado = true;

            // Creamos el hilo
            this.hiloEscuchaClientes = new Thread(new ThreadStart(this.escucharClientes));
            this.hiloEscuchaClientes.Start();
            this.hiloEscuchaClientes.IsBackground = true;

            bitacora.registrar("Servidor iniciado");
        }

        /// <summary>
        /// Método para detener el servidor de sockets
        /// </summary>
        public void Detener()
        {
            bitacora.registrar("Deteniendo el servidor");

            this.tcpListener.Stop();
            this.servidorIniciado = false;

            bitacora.registrar("Servidor detenido.");
        }

        /// <summary>
        /// Método para escuchar la aplicación cliente.
        /// </summary>
        private void escucharClientes()
        {
            this.tcpListener.Start();
            bitacora.registrar("Escuchando en -> " + ConfiguracionConexion.IP + ":" + ConfiguracionConexion.PUERTO);
            while (this.servidorIniciado)
            {
                try
                {
                    bitacora.registrar("Esperando por clientes.");
                    TcpClient cliente = this.tcpListener.AcceptTcpClient();
                    bitacora.registrar("Cliente conectado.");
                    Thread hiloCliente = new Thread(new ParameterizedThreadStart(this.procesarCliente));
                    hiloCliente.Start(cliente);
                }
                catch (Exception exception)
                {
                    // SI la exception contiene el texto WSACancelBlockingCall es porque se dejo de escuchar porque el servidor se detuvo
                    if (exception.Message.Contains("WSACancelBlockingCall"))
                    {
                        this.bitacora.registrar("Deteniendo la escucha de clientes.");
                    } else
                    {
                        this.bitacora.registrar("Error al escucharClientes: " + exception.Message);
                        this.bitacora.registrar(exception.StackTrace);
                    }
                    break;
                }
            }
            this.clientesConectados.removerTodosLosClientes();
        }

        /// <summary>
        /// Método para procesar un cliente.
        /// </summary>
        /// <param name="cliente"></param>
        private void procesarCliente(object cliente)
        {
            bitacora.registrar("Procesando cliente.");
            TcpClient clienteTcp = (TcpClient)cliente;
            StreamReader flujoEntrada = new StreamReader(clienteTcp.GetStream());
            StreamWriter flujoSalida = new StreamWriter(clienteTcp.GetStream());
            while (this.servidorIniciado && clienteTcp.Connected)
            {
                try
                {
                    bitacora.registrar("Esperando mensajes");
                    string mensajeLeido = flujoEntrada.ReadLine();
                    if(mensajeLeido != null)
                    {
                        MensajeDeSocket<object> mensajeSocket = JsonSerializer.Deserialize<MensajeDeSocket<object>>(mensajeLeido);
                        bitacora.registrar("Mensaje recibido. Método: " + mensajeSocket.Metodo + ". Entidad: " + mensajeSocket.Entidad);
                        this.ejecutarMetodo(mensajeSocket.Metodo, mensajeLeido, flujoEntrada, flujoSalida);
                        if (mensajeSocket.Metodo.Equals(Metodos.DESCONECTAR))
                        {
                            flujoEntrada.Close();
                            flujoSalida.Close();
                            clienteTcp.Close();
                            break;
                        }
                    } else
                    {
                        break;
                    }
                }
                catch (Exception exception)
                {
                    this.bitacora.registrar("Error al procesarCliente: " + exception.Message);
                    this.bitacora.registrar(exception.StackTrace);
                    break;
                }
            }
            flujoEntrada.Close();
            flujoSalida.Close();
            clienteTcp.Close();
        }

        private void ejecutarMetodo(String metodo, String mensajeJson, StreamReader flujoEntrada, StreamWriter flujoSalida)
        {
            switch (metodo)
            {
                case Metodos.CONECTAR:
                    {
                        MensajeDeSocket<string> mensajeSocket = JsonSerializer.Deserialize<MensajeDeSocket<string>>(mensajeJson);
                        string identificacionCliente = mensajeSocket.Entidad;
                        // Buscar con el id en el servicio
                        Conductor conductor = this.servicioConductor.ObtenerConductor(identificacionCliente);
                        if(conductor != null)
                        {
                            // Conductor existe, hay que mandarlo el cliente y decir que OK
                            bitacora.registrar("Cliente " + identificacionCliente + " se ha conectado.");
                            clientesConectados.agregarCliente(mensajeSocket.Entidad);
                            MensajeDeSocket<Conductor> mensajeRespuesta = new MensajeDeSocket<Conductor>() { Metodo = Metodos.OK, Entidad = conductor };
                            string respuestaJson = JsonSerializer.Serialize(mensajeRespuesta);
                            flujoSalida.WriteLine(respuestaJson);
                            flujoSalida.Flush();
                        } else
                        {
                            // Conductor no existe, hay que mandar un no-ok al cliente
                            MensajeDeSocket<string> mensajeRespuesta = new MensajeDeSocket<string>() { Metodo = Metodos.ERROR, Entidad = "El conductor no está registrado" };
                            string respuestaJson = JsonSerializer.Serialize(mensajeRespuesta);
                            flujoSalida.WriteLine(respuestaJson);
                            flujoSalida.Flush();
                        }
                    }
                    
                    break;
                case Metodos.CONSULTA_ROLES:
                    {
                        MensajeDeSocket<FiltroBusqueda> mensajeConsulta = JsonSerializer.Deserialize<MensajeDeSocket<FiltroBusqueda>>(mensajeJson);
                        List<Rol> rolesEncontrados = this.servicioRol.consultar(mensajeConsulta.Entidad);
                        MensajeDeSocket<List<Rol>> mensajeDeRespuesta = new MensajeDeSocket<List<Rol>>();
                        mensajeDeRespuesta.Metodo = Metodos.OK;
                        mensajeDeRespuesta.Entidad = rolesEncontrados;
                        string respuestaJson = JsonSerializer.Serialize(mensajeDeRespuesta);
                        flujoSalida.WriteLine(respuestaJson);
                        flujoSalida.Flush();
                    }
                    break;
                case Metodos.CARGAR_RUTAS:
                    {
                        MensajeDeSocket<object> mensajeConsulta = JsonSerializer.Deserialize<MensajeDeSocket<object>>(mensajeJson);
                        List<Ruta> rutas = this.servicioRuta.ObtenerRutasActivas();
                        MensajeDeSocket<List<Ruta>> mensajeDeRespuesta = new MensajeDeSocket<List<Ruta>>();
                        mensajeDeRespuesta.Metodo = Metodos.OK;
                        mensajeDeRespuesta.Entidad = rutas;
                        string respuestaJson = JsonSerializer.Serialize(mensajeDeRespuesta);
                        flujoSalida.WriteLine(respuestaJson);
                        flujoSalida.Flush();
                    }
                    break;
                case Metodos.CARGAR_CONDUCTORES:
                    {
                        MensajeDeSocket<object> mensajeConsulta = JsonSerializer.Deserialize<MensajeDeSocket<object>>(mensajeJson);
                        List<Conductor> conductores = this.servicioConductor.ObtenerConductoresRegulares();
                        MensajeDeSocket<List<Conductor>> mensajeDeRespuesta = new MensajeDeSocket<List<Conductor>>();
                        mensajeDeRespuesta.Metodo = Metodos.OK;
                        mensajeDeRespuesta.Entidad = conductores;
                        string respuestaJson = JsonSerializer.Serialize(mensajeDeRespuesta);
                        flujoSalida.WriteLine(respuestaJson);
                        flujoSalida.Flush();
                    }
                    break;
                case Metodos.CARGAR_AUTOBUSES:
                    {
                        MensajeDeSocket<object> mensajeConsulta = JsonSerializer.Deserialize<MensajeDeSocket<object>>(mensajeJson);
                        List<Autobus> autobuses = this.servicioAutobus.ObtenerAutobusesActivos();
                        MensajeDeSocket<List<Autobus>> mensajeDeRespuesta = new MensajeDeSocket<List<Autobus>>();
                        mensajeDeRespuesta.Metodo = Metodos.OK;
                        mensajeDeRespuesta.Entidad = autobuses;
                        string respuestaJson = JsonSerializer.Serialize(mensajeDeRespuesta);
                        flujoSalida.WriteLine(respuestaJson);
                        flujoSalida.Flush();
                    }
                    break;
                case Metodos.AGREGAR_ROL:
                    {
                        MensajeDeSocket<DatosRol> mensajeAgregar = JsonSerializer.Deserialize<MensajeDeSocket<DatosRol>>(mensajeJson);
                        try
                        {
                            DatosRol datosRol = mensajeAgregar.Entidad;
                            Rol rol = this.servicioRol.Agregar(datosRol.fechaHoraSalida, datosRol.idRuta, datosRol.idAutobus, datosRol.idConductor);
                            MensajeDeSocket<Rol> mensajeOk = new MensajeDeSocket<Rol>()
                            {
                                Metodo = Metodos.OK,
                                Entidad = rol
                            };
                            flujoSalida.WriteLine(JsonSerializer.Serialize(mensajeOk));
                            flujoSalida.Flush();
                        } catch(Exception exc)
                        {
                            MensajeDeSocket<string> mensajeError = new MensajeDeSocket<string>() {
                                Metodo = Metodos.ERROR,
                                Entidad = exc.Message
                            };
                            flujoSalida.WriteLine(JsonSerializer.Serialize(mensajeError));
                            flujoSalida.Flush();
                        }
                    }
                    break;
                case Metodos.DESCONECTAR:
                    {
                        MensajeDeSocket<string> mensajeSocket = JsonSerializer.Deserialize<MensajeDeSocket<string>>(mensajeJson);
                        string identificacionCliente = mensajeSocket.Entidad;
                        bitacora.registrar("Cliente " + identificacionCliente + " se ha desconectado.");
                        clientesConectados.removerCliente(mensajeSocket.Entidad);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
