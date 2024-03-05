using System;
using System.Data.SqlClient;

namespace LibBusesUNED.DAO
{
    /// <summary>
    /// Clase abstracta que contiene metodos útiles para cualquier repositorio que vaya a usar SQL server como motor de BD.
    /// </summary>
    public abstract class RepositorioSqlAbstracto : IRepositorio
    {
        public abstract void Agregar(object objeto);
        public abstract object Obtener(int id);
        public abstract object Obtener(string id);
        public abstract object[] Obtener();

        /// <summary>
        /// Método que obtiene una nueva conexion a la BD.
        /// </summary>
        /// <returns>Una nueva conexion a la BD, o null si da algún error</returns>
        public SqlConnection ObtenerConexion()
        {
            try
            {
                return new SqlConnection(@"Data Source=(local)\SQLEXPRESS; Initial Catalog=BUSUNED; Integrated security=True");
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine("Error: " + exception.Message);
                return null;
            }
        }
    }
}
