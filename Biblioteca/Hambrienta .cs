
namespace Biblioteca
{
    public class Hambrienta : Estado
    {
        public void hambrienta()
        {
            Nombre = "Hambrienta";
        }

        public override void Comer(Mascota mascota)
        {
            mascota.CambiarEstado(new Contenta());
        }

        public override void Jugar(Mascota mascota)
        {
        }

        public override bool PodesJugar()
        {
            return false;
        }
    }
}