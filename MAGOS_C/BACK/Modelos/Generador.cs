namespace MAGOS_C.BACK.Clases
{
    internal class Generador
    {
        public static int Aleatorio(int numero)
        { 
            int dado = (numero * 120295 + 713 )% 240214;
            return dado;
        }
    }
}
