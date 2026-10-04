using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yariela_Padilla_Tarea3
{
    internal class Program

        //Yariela Padilla Cas2
    {
        static void Main(string[] args)
        {
            double precio = 0.0;
            int cantidad = 0;
            double totalCompra = 0.0;
            double descuento = 0.0;
            double totalFinal = 0.0;
            bool precioValido = false;
            bool cantidadValida = false;

            Console.WriteLine("\n--- CÁLCULO DE COMPRA Y DESCUENTO ---");
            Console.Write("Ingrese el precio del producto: ");
            precioValido = double.TryParse(Console.ReadLine(), out precio);

            if (precioValido)
            {
                if (precio > 0)
                {
                    Console.Write("Ingrese la cantidad comprada: ");
                    cantidadValida = int.TryParse(Console.ReadLine(), out cantidad);

                    if (cantidadValida)
                    {
                        if (cantidad > 0)
                        {
                            totalCompra = precio * cantidad;

                            if (totalCompra > 25000)
                            {
                                descuento = totalCompra * 0.10;
                            }

                            totalFinal = totalCompra - descuento;

                            Console.WriteLine("Subtotal: " + totalCompra);
                            Console.WriteLine("Descuento (10%): " + descuento);
                            Console.WriteLine("Total a pagar: " + totalFinal);
                        }
                        else
                        {
                            Console.WriteLine("Error: La cantidad debe ser mayor a 0.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: La cantidad ingresada debe ser un número entero.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: El precio debe ser un monto mayor a 0.");
                }
            }
            else
            {
                Console.WriteLine("Error: El precio ingresado no es un número válido.");
            }
        }
            
        

        // Menú exclusivo para el Caso 2
        static void menuCaso2()
        {
            int opcion = 0;
            bool esNumero = false;

            do
            {
                Console.WriteLine("\n--- MENÚ CASO 2: SISTEMA DE COMPRAS ---");
                Console.WriteLine("1. Calcular total de una compra");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción (1-2): ");

                esNumero = int.TryParse(Console.ReadLine(), out opcion);

                if (esNumero)
                {
                    switch (opcion)
                    {
                        case 1:
                            calcularCompra();
                            break;
                        case 2:
                            Console.WriteLine("Saliendo del programa del Caso 2...");
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

        private static object calcularCompra()
        {
            throw new NotImplementedException();
        }

        static void menuCaso2(string[] args)
        {
            menuCaso2();
        }
    }
}
