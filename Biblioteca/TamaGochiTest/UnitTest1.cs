using Biblioteca;
namespace TamaGochiTest;

public class UnitTest1
{
    [Fact]
    public void Come_CuandoEstaHambrienta_SePoneContenta()
    {
        var mascota = new Mascota (new Hambrienta());
        mascota.Comer();

        Assert.IsType<Contenta>(mascota.estado);
    }
}