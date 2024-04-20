using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP645615_Unidad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;
            while (continuar)
            {
                Console.WriteLine("::::::::::::.....Hector Leonel Ruiz Trejo.....::::::::::::");
                Console.WriteLine("::::::::::::...............MENU...............::::::::::::");
                Console.WriteLine(":: Ejercicio 1. Numero Positivo/Negativo                ::");
                Console.WriteLine(":: Ejercicio 2. Numeros del 1 al 10                     ::");
                Console.WriteLine(":: Ejercicio 3. Calcular suma de Numeros Positivos      ::");
                Console.WriteLine(":: Ejercicio 4. Suma de 5 numeros                       ::");
                Console.WriteLine(":: Ejercicio 5. Calcular promedio de Numeros Ingresados ::");
                Console.WriteLine(":: Ejercicio 6. Salir                                   ::");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.Write("Elija una Opcion: ");
                
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        ejercicio1();
                        break;

                    case 2:
                        Console.Clear();
                        ejercicio2();
                        break;
                    case 3:
                        Console.Clear();
                        ejercicio3();
                        break;

                    case 4:
                        Console.Clear();
                        ejercicio4();
                        break;

                    case 5:
                        Console.Clear();
                        ejercicio5();
                        break;
                    case 6:
                        continuar = false;
                        break;
                }
            }
        }
                static void ejercicio1()
                {
                    //Desarrolle un programa que muestre si cada número que se teclea es positivo o
                    //negativo, y que se detenga cuando al teclear el número 0(usar While).
                    Console.WriteLine("Ingresa un número (presiona 0 para salir): ");

                    while (true)
                    {
                        Console.Write("Ingresa un numero: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        if (numero == 0)
                        {
                            Console.WriteLine("Hasta luego!");
                            break;
                        }
                        else if (numero > 0)
                        {
                            Console.WriteLine("El numero es positivo.");
                        }
                        else
                        {
                            Console.WriteLine("El numero es negativo.");
                        }
                    }

                }
                static void ejercicio2()
                {
                    //Desarolle un programa que escriba en pantalla los números del 1 al 10, usando "While"
                    int numero = 1;

                    Console.WriteLine("Números del 1 al 10: ");
                    while (numero <= 10)
                    {
                        Console.WriteLine(numero);
                        numero++;
                    }
                    Console.WriteLine("Presione Enter para finalizar...");
                    Console.ReadLine();

                }
                static void ejercicio3()
                {
                    //Desarrolle un programa que pida números positivos al usuario, y vaya calculando
                    //la suma de todos ellos (terminará cuando se teclea un número negativo o cero (usar Do-While).

                    int suma = 0;
                    int numero;

                    Console.WriteLine("Ingresa un positivo para sumar ó cero ó negativo para terminar: ");

                    do
                    {
                        Console.Write("Ingresa un número: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero > 0)
                        {
                            //si el numero es positivo se sumara a la suma total
                            suma += numero;
                        }
                    }
                    while (numero > 0);

                    Console.WriteLine("La suma de los números  ingresados es: " + suma);
                    Console.ReadKey();
                }

                static void ejercicio4()
                {
                    //Escriba un programa que lea 5 números desde teclado y presente la sumatoria de los mismos (usar Do-While)

                    int suma = 0;
                    int contador = 0;

                    Console.WriteLine("Ingrese 5 números:");

                    do
                    {
                        Console.Write("Ingrese el número {0}: ", contador + 1);
                        int numero = Convert.ToInt32(Console.ReadLine());
                        suma += numero;
                        contador++;
                    }
                    while (contador < 5);

                    Console.WriteLine("La Sumatoria de los 5 números es: " + suma);
                    Console.ReadKey();
                }

                static void ejercicio5()
                {
                    //Desarrolle un programa que pida una serie de números y al finalizar
                    //que calcule el promedio de dichos números (0 para finalizar) (usar While).

                    int cantidadNumeros = 0;
                    int suma = 0;

                    Console.WriteLine("Ingrese una serie de numeros ó ingrese 0 para finalizar: ");

                    int numero = -1; // Inicializar el primer valor que no sea 0

                    while (numero != 0)
                    {
                        Console.Write("Ingrese un numero: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (numero != 0)
                        {
                            suma += numero;
                            cantidadNumeros++;
                        }
                    }
                    if (cantidadNumeros > 0)
                    {
                        double promedio = (double)suma / cantidadNumeros;
                        Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No se han ingresado numeros.");
                        Console.ReadKey();
                    }

                }


    }
}
