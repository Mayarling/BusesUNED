using LibBusesUNED_comun.Dominio;
using LibBusesUNED.Logica;
using System;
using System.Windows.Forms;

namespace BusesUNED_Server.Pantallas
{
    public partial class PantallaAgregarAutobuses : Form
    {
        private ServicioAutobus servicioAutobus;

        /// <summary>
        /// Método constructor.
        /// </summary>
        public PantallaAgregarAutobuses()
        {
            InitializeComponent();
            this.servicioAutobus = ServicioAutobus.ObtenerInstancia();
        }

        /// <summary>
        /// Método para el click en el botón agregar autobús
        /// </summary>
        /// <param name="sender">El objeto del evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void buttonAgregarAutobus_Click(object sender, EventArgs e)
        {
            bool datosValidos = true;
            string errores = "";

            string placa = this.campoPlaca.Text.Trim();
            if (placa == null || placa.Equals(""))
            {
                datosValidos = false;
                errores += "La placa es requerida.\r\n";
            }
            string marca = this.campoMarca.Text.Trim();
            if (marca == null || marca.Equals(""))
            {
                datosValidos = false;
                errores += "La marca es requerida.\r\n";
            }
            int modelo = 0;
            try
            {
                modelo = Int32.Parse(this.campoModelo.Text.Trim());
                if (modelo <= 0)
                {
                    datosValidos = false;
                    errores += "El modelo debe ser mayor a cero.\r\n";
                }
            }
            catch (Exception exep)
            {
                datosValidos = false;
                errores += "El modelo debe ser un número {" + exep.Message + "}\r\n";
            }
            int capacidad = 0;
            try
            {
                capacidad = Int32.Parse(this.campoCapacidad.Text.Trim());
                if (capacidad <= 0)
                {
                    datosValidos = false;
                    errores += "La capacidad debe ser mayor a cero.\r\n";
                }
                else if (capacidad > ServicioAutobus.CAPACIDAD_MAXIMA)
                {
                    datosValidos = false;
                    errores += "La capacidad debe ser menor a " + ServicioAutobus.CAPACIDAD_MAXIMA + ".\r\n";
                }
            }
            catch (Exception exep)
            {
                datosValidos = false;
                errores += "La capacidad debe ser un número {" + exep.Message + "}\r\n";
            }
            bool estado = this.campoEstado.Text.Equals("ACTIVO") ? true : false;

            if (datosValidos)
            {
                try
                {
                    Autobus autobus = this.servicioAutobus.Agregar(placa, marca, modelo, capacidad, estado);
                    MessageBox.Show("El autobús con el # de placa " + autobus.Placa + " ha sido agregado con el Id: " + autobus.Id + ".", "Autobús agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((PantallaGestionAutobuses)this.Owner).CargarDatos();
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
        /// Método que se ejecuta cuando se carga el formulario
        /// </summary>
        /// <param name="sender">El objeto del evento</param>
        /// <param name="e">Los argumentos del evento</param>
        private void PantallaAgregarAutobuses_Load(object sender, EventArgs e)
        {
            this.campoEstado.SelectedIndex = 0;
        }
    }
}
