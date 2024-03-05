using System;

/// <summary>
/// Namespace para la clase Conductor
/// </summary>
namespace LibBusesUNED.Dominio
{
    /// <summary>
    /// clase que representa un conductor.
    /// </summary>
    public class Conductor
	{
		private string identificacion;

		public string Identificacion
		{
			get { return identificacion; }
			set { identificacion = value; }
		}

		private string nombre;

		public string Nombre
        {
			get { return nombre; }
			set { nombre = value; }
		}

		private string primerApellido;

		public string PrimerApellido
        {
			get { return primerApellido; }
			set { primerApellido = value; }
		}

		private string segundoApellido;

		public string SegundoApellido
		{
			get { return segundoApellido; }
			set { segundoApellido = value; }
		}

		private DateTime fechaNacimiento;

		public DateTime FechaNacimiento
        {
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		private char genero;

		public char Genero
        {
			get { return genero; }
			set { genero = value; }
		}

		private bool conductorSupervisor;

		public bool ConductorSupervisor
        {
			get { return conductorSupervisor; }
			set { conductorSupervisor = value; }
		}

		public string NombreCompleto
		{
			get { return this.nombre + " " + this.primerApellido + " " + this.segundoApellido; }
		}

		public string GeneroToString
		{
			get { return genero.Equals('M') ? "MASCULINO" : "FEMENINO"; }
		}

        public string ConductorSupervisorToString
        {
            get { return conductorSupervisor ? "SI" : "NO"; }
        }
    }
}
