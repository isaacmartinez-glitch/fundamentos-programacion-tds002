using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Mostrar tablas del 1 al 10");
            Console.WriteLine("2. Dibujar triangulo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opcion no valida.");
                opcion = -1;
                continue;
            }

            switch (opcion)
            {
                case 1:
                    MostrarTablas();
                    break;

                case 2:
                    DibujarTriangulo();
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Seleccione una opcion valida.");
                    break;
            }

        } while (opcion != 0);
    }

    static void MostrarTablas()
    {
        Console.WriteLine("\n===== TABLAS DEL 1 AL 10 =====");

        for (int fila = 1; fila <= 10; fila++)
        {
            for (int tabla = 1; tabla <= 10; tabla++)
            {
                Console.Write($"{tabla * fila,4}");
            }

            Console.WriteLine();
        }
    }

    static void DibujarTriangulo()
    {
        Console.Write("\nIngrese el numero de filas: ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Ingrese un numero entero positivo.");
            return;
        }

        for (int fila = 1; fila <= n; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}