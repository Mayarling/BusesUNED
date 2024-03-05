using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    public partial class PantallaAgregarTerminales : Form
    {
        private ServicioTerminal ServicioTerminal;
        public PantallaAgregarTerminales()
        {
            InitializeComponent();
            this.ServicioTerminal = ServicioTerminal.ObtenerInstancia();
        }

        /// <summary>
        /// Método para el click en el botón agregar terminal.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento</param>
        /// <param name="e">Los argumentos del evento </param>
        private void buttonAgregarTerminal_Click(object sender, EventArgs e)
        {
            bool datosValidos = true;
            string errores = "";

            string nombre = this.campoNombre.Text.Trim();
            if (nombre == null || nombre.Equals(""))
            {
                datosValidos = false;
                errores += "El nombre es requerido.\r\n";
            }
            string direccion = this.campoDireccion.Text.Trim();
            if (direccion == null || direccion.Equals(""))
            {
                datosValidos = false;
                errores += "La dirección es requerida.\r\n";
            }
            string telefono = this.campoTelefono.Text.Trim();
            if (telefono == null || telefono.Equals(""))
            {
                datosValidos = false;
                errores += "El número de teléfono es requerido.\r\n";
            }
            DateTime horaApertura = this.campoHoraApertura.Value;
            DateTime horaCierre = this.campoHoraCierre.Value;
            bool estado = this.campoEstado.Text.Equals("ACTIVO") ? true : false;

            if (datosValidos)
            {
                try
                {
                    Terminal terminal = this.ServicioTerminal.Agregar(nombre, direccion, telefono, horaApertura, horaCierre, estado);
                    MessageBox.Show("Terminal " + terminal.Nombre + " agregada con exito con el id: " + terminal.Id + ".", "Terminal agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((PantallaGestionTerminales)this.Owner).CargarDatos();
                    this.Dispose();
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Han ocurrido los siguientes errores:\r\n" + exception.Message, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Han ocurrido los siguientes errores:\r\n" + errores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void PantallaAgregarTerminales_Load(object sender, EventArgs e)
        {
            this.campoEstado.SelectedIndex = 0;
        }
    }
}
