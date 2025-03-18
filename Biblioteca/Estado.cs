
namespace Biblioteca;

public abstract class Estado
{
    public string Nombre { get; set; }
    public abstract void Comer(Mascota mascota);
    public abstract void Jugar(Mascota mascota);
    public abstract bool PodesJugar();
}