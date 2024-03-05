using LibBusesUNED.DAO;
using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;

namespace LibBusesUNED.Logica
{
    /// <summary>
    ///  Clase que contiene la logica de negocio de la clase conductor.
    /// </summary>
    public class ServicioConductor
    {
        /// <summary>
        /// Atributo statico que contiene el singleton del servicio
        /// </summary>
        private static ServicioConductor INSTANCIA = null;

        /// <summary>
        /// Método estatico para obtener el singleton del servicio.
        /// </summary>
        /// <returns>El singleton del servicio</returns>
        public static ServicioConductor ObtenerInstancia()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new ServicioConductor();
            }
            return INSTANCIA;
        }

        private IRepositorio repositorioConductores;

        /// <summary>
        /// Método constructor, se hace privado para que el objeto se haga un singleton.
        /// </summary>
        private ServicioConductor()
        {
            this.repositorioConductores = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.CONDUCTOR);
        }

        /// <summary>
        /// Método para agregar un nuevo conductor.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="genero"></param>
        /// <param name="conductorSupervisor"></param>
        /// <returns>El objeto conductor creado</returns>
        public Conductor Agregar(string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, char genero, Boolean conductorSupervisor)
        {
            bool datosValidos = true;
            string errores = "";
            if (this.existeIdentificacion(identificacion))
            {
                datosValidos = false;
                errores += "La identificación " + identificacion + " Ya existe.\r\n";
            }
            if(nombre.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "El nombre es requerido.\r\n";
            }
            if (primerApellido.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "El primer apellido es requerido.\r\n";
            }
            if (segundoApellido.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "El segundo apellido es requerido.\r\n";
            }
            if(fechaNacimiento == null)
            {
                datosValidos = false;
                errores += "La fecha de nacimiento es requerida.\r\n";
            }
            if (!genero.Equals('M') && !genero.Equals('F'))
            {
                datosValidos = false;
                errores += "El genero solo puede ser 'M' o 'F'.\r\n";
            }
            if (datosValidos)
            {
                Conductor conductor = new Conductor
                {
                    Identificacion = identificacion,
                    Nombre = nombre,
                    PrimerApellido = primerApellido,
                    SegundoApellido = segundoApellido,
                    FechaNacimiento = fechaNacimiento,
                    Genero = genero,
                    ConductorSupervisor = conductorSupervisor,
                };
                this.repositorioConductores.Agregar(conductor);
                return conductor;
            }
            else
            {
                throw new Exception("Hay datos invalidos:\r\n" + errores);
            }
        }

        /// <summary>
        /// Método para obtener el arreglo con los conductores registrados.
        /// </summary>
        /// <returns>El arreglo con todos los conductores.</returns>
        public Conductor[] ObtenerConductores()
        {
            Conductor[] conductores = new Conductor[(this.ObtenerCantidadConductores())];
            object[] datos = this.repositorioConductores.Obtener();
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] != null)
                {
                    conductores[i] = (Conductor)datos[i];
                }
                else
                {
                    break;
                }
            }
            return conductores;
        }

        /// <summary>
        /// Método para obtener el arreglo con los conductores registrados y regulares.
        /// </summary>
        /// <returns>El arreglo con todos los conductores.</returns>
        public List<Conductor> ObtenerConductoresRegulares()
        {
            List<Conductor> conductoresRegulares = new List<Conductor>();
            Conductor[] conductores = this.ObtenerConductores();
            for (int i = 0; i < conductores.Length; i++)
            {
                if (conductores[i] != null && !conductores[i].ConductorSupervisor)
                {
                    conductoresRegulares.Add(conductores[i]);
                }
            }
            return conductoresRegulares;
        }

        /// <summary>
        /// Método para obtener un conductor dado un id.
        /// </summary>
        /// <param name="id">El id del conductor</param>
        /// <returns>El conductor asociado al id, o null si no hay ningun conductor asociado al id</returns>
        public Conductor ObtenerConductor(string id)
        {
            Conductor conductor = null;
            Conductor[] conductores = this.ObtenerConductores();
            foreach (Conductor cond in conductores)
            {
                if (cond.Identificacion.Equals(id))
                {
                    conductor = cond;
                }
            }
            return conductor;
        }

        /// <summary>
        /// Método para obtener la cantidad de conductores que existen.
        /// </summary>
        /// <returns>La cantidad de conductores registrados.</returns>
        private int ObtenerCantidadConductores()
        {
            int cantidad = this.repositorioConductores.Obtener().Length;
            return cantidad;
        }

        /// <summary>
        /// Método para verificar si una indentificacion ya existe.
        /// </summary>
        /// <param name="identificacion"></param>
        /// <returns></returns>
        private bool existeIdentificacion(string identificacion)
        {
            bool existe = false;
            object[] conductores = this.repositorioConductores.Obtener();
            for (int i = 0; i < conductores.Length; i++)
            {
                if (conductores[i] != null)
                {
                    Conductor conductor = (Conductor)conductores[i];
                    if (conductor.Identificacion.Equals(identificacion))
                    {
                        existe = true;
                        break;
                    }
                }
            }
            return existe;
        }

        /// <summary>
        /// Método para determinar si hay conductores que NO sean supervisores.
        /// </summary>
        /// <returns>True si hay al menos un conductor que no es supervisor y false de caso contrario</returns>
        public bool hayConductoresRegulares()
        {
            bool regulares = false;
            Conductor[] conductores = this.ObtenerConductores();
            foreach (Conductor conductor in conductores)
            {
                if (!conductor.ConductorSupervisor)
                {
                    regulares = true;
                    break;
                }
            }
            return regulares;
        }
    }
}
