using System;

namespace LibBusesUNED_comun.Dominio
{
    /// <summary>
    /// Clase para representar una Terminal.
    /// </summary>
    public class Terminal
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private DateTime horaApertura;

        public DateTime HoraApertura
        {
            get { return horaApertura; }
            set { horaApertura = value; }
        }

        private DateTime horaCierre;

        public DateTime HoraCierre
        {
            get { return horaCierre; }
            set { horaCierre = value; }
        }

        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Horario
        {
            get { return horaApertura.ToString("HH:mm") + " - " + horaCierre.ToString("HH:mm"); }
        }
        public string EstadoToString
        {
            get { return this.estado ? "ACTIVO" : "INACTIVO"; }
        }
    }
}
