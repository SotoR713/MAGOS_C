using MAGOS_C.BACK.Modelos;

namespace MAGOS_C.BACK.Catalogos
{
    internal static class CatalogoEventos
    {

// los 4 eventos posibles durante el trayecto, pelea con un rival leve, contra un gran jefe, curarte o cofre misterioso
    public static readonly Evento BRival = new Evento("Rival", "⚔");
    public static readonly Evento BJefe = new Evento("Jefe", "☠");
    public static readonly Evento Curacion = new Evento("Curacion", "♥");
    public static readonly Evento Cofre = new Evento("Cofre", "[]");
    }
}
