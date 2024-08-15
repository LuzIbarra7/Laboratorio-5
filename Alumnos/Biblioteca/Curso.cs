namespace Biblioteca;

public class Curso
{
    public string Codigo {get; set;} = "";
    public int Año {get; set;}
    public int Division {get; set;}
    public int CicloLectivo {get; set;}
    public List<Alumno> alumnos {get; set;} = new List<Alumno>();

    public Curso(string codigo, int año, int division, int cicloLectivo)
    {
        Codigo = codigo;
        Año = año;
        Division = division;
        CicloLectivo = cicloLectivo;
        alumnos = new List<Alumno>();
    }

    public void InscribirAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public List<Alumno> ObtenerAlumnos()
    {
        return alumnos;
    }
}