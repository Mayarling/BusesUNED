using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusesUNED_Server.Utilidades
{
    /// <summary>
    /// Clase que abstrae el proceso de llevar una bitácora de eventos.
    /// </summary>
    public class Bitacora
    {
        /// <summary>
        /// TextBox que muestra la bitacora de registros
        /// </summary>
        private TextBox textoBitacora;

        /// <summary>
        /// Constructor por parametro, recibe el TextBox donde va a registrar los eventos
        /// </summary>
        /// <param name="textoBitacora">TextBox que muestra la bitacora de registros</param>
        public Bitacora(TextBox textoBitacora)
        {
            this.textoBitacora = textoBitacora;
        }
        /// <summary>
        /// Método que registra un evento en la bitácora utilizando el momento actual.
        /// </summary>
        /// <param name="evento">El evento a registrar</param>
        public void registrar(string evento)
        {
            DateTime ahora = DateTime.Now;
            string registro = ahora.ToString("dd/MM/yyyy HH:mm:ss:fff") + ": " + evento + Environment.NewLine;
            if (this.textoBitacora.InvokeRequired)
            {
                this.textoBitacora.Invoke((MethodInvoker)delegate ()
                {
                    this.textoBitacora.AppendText(registro);
                });
            }
            else
            {
                this.textoBitacora.AppendText(registro);
            }
        }

        /// <summary>
        /// Limpia los registros existentes de la bitácora.
        /// </summary>
        public void limpiar()
        {
            this.textoBitacora.Clear();
        }
    }
}
