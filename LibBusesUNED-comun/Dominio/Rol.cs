using System;

namespace LibBusesUNED_comun.Dominio
{
    /// <summary>
    /// Clase para representar un Rol.
    /// </summary>
    public class Rol
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime fechaHoraSalida;

        public DateTime FechaHoraSalida
        {
            get { return fechaHoraSalida; }
            set { fechaHoraSalida = value; }
        }

        private Ruta ruta;

        public Ruta Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        private Autobus autobus;

        public Autobus Autobus
        {
            get { return autobus; }
            set { autobus = value; }
        }

        private Conductor conductor;

        public Conductor Conductor
        {
            get { return conductor; }
            set { conductor = value; }
        }

    }
}
