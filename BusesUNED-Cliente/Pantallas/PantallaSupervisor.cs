using BusesUNED_Cliente.Red;
using LibBusesUNED_comun.Dominio;
using LibBusesUNED_comun.Red;
using System.Collections.Generic;
using System.Text.Json;
using System;
using System.Windows.Forms;

namespace BusesUNED_Cliente.Pantallas
{
    public partial class PantallaSupervisor : Form
    {
        private Conductor conductorSupervisor;
        private ClienteSocket clienteSocket;

        /// <summary>
        /// Lista de objetos de tipo ruta que se cargan desde el servidor.
        /// </summary>
        private List<Ruta> rutas;
        private List<Autobus> autobuses;
        private List<Conductor> conductores;


        public PantallaSupervisor(Conductor conductorSupervisor, ClienteSocket clienteSocket)
        {
            InitializeComponent();
            this.conductorSupervisor = conductorSupervisor;
            this.clienteSocket = clienteSocket;
        }

        private void PantallaSupervisor_Load(object sender, EventArgs e)
        {
            // Label con los datos del supervisor
            this.lableDatosSupervisor.Text = this.conductorSupervisor.Identificacion + " - " + this.conductorSupervisor.NombreCompleto + ".";

            // Configuracion de fechas
            DateTime hoy = DateTime.Today;
            DateTime fechaFin = hoy.AddDays(7);
            campoFechaInicio.Value = hoy;
            campoFechaFinal.Value = fechaFin;
            DateTime fechaDeAgregarMinima = hoy.AddDays(2);
            this.campoFechaSalida.MinDate = fechaDeAgregarMinima;

            // Cargamos los datos de los combos
            this.CargarRutasDelServidor();
            this.CargarAutobusesDelServidor();
            this.CargarConductoresDelServidor();

            // Validamos que hayan rutas, autobuses y conductores.
            if (this.rutas.Count == 0 || this.autobuses.Count == 0 || this.conductores.Count == 0)
            {
                MessageBox.Show(
                    "No hay rutas, autobuses o conductores registrados.\r\nPor favor contactese con el adminstrador del sistema.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Close();
            }
            this.CargarCombos();
            this.CargarColumnas();
        }

        /// <summary>
        /// Metodo que se conecta al servidor para cargar una lista de objetos ruta
        /// </summary>
        private void CargarRutasDelServidor()
        {
            MensajeDeSocket<object> solicitudCargaDeRutas = new MensajeDeSocket<object>() { Metodo = Metodos.CARGAR_RUTAS };
            this.clienteSocket.Enviar<object>(solicitudCargaDeRutas);
            string respuestaJson = this.clienteSocket.Recibir();
            MensajeDeSocket<List<Ruta>> mensajeRespuesta = JsonSerializer.Deserialize<MensajeDeSocket<List<Ruta>>>(respuestaJson);
            this.rutas = mensajeRespuesta.Entidad;
        }

        /// <summary>
        /// Metodo que se conecta al servidor para cargar una lista de objetos autobus
        /// </summary>
        private void CargarAutobusesDelServidor()
        {
            MensajeDeSocket<object> solicitudCargaDeAutobuses = new MensajeDeSocket<object>() { Metodo = Metodos.CARGAR_AUTOBUSES };
            this.clienteSocket.Enviar<object>(solicitudCargaDeAutobuses);
            string respuestaJson = this.clienteSocket.Recibir();
            MensajeDeSocket<List<Autobus>> mensajeRespuesta = JsonSerializer.Deserialize<MensajeDeSocket<List<Autobus>>>(respuestaJson);
            this.autobuses = mensajeRespuesta.Entidad;
        }

        /// <summary>
        /// Metodo que se conecta al servidor para cargar una lista de objetos conductor
        /// </summary>
        private void CargarConductoresDelServidor()
        {
            MensajeDeSocket<object> solicitudCargaDeConductores = new MensajeDeSocket<object>() { Metodo = Metodos.CARGAR_CONDUCTORES };
            this.clienteSocket.Enviar<object>(solicitudCargaDeConductores);
            string respuestaJson = this.clienteSocket.Recibir();
            MensajeDeSocket<List<Conductor>> mensajeRespuesta = JsonSerializer.Deserialize<MensajeDeSocket<List<Conductor>>>(respuestaJson);
            this.conductores = mensajeRespuesta.Entidad;
        }

        /// <summary>
        /// Método que carga los combos de la interface grafica. Los combos son 6, 2 de rutas, 2 de autobuses y 2 de conductores
        /// </summary>
        private void CargarCombos()
        {
            // Cargamos los combos de rutas
            this.comboBuscaRutas.Items.Clear();
            this.comboBuscaRutas.Items.Add("Todas las rutas");
            this.comboAgregarRutas.Items.Clear();
            foreach (Ruta ruta in this.rutas)
            {
                this.comboBuscaRutas.Items.Add(ruta);
                this.comboAgregarRutas.Items.Add(ruta);
            }
            this.comboBuscaRutas.SelectedIndex = 0;
            this.comboAgregarRutas.SelectedIndex = 0;
            // Cargamos los combos de autobuses
            this.comboBuscaAutobuses.Items.Clear();
            this.comboBuscaAutobuses.Items.Add("Todos los autobúses");
            this.comboAgregarAutbuses.Items.Clear();
            foreach (Autobus autobus in this.autobuses)
            {
                this.comboBuscaAutobuses.Items.Add(autobus);
                this.comboAgregarAutbuses.Items.Add(autobus);
            }
            this.comboBuscaAutobuses.SelectedIndex = 0;
            this.comboAgregarAutbuses.SelectedIndex = 0;
            // Cargamos los combos de conductores
            this.comboBuscaConductores.Items.Clear();
            this.comboBuscaConductores.Items.Add("Todos los conductores");
            this.comboAgregarConductores.Items.Clear();
            foreach (Conductor conductor in this.conductores)
            {
                this.comboBuscaConductores.Items.Add(conductor);
                this.comboAgregarConductores.Items.Add(conductor);
            }
            this.comboBuscaConductores.SelectedIndex = 0;
            this.comboAgregarConductores.SelectedIndex = 0;
        }

        /// <summary>
        /// Método par cargar las columnas del dategridview.
        /// </summary>
        private void CargarColumnas()
        {
            this.dataGridView1.Columns.Add("ColumnaFechaHora", "Fecha y Hora");
            this.dataGridView1.Columns.Add("ColumnaTerminalSalida", "Terminal de Salida");
            this.dataGridView1.Columns.Add("ColumnaTerminalLlegada", "Terminal de Llegada");
            this.dataGridView1.Columns.Add("ColumnaTipoRuta", "Tipo de Ruta");
            this.dataGridView1.Columns.Add("ColumnaTarifa", "Tarifa");
            this.dataGridView1.Columns.Add("ColumnaConductor", "Conductor");
            this.dataGridView1.Columns.Add("ColumnaAutobus", "Autobús");
        }


        /// <summary>
        /// Método para cargar los datos de los roles agregados en el dategridview.
        /// </summary>
        public void CargarDatos(List<Rol> roles)
        {
            this.dataGridView1.Rows.Clear();
            foreach (Rol rol in roles)
            {
                this.dataGridView1.Rows.Add(new string[7] {
                    rol.FechaHoraSalida.ToString("dd/MM/yyyy HH:mm"),
                    rol.Ruta.TerminalSalida.Nombre + " (Horario: " + rol.Ruta.TerminalSalida.Horario + ". Dirección: " + rol.Ruta.TerminalSalida.Direccion + ")",
                    rol.Ruta.TerminalLlegada.Nombre + " (Apertura: " + rol.Ruta.TerminalLlegada.Horario + ". Dirección: " + rol.Ruta.TerminalLlegada.Direccion + ")",
                    rol.Ruta.TipoRutaToString,
                    "CRC " + rol.Ruta.Tarifa,
                    rol.Conductor.Identificacion + " - " + rol.Conductor.NombreCompleto,
                    rol.Autobus.Placa + " (Marca: " + rol.Autobus.Marca + ". Capacidad: " + rol.Autobus.Capacidad + " pasajeros.)"
                });
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                FiltroBusqueda filtroBusqueda = new FiltroBusqueda();
                filtroBusqueda.fechaInicial = this.campoFechaInicio.Value;
                filtroBusqueda.fechaFinal = this.campoFechaFinal.Value;
                if (filtroBusqueda.fechaFinal > filtroBusqueda.fechaInicial)
                {
                    filtroBusqueda.idRuta = 0;
                    if (this.comboBuscaRutas.SelectedIndex > 0)
                    {
                        filtroBusqueda.idRuta = ((Ruta)this.comboBuscaRutas.SelectedItem).Id;
                    }
                    filtroBusqueda.idConductor = "";
                    if (this.comboBuscaConductores.SelectedIndex > 0)
                    {
                        filtroBusqueda.idConductor = ((Conductor)this.comboBuscaConductores.SelectedItem).Identificacion;
                    }
                    filtroBusqueda.idAutobus = 0;
                    if (this.comboBuscaAutobuses.SelectedIndex > 0)
                    {
                        filtroBusqueda.idAutobus = ((Autobus)this.comboBuscaAutobuses.SelectedItem).Id;
                    }
                    MensajeDeSocket<FiltroBusqueda> peticionDeBusqueda = new MensajeDeSocket<FiltroBusqueda>()
                    {
                        Metodo = Metodos.CONSULTA_ROLES,
                        Entidad = filtroBusqueda
                    };
                    this.clienteSocket.Enviar<FiltroBusqueda>(peticionDeBusqueda);
                    string respuestaJson = this.clienteSocket.Recibir();
                    if (respuestaJson != null)
                    {
                        MensajeDeSocket<List<Rol>> mensajeRespuesta = JsonSerializer.Deserialize<MensajeDeSocket<List<Rol>>>(respuestaJson);
                        List<Rol> roles = mensajeRespuesta.Entidad;
                        if (roles.Count > 0)
                        {
                            this.CargarDatos(mensajeRespuesta.Entidad);
                        }
                        else
                        {
                            this.dataGridView1.Rows.Clear();
                            MessageBox.Show(
                                "No se han encontrado datos con los criterios de busqueda seleccionados. Intente de nuevo.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }

                    }
                    else
                    {
                        throw new Exception("No se ha recibido respuesta del servidor. Intenter de nuevo.");
                    }
                }
                else
                {
                    MessageBox.Show(
                        "La fecha de inicio debe ser menor que la fecha final.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            } catch (Exception exc)
            {
                MessageBox.Show(
                    "Ha ocurrido lo siguiente: " + exc.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }


        }

        /// <summary>
        /// Click en el botón agregar rol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSalida = this.campoFechaSalida.Value;
                DateTime horaSalida = this.campoHoraSalida.Value;
                
                // Cargamos el objeto que contiene los datos a agregar
                DatosRol datosRol = new DatosRol();
                datosRol.fechaHoraSalida = new DateTime(fechaSalida.Year, fechaSalida.Month, fechaSalida.Day, horaSalida.Hour, horaSalida.Minute, 0);
                datosRol.idRuta = ((Ruta)this.comboAgregarRutas.SelectedItem).Id;
                datosRol.idConductor = ((Conductor)this.comboAgregarConductores.SelectedItem).Identificacion;
                datosRol.idAutobus = ((Autobus)this.comboAgregarAutbuses.SelectedItem).Id;
                
                // Creamos el mensaje
                MensajeDeSocket<DatosRol> peticionDeAgregar = new MensajeDeSocket<DatosRol>()
                {
                    Metodo = Metodos.AGREGAR_ROL,
                    Entidad = datosRol
                };
                this.clienteSocket.Enviar<DatosRol>(peticionDeAgregar);
                string respuestaJson = this.clienteSocket.Recibir();
                if (respuestaJson != null)
                {
                    MensajeDeSocket<Object> mensajeRespuesta = JsonSerializer.Deserialize<MensajeDeSocket<object>>(respuestaJson);
                    if(mensajeRespuesta.Metodo.Equals(Metodos.OK))
                    {
                        // se agrego
                        MensajeDeSocket<Rol> mensajeOk = JsonSerializer.Deserialize<MensajeDeSocket<Rol>>(respuestaJson);
                        Rol rolAgregado = mensajeOk.Entidad;
                        MessageBox.Show(
                            "Rol agregado con exito",
                            "Importante",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        List<Rol> roles = new List<Rol>();
                        roles.Add(rolAgregado);
                        this.CargarDatos(roles);

                    }
                    else if (mensajeRespuesta.Metodo.Equals(Metodos.ERROR))
                    {
                        // Error
                        MensajeDeSocket<string> mensajeError = JsonSerializer.Deserialize<MensajeDeSocket<string>>(respuestaJson);
                        MessageBox.Show(
                            "Ha ocurrido lo siguiente: \r\n" + mensajeError.Entidad,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    throw new Exception("No se ha recibido respuesta del servidor. Intenter de nuevo.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(
                    "Ha ocurrido lo siguiente: " + exc.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
   
}
