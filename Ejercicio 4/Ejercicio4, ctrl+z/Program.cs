using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> pilaAcciones = new Stack<string>();
        bool salir = false;

        Console.WriteLine("=== Simulador de Comando Deshacer ===");

        // Permitir al usuario ingresar cinco acciones iniciales
        Console.WriteLine("\nIngrese 5 acciones iniciales:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Acción {i}: ");
            string accion = Console.ReadLine();
            pilaAcciones.Push(accion);
        }

        while (!salir)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Agregar acción");
            Console.WriteLine("2. Deshacer última acción");
            Console.WriteLine("3. Mostrar acciones");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la nueva acción: ");
                    string nuevaAccion = Console.ReadLine();
                    pilaAcciones.Push(nuevaAccion);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acción agregada correctamente.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    if (pilaAcciones.Count > 0)
                    {
                        string accionDeshecha = pilaAcciones.Pop();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Acción deshecha: {accionDeshecha}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No hay más acciones por deshacer.");
                        Console.ResetColor();
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    Console.WriteLine("\n--- Acciones almacenadas ---");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    MostrarAcciones(pilaAcciones);
                    Console.ResetColor();
                    Console.WriteLine("-----------------");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        Console.WriteLine("\nPrograma finalizado.");
    }

    static void MostrarAcciones(Stack<string> pila)
    {
        if (pila.Count == 0)
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        string[] acciones = pila.ToArray();
        for (int i = acciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"- {acciones[i]}");
        }
    }
}