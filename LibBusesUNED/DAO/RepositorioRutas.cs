using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibBusesUNED.DAO
{
    /// <summary>
    /// La clase RepositorioRutas implementa la interface IRepositorio, por lo cual debe cumplir con todos sus metodos.
    /// Representa un objeto que sirve para guardas hasta 20 instancias de la clase Ruta.
    /// </summary>
    public class RepositorioRutas : RepositorioSqlAbstracto
    {
        private IRepositorio RepositorioTerminales;

        private List<Ruta> listaRutas = null;

        public RepositorioRutas()
        {
            this.RepositorioTerminales = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.TERMINAL);
        }

        /// <summary>
        /// Método para agregar un nuevo objeto repositorio.
        /// </summary>
        /// <param name="objeto">El objeto agregar</param>
        /// <exception cref="Exception">Exepción en caso de que haya un error</exception>
        public override void Agregar(object objeto)
        {
            if (objeto.GetType() == typeof(Ruta))
            {
                Ruta ruta = (Ruta)objeto;
                string sentenciaSql = "INSERT INTO RUTA(NUM_RUTA, COD_TERMINAL_SALIDA, COD_TERMINAL_LLEGADA, NUM_TARIFA, DSC_RUTA, NUM_TIPO_RUTA, BOL_ESTADO) " +
                    "VALUES((SELECT COALESCE(MAX(NUM_RUTA), 0) + 1 AS ID FROM RUTA), @idTerminalSalida, @idTerminalLlegada, @tarifa, @descripcion, @tipoRuta, @estado)";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand(sentenciaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@idTerminalSalida", ruta.TerminalSalida.Id);
                    comando.Parameters.AddWithValue("@idTerminalLlegada", ruta.TerminalLlegada.Id);
                    comando.Parameters.AddWithValue("@tarifa", ruta.Tarifa);
                    comando.Parameters.AddWithValue("@descripcion", ruta.Descripcion);
                    comando.Parameters.AddWithValue("@tipoRuta", ruta.TipoRuta);
                    comando.Parameters.AddWithValue("@estado", ruta.Estado ? 1 : 0);
                    conexion.Open();
                    int resultado = comando.ExecuteNonQuery();
                }
                if(this.listaRutas != null)
                {
                    this.listaRutas = null;
                }
            }
            else
            {
                throw new Exception("El objeto no es de tipo Ruta.");
            }
        }

        /// <summary>
        /// Método obtener un objeto por si id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El objeto encontrado</returns>
        public override object Obtener(int id)
        {
            Ruta ruta = null;
            object[] objetos = this.Obtener();
            for (int i = 0; i < objetos.Length; i++)
            {
                if (objetos[i] != null && ((Ruta)objetos[i]).Id == id)
                {
                    ruta = (Ruta)objetos[i];
                    break;
                }
            }
            return ruta;
        }

        /// <summary>
        /// Método obtener un objeto por si id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El objeto encontrado</returns>
        public override object Obtener(string id)
        {
            Ruta ruta = null;
            try
            {
                ruta = (Ruta)this.Obtener(Int32.Parse(id));
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine("Error: " + exc.Message, exc);
                throw new Exception("Los ID para objetos de tipo Ruta, deben contener solo numeros.");
            }
            return ruta;
        }

        /// <summary>
        /// Método para devolver un arrelo con todo los objetos de repositorio.
        /// </summary>
        /// <returns>EL arreglo</returns>
        public override object[] Obtener()
        {
            if(this.listaRutas == null)
            {
                this.listaRutas = new List<Ruta>();
                DataTable dataTable = new DataTable();
                string sentenciaSql = "SELECT NUM_RUTA, COD_TERMINAL_SALIDA, COD_TERMINAL_LLEGADA, NUM_TARIFA, DSC_RUTA, NUM_TIPO_RUTA, BOL_ESTADO FROM RUTA ORDER BY NUM_RUTA ASC";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sentenciaSql, conexion))
                {
                    conexion.Open();
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Ruta ruta = new Ruta();
                        ruta.Id = (int)row.Field<decimal>("NUM_RUTA");
                        int idTerminalSalida = (int)row.Field<decimal>("COD_TERMINAL_SALIDA");
                        ruta.TerminalSalida = (Terminal)this.RepositorioTerminales.Obtener(idTerminalSalida);
                        int idTerminalLlegada = (int)row.Field<decimal>("COD_TERMINAL_LLEGADA");
                        ruta.TerminalLlegada = (Terminal)this.RepositorioTerminales.Obtener(idTerminalLlegada);
                        ruta.Tarifa = (double)row.Field<decimal>("NUM_TARIFA");
                        ruta.Descripcion = row.Field<string>("DSC_RUTA");
                        ruta.TipoRuta = (int)row.Field<decimal>("NUM_TIPO_RUTA");
                        ruta.Estado = row.Field<bool>("BOL_ESTADO");
                        listaRutas.Add(ruta);
                    }
                }
            }
            return listaRutas.ToArray();
        }
    }
}