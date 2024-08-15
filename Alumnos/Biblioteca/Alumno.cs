namespace Biblioteca;

public class Alumno
{
    public string Nombre {get; set;} = "";
    public string Apellido {get; set;} = "";
    public int Numero {get; set;}
    public string TipoDocumento {get; set;} = "";

    public Alumno (string nombre, string apellido, int numero, string tipoDocumento)
    {
        Nombre = nombre;
        Apellido = apellido;
        TipoDocumento = tipoDocumento;
        Numero = numero;
    }
}