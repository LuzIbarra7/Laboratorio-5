
namespace Biblioteca
{
    public class Empleado : Persona
    {
        public decimal Salario {get;set;}
    
public void Mostrar ()
    {
        Console.WriteLine ($"{Nombre}, {Apellido}, {Domicilio}, {Salario}");
    }

    public Empleado (string Nombre, string Apellido, string Domicilio, int Salario)
:base ( Nombre, Apellido, Domicilio)
{
        this.Salario = Salario;
}   
    }
}