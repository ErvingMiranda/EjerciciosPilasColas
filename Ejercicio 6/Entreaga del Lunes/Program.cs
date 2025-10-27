//Ejercicio 6: Cola de Impresión
//Enunciado: Desarrolle un programa que simule una cola de impresión en una oficina,
//donde cada documento debe imprimirse en el orden en que llega.
//Problema a resolver:
//1.Declarar una cola de tipo string para almacenar los nombres de los documentos.
//2.	Permitir al usuario ingresar varios nombres de documentos a imprimir.
//3.	Mostrar la cola completa (orden de impresión).
//4.	Atender el primer documento (Dequeue) simulando que se imprimió.
//5.	Mostrar los documentos restantes en la cola.
//6.	Mostrar un mensaje si no hay documentos pendientes.


using System;
using System.Collections.Generic; // Necesario para usar Queue

namespace ColaDeImpresion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declarar una cola de tipo string
            Queue<string> colaImpresion = new Queue<string>();
            bool salir = false;

            Console.WriteLine("---  Simulador de Cola de Impresión ---");

            while (!salir)
            {
                // Mostramos el menú
                Console.WriteLine("\n======================================");
                Console.WriteLine("Menú de Opciones:");
                Console.WriteLine("1. Agregar documento(s) a la cola");
                Console.WriteLine("2. Imprimir siguiente documento");
                Console.WriteLine("3. Mostrar cola de impresión actual");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción (1-4): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // 2. Permitir al usuario ingresar varios nombres de documentos
                        Console.Write("\n¿Cuántos documentos desea agregar?: ");
                        string inputCantidad = Console.ReadLine();

                        int cantidad;
                        // Validamos que sea un número entero y positivo
                        if (int.TryParse(inputCantidad, out cantidad) && cantidad > 0)
                        {
                            Console.WriteLine($"\nIngrese los nombres de los {cantidad} documentos:");
                            for (int i = 1; i <= cantidad; i++)
                            {
                                Console.Write($"Documento {i}/{cantidad}: ");
                                string nombreDocumento = Console.ReadLine();

                                if (!string.IsNullOrWhiteSpace(nombreDocumento))
                                {
                                    colaImpresion.Enqueue(nombreDocumento);
                                    Console.WriteLine($"'{nombreDocumento}' agregado.");
                                }
                                else
                                {
                                    Console.WriteLine(" El nombre no puede estar vacío. Intente de nuevo.");
                                    i--; // Decrementamos i para que vuelva a pedir el mismo número
                                }
                            }
                            Console.WriteLine($"\n Se agregaron {cantidad} documentos correctamente a la cola.");
                        }
                        else
                        {
                            Console.WriteLine(" Cantidad no válida. Debe ingresar un número mayor a 0.");
                        }
                        break;

                    case "2":
                        // 4. Atender el primer documento (Dequeue)
                        if (colaImpresion.Count > 0)
                        {
                            string docImpreso = colaImpresion.Dequeue();
                            Console.WriteLine($"\n---  Imprimiendo: {docImpreso} ---");

                            // --- INICIO DE LA MODIFICACIÓN (Req. 5) ---
                            // 5. Mostrar los documentos restantes en la cola.
                            if (colaImpresion.Count > 0)
                            {
                                Console.WriteLine("\n Documentos restantes en la cola:");
                                int i = 1;
                                foreach (string doc in colaImpresion)
                                {
                                    Console.WriteLine($"{i}. {doc}");
                                    i++;
                                }
                            }
                            else
                            {
                                // 6. Mostrar mensaje si la cola queda vacía DESPUÉS de imprimir
                                Console.WriteLine("\n La cola de impresión ha quedado vacía.");
                            }
                            // --- FIN DE LA MODIFICACIÓN ---
                        }
                        else
                        {
                            // 6. Mostrar un mensaje si no hay documentos pendientes (antes de imprimir)
                            Console.WriteLine("\n La cola de impresión ya estaba vacía. No hay nada que imprimir.");
                        }
                        break;

                    case "3":
                        // 3. Mostrar la cola completa (orden de impresión)
                        if (colaImpresion.Count > 0)
                        {
                            Console.WriteLine("\n Documentos pendientes en la cola (orden de impresión):");
                            int i = 1;
                            foreach (string doc in colaImpresion)
                            {
                                Console.WriteLine($"{i}. {doc}");
                                i++;
                            }
                        }
                        else
                        {
                            // 6. Mostrar un mensaje si no hay documentos pendientes.
                            Console.WriteLine("\n La cola de impresión está vacía.");
                        }
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("\n Saliendo del simulador...");
                        break;

                    default:
                        Console.WriteLine("\n Opción no válida. Por favor, intente de nuevo.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine(); // Pausa para que el usuario lea el mensaje
                    Console.Clear(); // Limpia la consola para mostrar el menú de nuevo
                }
            }
        }
    }
}