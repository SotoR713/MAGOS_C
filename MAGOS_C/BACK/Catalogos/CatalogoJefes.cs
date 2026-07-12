using MAGOS_C.BACK.Modelos;

namespace MAGOS_C.BACK.Catalogos
{
    internal class CatalogoJefes
    {
        public static readonly Jefe Nullizador = new Jefe(0, "Nullizador", Neutral, 28, 28, 2, 4, 1, 0);
        public static readonly Jefe Hexecutor = new Jefe (1, "Hexecutor", Fuego, 16, 16, 10, 4, 5, 0);
        public static readonly Jefe Daemonus = new Jefe(2, "Daemonus", Fuego, 19, 19, 7, 4, 5, 0);
        public static readonly Jefe ElProfeCaguamo=new Jefe(3, "ElProfeCaguamo", Tierra, 22, 22, 6, 6, 1, 0);
        public static readonly Jefe Bytemaster = new Jefe(4, "Bytemaster", Agua, 18, 18, 5, 3, 9, 0);
        public static readonly Jefe Compilator = new Jefe(5, "Compilator", Planta, 24, 24, 4, 5, 2, 0);
        public static readonly Jefe Piri = new Jefe(6, "Piri", Neutral, 25, 25, 7, 2, 1, 0);
        public static readonly Jefe Fatalerror = new Jefe(7, "Fatalerror", Neutral, 20, 20, 8, 3, 4, 0);
        public static readonly Jefe CeszarW = new Jefe(8, "CeszarW", Fuego, 17, 17, 7, 5, 6, 0);
        public static readonly Jefe CarluxSanguis = new Jefe(9, "CarluxSanguis", Neutral, 26, 26, 6, 2, 1, 0);
    }
}

