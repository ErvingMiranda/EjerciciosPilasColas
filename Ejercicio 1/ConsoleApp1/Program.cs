/*Ejercicio 1: Pila de Números Enteros
Enunciado: Se desea simular una pila que almacene números enteros ingresados por el usuario. La aplicación debe permitir realizar las operaciones básicas de una pila: insertar (push), eliminar (pop) y mostrar el contenido actual.
Problema a resolver:
1.	Declarar una pila utilizando una estructura adecuada (arreglo o clase Stack en C#).
2.	Permitir al usuario ingresar varios números enteros para apilarlos (push).
3.	Mostrar los elementos actuales de la pila.
4.	Eliminar el último elemento ingresado (pop).
5.	Mostrar nuevamente la pila después de la eliminación.
6.	Comprobar si la pila está vacía o no antes de extraer un elemento.*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();
        string opcion;

        do
        {
            Console.WriteLine("\n=== Pila de Números Enteros ===");
            Console.WriteLine("1. Insertar número");
            Console.WriteLine("2. Eliminar último número");
            Console.WriteLine("3. Mostrar pila");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese un número entero para apilar: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        pila.Push(numero); //agrega elemento a la pila
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Número apilado correctamente.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entrada inválida. Debe ser un número entero.");
                        Console.ResetColor();
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "2":
                    if (pila.Count > 0)
                    {
                        int eliminado = pila.Pop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Eliminaste: {eliminado}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("La pila está vacía.");
                        Console.ResetColor();
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "3":
                    if (pila.Count > 0)
                    {
                        Console.WriteLine("Elementos actuales de la pila:");
                        Console.WriteLine("------------------------------");
                        foreach (int elem in pila)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(elem);
                            Console.ResetColor();
                        }
                        Console.WriteLine("------------------------------");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("La pila está vacía.");
                        Console.ResetColor();
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "4":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Saliendo");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (opcion != "4");
    }
}