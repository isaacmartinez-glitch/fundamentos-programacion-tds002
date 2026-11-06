using System;

class Program
{
    static void Main(string[] args)
    {
        decimal numero1;
        decimal numero2;
        int opcion;

        Console.WriteLine("===== CALCULADORA =====");

        // Solicitar y validar el primer numero.
        Console.Write("Ingrese el primer numero: ");

        if (!decimal.TryParse(Console.ReadLine(), out numero1))
        {
            Console.WriteLine("Error: primer numero invalido.");
            return;
        }

        // Solicitar y validar el segundo numero.
        Console.Write("Ingrese el segundo numero: ");

        if (!decimal.TryParse(Console.ReadLine(), out numero2))
        {
            Console.WriteLine("Error: segundo numero invalido.");
            return;
        }

        // Mostrar las operaciones disponibles.
        Console.WriteLine("\nSeleccione una operacion:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Opcion: ");

        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Error: opcion invalida.");
            return;
        }

        // Resolver la operacion utilizando switch.
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado: {numero1 + numero2:N2}");
                break;

            case 2:
                Console.WriteLine($"Resultado: {numero1 - numero2:N2}");
                break;

            case 3:
                Console.WriteLine($"Resultado: {numero1 * numero2:N2}");
                break;

            case 4:
                if (numero2 == 0)
                {
                    Console.WriteLine("Error: no se puede dividir entre cero.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {numero1 / numero2:N2}");
                }
                break;

            default:
                Console.WriteLine("Seleccione una opcion entre 1 y 4.");
                break;
        }
    }
}
