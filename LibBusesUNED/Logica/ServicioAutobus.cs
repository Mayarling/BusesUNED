using LibBusesUNED.DAO;
using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;

namespace LibBusesUNED.Logica
{
    /// <summary>
    /// La clase  que contiene la Logica de negocio de la clase Autobus.
    /// </summary>
    public class ServicioAutobus
    {
        /// <summary>
        /// Atributo statico que contiene el singleton del servicio.
        /// </summary>
        private static ServicioAutobus INSTANCIA = null;

        /// <summary>
        /// Atributo estatico para definir la capacidad maxima de un autobús
        /// </summary>
        public static readonly int CAPACIDAD_MAXIMA = 100;

        /// <summary>
        /// Método statico para obtener el singleton del servicio.
        /// </summary>
        /// <returns></returns>
        public static ServicioAutobus ObtenerInstancia()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new ServicioAutobus();
            }
            return INSTANCIA;
        }          

        private IRepositorio repositorioAutobuses;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private ServicioAutobus()
        {
            this.repositorioAutobuses = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.AUTOBUS);
        }

        /// <summary>
        /// Metodo para agregar un nuevo autobus
        /// </summary>
        /// <param name="placa">El numero de placa</param>
        /// <param name="marca">La marca</param>
        /// <param name="modelo">El modelo</param>
        /// <param name="capacidad">La capacidad, debet ser mayor a 0 y menor o igual a 100</param>
        /// <param name="estado">El estao, true para activo, false para inactivo</param>
        /// <returns>El objeto Autobus creado</returns>
        /// <exception cref="Exception">En caso que haya algun error en el proceso</exception>
        public Autobus Agregar(string placa, string marca, int modelo, int capacidad, bool estado)
        {
            bool datosValidos = true;
            string errores = "";
            if (this.existePlaca(placa))
            {
                datosValidos = false;
                errores += "La placa "+placa+" ya existe.\r\n";
            }
            if(marca.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "La marca es requerida.\r\n";
            }
            if (modelo <= 0)
            {
                datosValidos = false;
                errores += "El modelo debe ser mayor a cero.\r\n";
            }
            if (capacidad <= 0)
            {
                datosValidos = false;
                errores += "La capacidad del autobus debe ser mayor a cero.\r\n";
            }
            else if (capacidad > CAPACIDAD_MAXIMA)
            {
                datosValidos = false;
                errores += "La capacidad del autobus debe ser menor o igual a cien.";
            }
            if (datosValidos)
            {
                Autobus autobus = new Autobus
                {
                    Id = this.ObtenerProximoId(),
                    Placa = placa,
                    Marca = marca,
                    Modelo = modelo,
                    Capacidad = capacidad,
                    Estado = estado
                };
                this.repositorioAutobuses.Agregar(autobus);
                return autobus;
            }
            else
            {
                throw new Exception("Hay datos invalidos:\r\n" + errores);
            }
        }

        /// <summary>
        /// Método obtener el arreglo con los autobúses registrados.
        /// </summary>
        /// <returns>El arreglo con los autobúses registrados</returns>
        public Autobus[] ObtenerAutobuses()
        {
            Autobus[] autobuses = new Autobus[(this.ObtenerProximoId() - 1)];
            object[] datos = this.repositorioAutobuses.Obtener();
            for(int i = 0; i < datos.Length; i++)
            {
                if (datos[i] != null)
                {
                    autobuses[i] = (Autobus)datos[i];
                }
                else
                {
                    break;
                }
            }
            return autobuses;
        }

        /// <summary>
        /// Método obtener el arreglo con los autobúses registrados y activos
        /// </summary>
        /// <returns>El arreglo con los autobúses registrados y activos</returns>
        public List<Autobus> ObtenerAutobusesActivos()
        {
            List<Autobus> autobusesActivos = new List<Autobus>();
            Autobus[] autobuses = this.ObtenerAutobuses();
            for (int i = 0; i < autobuses.Length; i++)
            {
                if (autobuses[i] != null && autobuses[i].Estado)
                {
                    autobusesActivos.Add(autobuses[i]);
                }
            }
            return autobusesActivos;
        }

        /// <summary>
        /// Método para obtener un autobus dado un id.
        /// </summary>
        /// <param name="id">El id del autobus</param>
        /// <returns>El autobus asociado al id, o null si no hay ningun autobus asociado al id</returns>
        public Autobus ObtenerAutobus(int id)
        {
            Autobus autobus = null;
            Autobus[] autobuses = this.ObtenerAutobuses();
            foreach (Autobus bus in autobuses)
            {
                if(bus.Id == id)
                {
                    autobus = bus;
                }
            }
            return autobus;
        }

        /// <summary>
        /// Método para obtener el próximo Id.
        /// </summary>
        /// <returns>El siguiente Id</returns>
        private int ObtenerProximoId()
        {
            int id = 0;
            object[] buses = this.repositorioAutobuses.Obtener();
            id = buses.Length + 1;
            return id;
        }

        /// <summary>
        /// Método para verificar si una placa existe.
        /// </summary>
        /// <param name="placa"></param>
        /// <returns></returns>
        public bool existePlaca(string placa)
        {
            bool existe = false;
            object[] buses = this.repositorioAutobuses.Obtener();
            for(int i = 0; i < buses.Length; i++)
            {
                if (buses[i] != null)
                {
                    Autobus autobus = (Autobus) buses[i];
                    if (autobus.Placa.Equals(placa))
                    {
                        existe = true;
                        break;
                    }
                }
            }
            return existe;
        }

        /// <summary>
        /// Método para verificar si hay autobuses activos.
        /// </summary>
        /// <returns>True si hay autobuses activos, false en caso contrario.</returns>
        public bool hayAutobusesActivos()
        {
            bool activos = false;
            Autobus[] autobuses = this.ObtenerAutobuses();
            foreach (Autobus autobus  in autobuses)
            {
                if (autobus.Estado)
                {
                    activos = true;
                    break;
                }
            }
            return activos;
        }
    }
}
