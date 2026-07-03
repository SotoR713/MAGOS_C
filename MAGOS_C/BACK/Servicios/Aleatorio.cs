using MAGOS_C.CONFIGURACION;
using MAGOS_C.BACK.Modelos;


namespace MAGOS_C.BACK.Servicios
{
    internal class Aleatorio
    {
        public int tirada(int Dado)
        {
            Dado = (Dado* Configuracion.Multiplica + Configuracion.Incrementa) % Configuracion.Modela;
            return Dado;
        }
    }
}

