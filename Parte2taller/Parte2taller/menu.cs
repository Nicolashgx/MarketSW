using instituto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2taller
{
    class Menu
    {
        static void Main()
        {
            Curso cursoIngles = new Curso("Inglés Básico", "Gramática y vocabulario básico", 12, "Básico", DateTime.Now, DateTime.Now.AddMonths(3), 50.000m, 300.000m);
            Curso cursoFrances = new Curso("Francés Intermedio", "Cultura francesa", 16, "Intermedio", DateTime.Now, DateTime.Now.AddMonths(4), 60.000m, 350.000m);
            Curso cursoPortugues = new Curso("Portugués Avanzado", "Negocios en portugués", 20, "Avanzado", DateTime.Now, DateTime.Now.AddMonths(5), 70.000m, 400.000m);

            Alumno alumno1 = new Alumno("123456789", "Hernandez", "Nicolas", "Cl 80#32-19", "10115909281", "Estudiante");
            Alumno alumno2 = new Alumno("987654321", "Gutierrez", "Juan", "Cll900#21-98", "987654321", "Estudiante");

            int opcion;
            do
            {
                MostrarMenu();
                opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1:
                        MostrarInformacionCurso(cursoIngles);
                        break;
                    case 2:
                        InscribirAlumnoEnCurso(cursoIngles);
                        break;
                    case 3:
                        MostrarAlumnosInscritos(cursoIngles);
                        break;
                    case 4:
                        MostrarInformacionCurso(cursoFrances);
                        break;
                    case 5:
                        InscribirAlumnoEnCurso(cursoFrances);
                        break;
                    case 6:
                        MostrarAlumnosInscritos(cursoFrances);
                        break;
                    case 7:
                        MostrarInformacionCurso(cursoPortugues);
                        break;
                    case 8:
                        InscribirAlumnoEnCurso(cursoPortugues);
                        break;
                    case 9:
                        MostrarAlumnosInscritos(cursoPortugues);
                        break;
                    case 10:
                        MostrarInformacionAlumno(alumno1);
                        break;
                    case 11:
                        MostrarInformacionAlumno(alumno2);
                        break;
                    case 12:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                Console.WriteLine();
            } while (opcion != 12);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1- Mostrar información del curso de Inglés");
            Console.WriteLine("2- Inscribir alumno en el curso de Inglés");
            Console.WriteLine("3- Mostrar alumnos inscritos en el curso de Inglés");
            Console.WriteLine("4- Mostrar información del curso de Francés");
            Console.WriteLine("5- Inscribir alumno en el curso de Francés");
            Console.WriteLine("6- Mostrar alumnos inscritos en el curso de Francés");
            Console.WriteLine("7- Mostrar información del curso de Portugués");
            Console.WriteLine("8- Inscribir alumno en el curso de Portugués");
            Console.WriteLine("9- Mostrar alumnos inscritos en el curso de Portugués");
            Console.WriteLine("10- Mostrar información del alumno 1");
            Console.WriteLine("11- Mostrar información del alumno 2");
            Console.WriteLine("12- Salir");
            Console.Write("Seleccione una opción: \n");
        }

        static int LeerOpcion()
        {
            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                return opcion;
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
                return 0;
            }
        }

        static void MostrarInformacionCurso(Curso curso)
        {
            Console.WriteLine(curso);
        }

        static void InscribirAlumnoEnCurso(Curso curso)
        {
            Console.Write("Ingrese la cédula del alumno: ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese el apellido del alumno: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la dirección del alumno: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese el teléfono del alumno: ");
            string telefono = Console.ReadLine();
            Console.Write("Ingrese la ocupación del alumno: ");
            string ocupacion = Console.ReadLine();

            Alumno nuevoAlumno = new Alumno(cedula, apellido, nombre, direccion, telefono, ocupacion);

            Console.WriteLine("Formas de Pago:");
            Console.WriteLine("1. Tarjeta de Crédito");
            Console.WriteLine("2. Efectivo");
            Console.WriteLine("3. Cheque");
            Console.Write("Seleccione la forma de pago: ");
            if (Enum.TryParse(Console.ReadLine(), out FormaPago formaPago))
            {
                Console.Write("Ingrese el número de cuotas");
                if (int.TryParse(Console.ReadLine(), out int cuotas))
                {
                    curso.InscribirAlumno(nuevoAlumno, formaPago, cuotas);
                }
                else
                {
                    Console.WriteLine("Número de cuotas no válido.");
                }
            }
            else
            {
                Console.WriteLine("Forma de pago no válida.");
            }
        }

        static void MostrarInformacionAlumno(Alumno alumno)
        {
            Console.WriteLine(alumno);
        }

        static void MostrarAlumnosInscritos(Curso curso)
        {
            curso.MostrarAlumnosInscritos();
        }
    }
}