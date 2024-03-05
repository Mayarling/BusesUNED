using System.Windows.Forms;

namespace BusesUNED_Server.Utilidades
{
    /// <summary>
    /// Clase para abstraer la lista de clientes conectados.
    /// </summary>
    public class GestorClientes
    {
        /// <summary>
        /// El ListBox donde se muestran los clientes conectados.
        /// </summary>
        private ListBox listaClientes;

        /// <summary>
        /// Constructor que recibe el ListBox donde se muestran los clientes conectados.
        /// </summary>
        /// <param name="listaClientes">el ListBox donde se muestran los clientes conectados.</param>
        public GestorClientes(ListBox listaClientes)
        {
            this.listaClientes = listaClientes;
        }

        /// <summary>
        /// Método para agregar un cliente a la lista de clientes
        /// </summary>
        /// <param name="cliente">El cliente</param>
        public void agregarCliente(string cliente)
        {
            if (this.listaClientes.InvokeRequired)
            {
                this.listaClientes.Invoke((MethodInvoker)delegate ()
                {
                    this.listaClientes.Items.Add("Cliente: " + cliente);
                });
            }
            else
            {
                this.listaClientes.Items.Add("Cliente: " + cliente);
            }
        }

        /// <summary>
        /// Método para quitar un cliente de la lista de clientes.
        /// </summary>
        /// <param name="cliente">El cliente</param>
        public void removerCliente(string cliente)
        {
            if (this.listaClientes.InvokeRequired)
            {
                this.listaClientes.Invoke((MethodInvoker)delegate ()
                {
                    this.listaClientes.Items.Remove("Cliente: " + cliente);
                });
            }
            else
            {
                this.listaClientes.Items.Remove("Cliente: " + cliente);
            }
        }

        /// <summary>
        /// Método que remueve todos los clientes de la lista
        /// </summary>
        public void removerTodosLosClientes()
        {
            if (this.listaClientes.InvokeRequired)
            {
                this.listaClientes.Invoke((MethodInvoker)delegate ()
                {
                    this.listaClientes.Items.Clear();
                });
            }
            else
            {
                this.listaClientes.Items.Clear();
            }
        }
    }
}
