using MAGOS_C.CONFIGURACION;

namespace MAGOS_C.BACK.Modelos
{
    internal class Generador
    {
        private int _dado; 

        public Generador(int dado)
        {
            _dado = dado;

        }
        public int Aleatorio()
        {
            _dado = (_dado * Configuracion.Multiplica + Configuracion.Incrementa) % Configuracion.Modela;
            return _dado;
        }
    }
}
