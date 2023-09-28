

namespace instituto;

class Curso
{
    public string Nombre, Contenido, Nivel;
    public int Duracion;
    public DateTime FechaInicio, FechaFin;
    public decimal Matricula, Precio;
  

    public List<Alumno> AlumnosInscritos { get; } = new List<Alumno>();

    public Curso(string nombre, string contenido, int duracion, string nivel, DateTime fechaInicio, DateTime fechaFin, decimal matricula, decimal precio)
    {
        Nombre = nombre;
        Contenido = contenido;
        Duracion = duracion;
        Nivel = nivel;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
        Matricula = matricula;
        Precio = precio;
    }

    public void InscribirAlumno(Alumno alumno, FormaPago formaPago, int cuotas)
    {
        AlumnosInscritos.Add(alumno);

        Console.WriteLine($"\nAlumno {alumno.Nombre} inscrito en el curso {Nombre}.");

        switch (formaPago)
        {
            case FormaPago.TarjetaCredito:
                Console.WriteLine("Forma de pago: Tarjeta de Crédito");
                break;
            case FormaPago.Efectivo:
                Console.WriteLine("Forma de pago: Efectivo");
                break;
            case FormaPago.Cheque:
                Console.WriteLine("Forma de pago: Cheque");
                break;
        }

        if (cuotas > 1)
        {
            Console.WriteLine($"Plan de pago: {cuotas} cuotas");
        }
    }
    public void MostrarAlumnosInscritos()
    {
        Console.WriteLine($"\nAlumnos inscritos en el curso {Nombre}:");
        foreach (var alumno in AlumnosInscritos)
        {
            Console.WriteLine($"{alumno.Nombre} {alumno.Apellido}");
        }
    }

    public override string ToString()
    {
        return $"\nCurso: {Nombre}:\n" +
               $"Contenido: {Contenido}\n" +
               $"Duración: {Duracion} semanas\n" +
               $"Nivel: {Nivel}\n" +
               $"Fecha de inicio: {FechaInicio}\n" +
               $"Fecha de fin: {FechaFin}\n" +
               $"Matrícula: {Matricula}\n" +
               $"Precio: {Precio}";
    }
}

class Alumno
{
    public string Cedula, Apellido, Nombre, Direccion, Telefono, Ocupacion;
   

    public Alumno(string cedula, string apellido, string nombre, string direccion, string telefono, string ocupacion)
    {
        Cedula = cedula;
        Apellido = apellido;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        Ocupacion = ocupacion;
    }

    public override string ToString()
    {
        return $"\nAlumno: {Nombre} {Apellido}:\n" +
               $"Cédula: {Cedula}\n" +
               $"Dirección: {Direccion}\n" +
               $"Teléfono: {Telefono}\n" +
               $"Ocupación: {Ocupacion}";
    }
}

enum FormaPago
{
    TarjetaCredito,
    Efectivo,
    Cheque
}