using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    public partial class PantallaGestionTerminales : Form
    {
        private ServicioTerminal ServicioTerminal;
        private PantallaAgregarTerminales pantallaAgregarTerminales;

        public PantallaGestionTerminales()
        {
            InitializeComponent();
            this.ServicioTerminal = ServicioTerminal.ObtenerInstancia();
        }
        /// <summary>
        /// Método para cuando se hace click en el botón agregar terminal.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void buttonAgregarTerminal_Click(object sender, EventArgs e)
        {
            if (this.pantallaAgregarTerminales == null || this.pantallaAgregarTerminales.IsDisposed)
            {
                this.pantallaAgregarTerminales = new PantallaAgregarTerminales();
                pantallaAgregarTerminales.Show(this);
            } else
            {
                this.pantallaAgregarTerminales.Focus();
            }
        }

        /// <summary>
        /// Método que se ejecuta al cargar el formulario.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void PantallaGestionTerminales_Load(object sender, EventArgs e)
        {
            this.CargarColumas();
            this.CargarDatos();
            this.dataGridView1.ReadOnly = true;
        }

        /// <summary>
        /// Método para cargar las columnas del dategridview.
        /// </summary>
        private void CargarColumas()
        {
            this.dataGridView1.Columns.Add("columnaId", "ID");
            this.dataGridView1.Columns.Add("columnaNombre", "Nombre");
            this.dataGridView1.Columns.Add("columnaDireccion", "Dirección");
            this.dataGridView1.Columns.Add("columnaTelefono", "Teléfono");
            this.dataGridView1.Columns.Add("columnaApertura", "Hora de Apertura");
            this.dataGridView1.Columns.Add("columnaCierre", "Hora de Cierre");
            this.dataGridView1.Columns.Add("columnaEstado", "Estado");
        }

        /// <summary>
        /// Método para cargar los datos de las terminales agregadas en el DataGridView.
        /// </summary>
        public void CargarDatos()
        {
            this.dataGridView1.Rows.Clear();
            Terminal[] terminales = this.ServicioTerminal.ObtenerTerminales();
            foreach (Terminal terminal in terminales)
            {
                this.dataGridView1.Rows.Add(new string[7] {
                    terminal.Id.ToString(),
                    terminal.Nombre,
                    terminal.Direccion,
                    terminal.Telefono,
                    terminal.HoraApertura.ToString("HH:mm"),
                    terminal.HoraCierre.ToString("HH:mm"),
                    terminal.EstadoToString
                });
            }
        }
    }
}
