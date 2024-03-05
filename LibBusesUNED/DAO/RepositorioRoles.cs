using LibBusesUNED_comun.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibBusesUNED.DAO
{
    /// <summary>
    /// La clase RepositorioRoles implementa la interface IRepositorio, por lo cual debe cumplir con todos sus metodos.
    /// Representa un objeto que sirve para guardas hasta 20 instancias de la clase Rol.
    /// </summary>
    public class RepositorioRoles : RepositorioSqlAbstracto
    {
        private IRepositorio RepositorioConductores;
        private IRepositorio RepositorioAutobuses;
        private IRepositorio RepositorioRutas;

        private List<Rol> listaRoles = null;

        public RepositorioRoles()
        {
            this.RepositorioConductores = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.CONDUCTOR);
            this.RepositorioAutobuses = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.AUTOBUS);
            this.RepositorioRutas = FabricaRepositorios.ObtenerRepositorio(FabricaRepositorios.RUTA);
        }
        /// <summary>
        /// Método para agregar un nuevo objeto repositorio.
        /// </summary>
        /// <param name="objeto">El objeto agregar</param>
        /// <exception cref="Exception">Exepción en caso de que haya un error</exception>
        public override void Agregar(object objeto)
        {
            if (objeto.GetType() == typeof(Rol))
            {
                Rol rol = (Rol)objeto;
                string sentenciaSql = "INSERT INTO ROL(FEC_ROL, TIM_HORA_SALIDA, NUM_RUTA, NUM_IDENTIFICACION_BUS, NUM_CEDULA_CONDUCTOR) " +
                    "VALUES(@fechaRol, @horaSalida, @idRuta, @idBus, @cedulaConductor)";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlCommand comando = new SqlCommand(sentenciaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@fechaRol", rol.FechaHoraSalida.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@horaSalida", rol.FechaHoraSalida.ToString("HH:mm:00"));
                    comando.Parameters.AddWithValue("@idRuta", rol.Ruta.Id);
                    comando.Parameters.AddWithValue("@idBus", rol.Autobus.Id);
                    comando.Parameters.AddWithValue("@cedulaConductor", rol.Conductor.Identificacion);
                    conexion.Open();
                    int resultado = comando.ExecuteNonQuery();
                }
                if(this.listaRoles != null)
                {
                    this.listaRoles = null;
                }
            }
            else
            {
                throw new Exception("El objeto no es de tipo Rol.");
            }
        }

        /// <summary>
        /// Método obtener un objeto por su id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El objeto encontrado</returns>
        public override object Obtener(int id)
        {
            Rol rol = null;
            object[] objetos = this.Obtener();
            for (int i = 0; i < objetos.Length; i++)
            {
                if (objetos[i] != null && ((Rol)objetos[i]).Id == id)
                {
                    rol = (Rol)objetos[i];
                    break;
                }
            }
            return rol;
        }

        /// <summary>
        /// Método obtener un objeto por si id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El objeto encontrado</returns>
        public override object Obtener(string id)
        {
            Rol rol = null;
            try
            {
                rol = (Rol)this.Obtener(Int32.Parse(id));
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine("Error: " + exc.Message, exc);
                throw new Exception("Los ID para objetos de tipo Rol, deben contener solo numeros.");
            }
            return rol;
        }

        /// <summary>
        /// Método para devolver un arrelo con todo los objetos de repositorio.
        /// </summary>
        /// <returns>EL arreglo</returns>
        public override object[] Obtener()
        {
            if(this.listaRoles == null)
            {
                this.listaRoles = new List<Rol>();
                DataTable dataTable = new DataTable();
                string sentenciaSql = "SELECT FEC_ROL, TIM_HORA_SALIDA, NUM_RUTA, NUM_IDENTIFICACION_BUS, NUM_CEDULA_CONDUCTOR FROM ROL";
                using (SqlConnection conexion = this.ObtenerConexion())
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sentenciaSql, conexion))
                {
                    conexion.Open();
                    dataAdapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow row = dataTable.Rows[i];
                        Rol rol = new Rol();
                        rol.Id = i;
                        DateTime fechaRol = row.Field<DateTime>("FEC_ROL");
                        TimeSpan horaRol = row.Field<TimeSpan>("TIM_HORA_SALIDA");
                        rol.FechaHoraSalida = new DateTime(fechaRol.Year, fechaRol.Month, fechaRol.Day, horaRol.Hours, horaRol.Minutes, 0);

                        int idRuta = (int)row.Field<decimal>("NUM_RUTA");
                        rol.Ruta = (Ruta)this.RepositorioRutas.Obtener(idRuta);

                        int idAutobus = (int)row.Field<decimal>("NUM_IDENTIFICACION_BUS");
                        rol.Autobus = (Autobus)this.RepositorioAutobuses.Obtener(idAutobus);

                        string idConductor = row.Field<string>("NUM_CEDULA_CONDUCTOR");
                        rol.Conductor = (Conductor)this.RepositorioConductores.Obtener(idConductor);
                        listaRoles.Add(rol);
                    }
                }
            }
            return listaRoles.ToArray();
        }
    }
}