using BusesUNED_Cliente.Red;
using LibBusesUNED_comun.Dominio;
using LibBusesUNED_comun.Red;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace BusesUNED_Cliente.Pantallas
{
    public partial class PantallaConductores : Form
    {
        private Conductor conductor;
        private ClienteSocket clienteSocket;

        public PantallaConductores(Conductor conductor, ClienteSocket clienteSocket)
        {
            InitializeComponent();
            this.conductor = conductor;
            this.clienteSocket = clienteSocket;
        }

        private void PantallaConductores_Load(object sender, System.EventArgs e)
        {
            this.labelDatosConductor.Text = this.conductor.Identificacion + " - " + this.conductor.NombreCompleto + ".";
            DateTime hoy = DateTime.Today;
            DateTime fechaFin = hoy.AddDays(7);
            campoFechaInicio.Value = hoy;
            campoFechaFinal.Value = fechaFin;

            this.CargarColumnas();
        }

        /// <summary>
        /// Método par cargar las columnas del dategridview.
        /// </summary>
        private void CargarColumnas()
        {
            this.dataGridView1.Columns.Add("ColumnaFechaHora", "Fecha y Hora");
            this.dataGridView1.Columns.Add("ColumnaTerminalSalida", "Terminal de Salida");
            this.dataGridView1.Columns.Add("ColumnaTerminalLlegada", "Terminal de Llegada");
            this.dataGridView1.Columns.Add("ColumnaTipoRuta", "Tipo de Ruta");
            this.dataGridView1.Columns.Add("ColumnaTarifa", "Tarifa");
            this.dataGridView1.Columns.Add("ColumnaConductor", "Conductor");
            this.dataGridView1.Columns.Add("ColumnaAutobus", "Autobús");
        }

        /// <summary>
        /// Método para cargar los datos de los roles agregados en el dategridview.
        /// </summary>
        public void CargarDatos(List<Rol> roles)
        {
            this.dataGridView1.Rows.Clear();
            foreach (Rol rol in roles)
            {
                this.dataGridView1.Rows.Add(new string[7] {
                    rol.FechaHoraSalida.ToString("dd/MM/yyyy HH:mm"),
                    rol.Ruta.TerminalSalida.Nombre + " (Horario: " + rol.Ruta.TerminalSalida.Horario + ". Dirección: " + rol.Ruta.TerminalSalida.Direccion + ")",
                    rol.Ruta.TerminalLlegada.Nombre + " (Apertura: " + rol.Ruta.TerminalLlegada.Horario + ". Dirección: " + rol.Ruta.TerminalLlegada.Direccion + ")",
                    rol.Ruta.TipoRutaToString,
                    "CRC " + rol.Ruta.Tarifa,
                    rol.Conductor.Identificacion + " - " + rol.Conductor.NombreCompleto,
                    rol.Autobus.Placa + " (Marca: " + rol.Autobus.Marca + ". Capacidad: " + rol.Autobus.Capacidad + " pasajeros.)"
                });
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = this.campoFechaInicio.Value;
            DateTime fechaFinal = this.campoFechaFinal.Value;
            if (fechaInicio != null && fechaFinal != null && fechaInicio < fechaFinal)
            {
                FiltroBusqueda filtro = new FiltroBusqueda();
                filtro.fechaInicial = fechaInicio;
                filtro.fechaFinal = fechaFinal;
                filtro.idConductor = this.conductor.Identificacion;
                MensajeDeSocket<FiltroBusqueda> mensajeDeBusqueda = new MensajeDeSocket<FiltroBusqueda>();
                mensajeDeBusqueda.Metodo = Metodos.CONSULTA_ROLES;
                mensajeDeBusqueda.Entidad = filtro;
                this.clienteSocket.Enviar<FiltroBusqueda>(mensajeDeBusqueda);
                string respuestaJson = clienteSocket.Recibir();
                MensajeDeSocket<List<Rol>> mensajeDeRespuesta = JsonSerializer.Deserialize<MensajeDeSocket<List<Rol>>>(respuestaJson);
                if (mensajeDeRespuesta.Metodo.Equals(Metodos.OK))
                {
                    List<Rol> roles = mensajeDeRespuesta.Entidad;
                    if (roles.Count > 0)
                    {
                        this.CargarDatos(roles);
                    }
                    else
                    {
                        this.dataGridView1.Rows.Clear();
                        MessageBox.Show(
                            "No se encontraron roles registrados para su criterio de búsqueda.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "El resultado de la consulta de roles no fue exitoso.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                
            }
            else
            {
                MessageBox.Show(
                    "Las fechas inicial y final son requeridas y la fecha inicial debe ser menor que la fecha final.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
