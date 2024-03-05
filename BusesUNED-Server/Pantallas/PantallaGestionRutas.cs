using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    /// <summary>
    /// Pantalla de gestion de rutas.
    /// </summary>
    public partial class PantallaGestionRutas : Form
    {
        private ServicioRuta ServicioRuta;
        private PantallaAgregarRutas PantallaAgregarRutas;

        /// <summary>
        /// Método constructor.
        /// </summary>
        public PantallaGestionRutas()
        {
            InitializeComponent();
            this.ServicioRuta = ServicioRuta.ObtenerInstancia();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.PantallaAgregarRutas == null || this.PantallaAgregarRutas.IsDisposed)
            {
                this.PantallaAgregarRutas = new PantallaAgregarRutas();
                PantallaAgregarRutas.Show(this);
            }
            else
            {
                this.PantallaAgregarRutas.Focus();
            }
        }

        /// <summary>
        /// Método que se ejecuta al cargar el formulario.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento</param>
        /// <param name="e">LOs argumentos del evento</param>
        private void PantallaGestionRutas_Load(object sender, EventArgs e)
        {
            this.CargarColumnas();
            this.CargarDatos();
            this.dataGridView1.ReadOnly = true;
        }

        /// <summary>
        /// Métod para cargar las columnas del dategridview.
        /// </summary>
        private void CargarColumnas()
        {
            this.dataGridView1.Columns.Add("ColumnaId", "ID Ruta");
            this.dataGridView1.Columns.Add("ColumnaTerminalSalida", "Terminal de Salida (ID y Nombre)");
            this.dataGridView1.Columns.Add("ColumnaDetallesTerminalSalida", "Dirección (Terminal de salida)");
            this.dataGridView1.Columns.Add("ColumnaDetallesTerminalSalidaHoras", "Hora Apertura - Hora Cierre");
            this.dataGridView1.Columns.Add("ColumnaDetallesTerminalEntrada", " Terminal de llegada (ID y Nombre)");
            this.dataGridView1.Columns.Add("ColumnaDetallesTerminalLlegada", "Dirección (Terminal de llegada)");
            this.dataGridView1.Columns.Add("ColumnaDetallesTerminalSalidaHoras", "Hora Apertura - Hora Cierre");
            this.dataGridView1.Columns.Add("ColumnaTarifa", "Tarifa (Ruta)");
            this.dataGridView1.Columns.Add("columnaDescripcion", "Descripción (Ruta)");
            this.dataGridView1.Columns.Add("ColumnaTipo", "Tipo de Ruta");
            this.dataGridView1.Columns.Add("ColumnaEstado", "Estado de la Ruta");
        }

        /// <summary>
        /// Método para cargar los datos de las rutas agregadas en el dategridview.
        /// </summary>
        public void CargarDatos()
        {
            this.dataGridView1.Rows.Clear();
            Ruta[] rutas = this.ServicioRuta.ObtenerRutas();
            foreach (Ruta ruta in rutas)
            {
                this.dataGridView1.Rows.Add(new string[11] {
                    ruta.Id.ToString(),
                    ruta.TerminalSalida.Id + "-" + ruta.TerminalSalida.Nombre,
                    ruta.TerminalSalida.Direccion,
                    ruta.TerminalSalida.Horario,
                    ruta.TerminalLlegada.Id + "-" + ruta.TerminalLlegada.Nombre,
                    ruta.TerminalLlegada.Direccion,
                    ruta.TerminalLlegada.Horario,
                    ruta.Tarifa.ToString(),
                    ruta.Descripcion,
                    ruta.TipoRutaToString,
                    ruta.EstadoToString

                });
            }

        }
    }
}
