using MAGOS_C.BACK.Clases;

namespace MAGOS_C.BACK.Catalogos
{
    internal static class CatalogoElementos
    {
        //en el juego actual existen 4 elementos, Agua, Fuego, Planta y Tierra, cada uno tiene un elemento al que es fuerte y otro al que es debil

        public static readonly Elemento Agua = new Elemento("Agua", "Fuego", "Tierra");
        public static readonly Elemento Fuego = new Elemento("Fuego", "Planta", "Agua");
        public static readonly Elemento Planta = new Elemento("Planta", "Tierra", "Fuego");
        public static readonly Elemento Tierra = new Elemento("Tierra", "Agua", "Planta");
        public static readonly Elemento Neutral = new Elemento("Neutral", "", "");
    }

}
