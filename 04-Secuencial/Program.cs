using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante para convertir libras a kilogramos.
        const decimal LIBRAS_A_KILOGRAMOS = 0.453592m;

        decimal libras;
        decimal fahrenheit;

        Console.WriteLine("===== CONVERSOR DE UNIDADES =====");

        // Entrada: solicitar el peso en libras.
        do
        {
            Console.Write("Ingrese el peso en libras: ");

            if (!decimal.TryParse(Console.ReadLine(), out libras) || libras < 0)
            {
                Console.WriteLine("Ingrese un peso valido mayor o igual a cero.");
                libras = -1;
            }

        } while (libras < 0);

        // Entrada: solicitar la temperatura en Fahrenheit.
        Console.Write("Ingrese la temperatura en grados Fahrenheit: ");

        while (!decimal.TryParse(Console.ReadLine(), out fahrenheit))
        {
            Console.Write("Entrada invalida. Ingrese la temperatura en °F: ");
        }

        // Proceso: realizar las conversiones.
        decimal kilogramos = libras * LIBRAS_A_KILOGRAMOS;
        decimal celsius = (fahrenheit - 32m) * 5m / 9m;

        // Salida: mostrar los resultados con dos decimales.
        Console.WriteLine("\n===== RESULTADOS DE CONVERSION =====");
        Console.WriteLine($"Peso en libras: {libras:F2} lb");
        Console.WriteLine($"Peso en kilogramos: {kilogramos:F2} kg");
        Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit:F2} °F");
        Console.WriteLine($"Temperatura en Celsius: {celsius:F2} °C");

        Console.WriteLine("\nConversion completada.");
    }
}
