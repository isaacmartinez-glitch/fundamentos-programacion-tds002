using System;

class Program
{
    static void Main(string[] args)
    {
        int numero1;
        int numero2;

        Console.WriteLine("===== PROGRAMA DE OPERADORES =====");

        // Solicitar el primer numero entero.
        Console.Write("Ingrese el primer numero entero: ");

        while (!int.TryParse(Console.ReadLine(), out numero1))
        {
            Console.Write("Entrada invalida. Ingrese un numero entero: ");
        }

        // Solicitar el segundo numero entero.
        Console.Write("Ingrese el segundo numero entero: ");

        while (!int.TryParse(Console.ReadLine(), out numero2))
        {
            Console.Write("Entrada invalida. Ingrese un numero entero: ");
        }

        // Realizar y mostrar las operaciones aritmeticas.
        Console.WriteLine("\n===== RESULTADOS =====");
        Console.WriteLine($"Suma: {numero1} + {numero2} = {numero1 + numero2}");
        Console.WriteLine($"Resta: {numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"Producto: {numero1} * {numero2} = {(long)numero1 * numero2}");

        // Verificar que no se divida entre cero.
        if (numero2 != 0)
        {
            double divisionReal = (double)numero1 / numero2;
            int divisionEntera = numero1 / numero2;
            int residuo = numero1 % numero2;

            Console.WriteLine($"Division real: {divisionReal:F2}");
            Console.WriteLine($"Division entera: {divisionEntera}");
            Console.WriteLine($"Residuo: {residuo}");
        }
        else
        {
            Console.WriteLine("Division real: No se puede dividir entre cero.");
            Console.WriteLine("Division entera: No se puede dividir entre cero.");
            Console.WriteLine("Residuo: No se puede calcular.");
        }

        // Comprobar si el primer numero es par.
        bool esPar = numero1 % 2 == 0;
        Console.WriteLine($"¿El primer numero es par?: {esPar}");
    }
}

/*
PRUEBA DE ESCRITORIO
Valores de entrada:
x = 10
y = 3

Operaciones:
Suma:             10 + 3  = 13
Resta:            10 - 3  = 7
Producto:         10 * 3  = 30
Division real:    10 / 3  = 3.33
Division entera:  10 / 3  = 3
Residuo:          10 % 3  = 1
Es par:           10 % 2  = 0 -> true

Resultado:
El primer numero (10) es par.
*/
