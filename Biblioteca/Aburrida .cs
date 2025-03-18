
namespace Biblioteca
{
    public class Aburrida : Estado
    {
        private DateTime Inicio { get; set; }
        private short MinutosAburrida { get; set; }
        private short umbralComida { get; set; }

        public Aburrida()

        {
            Nombre = "ABURRIDA";
            Inicio = DateTime.Now;
        }

        public override void Comer(Mascota mascota)
        {
            if ((DateTime.Now - Inicio).TotalMinutes > umbralComida)
            {
                mascota.CambiarEstado(new Contenta());
            }
        }

        public override void Jugar(Mascota mascota)
        {
            mascota.CambiarEstado(new Contenta());
        }

        public override bool PodesJugar()
        {
            return true;
        }

    }
}