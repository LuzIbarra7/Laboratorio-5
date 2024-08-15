
namespace Biblioteca
{
    public class Autos
    {
        public required string NumeroSerie {get;set;}
        public required string Motor {get;set;}
        public required string Marca {get;set;}
        public int Año {get;set;}
        public decimal Precio {get;set;}
        public required string TipoCombustible {get;set;}   
        public int kilometraje {get;set;}


        public  Autos(string NumeroSerie, string Motor, string Marca, int Año, decimal Precio, string TipoCombustible, int kilometraje)
    {
        this.NumeroSerie = NumeroSerie;
        this.Motor = Motor;
        this.Marca = Marca;
        this.Año = Año;
        this.Precio = Precio;
        this.TipoCombustible = TipoCombustible;
        this.kilometraje = kilometraje;
    }
    }
}