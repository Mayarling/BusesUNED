namespace LibBusesUNED.DAO
{
    /// <summary>
    /// Interface IRepositorio que permite estandarizar la forma en como guardamos los objetos.
    /// </summary>
    public interface IRepositorio
    {
        /// <summary>
        /// Método para agregar un objeto al repositorio
        /// </summary>
        /// <param name="objeto">El objeto a agregar</param>
        void Agregar(object objeto);

        /// <summary>
        /// Método para obtener un objeto dado su ID como un int
        /// </summary>
        /// <param name="id">El ID en forma de int</param>
        /// <returns>El objeto asociado al ID o null si no existe ningun objeto para ese ID.</returns>
        object Obtener(int id);

        /// <summary>
        /// Método para obtener un objeto dado su ID como un string
        /// </summary>
        /// <param name="id">El ID en forma de string</param>
        /// <returns>El objeto asociado al ID o null si no existe ningun objeto para ese ID.</returns>
        object Obtener(string id);

        /// <summary>
        /// Retorna todos los objetos que hay en el repositorio en forma de un arreglo de objetos.
        /// </summary>
        /// <returns>Un arreglo con todos los objetos del repositorio</returns>
        object[] Obtener();
    }
}
