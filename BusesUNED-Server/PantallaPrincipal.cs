using BusesUNED_Server.Pantallas;
using BusesUNED_Server.Utilidades;
using LibBusesUNED_comun.Utilidades;
using LibBusesUNED_comun.Red;
using System;
using System.Windows.Forms;
using BusesUNED_Server.Red;

namespace BusesUNED_Server
{
    public partial class PantallaPrincipal : Form
    {
        private PantallaGestionTerminales pantallaGestionTerminales;
        private PantallaGestionConductores pantallaGestionConductores;
        private PantallaGestionAutobuses pantallaGestionAutobuses;
        private PantallaGestionRutas pantallaGestionRutas;

        // Objeto para manejar las conexiones socket
        private ServidorSocket servidorSocket;
        // Para la bitácora de eventos
        private Bitacora bitacora;
        // Para el estado del servidor
        private GestorDeEstado estadoServidor;
        // Para registrar la lista de clientes conectados
        private GestorClientes clientesConectados;

        public PantallaPrincipal()
        {
            InitializeComponent();
            // Iniciamos la bitacora y el gestor de estado del servidor.
            bitacora = new Bitacora(this.txtBitacora);
            estadoServidor = new GestorDeEstado(this.labelEstadoServidor);
            clientesConectados = new GestorClientes(this.lstClientesConectados);

            // Creamos el servidor de sockers
            this.servidorSocket = new ServidorSocket(bitacora, clientesConectados);
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            this.botonIniciarServidor.Enabled = true;
            this.botonDetenerServidor.Enabled = false;

            bitacora.registrar("Bienvenido al modulo administrativo de Autotransportes UNED");
            bitacora.registrar("Actuando como usuario administrador.");

            estadoServidor.inactivo("Inactivo");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void gestiónDeTerminalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pantallaGestionTerminales == null || this.pantallaGestionTerminales.IsDisposed)
            {
                this.pantallaGestionTerminales = new PantallaGestionTerminales();
                pantallaGestionTerminales.Show(this);
            }
            else
            {
                this.pantallaGestionTerminales.Focus();
            }
        }
        private void gestiónDeConductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pantallaGestionConductores == null || this.pantallaGestionConductores.IsDisposed)
            {
                this.pantallaGestionConductores = new PantallaGestionConductores();
                pantallaGestionConductores.Show(this);
            } else
            {
                this.pantallaGestionConductores.Focus();
            }
        }

        private void gestiónDeAutobúsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pantallaGestionAutobuses == null || this.pantallaGestionAutobuses.IsDisposed)
            {
                this.pantallaGestionAutobuses = new PantallaGestionAutobuses();
                pantallaGestionAutobuses.Show(this);
            }
            else
            {
                this.pantallaGestionAutobuses.Focus();
            }   
        }

        private void gestiónDeRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pantallaGestionRutas == null || this.pantallaGestionRutas.IsDisposed)
            {
                this.pantallaGestionRutas = new PantallaGestionRutas();
                pantallaGestionRutas.Show(this);
            }
            else
            {
                this.pantallaGestionRutas.Focus();
            }
        }

        private void botonIniciarServidor_Click(object sender, EventArgs e)
        {
            try
            {
                estadoServidor.actividad("Iniciando");

                this.servidorSocket.Iniciar();
                if (this.servidorSocket.Iniciado)
                {
                    estadoServidor.exito("Escuchando en -> " + ConfiguracionConexion.IP + ":" + ConfiguracionConexion.PUERTO);
                }

                botonIniciarServidor.Enabled = false;
                botonDetenerServidor.Enabled = true;

            } catch(Exception exception)
            {
                bitacora.registrar("[ERROR] No ha sido posible iniciar el servidor. Causa: " + exception.Message);
                estadoServidor.error("Causa: " + exception.Message);
            }
        }

        private void botonDetenerServidor_Click(object sender, EventArgs e)
        {
            estadoServidor.actividad("Deteniendo");
            this.servidorSocket.Detener();
            estadoServidor.inactivo("Inactivo");

            botonIniciarServidor.Enabled = true;
            botonDetenerServidor.Enabled = false;
        }

        private void limpiarBitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitacora.limpiar();
        }
    }
}
