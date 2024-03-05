using LibBusesUNED.DAO;
using LibBusesUNED_comun.Dominio;
using System;

namespace LibBusesUNED.Logica
{
    /// <summary>
    /// Clase que contiene la logica de negocio de la clase Terminal.
    /// </summary>
    public class ServicioTerminal
    {
        /// <summary>
        /// Atributo statico que contiene el singleton del servicio.
        /// </summary>
        private static ServicioTerminal INSTANCIA = null;

        /// <summary>
        /// Metodo estatico para obtener el singleton del servicio.
        /// </summary>
        /// <returns>El singleton del servicio</returns>
        public static ServicioTerminal ObtenerInstancia()
        {
            if(INSTANCIA == null)
            {
                INSTANCIA = new ServicioTerminal();
            }
            return INSTANCIA;
        }

        private IRepositorio repositorioTerminales;

        /// <summary>
        /// Método constructor, se hace privado para que el objeto se haga un singleton.
        /// </summary>
        private ServicioTerminal()
        {
            this.repositorioTerminales = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.TERMINAL);
        }

        /// <summary>
        /// Método para agregar unaterminal.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="horaApertura"></param>
        /// <param name="horaCierre"></param>
        /// <param name="estado"></param>
        /// <returns>El objeto terminal creado</returns>
        /// <exception cref="Exception">En el caso de que haya algún error</exception>
        public Terminal Agregar(string nombre, string direccion, string telefono, DateTime horaApertura, DateTime horaCierre, bool estado)
        {
            bool datosValidos = true;
            string errores = "";

            if (nombre.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "El nombre es requerido.\r\n";
            }
            if (direccion.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "La dirección es requerida.\r\n";
            }
            if (telefono.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "El número telefonico es requerido.\r\n";
            }
            if (horaApertura == null)
            {
                datosValidos = false;
                errores += "La hora de apertura es requerida.\r\n"; 
            }
            if (horaCierre == null)
            {
                datosValidos = false;
                errores += "La hora de cierre es requerida.\r\n";
            }

            if (datosValidos)
            {
                Terminal terminal = new Terminal
                {
                    Id = this.ObtenerProximoId(),
                    Nombre = nombre,
                    Direccion = direccion,
                    Telefono = telefono,
                    HoraApertura = horaApertura,
                    HoraCierre = horaCierre,
                    Estado = estado,
                };
                this.repositorioTerminales.Agregar(terminal);
                return terminal;
            }
            else
            {
                throw new Exception("Hay datos invalidos:\r\n" + errores);
            }
        }

        /// <summary>
        /// Método para devolver todas las terminales existentes.
        /// </summary>
        /// <returns>Todas las terminales existentes</returns>
        public Terminal[] ObtenerTerminales()
        {
            Terminal[] terminales = new Terminal[(this.ObtenerProximoId() - 1)];
            object[] datos = this.repositorioTerminales.Obtener();
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] != null)
                {
                    terminales[i] = (Terminal)datos[i];
                }
                else
                {
                    break;
                }
            }
            return terminales;
        }

        /// <summary>
        /// Método para saber si una terminal existe.
        /// </summary>
        /// <param name="id">El id para revisar si existe o no una terminal</param>
        /// <returns>True si el id existe y false si el id no existe.</returns>
        public bool existeTerminal(int id)
        {
            bool existe = false;
            
            Terminal[] terminales = this.ObtenerTerminales();
            for (int i = 0; i < terminales.Length; i++)
            {
                Terminal terminal = terminales[i];
                if (terminal.Id.Equals(id))
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        /// <summary>
        /// Método para obtener un objeto Terminal dado su ID
        /// </summary>
        /// <param name="id">El ID de la terminal a buscar</param>
        /// <returns>El objeto terminal que le corresponde a ese id, o null si no existe ninguna terminal con ese id</returns>
        public Terminal obtenerTerminal(int id)
        {
            Terminal terminal = null;
            Terminal[] terminales = this.ObtenerTerminales();
            for(int i = 0; i  < terminales.Length; i++)
            {
                if (terminales[i].Id == id)
                {
                    terminal = terminales[i];
                    break;
                }
            }
            return terminal;
        }

        /// <summary>
        /// Método para generar un Id para cada terminal de manera automatica por el sistema.
        /// </summary>
        /// <returns>El siguiente ID</returns>
        private int ObtenerProximoId()
        {
            int id = 0;
            object[] terminales = this.repositorioTerminales.Obtener();
            id = terminales.Length + 1;
            return id;
        }

        /// <summary>
        /// Método para determinar si hay terminales activas.
        /// </summary>
        /// <returns>True si hay al menos una terminal activa y false de caso contrario</returns>
        public bool hayTerminalesActivas()
        {
            bool terminalesActivas = false;
            Terminal[] terminales = this.ObtenerTerminales();
            foreach (Terminal terminal in terminales)
            {
                if (terminal.Estado)
                {
                    terminalesActivas = true;
                    break;
                }
            }
            return terminalesActivas;
        }
    }
}
