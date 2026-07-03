using MAGOS_C.BACK.Clases;

namespace MAGOS_C.BACK.Catalogos
{
    internal class CatalogoEventos
    {

// los 4 eventos posibles durante el trayecto, pelea con un rival leve, contra un gran jefe, curarte o cofre misterioso
    Evento BRival = new Evento("Rival", "⚔");
    Evento BJefe = new Evento("Jefe", "☠");
    Evento Curacion = new Evento("Curacion", "♥");
    Evento Cofre = new Evento("Cofre", "[]");
    }
}
