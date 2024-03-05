using System;

namespace LibBusesUNED_comun.Dominio
{
    /// <summary>
    /// Clase para representar los filtros de búsqueda para roles.
    /// </summary>
    public class FiltroBusqueda
    {
        /// <summary>
        /// Fecha inicial para la búsqueda.
        /// </summary>
        public DateTime fechaInicial { get; set; }

        /// <summary>
        /// Fecha final para la búsqueda.
        /// </summary>
        public DateTime fechaFinal { get; set; }

        /// <summary>
        /// Id del conductor o vacio sí se requieren todos los conductores.
        /// </summary>
        public string idConductor { get; set; }

        /// <summary>
        /// Id de la ruta o cero sí se requieren todas las rutas.
        /// </summary>
        public int idRuta { get; set; }

        /// <summary>
        /// Id del autóbus o cero sí se requieren todos los autobuses.
        /// </summary>
        public int idAutobus { get; set; }
    }
}
