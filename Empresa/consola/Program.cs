using Biblioteca;

Cliente cliente = new Cliente ("Luz", "Ibarra", "",0)
{
    Nombre = "Luz",
    Apellido = "Ibarra",
    Domicilio = "",
    Credito = 0
};

cliente.Mostrar();

Empleado empleado = new Empleado("Luz", "Ibarra", "",0)
{
    Nombre = "Luz",
    Apellido = "Ibarra",
    Domicilio = "",
    Salario = 0
};

empleado.Mostrar();

Persona persona = new Persona("Luz", "Ibarra", "")
{
    Nombre = "Luz",
    Apellido = "Ibarra",
    Domicilio = ""
};

persona.Mostrar();
