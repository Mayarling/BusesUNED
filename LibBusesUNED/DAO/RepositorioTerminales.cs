using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibBusesUNED.DAO
{
    /// <summary>
    /// La clase RepositorioTerminales implementa la interface IRepositorio, por lo cual debe cumplir con todos sus metodos.
    /// Representa un objeto que sirve para guardas hasta 20 instancias de la clase Terminal.
    /// </summary>
    public class RepositorioTerminales : RepositorioSqlAbstracto
    {
        private List<Terminal> listaTerminales = null;
        public RepositorioTerminales(){}

        /// <summary>
        /// Método para agregar un nuevo objeto repositorio.
        /// </summary>
        /// <param name="objeto">El objeto agregar</param>
        /// <exception cref="Exception">Exepción en caso de que haya un error</exception>
        public override void Agregar(object objeto)
        {
            if(objeto.GetType() == typeof(Terminal))
            {
                Terminal terminal = (Terminal)objeto;
                string sentenciaSql = "INSERT INTO TERMINAL(COD_TERMINAL, NOM_TERMINAL, DIR_TERMINAL, NUM_TELEFONO, " +
                    "TIM_HORA_APERTURA, TIM_HORA_CIERRE, BOL_ESTADO) " +
                    "VALUES((SELECT COALESCE(MAX(COD_TERMINAL), 0) + 1 AS ID FROM TERMINAL),@nombre, @direccion, @telefono, " +
                    "@horaApertura, @horaCierre, @estado)";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand(sentenciaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", terminal.Nombre);
                    comando.Parameters.AddWithValue("@direccion", terminal.Direccion);
                    comando.Parameters.AddWithValue("@telefono", terminal.Telefono);
                    comando.Parameters.AddWithValue("@horaApertura", terminal.HoraApertura.ToString("HH:mm"));
                    comando.Parameters.AddWithValue("@horaCierre", terminal.HoraCierre.ToString("HH:mm"));
                    comando.Parameters.AddWithValue("@estado", terminal.Estado ? 1 : 0);
                    conexion.Open();
                    int resultado = comando.ExecuteNonQuery();
                }
                if(this.listaTerminales != null)
                {
                    this.listaTerminales = null;
                }
            }
            else
            {
                throw new Exception("El objeto no es de tipo Terminal.");
            }
        }

        /// <summary>
        /// Método obtener un objeto por si id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El objeto encontrado</returns>
        public override object Obtener(int id)
        {
            Terminal terminal = null;
            object[] objetos = this.Obtener();
            for(int i = 0; i < objetos.Length; i++)
            {
                if(objetos[i] != null && ((Terminal)objetos[i]).Id == id)
                {
                    terminal = (Terminal)objetos[i];
                    break;
                }
            }
            return terminal;
        }

        /// <summary>
        /// Método obtener un objeto por si id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El objeto encontrado</returns>
        public override object Obtener(string id)
        {
            Terminal terminal = null;
            try
            {
                terminal = (Terminal) this.Obtener(Int32.Parse(id));
            } catch(Exception exc)
            {
                Console.Error.WriteLine("Error: "+exc.Message, exc);
                throw new Exception("Los ID para objetos de tipo Terminal, deben contener solo numeros.");
            }
            return terminal;
        }

        /// <summary>
        /// Método para devolver un arrelo con todo los objetos de repositorio.
        /// </summary>
        /// <returns>EL arreglo</returns>
        public override object[] Obtener()
        {
            if(this.listaTerminales == null)
            {
                this.listaTerminales = new List<Terminal>();
                DataTable dataTable = new DataTable();
                string sentenciaSql = "SELECT COD_TERMINAL, NOM_TERMINAL, DIR_TERMINAL, NUM_TELEFONO, TIM_HORA_APERTURA, TIM_HORA_CIERRE, " +
                    "BOL_ESTADO FROM TERMINAL ORDER BY COD_TERMINAL ASC";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sentenciaSql, conexion))
                {
                    conexion.Open();
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Terminal terminal = new Terminal();
                        terminal.Id = (int)row.Field<decimal>("COD_TERMINAL");
                        terminal.Nombre = row.Field<string>("NOM_TERMINAL");
                        terminal.Direccion = row.Field<string>("DIR_TERMINAL");
                        terminal.Telefono = row.Field<string>("NUM_TELEFONO");
                        terminal.Estado = row.Field<bool>("BOL_ESTADO");
                        TimeSpan spanHoraApertura = row.Field<TimeSpan>("TIM_HORA_APERTURA");
                        terminal.HoraApertura = new DateTime(2022, 01, 01, spanHoraApertura.Hours, spanHoraApertura.Minutes, 00);
                        TimeSpan spanHoraCierre = row.Field<TimeSpan>("TIM_HORA_CIERRE");
                        terminal.HoraCierre = new DateTime(2022, 01, 01, spanHoraCierre.Hours, spanHoraCierre.Minutes, 00);
                        terminal.Estado = row.Field<bool>("BOL_ESTADO");
                        listaTerminales.Add(terminal);
                    }
                }
            } 
            return listaTerminales.ToArray();
        }
    }
}
