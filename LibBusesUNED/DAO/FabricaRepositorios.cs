using System.Collections.Generic;

namespace LibBusesUNED.DAO
{
    /// <summary>
    /// Fabrica de repositorios
    /// </summary>
    public class FabricaRepositorios
    {
        /// <summary>
        /// Constante para el tipo autobús.
        /// </summary>
        public static readonly string AUTOBUS = "Autobús";

        /// <summary>
        /// Constante para el tipo conductor.
        /// </summary>
        public static readonly string CONDUCTOR = "Conductor";

        /// <summary>
        /// Constante para el tipo rol.
        /// </summary>
        public static readonly string ROL = "Rol";

        /// <summary>
        /// Constante para el tipo ruta.
        /// </summary>
        public static readonly string RUTA = "Ruta";

        /// <summary>
        /// Constante para el tipo terminal.
        /// </summary>
        public static readonly string TERMINAL = "Terminal";

        private static readonly Dictionary<string, IRepositorio> Repositorios = new Dictionary<string, IRepositorio>();

        /// <summary>
        /// Método para obtener un repositorio de acuerdo al tipo de repositorio indicado.
        /// </summary>
        /// <param name="TipoRepositorio"> Alguno de los tipos de repositorio definidos como constantes estaticas de la fabrica</param>
        /// <returns>Un repositorio de acuerdo al tipo, o null si no se indica un tipo valido</returns>
        public static IRepositorio ObtenerRepositorio(string TipoRepositorio)
        {
            IRepositorio repositorio = null;
            if (AUTOBUS.Equals(TipoRepositorio))
            {
                if (Repositorios.ContainsKey(TipoRepositorio))
                {
                    repositorio = Repositorios[TipoRepositorio];
                }
                else
                {
                    repositorio = new RepositorioAutobuses();
                    Repositorios.Add(TipoRepositorio, repositorio);
                }
                
            }
            else if (CONDUCTOR.Equals(TipoRepositorio))
            {
                if (Repositorios.ContainsKey(TipoRepositorio))
                {
                    repositorio = Repositorios[TipoRepositorio];
                }
                else
                {
                    repositorio = new RepositorioConductores();
                    Repositorios.Add(TipoRepositorio, repositorio);
                }
            }
            else if (ROL.Equals(TipoRepositorio))
            {
                if (Repositorios.ContainsKey(TipoRepositorio))
                {
                    repositorio = Repositorios[TipoRepositorio];
                }
                else
                {
                    repositorio = new RepositorioRoles();
                    Repositorios.Add(TipoRepositorio, repositorio);
                }
            }
            else if (RUTA.Equals(TipoRepositorio))
            {
                if (Repositorios.ContainsKey(TipoRepositorio))
                {
                    repositorio = Repositorios[TipoRepositorio];
                }
                else
                {
                    repositorio = new RepositorioRutas();
                    Repositorios.Add(TipoRepositorio, repositorio);
                }
            }
            else if (TERMINAL.Equals(TipoRepositorio))
            {
                if (Repositorios.ContainsKey(TipoRepositorio))
                {
                    repositorio = Repositorios[TipoRepositorio];
                }
                else
                {
                    repositorio = new RepositorioTerminales();
                    Repositorios.Add(TipoRepositorio, repositorio);
                } 
            }
            return repositorio;
        }
    }
}
