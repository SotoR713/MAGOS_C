using MAGOS_C.CONFIGURACION;

namespace MAGOS_C.BACK.Modelos
{
    internal class Generador
    {
        private long _dado; 

        public Generador(long dado)
        {
            _dado = dado;

        }
        public long Aleatorio()
        {
            _dado = (_dado * Configuracion.Multiplica + Configuracion.Incrementa) % Configuracion.Modela;
            return _dado;
        }
    }
}
