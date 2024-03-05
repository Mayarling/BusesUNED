namespace LibBusesUNED_comun.Dominio
{
    /// <summary>
	/// Clase para representar un autobús.
	/// </summary>
	public class Autobus
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private int modelo;

        public int Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int capacidad;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
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

        public override string ToString()
        {
            return this.placa + " - Marca: " + this.marca + " - Capacidad: " + this.capacidad + " pasajeros";
        }
    }
}
