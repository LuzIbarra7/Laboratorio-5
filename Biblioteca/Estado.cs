
namespace Biblioteca
{
    public abstract class Estado
    {
        public required string Nombre {get;set;}

    public void Comer(Mascota mascota);
    public void Jugar (Mascota mascota);
    public  bool PodesJugar();
    }
}