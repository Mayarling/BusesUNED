using System;

namespace LibBusesUNED_comun.Dominio
{
    /// <summary>
    /// Clase para representar los datos de un rol.
    /// </summary>
    public class DatosRol
    {
        /// <summary>
        /// Fecha inicial para la búsqueda.
        /// </summary>
        public DateTime fechaHoraSalida { get; set; }

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
