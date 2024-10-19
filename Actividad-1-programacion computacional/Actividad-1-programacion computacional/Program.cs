using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_programacion_computacional
{
    internal class Program
    {


        static void Main(string[] args)
        {

            int opcion;

            do
            {
               
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. Mostrar si un número es positivo o negativo.");
                Console.WriteLine("2. Mostrar la tabla de multiplicar de un número.");
                Console.WriteLine("3. Sumar números positivos.");
                Console.WriteLine("4. Verificar si un número es primo.");
                Console.WriteLine("5. Calcular promedio de una serie de números.");
                Console.WriteLine("0. Salir.");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        int numero;
                        do
                        {
                            Console.WriteLine("Ingresa un número (0 para salir):");
                            numero = Convert.ToInt32(Console.ReadLine());
                            if (numero > 0)
                            {
                                Console.WriteLine("El número es positivo.");
                            }
                            else if (numero < 0)
                            {
                                Console.WriteLine("El número es negativo.");
                            }
                        } while (numero != 0);
                        break;

                    case 2:
                        int tabla;
                        do
                        {
                            Console.WriteLine("Ingresa un número entre 1 y 10 (0 para salir):");
                            tabla = Convert.ToInt32(Console.ReadLine());
                            if (tabla >= 1 && tabla <= 10)
                            {
                                for (int i = 1; i <= 10; i++)
                                {
                                    Console.WriteLine(tabla + " x " + i + " = " + (tabla * i));
                                }
                            }
                            else if (tabla != 0)
                            {
                                Console.WriteLine("Número fuera de rango.");
                            }
                        } while (tabla != 0);
                        break;

                    case 3:
                        int suma = 0;
                        do
                        {
                            Console.WriteLine("Ingresa un número positivo (0 o negativo para salir):");
                            numero = Convert.ToInt32(Console.ReadLine());
                            if (numero > 0)
                            {
                                suma += numero;
                            }
                        } while (numero > 0);
                        Console.WriteLine("La suma total es: " + suma);
                        break;

                    case 4:
                        bool esPrimo = true;
                        Console.WriteLine("Ingresa un número para verificar si es primo:");
                        numero = Convert.ToInt32(Console.ReadLine());
                        if (numero < 2)
                        {
                            esPrimo = false;
                        }
                        else
                        {
                            for (int i = 2; i <= Math.Sqrt(numero); i++)
                            {
                                if (numero % i == 0)
                                {
                                    esPrimo = false;
                                    break;
                                }
                            }
                        }
                        if (esPrimo)
                        {
                            Console.WriteLine("El número es primo.");
                        }
                        else
                        {
                            Console.WriteLine("El número no es primo.");
                        }
                        break;

                    case 5:
                        int contador = 0;
                        suma = 0;
                        do
                        {
                            Console.WriteLine("Ingresa un número (0 para finalizar):");
                            numero = Convert.ToInt32(Console.ReadLine());
                            if (numero > 0)
                            {
                                suma += numero;
                                contador++;
                            }
                        } while (numero != 0);

                        if (contador > 0)
                        {
                            double promedio = (double)suma / contador;
                            Console.WriteLine("El promedio es: " + promedio);
                        }
                        else
                        {
                            Console.WriteLine("No ingresaste ningún número válido.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                

            } while (opcion != 0); 
        }
    }
}