
namespace Biblioteca
{
    public class Familiares : Autos
    {
        public int CantidadPasajeros {get;set;}

        public Familiares (string NumeroSerie,string Motor, string Marca, int Año, decimal Precio, string TipoCombustible, int kilometraje)
        : base(NumeroSerie,Motor, Marca, Año, Precio, TipoCombustible, kilometraje)
    { 
        this.CantidadPasajeros = CantidadPasajeros;

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

