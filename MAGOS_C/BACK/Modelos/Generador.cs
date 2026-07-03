using MAGOS_C.CONFIGURACION;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MAGOS_C.BACK.Modelos
{
    internal class Generador
    {
        private int Dado { get; }

        private Generador(int dado)
        {
            Dado = dado;

        }
    }
}

