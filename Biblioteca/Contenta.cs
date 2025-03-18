namespace Biblioteca
{
    public class Contenta : Estado 
    {
        private int vecesjugadas = 0;
        
    public Contenta()
    {
        Nombre = "Contenta";
    }

    public override void Comer(Mascota mascota)
    {
        mascota.Incrementarfelicidad(1);
    }

    public override void Jugar(Mascota mascota)
    {
        mascota.Incrementarfelicidad(2);
        vecesjugadas++;

        if(vecesjugadas > 5)
        {
        mascota.CambiarEstado(new Hambrienta());
        }
    }

    public override bool PodesJugar()
    {
        return true;
    }
    }
}