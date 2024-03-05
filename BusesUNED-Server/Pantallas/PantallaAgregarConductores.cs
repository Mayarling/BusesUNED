using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    /// <summary>
    /// Pantalla agregar conductores
    /// </summary>
    public partial class PantallaAgregarConductores : Form
    {
        private ServicioConductor servicioConductor;

        /// <summary>
        /// Método constructor.
        /// </summary>
        public PantallaAgregarConductores()
        {
            InitializeComponent();
            this.servicioConductor = ServicioConductor.ObtenerInstancia();
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void PantallaAgregarConductores_Load(object sender, EventArgs e)
        {
            this.campoGenero.SelectedIndex = 0;
        }

        private void buttonAgregarConductor_Click(object sender, EventArgs e)
        {
            bool datosValidos = true;
            string errores = "";

            string identificacion = this.campoIdentificacion.Text.Trim();
            if (identificacion == null || identificacion.Equals(""))
            {
                datosValidos = false;
                errores += "La identificación es requerida.\r\n";
            }
            string nombre = this.campoNombre.Text.Trim();
            if (nombre == null || nombre.Equals(""))
            {
                datosValidos = false;
                errores += "El nombre es requerido.\r\n";
            }
            string primerApellido = this.campoPrimerApellido.Text.Trim();
            if (primerApellido == null || primerApellido.Equals(""))
            {
                datosValidos = false;
                errores += "El primer apellido es requerido.\r\n";
            }
            string segundorApellido = this.campoSegundoApellido.Text.Trim();
            if (segundorApellido == null || segundorApellido.Equals(""))
            {
                datosValidos = false;
                errores += "El segundo apellido es requerido.";
            }
            DateTime fechaNacimiento = this.campoFechaNacimiento.Value;
            char genero = this.campoGenero.SelectedItem.Equals("MASCULINO") ? 'M' : 'F';
            bool esSupervisor = this.checkSupervisor.Checked;

            if (datosValidos)
            {
                try
                {
                    Conductor conductor = this.servicioConductor.Agregar(identificacion, nombre, primerApellido, segundorApellido, fechaNacimiento, genero, esSupervisor);
                    MessageBox.Show("El conductor con identificación " + conductor.Identificacion + " ha sido agregado.", "Conductor agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((PantallaGestionConductores)this.Owner).CargarDatos();
                    this.Dispose();
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Han ocurridos los siguientes errores:\r\n" + exception.Message, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Han ocurridos los siguientes errores:\r\n" + errores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
