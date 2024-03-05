using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibBusesUNED.DAO
{
    /// <summary>
    /// La clase RepositorioAutobuses implementa la interface IRepositorio, por lo cual debe cumplir con todos sus métodos.
    /// Representa un objeto que sirve para guardas hasta 20 instancias de la clase Autobus.
    /// </summary>
    public class RepositorioAutobuses : RepositorioSqlAbstracto
    {
        private List<Autobus> listaAutobus = null;
        public RepositorioAutobuses(){}

        public override void Agregar(object objeto)
        {
            if(objeto.GetType() == typeof(Autobus))
            {
                Autobus autobus = (Autobus) objeto;
                string sentenciaSql = "INSERT INTO AUTOBUS(NUM_IDENTIFICACION, NUM_PLACA, DSC_MARCA, NUM_MODELO, " +
                    "NUM_CAPACIDAD, BOL_ESTADO) " +
                    "VALUES((SELECT COALESCE(MAX(NUM_IDENTIFICACION), 0) + 1 AS ID FROM AUTOBUS), @placa, @marca, @modelo, " +
                    "@capacidad, @estado)";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand(sentenciaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@placa", autobus.Placa);
                    comando.Parameters.AddWithValue("@marca", autobus.Marca);
                    comando.Parameters.AddWithValue("@modelo", autobus.Modelo);
                    comando.Parameters.AddWithValue("@capacidad", autobus.Capacidad);
                    comando.Parameters.AddWithValue("@estado", autobus.Estado ? 1 : 0);
                    conexion.Open();
                    int resultado = comando.ExecuteNonQuery();
                }
                if(this.listaAutobus != null)
                {
                    this.listaAutobus = null;
                }
            }
            else
            {
                throw new Exception("El objeto no es de tipo Autobús.");
            }
        }

        /// <summary>
        /// Método para obtener un objeto por un ID
        /// </summary>
        /// <param name="id">El id del autóbus</param>
        /// <returns>El objeto autóbus</returns>
        public override object Obtener(int id)
        {
            Autobus autobus = null;
            object[] objetos = this.Obtener();
            for (int i = 0; i < objetos.Length; i++)
            {
                if (objetos[i] != null && ((Autobus)objetos[i]).Id == id)
                {
                    autobus = (Autobus)objetos[i];
                    break;
                }
            }
            return autobus;

        }

        /// <summary>
        /// Método para obtener un objeto por un ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public override object Obtener(string id)
        {
            Autobus autobus = null;
            try
            {
                autobus = (Autobus) this.Obtener(Int32.Parse(id));
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine("Error: " + exc.Message, exc);
                throw new Exception("Los ID para objetos de tipo Autobús, deben contener solo numeros.");
            }
            return autobus;
        }

        /// <summary>
        /// Método para devolver un arrelo con todo los objetos de repositorio.
        /// </summary>
        /// <returns>EL arreglo</returns>
        public override object[] Obtener()
        {
            if(this.listaAutobus == null)
            {
                this.listaAutobus = new List<Autobus>();
                DataTable dataTable = new DataTable();
                string sentenciaSql = "SELECT NUM_IDENTIFICACION, NUM_PLACA, DSC_MARCA, NUM_MODELO, " +
                        "NUM_CAPACIDAD, BOL_ESTADO FROM AUTOBUS ORDER BY NUM_IDENTIFICACION ASC";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sentenciaSql, conexion))
                {
                    conexion.Open();
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Autobus autobus = new Autobus();
                        autobus.Id = (int)row.Field<decimal>("NUM_IDENTIFICACION");
                        autobus.Placa = row.Field<string>("NUM_PLACA");
                        autobus.Marca = row.Field<string>("DSC_MARCA");
                        autobus.Modelo = (int)row.Field<decimal>("NUM_MODELO");
                        autobus.Capacidad = (int)row.Field<decimal>("NUM_CAPACIDAD");
                        autobus.Estado = row.Field<bool>("BOL_ESTADO");
                        listaAutobus.Add(autobus);
                    }
                }
            }
            return listaAutobus.ToArray();
        }
    }
}
