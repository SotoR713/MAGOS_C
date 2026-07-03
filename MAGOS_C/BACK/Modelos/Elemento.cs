namespace MAGOS_C.BACK.Clases
{

    internal class Elemento
    {
        public string Nombre { get; }
        public string Fortaleza { get; }
        public string Debilidad { get; }

        public Elemento(string nombre, string fortaleza, string debilidad)
        {
            Nombre = nombre;
            Fortaleza = fortaleza;
            Debilidad = debilidad;
        }
    }


}


