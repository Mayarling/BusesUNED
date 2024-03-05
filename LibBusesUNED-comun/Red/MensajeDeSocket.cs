namespace LibBusesUNED_comun.Red
{
    /// <summary>
    /// Clase que representa un mensaje que se envia o se recibe mediante un socket.
    /// 
    /// La clase puede ser serializada (convertida en) y deserializada (convertida desde) en JSON.
    /// 
    /// La clase contiene un atributo que indica el método que se debe ejecutar, y el atributo Entidad representa el objeto del tipo generico T que se envia para ser procesado.
    /// </summary>
    /// <typeparam name="T">El tipo de dato de la entidad asociada al mensaje.</typeparam>
    public class MensajeDeSocket<T>
    {
        public string Metodo { get; set; }

        public T Entidad { get; set; }

    }
}
