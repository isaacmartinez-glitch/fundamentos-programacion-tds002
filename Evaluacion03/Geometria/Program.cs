using System;

class Program
{
    static void Main(string[] args)
    {
        decimal radio;
        decimal cateto1;
        decimal cateto2;

        Console.WriteLine("===== CALCULADORA DE GEOMETRIA =====");

        // Solicitar y validar el radio del circulo.
        do
        {
            Console.Write("Ingrese el radio del circulo: ");

            if (!decimal.TryParse(Console.ReadLine(), out radio) || radio <= 0)
            {
                Console.WriteLine("El radio debe ser un numero mayor que cero.");
                radio = 0;
            }

        } while (radio <= 0);

        // Solicitar y validar el primer cateto.
        do
        {
            Console.Write("Ingrese el primer cateto del triangulo: ");

            if (!decimal.TryParse(Console.ReadLine(), out cateto1) || cateto1 <= 0)
            {
                Console.WriteLine("El cateto debe ser mayor que cero.");
                cateto1 = 0;
            }

        } while (cateto1 <= 0);

        // Solicitar y validar el segundo cateto.
        do
        {
            Console.Write("Ingrese el segundo cateto del triangulo: ");

            if (!decimal.TryParse(Console.ReadLine(), out cateto2) || cateto2 <= 0)
            {
                Console.WriteLine("El cateto debe ser mayor que cero.");
                cateto2 = 0;
            }

        } while (cateto2 <= 0);

        // Calcular area y circunferencia del circulo.
        double radioDouble = (double)radio;
        double area = Math.PI * Math.Pow(radioDouble, 2);
        double circunferencia = 2 * Math.PI * radioDouble;

        // Calcular la hipotenusa del triangulo rectangulo.
        double a = (double)cateto1;
        double b = (double)cateto2;
        double hipotenusa = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        // Mostrar todos los resultados.
        Console.WriteLine("\n===== RESULTADOS GEOMETRICOS =====");
        Console.WriteLine($"Area del circulo: {area:N2}");
        Console.WriteLine($"Circunferencia del circulo: {circunferencia:N2}");
        Console.WriteLine($"Hipotenusa del triangulo: {hipotenusa:N2}");
    }
}
