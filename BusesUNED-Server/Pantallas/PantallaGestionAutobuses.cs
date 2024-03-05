using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    /// <summary>
    /// Pantalla gestión de autobúses.
    /// </summary>
    public partial class PantallaGestionAutobuses : Form
    {
        private ServicioAutobus servicioAutobus;
        private PantallaAgregarAutobuses agregarAutobuses;


        /// <summary>
        /// Método constructor.
        /// </summary>
        public PantallaGestionAutobuses()
        {
            InitializeComponent();
            this.servicioAutobus = ServicioAutobus.ObtenerInstancia();
        }

        private void buttonAgregarAutobus_Click(object sender, EventArgs e)
        {
            if (this.agregarAutobuses == null || this.agregarAutobuses.IsDisposed)
            {
                this.agregarAutobuses = new PantallaAgregarAutobuses();
                this.agregarAutobuses.Show(this);
            }
            else
            {
                this.agregarAutobuses.Focus();
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga la pantalla.
        /// </summary>
        /// <param name="sender">El objeto del evento</param>
        /// <param name="e">Los argumentos que genera el evento</param>
        private void PantallaGestionAutobuses_Load(object sender, EventArgs e)
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
            this.dataGridView1.Columns.Add("ColumnaId", "ID");
            this.dataGridView1.Columns.Add("ColumnaPlaca", "Placa");
            this.dataGridView1.Columns.Add("columnaMarca", "Marca");
            this.dataGridView1.Columns.Add("columnaModelo", "Modelo");
            this.dataGridView1.Columns.Add("columnaCapacidad", "Capacidad");
            this.dataGridView1.Columns.Add("columnaEstado", "Estado");

        }

        /// <summary>
        /// Método para cargar los datos en el dategridview.
        /// </summary>
        public void CargarDatos()
        {
            this.dataGridView1.Rows.Clear();
            Autobus[] autobuses = this.servicioAutobus.ObtenerAutobuses();
            foreach (Autobus autobus in autobuses)
            {
                this.dataGridView1.Rows.Add(new string[6]
                {
                    autobus.Id.ToString(),
                    autobus.Placa,
                    autobus.Marca,
                    autobus.Modelo.ToString(),
                    autobus.Capacidad.ToString(),
                    autobus.EstadoToString
                });
            }
        }
    }
}
