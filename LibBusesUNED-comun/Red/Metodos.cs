namespace LibBusesUNED_comun.Red
{
    /// <summary>
    /// Clase que contiene los string que representan los  metodos disponibles
    /// para el atributo <code>Metodo</code> de los mensajes de tipo <code>MensajeDeSocket</code>
    /// que se envian y reciben entre el cliente y el servidor servidor.
    /// </summary>
    public class Metodos
    {
        /// <summary>
        /// Permite invocar la logica de conexion de usuario, se envia junto
        /// con un string que contiene el ID el usuario.
        /// 
        /// El servidor va a response con un mensaje OK en caso de que el ID
        /// corresponsa a un usuario valido, y en el atributo Entidad asociado
        /// viene el objeto Conductor que se conecto.
        /// 
        /// Si el usuario no es valido viene un mensaje ERROR junto con una Entidad
        /// string que contiene el mensaje del error.
        /// </summary>
        public const string CONECTAR = "Conectar";

        /// <summary>
        /// Permite invocar la logica de desconexion de usaurio, se enviar junto
        /// con un string que contiene el ID del usuario.
        /// 
        /// No tiene respuesta.
        /// </summary>
        public const string DESCONECTAR = "Desconectar";

        /// <summary>
        /// Permite enviar respuestas que indican una operacion exitosa, en el atributo
        /// Entidad se puede asociar cualquier objeto que sea relevante a la operacion
        /// realizada.
        /// </summary>
        public const string OK = "Ok";

        /// <summary>
        /// Permite enviar respuestas que indican que la operacion terminó con error o errores.
        /// 
        /// En la Entidad asociada por lo general viene un string con el mensaje de error
        /// correspondiente, sin embargo podría ser cualquier otro objeto.
        /// </summary>
        public const string ERROR = "Error";

        /// <summary>
        /// Permite realidar una consulta de roles.
        /// 
        /// En el atributo Entidad se enviar un objeto de tipo <code>FiltroBusqueda</code>.
        /// 
        /// Devuelve un mensaje OK con una lista de objetos de tipo <code>Rol</code>
        /// </summary>
        public const string CONSULTA_ROLES = "consulta de roles";

        /// <summary>
        /// Permite cargar las rutas. No necesita adjuntar nada.
        /// 
        /// Response con una lista de objetos de tipo ruta
        /// </summary>
        public const string CARGAR_RUTAS = "CargarRutas";

        /// <summary>
        /// Similar a CARGAR_RUTAS pero con objetos de tipo <code>Conductor</code>
        /// </summary>
        public const string CARGAR_CONDUCTORES = "CargarConductores";

        /// <summary>
        /// Similar a CARGAR_RUTAS pero con objetos de tipo <code>Autobus</code>
        /// </summary>
        public const string CARGAR_AUTOBUSES = "CargarAutobuses";

        /// <summary>
        /// Permite agregar un nuevo rol. Se adjunta un objeto de tipo <code>DatosRol</code> que contiene los IDs
        /// que se necesitan para agregar el rol.
        /// 
        /// Responde con un mensaje OK y el Rol agregado si todo sale bien.
        /// 
        /// Responde ERROR y un string de mensaje de error en caso que no se pueda agregar.
        /// </summary>
        public const string AGREGAR_ROL = "AgregarRol";
    }
}
