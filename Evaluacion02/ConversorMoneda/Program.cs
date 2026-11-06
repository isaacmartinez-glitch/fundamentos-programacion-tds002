using System;

class Program
{
    static void Main(string[] args)
    {
        // Tasa de venta de referencia: 1 USD = 61.0459 DOP.
        const double TASA_USD = 61.0459;

        double montoPesos;

        Console.WriteLine("===== CONVERSOR DE MONEDA =====");

        // Solicitar el monto en pesos dominicanos.
        Console.Write("Ingrese el monto en pesos dominicanos: ");

        while (!double.TryParse(Console.ReadLine(), out montoPesos) || montoPesos < 0)
        {
            Console.Write("Monto invalido. Ingrese un valor mayor o igual a cero: ");
        }

        // Convertir pesos dominicanos a dolares.
        double montoDolares = montoPesos / TASA_USD;

        // Mostrar el resultado.
        Console.WriteLine("\n===== RESULTADO =====");
        Console.WriteLine($"Monto en pesos: RD$ {montoPesos:N2}");
        Console.WriteLine($"Tasa utilizada: RD$ {TASA_USD:N4} por dolar");
        Console.WriteLine($"Equivalente en dolares: US$ {montoDolares:N2}");
    }
}
