using BusesUNED_Cliente.Pantallas;
using BusesUNED_Cliente.Red;
using LibBusesUNED_comun.Dominio;
using LibBusesUNED_comun.Red;
using LibBusesUNED_comun.Utilidades;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace BusesUNED_Cliente
{
    public partial class PantallaInicio : Form
    {
        private ClienteSocket clienteSocket;

        private GestorDeEstado estadoServidor;

        private Conductor conductor;

        private PantallaConductores pantallaConductores;
        private PantallaSupervisor pantallaSupervisor;


        public PantallaInicio()
        {
            InitializeComponent();
            this.clienteSocket = new ClienteSocket();
            estadoServidor = new GestorDeEstado(this.labelEstadoConexion);
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (!campoIdentificacion.Text.Trim().Equals(""))
            {
                try
                {
                    estadoServidor.actividad("Conectando");
                    this.clienteSocket.ConectarCliente();
                    
                    // Conectar al usuario
                    String identificacion = campoIdentificacion.Text.Trim();
                    MensajeDeSocket<string> mensaje = new MensajeDeSocket<string>() { Metodo = Metodos.CONECTAR, Entidad = identificacion };
                    this.clienteSocket.Enviar(mensaje);
                    string respuestaJson = this.clienteSocket.Recibir();
                    MensajeDeSocket<object> respuestaServidor = JsonSerializer.Deserialize<MensajeDeSocket<object>>(respuestaJson);
                    if (respuestaServidor.Metodo.Equals(Metodos.OK))
                    {
                        // El ID es valido y viene un objeto conductor
                        MensajeDeSocket<Conductor> respuestaOk = JsonSerializer.Deserialize<MensajeDeSocket<Conductor>>(respuestaJson);
                        this.conductor = respuestaOk.Entidad;
                        estadoServidor.exito(this.conductor.NombreCompleto + " conectado.");
                        this.campoIdentificacion.ReadOnly = true;

                        this.buttonConectar.Enabled = false;
                        this.buttonDesconectar.Enabled = true;
                        if (this.conductor.ConductorSupervisor)
                        {
                            // Muestra la pantalla del supervisor
                            if (this.pantallaSupervisor == null || this.pantallaSupervisor.IsDisposed)
                            {
                                this.pantallaSupervisor = new PantallaSupervisor(conductor, clienteSocket);
                                this.pantallaSupervisor.Show(this);
                            }
                            else
                            {
                                this.pantallaSupervisor.Focus();
                            }
                        }
                        else
                        {
                            // Muestra la pantalla del conductor regular
                            if (this.pantallaConductores == null || this.pantallaConductores.IsDisposed)
                            {
                                this.pantallaConductores = new PantallaConductores(conductor, clienteSocket);
                                this.pantallaConductores.Show(this);
                            }
                            else
                            {
                                this.pantallaConductores.Focus();
                            }
                        }
                    }
                    else if (respuestaServidor.Metodo.Equals(Metodos.ERROR))
                    {
                        MessageBox.Show(
                            "Ha ocurrido el siguiente error: " + respuestaServidor.Entidad.ToString(),
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        estadoServidor.actividad("Desconectando");
                        this.clienteSocket.DesconectarCliente();
                        estadoServidor.inactivo("Inactivo");
                        this.campoIdentificacion.Text = "";
                    }
                } catch(Exception exc)
                {
                    MessageBox.Show(
                    "Ha ocurrido el siguiente error: " + exc.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                }
                
            }
            else
            {
                MessageBox.Show(
                    "La identificación es requerida",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.buttonConectar.Enabled = true;
            this.buttonDesconectar.Enabled = false;
            estadoServidor.inactivo("Desconectado");
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            if (!campoIdentificacion.Text.Trim().Equals(""))
            {
                if(this.pantallaConductores != null && !this.pantallaConductores.IsDisposed){
                    this.pantallaConductores.Close();
                }
                if(this.pantallaSupervisor != null && !this.pantallaSupervisor.IsDisposed)
                {
                    this.pantallaSupervisor.Close();
                }
                estadoServidor.actividad("Desconectando");

                // Desconectar al usuario
                String identificacion = campoIdentificacion.Text.Trim();
                MensajeDeSocket<string> mensaje = new MensajeDeSocket<string>() { Metodo = Metodos.DESCONECTAR, Entidad = identificacion };
                this.clienteSocket.Enviar(mensaje);
                this.clienteSocket.DesconectarCliente();
                estadoServidor.inactivo("Desconectado");

                this.campoIdentificacion.ReadOnly = false;
                this.campoIdentificacion.Text = "";

                this.buttonConectar.Enabled = true;
                this.buttonDesconectar.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                    "La identificación es requerida",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void campoIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
