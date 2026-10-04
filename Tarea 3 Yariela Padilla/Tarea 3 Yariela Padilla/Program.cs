using System;

namespace Tarea_3_Yariela_Padilla
{
    internal class Program
    {
        // caso1 Yariela Padilla
        // Método que realiza la lógica de evaluación
        static void evaluarAprobacion()
        {
            // Variables inicializadas al inicio
            string entrada = "";
            double notaEstudiante = 0.0;
            bool esValido = false;

            Console.WriteLine("\n--- EVALUACIÓN DE NOTA FINAL ---");
            Console.Write("Ingrese la nota del estudiante (0 - 100): ");

            entrada = Console.ReadLine();
            esValido = double.TryParse(entrada, out notaEstudiante);

            if (esValido && notaEstudiante >= 0)
            {
                if (notaEstudiante <= 100)
                {
                    if (notaEstudiante >= 70.0)
                    {
                        Console.WriteLine("Resultado: Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Resultado: Reprobado");
                    }
                }
                else
                {
                    Console.WriteLine("Error: El valor ingresado no es válido o está fuera de la escala (0 - 100).");
                }
            }
            else
            {
                Console.WriteLine("Error: El valor ingresado no es válido o está fuera de la escala (0 - 100).");
            }
        }

        // Menú exclusivo para el Caso 1
        static void menuCaso1()
        {
            int opcion = 0;
            bool esNumero = false;

            do
            {
                Console.WriteLine("\n--- MENÚ CASO 1: EVALUACIÓN DE NOTAS ---");
                Console.WriteLine("1. Procesar nota de un estudiante");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción (1-2): ");

                esNumero = int.TryParse(Console.ReadLine(), out opcion);

                if (esNumero)
                {
                    switch (opcion)
                    {
                        case 1:
                            evaluarAprobacion();
                            break;
                        case 2:
                            Console.WriteLine("Saliendo del programa del Caso 1...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Ingrese 1 o 2.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
                }

                if (opcion != 2)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 2);
        }

        static void Main(string[] args)
        {
            menuCaso1();
        }
    }
}



