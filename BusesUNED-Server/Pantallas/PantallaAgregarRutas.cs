using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    public partial class PantallaAgregarRutas : Form
    {
        private ServicioRuta ServicioRuta;
        private ServicioTerminal ServicioTerminal;

        /// <summary>
        /// Método constructor.
        /// </summary>
        public PantallaAgregarRutas()
        {
            InitializeComponent();
            this.ServicioRuta = ServicioRuta.ObtenerInstancia();
            this.ServicioTerminal = ServicioTerminal.ObtenerInstancia();
        }

        /// <summary>
        /// Método para cuando se hace click en el botón agregar ruta.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void buttonAgregarRuta_Click(object sender, EventArgs e)
        {
            bool datosValidos = true;
            string errores = "";

            int idTerminalSalida = this.CargarIdTerminalSeleccionada(this.CampoIdTerminalSalida);
            if (idTerminalSalida == 0)
            {
                datosValidos = false;
                errores += "Debe seleccionar una terminal de salida activa.\r\n";
            }
            int idTerminalLlegada = this.CargarIdTerminalSeleccionada(this.campoTerminalLlegada);
            if (idTerminalLlegada == 0)
            {
                datosValidos = false;
                errores += "Debe seleccionar una terminal de llegada activa.\r\n";
            }
            if (idTerminalSalida == idTerminalLlegada)
            {
                datosValidos = false;
                errores += "La terminal de salida y la terminal de llegada no deben ser la misma.\r\n";
            }
            double tarifa = 0;
            try
            {
                tarifa = double.Parse(this.campoTarifa.Text);
                if (tarifa <= 0)
                {
                    datosValidos = false;
                    errores += "La tarifa debe de ser mayor a cero.\r\n";
                }
                if (tarifa > 50000)
                {
                    datosValidos = false;
                    errores += "La tarifa debe de ser menor a CRC 50.000.\r\n";
                }
            }
            catch (Exception exception)
            {
                datosValidos = false;
                errores += "La tarifa debe de ser un valor númerico(" + exception.Message + ").\r\n";
            }

            string descripcion = this.campoDescripcion.Text.Trim();
            if (descripcion.Equals(""))
            {
                datosValidos = false;
                errores += "La descripción es requerida.\r\n";
            }
            int tipo = this.campoTipoRuta.SelectedIndex + 1;
            bool estado = this.campoEstado.SelectedItem.Equals("ACTIVO") ? true : false;
            if (datosValidos)
            {
                try
                {
                    Ruta ruta = this.ServicioRuta.Agregar(idTerminalSalida, idTerminalLlegada, tarifa, descripcion, tipo, estado);
                    MessageBox.Show(
                        "La ruta " + ruta.TerminalSalida.Nombre + " -> " + ruta.TerminalLlegada.Nombre + " ha sido agregada con el id: " + ruta.Id + ".",
                        "Errores de validación.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    ((PantallaGestionRutas)this.Owner).CargarDatos();
                    this.Dispose();
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        "Han ocurrido los siguientes errores:\r\n" + exception.Message,
                        "Errores de validación.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Han ocurrido los siguientes errores:\r\n" + errores,
                    "Errores de validación.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que genra el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void PantallaAgregarRutas_Load(object sender, EventArgs e)
        {
            if (this.ServicioTerminal.hayTerminalesActivas())
            {
                this.CargarTerminalesActivas(this.CampoIdTerminalSalida);
                this.CargarTerminalesActivas(this.campoTerminalLlegada);
                this.campoEstado.SelectedIndex = 0;
                this.campoTipoRuta.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(
                    "No hay datos registrados de terminales para proceder a agregar rutas. Debe haber al menos 1 terminal activa.",
                    "Datos insuficientes.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
                this.Dispose();
                this.Close();
            }
        }

        /// <summary>
        /// Método para cargar un ComboBox con las terminales Activas.
        /// </summary>
        /// <param name="comboTerminalesActivas">El ComboBox en que se cargaran las terminales activas.</param>
        private void CargarTerminalesActivas(ComboBox comboTerminalesActivas)
        {
            comboTerminalesActivas.Items.Clear();
            Terminal[] terminales = this.ServicioTerminal.ObtenerTerminales();
            foreach (Terminal terminal in terminales)
            {
                if (terminal.Estado) // Osea, la terminal esta ACTIVA
                {
                    comboTerminalesActivas.Items.Add(terminal.Id + "-" + terminal.Nombre);
                }
            }
            comboTerminalesActivas.SelectedIndex = 0;
        }

        /// <summary>
        /// Método que retorna el id de la terminal basado en el item seleccionado en el ComboBox
        /// </summary>
        /// <param name="comboTerminalesActivas">El combo del cual se va a cargar el id de la terminal</param>
        /// <returns>El id de la terminal o cero si no encuentra nada.</returns>
        private int CargarIdTerminalSeleccionada(ComboBox comboTerminalesActivas)
        {
            int id = 0;
            string item = comboTerminalesActivas.SelectedItem.ToString();
            if (item != null && item.Length > 0)
            {
                id = Int32.Parse(item.Substring(0, item.IndexOf("-")));
            }
            return id;
        }
    }
}
