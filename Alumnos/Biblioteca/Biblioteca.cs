namespace Biblioteca;

public class Escuela
{
    public List<Curso> cursos { get; set; } = new List<Curso>();

    public void AgregarCurso(Curso curso)
    {
        cursos.Add(curso);
    }

    public Curso ObtenerCursoPorCodigo(string codigo)
    {
        return cursos.FirstOrDefault(c => c.Codigo == codigo);
    }
    public void ListarAlumnosDeCurso(string codigoCurso)
    {
        Curso cursoBuscado = ObtenerCursoPorCodigo(codigoCurso);
        if (cursoBuscado != null)
        {
            var alumnos = cursoBuscado.ObtenerAlumnos();
            if (alumnos.Count > 0)
            {
                foreach (var alumno in alumnos)
                {
                    Console.WriteLine(alumno);
                }
            }
        }
    }
}