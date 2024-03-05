using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    public partial class PantallaAgregarRoles : Form
    {
        private ServicioRol servicioRol;
        private ServicioRuta ServicioRuta;
        private ServicioConductor ServicioConductor;
        private ServicioAutobus servicioAutobus;

        /// <summary>
        /// Método contructor.
        /// </summary>
        public PantallaAgregarRoles()
        {
            InitializeComponent();
            this.servicioRol = ServicioRol.ObtenerInstancia();
            this.ServicioRuta = ServicioRuta.ObtenerInstancia();
            this.ServicioConductor = ServicioConductor.ObtenerInstancia();
            this.servicioAutobus = ServicioAutobus.ObtenerInstancia();
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void PantallaAgregarRoles_Load(object sender, EventArgs e)
        {
            if (!this.ServicioRuta.hayRutasActivas())
            {

                MessageBox.Show(
                   "No hay datos registrados de rutas para proceder a agregar roles. Debe haber al menos 1 ruta activa.",
                   "Datos insuficientes.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Stop
                );
                this.Dispose();
                this.Close();
            }
            else if (!this.servicioAutobus.hayAutobusesActivos())
            {
                MessageBox.Show(
                   "No hay datos registrados de autobuses para proceder a agregar roles. Debe haber al menos 1 autobús activo.",
                   "Datos insuficientes.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Stop
                );
                this.Dispose();
                this.Close();
            }
            else if (!this.ServicioConductor.hayConductoresRegulares())
            {
                MessageBox.Show(
                   "No hay datos registrados de conductores para proceder a agregar roles. Debe haber al menos 1 conductor activo.",
                   "Datos insuficientes.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Stop
                );
                this.Dispose();
                this.Close();
            }
            else
            {
                this.CargarRutasActivas(this.campoRuta);
                this.CargarAutobusesActivos(this.campoAutobus);
                this.cargarConductoresRegistrados(this.campoConductor);
                DateTime fechaMinima = DateTime.Today.AddDays(2);
                this.campoFecha.MinDate = fechaMinima;
            }
        }

        /// <summary>
        /// Método para cargar un ComboBox con las rutas activas.
        /// </summary>
        /// <param name="comboRutasActivas">El ComboBox en que se cargaran las rutas activas.</param>
        private void CargarRutasActivas(ComboBox comboRutasActivas)
        {
            comboRutasActivas.Items.Clear();
            Ruta[] rutas = this.ServicioRuta.ObtenerRutas();
            foreach (Ruta ruta in rutas)
            {
                if (ruta.Estado)
                {
                    comboRutasActivas.Items.Add(ruta.Id + "-" + ruta.TerminalSalida.Nombre + " -> " + ruta.TerminalLlegada.Nombre + ". Tarifa: CRC " + ruta.Tarifa + ". Tipo:" + (ruta.TipoRuta == 1 ? "DIRECTO" : "REGULAR"));
                }
            }
            comboRutasActivas.SelectedIndex = 0;
        }

        /// <summary>
        /// Método para cargar un ComboBox con los autobuses activos.
        /// </summary>
        /// <param name="comboAutobusesActivos">El ComboBox en que se cargaran los autobuses activos.</param>
        private void CargarAutobusesActivos(ComboBox comboAutobusesActivos)
        {
            comboAutobusesActivos.Items.Clear();
            Autobus[] autobuses = this.servicioAutobus.ObtenerAutobuses();
            foreach (Autobus autobus in autobuses)
            {
                if (autobus.Estado)
                {
                    comboAutobusesActivos.Items.Add(autobus.Id + "-" + autobus.Placa + "-" + autobus.Marca + "-" + autobus.Capacidad);
                }
            }
            comboAutobusesActivos.SelectedIndex = 0;
        }

        /// <summary>
        /// Método para cargar un combox con los conductores registrados.
        /// </summary>
        /// <param name="comboConductoresRegistrados">El ComboBox en que se cargaran los conductores registrados.</param>
        private void cargarConductoresRegistrados(ComboBox comboConductoresRegistrados)
        {
            comboConductoresRegistrados.Items.Clear();
            Conductor[] conductores = this.ServicioConductor.ObtenerConductores();
            foreach (Conductor conductor in conductores)
            {
                if (!conductor.ConductorSupervisor)
                {
                    comboConductoresRegistrados.Items.Add("(" + conductor.Identificacion + ") " + conductor.NombreCompleto);
                }
            }
            comboConductoresRegistrados.SelectedIndex = 0;
        }

        private void buttonAgregarRol_Click(object sender, EventArgs e)
        {
            DateTime fechaSalida = this.campoFecha.Value;
            DateTime horaSalida = this.campoHoraSalida.Value;
            DateTime fechaHoraSalida = new DateTime(fechaSalida.Year, fechaSalida.Month, fechaSalida.Day, horaSalida.Hour, horaSalida.Minute, 0);
            int idRuta = this.ObtenerIdRuta();
            int idAutobus = this.ObtenerIdAutobus();
            string idConductor = this.ObtenerIdConductor();
            try
            {
                Rol rol = this.servicioRol.Agregar(fechaHoraSalida, idRuta, idAutobus, idConductor);
                MessageBox.Show(
                   "Rol agregado con el ID " + rol.Id + ".",
                   "Rol agregado.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                );
                this.Dispose();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                   "Han ocurrido los siguientes errores de validación: " + exception.Message,
                   "Errores de validación.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Método para obtener el Id de la ruta basado en el Item seleccionado del combobox
        /// </summary>
        /// <returns>El Id de la ruta o 0 sino hay ningún Item seleccionado.</returns>
        private int ObtenerIdRuta()
        {
            int id = 0;

            string seleccionCombo = this.campoRuta.SelectedItem.ToString();
            if (seleccionCombo != null)
            {
                try
                {
                    id = Int32.Parse(seleccionCombo.Substring(0, seleccionCombo.IndexOf("-")));
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                }
            }

            return id;
        }

        /// <summary>
        /// Método para obtener el Id del autobús basado en el Item seleccionado del combobox
        /// </summary>
        /// <returns>El Id del autobús o 0 sino hay ningún Item seleccionado.</returns>
        private int ObtenerIdAutobus()
        {
            int id = 0;

            string seleccionCombo = this.campoAutobus.SelectedItem.ToString();
            if (seleccionCombo != null)
            {
                try
                {
                    id = Int32.Parse(seleccionCombo.Substring(0, seleccionCombo.IndexOf("-")));
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                }
            }

            return id;
        }

        /// <summary>
        /// Método para obtener el Id del conductor basado en el Item seleccionado del combobox
        /// </summary>
        /// <returns>El Id del conductor o 0 sino hay ningún Item seleccionado.</returns>
        private string ObtenerIdConductor()
        {
            string id = "";

            string seleccionCombo = this.campoConductor.SelectedItem.ToString();
            if (seleccionCombo != null)
            {
                try
                {
                    id = seleccionCombo.Substring(1, seleccionCombo.IndexOf(")") - 1);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.StackTrace);
                }
            }

            return id;
        }
    }
}
