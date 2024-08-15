
namespace Biblioteca
{
    public class Compactos : Autos
    {
        public Compactos(string NumeroSerie,string Motor, string Marca, int Año, decimal Precio, string TipoCombustible, int kilometraje)
        : base(NumeroSerie,Motor, Marca, Año, Precio, TipoCombustible, kilometraje)
    { 
    }

    public decimal CalcularConsumo(int kilometrosRecorridos)
        {
            if (TipoCombustible == "Combustión")
            {
                return kilometrosRecorridos / 13m;
            }
            else if (TipoCombustible == "Eléctrico")
            {
                return kilometrosRecorridos * 20m;
            }
            else
            {
                throw new Exception("Tipo de combustible no reconocido");
            }
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"NumeroSerie: {NumeroSerie}Marca: {Marca}, Año: {Año}, Precio: {Precio:C}, Combustible: {TipoCombustible}, Kilometraje: {kilometraje} km");
        }
    }
}