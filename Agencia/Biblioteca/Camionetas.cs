
namespace Biblioteca
{
    public class Camionetas : Autos
    {
        public int CapacidadCarga {get;set;}
        public int CantidadEjes {get;set;}

        public Camionetas (string NumeroSerie,string Motor, string Marca, int Año, decimal Precio, string TipoCombustible, int kilometraje)
        : base(NumeroSerie,Motor, Marca, Año, Precio, TipoCombustible, kilometraje)
    { 
        this.CapacidadCarga = CapacidadCarga;
        this.CantidadEjes = CantidadEjes;
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