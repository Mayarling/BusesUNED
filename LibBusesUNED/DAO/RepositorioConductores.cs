using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibBusesUNED.DAO
{
    /// <summary>
    /// La clase RepositorioConductores implementa la interface IRepositorio, por lo cual debe cumplir con todos sus metodos.
    /// Representa un objeto que sirve para guardas hasta 20 instancias de la clase Conductor.
    /// </summary>
    public class RepositorioConductores : RepositorioSqlAbstracto
    {
        private List<Conductor> listaConductores = null;
        public RepositorioConductores()
        {
        }
        public override void Agregar(object objeto)
        {
            if (objeto.GetType() == typeof(Conductor))
            {
                Conductor conductor = (Conductor)objeto;
                string sentenciaSql = "INSERT INTO CONDUCTOR(NUM_CEDULA, NOM_NOMBRE, NOM_APELLIDO_1, NOM_APELLIDO_2, FEC_NACIMIENTO, TIP_GENERO, BIT_SUPERVISOR) " +
                    "VALUES(@cedula, @nombre, @apellido1, @apellido2, @fechaNacimiento, @genero, @supervisor)";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand(sentenciaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@cedula", conductor.Identificacion);
                    comando.Parameters.AddWithValue("@nombre", conductor.Nombre);
                    comando.Parameters.AddWithValue("@apellido1", conductor.PrimerApellido);
                    comando.Parameters.AddWithValue("@apellido2", conductor.SegundoApellido);
                    comando.Parameters.AddWithValue("@fechaNacimiento", conductor.FechaNacimiento.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@genero", conductor.Genero);
                    comando.Parameters.AddWithValue("@supervisor", conductor.ConductorSupervisor ? 1 : 0);
                    conexion.Open();
                    int resultado = comando.ExecuteNonQuery();
                }
                if(this.listaConductores != null)
                {
                    this.listaConductores = null;
                }
            }
            else
            {
                throw new Exception("El objeto no es de tipo Conductor.");
            }
        }

        /// <summary>
        /// Método obtener un objeto por si id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El objeto encontrado</returns>
        public override object Obtener(int id)
        {
            return this.Obtener("" + id);
        }

        public override object Obtener(string id)
        {
            Conductor conductor = null;
            object[] objetos = this.Obtener();
            for (int i = 0; i < objetos.Length; i++)
            {
                if (objetos[i] != null && ((Conductor)objetos[i]).Identificacion.Equals(id))
                {
                    conductor = (Conductor)objetos[i];
                    break;
                }
            }
            return conductor;
        }

        /// <summary>
        /// Método para devolver un arrelo con todo los objetos de repositorio.
        /// </summary>
        /// <returns>EL arreglo</returns>
        public override object[] Obtener()
        {
            if(this.listaConductores == null)
            {
                this.listaConductores = new List<Conductor>();
                DataTable dataTable = new DataTable();
                string sentenciaSql = "SELECT NUM_CEDULA, NOM_NOMBRE, NOM_APELLIDO_1, NOM_APELLIDO_2, FEC_NACIMIENTO, TIP_GENERO, BIT_SUPERVISOR " +
                    "FROM CONDUCTOR";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sentenciaSql, conexion))
                {
                    conexion.Open();
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Conductor conductor = new Conductor();
                        conductor.Identificacion = row.Field<string>("NUM_CEDULA");
                        conductor.Nombre = row.Field<string>("NOM_NOMBRE");
                        conductor.PrimerApellido = row.Field<string>("NOM_APELLIDO_1");
                        conductor.SegundoApellido = row.Field<string>("NOM_APELLIDO_2");
                        conductor.FechaNacimiento = row.Field<DateTime>("FEC_NACIMIENTO");
                        conductor.Genero = row.Field<string>("TIP_GENERO").ToCharArray()[0];
                        conductor.ConductorSupervisor = row.Field<bool>("BIT_SUPERVISOR");
                        listaConductores.Add(conductor);
                    }
                }
            }
            return listaConductores.ToArray();
        }
    }
}