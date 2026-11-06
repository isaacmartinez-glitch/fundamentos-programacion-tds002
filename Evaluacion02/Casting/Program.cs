using System;

class Program
{
    static void Main(string[] args)
    {
        double numeroDecimal;

        Console.WriteLine("===== DEMOSTRACION DE CASTING =====");

        // Solicitar un numero decimal.
        Console.Write("Ingrese un numero con decimales: ");

        while (!double.TryParse(Console.ReadLine(), out numeroDecimal))
        {
            Console.Write("Entrada invalida. Ingrese un numero decimal: ");
        }

        // Casting explicito: convertir double a int.
        int parteEntera = (int)numeroDecimal;

        // Casting implicito: convertir int a double.
        double numeroConvertido = parteEntera;

        // Mostrar los resultados.
        Console.WriteLine("\n===== RESULTADOS =====");
        Console.WriteLine($"Numero original: {numeroDecimal}");
        Console.WriteLine($"Parte entera (casting explicito): {parteEntera}");
        Console.WriteLine($"Casting implicito de int a double: {numeroConvertido}");
    }
}
