namespace MAGOS_C.BACK.Clases
{
    //aqui se crea la estructura basica de los elementos, donde cada uno se obligara a tener un nombre, un elemento al que es fuerte y otro al que es debil
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


