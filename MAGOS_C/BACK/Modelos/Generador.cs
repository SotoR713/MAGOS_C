using MAGOS_C.CONFIGURACION;

namespace MAGOS_C.BACK.Modelos
{
    internal class Generador
    {
        public int Aleatorio(int numero)
        { 
            int dado = (numero * Configuracion.Multiplica + Configuracion.Incrementa )% Configuracion.Modela;
            return dado;
        }
    }
}
