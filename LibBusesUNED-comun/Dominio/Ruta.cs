using System;

namespace LibBusesUNED_comun.Dominio
{
    /// <summary>
	/// Clase para representar una ruta.
	/// </summary>
	public class Ruta
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private Terminal terminalSalida;

        public Terminal TerminalSalida
        {
            get { return terminalSalida; }
            set { terminalSalida = value; }
        }

        private Terminal terminalLlegada;

        public Terminal TerminalLlegada
        {
            get { return terminalLlegada; }
            set { terminalLlegada = value; }
        }

        private Double tarifa;

        public Double Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private int tipoRuta;

        public int TipoRuta
        {
            get { return tipoRuta; }
            set { tipoRuta = value; }
        }

        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string EstadoToString
        {
            get { return estado ? "ACTIVO" : "INACTIVO"; }
        }

        public string TipoRutaToString
        {
            get { return tipoRuta == 1 ? "DIRECTO" : "REGULAR"; }
        }

        public override string ToString()
        {
            return TerminalSalida.Nombre + " -› " + TerminalLlegada.Nombre + ". Tarifa: CRC " + Tarifa + ". Tipo:" + TipoRutaToString;
        }
    }
}
