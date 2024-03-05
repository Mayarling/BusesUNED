using System.Drawing;
using System.Windows.Forms;

namespace LibBusesUNED_comun.Utilidades
{
    /// <summary>
    /// Clase que permite abstraer el estado del servidor de manera sencilla en un Label
    /// </summary>
    public class GestorDeEstado
    {
        /// <summary>
        /// La etiqueta donde se vera reflejado el estado
        /// </summary>
        private Label etiquetaEstado;

        /// <summary>
        /// Constructor por parametro para crear el gestor asociado a una etiqueta
        /// </summary>
        /// <param name="etiqueta">La etiqueta donde se vera reflejado el estado</param>
        public GestorDeEstado(Label etiqueta)
        {
            this.etiquetaEstado = etiqueta;
        }

        /// <summary>
        /// Método para registrar en mensaje en estado de exito. El estado de exito es VERDE
        /// </summary>
        /// <param name="mensaje">El mensaje</param>
        public void exito(string mensaje)
        {
            this.etiquetaEstado.Text = mensaje;
            this.etiquetaEstado.ForeColor = Color.Green;
        }
        /// <summary>
        /// Método para registrar en mensaje en estado de error. El estado de exito es ROJO
        /// </summary>
        /// <param name="mensaje">El mensaje</param>
        public void error(string mensaje)
        {
            this.etiquetaEstado.Text = "[ERROR]: " + mensaje;
            this.etiquetaEstado.ForeColor = Color.Red;
        }

        /// <summary>
        /// Método para registrar en mensaje en estado de inactividad. El estado de exito es NEGRO
        /// </summary>
        /// <param name="mensaje">El mensaje</param>
        public void inactivo(string mensaje)
        {
            this.etiquetaEstado.Text = mensaje;
            this.etiquetaEstado.ForeColor = Color.Black;
        }

        /// <summary>
        /// Método para registrar en mensaje en estado de actividad. El estado de exito es AZUL
        /// </summary>
        /// <param name="mensaje">El mensaje</param>
        public void actividad(string mensaje)
        {
            this.etiquetaEstado.Text = mensaje;
            this.etiquetaEstado.ForeColor = Color.Blue;
        }
    }
}
