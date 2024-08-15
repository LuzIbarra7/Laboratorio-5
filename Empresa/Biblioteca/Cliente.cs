namespace Biblioteca
{
    public class Cliente : Persona
    {
        public int Credito {get;set;}

        public void Mostrar ()
        {
            Console.WriteLine ($"{Nombre}, {Apellido}, {Domicilio}, {Credito}");
        }

public Cliente (string Nombre, string Apellido, string Domicilio, int Credito)
:base ( Nombre, Apellido, Domicilio)
{
        this.Credito = Credito;
}   
    }
}

