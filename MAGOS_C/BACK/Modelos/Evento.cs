namespace MAGOS_C.BACK.Modelos
{
    internal class Evento
    {
        public string Nombre { get; }
        public string Caracter { get; }

        public Evento(string nombre, string caracter)
        {
            Nombre = nombre;
            Caracter = caracter;
        }



    }
}
