using LibBusesUNED.DAO;
using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;

namespace LibBusesUNED.Logica
{
    /// <summary>
    /// Clase que contiene la logica de negocio de la clase ruta.
    /// </summary>
    public class ServicioRuta
    {
        /// <summary>
        /// Atributo statico que contiene el singleton del servicio
        /// </summary>
        private static ServicioRuta INSTANCIA = null;

        /// <summary>
        /// Método estatico para obtener el singleton del servicio
        /// </summary>
        /// <returns>El singleton del servicio</returns>
        public static ServicioRuta ObtenerInstancia()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new ServicioRuta();
            }
            return INSTANCIA;
        }

        private IRepositorio repositorioRutas;
        private ServicioTerminal ServicioTerminal;

        /// <summary>
        /// Método constructor, se hace privado para que el objeto se haga un singleton
        /// </summary>
        private ServicioRuta()
        {
            this.repositorioRutas = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.RUTA);
            this.ServicioTerminal = ServicioTerminal.ObtenerInstancia();
        }

        /// <summary>
        /// Método para agregar una ruta.
        /// </summary>
        /// <param name="idTerminalSalida"></param>
        /// <param name="idTerminalLlegada"></param>
        /// <param name="tarifa"></param>
        /// <param name="descripcionRuta"></param>
        /// <param name="tipoRuta"></param>
        /// <param name="estado"></param>
        /// <returns>El objeto ruta creado</returns>
        /// <exception cref="Exception">En el caso de que haya algún error</exception>
        public Ruta Agregar(int idTerminalSalida, int idTerminalLlegada, double tarifa, string descripcionRuta, int tipoRuta, bool estado)
        {
            bool datosValidos = true;
            string errores = "";
            if (!this.ServicioTerminal.existeTerminal(idTerminalSalida))
            {
                datosValidos = false;
                errores += "La Terminal de salida con el Id " + idTerminalSalida + " no existe.\r\n";
            } else if(this.ServicioTerminal.obtenerTerminal(idTerminalSalida).Estado == false)
            {
                datosValidos = false;
                errores += "La Terminal de salida con el Id " + idTerminalSalida + " esta inactiva.\r\n";
            }
            if (!this.ServicioTerminal.existeTerminal(idTerminalLlegada))
            {
                datosValidos = false;
                errores += "La Terminal de llegada con el Id " + idTerminalSalida + " no existe.\r\n";
            } else if(this.ServicioTerminal.obtenerTerminal(idTerminalLlegada).Estado == false)
            {
                datosValidos = false;
                errores += "La Terminal de llegada con el Id " + idTerminalSalida + " esta inactiva.\r\n";
            }
            if(idTerminalSalida == idTerminalLlegada)
            {
                datosValidos = false;
                errores += "La terminal de salida y de llegada no pueden ser la misma terminal.\r\n";
            }
            if (tarifa == 0)
            {
                datosValidos = false;
                errores += "La tarifa es requerida.\r\n";
            }
            if(descripcionRuta.Trim().Equals(""))
            {
                datosValidos = false;
                errores += "La descripción de la ruta es requerida.\r\n";
            }
            if(tipoRuta != 1 && tipoRuta != 2)
            {
                datosValidos = false;
                errores += "El tipo de ruta solo puede ser 1-Directo o 2-Regular.\r\n";
            }

            if(datosValidos)
            {
                Terminal terminalSalida = this.ServicioTerminal.obtenerTerminal(idTerminalSalida);
                Terminal terminalLlegada = this.ServicioTerminal.obtenerTerminal(idTerminalLlegada);
                Ruta ruta = new Ruta
                {
                    Id = this.ObtenerProximoId(),
                    TerminalSalida = terminalSalida,
                    TerminalLlegada = terminalLlegada,
                    Tarifa = tarifa,
                    Descripcion = descripcionRuta,
                    TipoRuta = tipoRuta,
                    Estado = estado
                };   
                this.repositorioRutas.Agregar(ruta);
                return ruta;
            }
            else
            {
                throw new Exception("Hay datos invalidos:\r\n" + errores);
            }
        }

        /// <summary>
        /// Método para obtener las rutas registradas.
        /// </summary>
        /// <returns>El arreglo con las rutas registradas</returns>
        public Ruta[] ObtenerRutas()
        {
            Ruta[] rutas = new Ruta[this.ObtenerProximoId() - 1];
            object[] datos = this.repositorioRutas.Obtener();
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] != null)
                {
                    rutas[i] = (Ruta)datos[i];
                } else
                {
                    break;
                }
            }
            return rutas;
        }

        /// <summary>
        /// Método para obtener las rutas registradas y activas.
        /// </summary>
        /// <returns>El arreglo con las rutas registradas</returns>
        public List<Ruta> ObtenerRutasActivas()
        {
            List<Ruta> rutasActivas = new List<Ruta>();
            Ruta[] rutas = this.ObtenerRutas();
            for (int i = 0; i < rutas.Length; i++)
            {
                if (rutas[i] != null && rutas[i].Estado)
                {
                    rutasActivas.Add(rutas[i]);
                }
            }
            return rutasActivas;
        }

        /// <summary>
        /// Método para obtener una ruta dado un id
        /// </summary>
        /// <param name="id">El id de la ruta</param>
        /// <returns>La ruta asociada al id, o null si no hay ninguna ruta asociada al id</returns>
        public Ruta ObtenerRuta(int id)
        {
            Ruta ruta = null;
            Ruta[] rutas = this.ObtenerRutas();
            foreach (Ruta rut in rutas)
            {
                if (rut.Id == id)
                {
                    ruta = rut;
                }
            }
            return ruta;
        }


        /// <summary>
        /// Metodo para generar un Id para cada terminal de manera automatica por el sistema.
        /// </summary>
        /// <returns>El siguiente Id</returns>
        private int ObtenerProximoId()
        {
            int id = 0;
            object[] rutas = this.repositorioRutas.Obtener();
            id = rutas.Length + 1;
            return id;
        }

        /// <summary>
        /// Método para determinar si hay rutas activas.
        /// </summary>
        /// <returns>True si hay al menos una ruta activa y false de caso contrario</returns>
        public bool hayRutasActivas()
        {
            bool activas = false;
            Ruta[] rutas = this.ObtenerRutas();
            foreach (Ruta ruta in rutas)
            {
                if (ruta.Estado)
                {
                    activas = true;
                    break;
                }
            }
            return activas;
        }
    }
}
