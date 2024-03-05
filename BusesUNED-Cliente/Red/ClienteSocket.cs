using LibBusesUNED_comun.Red;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;

namespace BusesUNED_Cliente.Red
{
    /// <summary>
    /// Clase para abstraer y simplificar el uso de un cliente socket
    /// </summary>
    public class ClienteSocket
    {
        // Para la conexion de servidor por socket
        private TcpClient clienteTcp;
        private StreamReader flujoDeEntrada;
        private StreamWriter flujoDeSalida;

        /// <summary>
        /// Constructor
        /// </summary>
        public ClienteSocket()
        {
            this.clienteTcp = null;
            this.flujoDeEntrada = null;
            this.flujoDeSalida = null;
        }

        public void ConectarCliente()
        {
            IPAddress ipDelServidor = IPAddress.Parse(ConfiguracionConexion.IP);
            IPEndPoint endPoint = new IPEndPoint(ipDelServidor, ConfiguracionConexion.PUERTO);
            clienteTcp = new TcpClient();
            clienteTcp.Connect(endPoint);

            this.flujoDeEntrada = new StreamReader(clienteTcp.GetStream());
            this.flujoDeSalida = new StreamWriter(clienteTcp.GetStream());
        }

        public void DesconectarCliente()
        {
            this.flujoDeEntrada.Close();
            this.flujoDeSalida.Close();
            this.clienteTcp.Close();
        }

        public void Enviar<T>(MensajeDeSocket<T> Mensaje)
        {
            string mensajeJSON = JsonSerializer.Serialize(Mensaje);
            this.flujoDeSalida.WriteLine(mensajeJSON);
            this.flujoDeSalida.Flush();
        }

        public string Recibir()
        {
            return this.flujoDeEntrada.ReadLine();
        }
    }
}
