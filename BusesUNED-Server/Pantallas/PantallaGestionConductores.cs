using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    /// <summary>
    /// Pantalla de gestión de conductores.
    /// </summary>
    public partial class PantallaGestionConductores : Form
    {
        private ServicioConductor servicioConductor;
        private PantallaAgregarConductores pantallaAgregarConductores;

        /// <summary>
        /// Método constructor.
        /// </summary>
        public PantallaGestionConductores()
        {
            InitializeComponent();
            this.servicioConductor = ServicioConductor.ObtenerInstancia();
        }

        private void buttonAgregarConductor_Click(object sender, EventArgs e)
        {
            if (this.pantallaAgregarConductores == null || this.pantallaAgregarConductores.IsDisposed)
            {
                pantallaAgregarConductores = new PantallaAgregarConductores();
                pantallaAgregarConductores.Show(this);
            }
            else
            {
                this.pantallaAgregarConductores.Focus();
            }

        }

        /// <summary>
        /// Método que se ejecuta al cargar el formulario
        /// </summary>
        /// <param name="sender">El objeto que gnera el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void PantallaGestionConductores_Load(object sender, EventArgs e)
        {
            this.CargarColumnas();
            this.CargarDatos();
            this.dataGridView1.ReadOnly = true;

        }

        /// <summary>
        /// Método para cargar las columnas del dategridview.
        /// </summary>
        private void CargarColumnas()
        {
            this.dataGridView1.Columns.Add("columnaId", "ID");
            this.dataGridView1.Columns.Add("columnaNombre", "Nombre Completo");
            this.dataGridView1.Columns.Add("columnaFechaNacimiento", "Fecha de Nacimiento");
            this.dataGridView1.Columns.Add("columnaGenero", "Género");
            this.dataGridView1.Columns.Add("columnaSupervisro", "Conductor Supervisor");
        }

        /// <summary>
        /// Método para cargar los datos de los conductores agregados en el dateGridViud.
        /// </summary>
        public void CargarDatos()
        {
            this.dataGridView1.Rows.Clear();
            Conductor[] conductores = this.servicioConductor.ObtenerConductores();
            foreach (Conductor conductor in conductores)
            {
                this.dataGridView1.Rows.Add(new String[5]
                {
                    conductor.Identificacion,
                    conductor.NombreCompleto,
                    conductor.FechaNacimiento.ToString("dd/MM/yyyy"),
                    conductor.GeneroToString,
                    conductor.ConductorSupervisorToString
                });
            }
        }
    }
}
