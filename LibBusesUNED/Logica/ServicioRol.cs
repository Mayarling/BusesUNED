using LibBusesUNED.DAO;
using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;

namespace LibBusesUNED.Logica
{
    /// <summary>
    /// Clase que contiene la logica de negocio de la clase Rol.
    /// </summary>
    public class ServicioRol
    {
        /// <summary>
        /// Atributo statico que contiene el singleton del servicio
        /// </summary>
        private static ServicioRol INSTANCIA = null;

        /// <summary>
        /// Método estatico para obtener el singleton del servicio.
        /// </summary>
        /// <returns>El singleton del servicio</returns>
        public static ServicioRol ObtenerInstancia()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new ServicioRol();
            }
            return INSTANCIA;
        }

        private IRepositorio repositorioRoles;

        private ServicioAutobus ServicioAutobus;
        private ServicioConductor ServicioConductor;
        private ServicioRuta ServicioRuta;

        /// <summary>
        /// 
        /// </summary>
        private ServicioRol()
        {
            this.repositorioRoles = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.ROL);
            this.ServicioAutobus = ServicioAutobus.ObtenerInstancia();
            this.ServicioConductor = ServicioConductor.ObtenerInstancia();
            this.ServicioRuta = ServicioRuta.ObtenerInstancia();
        }

        /// <summary>
        /// Método para agregar un nuevo rol.
        /// </summary>
        /// <param name="fechaHoraSalida"></param>
        /// <param name="idRuta"></param>
        /// <param name="idAutobus"></param>
        /// <param name="idConductor"></param>
        /// <returns>El objeto rol creado</returns>
        /// <exception cref="Exception">En caso que haya algun error en el proceso</exception>
        public Rol Agregar(DateTime fechaHoraSalida, int idRuta, int idAutobus, string idConductor)
        {
            bool datosValidos = true;
            string errores = "";

            if (fechaHoraSalida == null)
            {
                datosValidos = false;
                errores += "La fecha y hora de salida es requerida.\r\n";

            }

            DateTime hoy = DateTime.Today;
            DateTime fechaMinimaRol = hoy.AddDays(2);
            if(fechaHoraSalida.CompareTo(fechaMinimaRol) < 0)
            {
                datosValidos = false;
                errores += "La fecha del rol debe ser posterior a " + fechaMinimaRol.ToString("dd/MM/yyyy") + ".\r\n";
            }

            if (idRuta == 0)
            {
                datosValidos = false;
                errores += "El Id de la ruta es requerido.\r\n";
            } else if (this.ServicioRuta.ObtenerRuta(idRuta) == null)
            {
                datosValidos = false;
                errores += "La ruta no existe.\r\n";
            } else if (!this.ServicioRuta.ObtenerRuta(idRuta).Estado)
            {
                datosValidos = false;
                errores += "La ruta esta inactiva.\r\n";
            }

            if (idAutobus == 0)
            {
                datosValidos = false;
                errores += "El id del autobus es requerido.\r\n";
            } else if (this.ServicioAutobus.ObtenerAutobus(idAutobus) == null)
            {
                datosValidos = false;
                errores += "El autobus no existe.\r\n";
            } else if (!this.ServicioAutobus.ObtenerAutobus(idAutobus).Estado)
            {
                datosValidos = false;
                errores += "El autobus esta inactivo.\r\n";
            }

            if (idConductor.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "El id del conductor es requerido.\r\n";
            } else if (this.ServicioConductor.ObtenerConductor(idConductor) == null)
            {
                datosValidos = false;
                errores += "El conductor no existe.\r\n";
            }
            else if (this.ServicioConductor.ObtenerConductor(idConductor).ConductorSupervisor)
            {
                datosValidos = false;
                errores += "El conductor es un supervisor, no puede ser asignado a un rol.\r\n";
            }

            if (datosValidos)
            {
                Autobus autobus = this.ServicioAutobus.ObtenerAutobus(idAutobus);
                Conductor conductor = this.ServicioConductor.ObtenerConductor(idConductor);
                Ruta ruta = this.ServicioRuta.ObtenerRuta(idRuta);

                
                if(this.ExisteRolParaAutobus(fechaHoraSalida, autobus))
                {
                    datosValidos = false;
                    errores += "Ya existe un rol asignado al autobus placa " + autobus.Placa + " entre la hora de salida y las 2 horas posteriores.\r\n";
                }
                
                if(this.ExisteRolParaConductor(fechaHoraSalida, conductor))
                {
                    datosValidos = false;
                    errores += "Ya existe un rol asignado al conductor " + conductor.Identificacion + " - " + conductor.NombreCompleto + " entre la hora de salida y las 2 horas posteriores.\r\n";
                }

                if (datosValidos)
                {
                    Rol rol = new Rol
                    {
                        Id = this.ObtenerProximoId(),
                        FechaHoraSalida = fechaHoraSalida,
                        Ruta = ruta,
                        Autobus = autobus,
                        Conductor = conductor
                    };
                    this.repositorioRoles.Agregar(rol);
                    return rol;
                }
                else
                {
                    throw new Exception("Hay datos invalidos:\r\n" + errores);
                }
            }
            else
            {
                throw new Exception("Hay datos invalidos:\r\n" + errores);
            }
        }

        /// <summary>
        /// Método para obtener los roles
        /// </summary>
        /// <returns>El arreglo con los roles creados</returns>
        public Rol[] ObtenerRoles()
        {
            Rol[] roles = new Rol[this.ObtenerProximoId() - 1];
            object[] datos = this.repositorioRoles.Obtener();
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] != null)
                {
                    roles[i] = (Rol)datos[i];
                }
                else
                {
                    break;
                }
            }
            return roles;
        }

        /// <summary>
        /// Método para consultar los roles dado el filtro de búsqueda.
        /// </summary>
        /// <param name="filtroBusqueda">El filtro de búsqueda</param>
        /// <returns>UNa lista de objetos de tipo rol</returns>
        public List<Rol> consultar(FiltroBusqueda filtroBusqueda)
        {
            List<Rol> roles = new List<Rol>();
            Rol[] todosLosRoles = this.ObtenerRoles();
            foreach (Rol rol in todosLosRoles)
            {
                if ((rol.FechaHoraSalida >= filtroBusqueda.fechaInicial) &&
                    (rol.FechaHoraSalida <= filtroBusqueda.fechaFinal) &&
                    (filtroBusqueda.idConductor == null || filtroBusqueda.idConductor.Equals("") || rol.Conductor.Identificacion.Equals(filtroBusqueda.idConductor)) &&
                    (filtroBusqueda.idRuta == 0 || rol.Ruta.Id == filtroBusqueda.idRuta) &&
                    (filtroBusqueda.idAutobus == 0 || rol.Autobus.Id == filtroBusqueda.idAutobus))
                {
                    roles.Add(rol);
                }
            }
            return roles;
        }

        /// <summary>
        /// Método para obtener el siguiente Id.
        /// </summary>
        /// <returns>El siguiente Id</returns>
        private int ObtenerProximoId()
        {
            int id = 0;
            object[] roles = this.repositorioRoles.Obtener();
            id = roles.Length + 1;
            return id;
        }

        /// <summary>
        /// Método para verificar si existe un rol para un autobús.
        /// </summary>
        /// <param name="fechaHoraSalida">La fecha de salida</param>
        /// <param name="autobus">El autobús</param>
        /// <returns>Si existe el rol</returns>
        private bool ExisteRolParaAutobus(DateTime fechaHoraSalida, Autobus autobus)
        {
            Rol[] roles = this.ObtenerRoles(fechaHoraSalida);
            bool existeRol = false;
            foreach (Rol rol in roles)
            {
                if(rol.Autobus.Id == autobus.Id)
                {
                    existeRol = true;
                }
            }
            return existeRol;
        }

        /// <summary>
        /// Método para verifcar si existe un rol para un conductor.
        /// </summary>
        /// <param name="fechaHoraSalida">La fecha de salida</param>
        /// <param name="conductor"></param>
        /// <returns>Si exisite el rol</returns>
        private bool ExisteRolParaConductor(DateTime fechaHoraSalida, Conductor conductor)
        {
            Rol[] roles = this.ObtenerRoles(fechaHoraSalida);
            bool existeRol = false;
            foreach (Rol rol in roles)
            {
                if (rol.Conductor.Identificacion.Equals(conductor.Identificacion))
                {
                    existeRol = true;
                }
            }
            return existeRol;
        }

        /// <summary>
        /// Método para obtener el arreglo con los roles creados
        /// </summary>
        /// <param name="fechaHoraSalida"></param>
        /// <returns>El arreglo con los roles</returns>
        private Rol[] ObtenerRoles(DateTime fechaHoraSalida)
        {
            TimeSpan limiteDeHoras = TimeSpan.FromHours(2);

            DateTime fechaHoraMaxima = fechaHoraSalida.Add(limiteDeHoras);
            DateTime fechaHoraMinima = fechaHoraSalida.Subtract(limiteDeHoras);

            List<Rol> listaRoles = new List<Rol>();
            Rol[] roles = this.ObtenerRoles();
            foreach(Rol rol in roles)
            {
                if(rol.FechaHoraSalida.CompareTo(fechaHoraMinima) >= 0 && rol.FechaHoraSalida.CompareTo(fechaHoraMaxima) <= 0)
                {
                    listaRoles.Add(rol);
                }
            }
            return listaRoles.ToArray();
        }
    }
}
