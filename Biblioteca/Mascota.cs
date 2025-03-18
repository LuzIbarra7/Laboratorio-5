namespace Biblioteca;

public class Mascota
{

    public byte Felicidad { get; set; }
    public required Estado estado { get; set; }

    public Mascota(Estado estadoInicial)
    {
        estado = estadoInicial;
        Felicidad = 0;
    }

    public void Comer()
    {
        estado.Comer(this);
    }

    public void Jugar()
    {
        if (podesJugar())
        {
            estado.Jugar(this);
        }
    }

    public bool podesJugar()
    {
        return estado.PodesJugar();
    }

    public void CambiarEstado(Estado NuevoEstado)
    {
        estado = NuevoEstado;
    }

    public void Incrementarfelicidad(byte cantidad)
    {
        Felicidad += cantidad;
    }
}
