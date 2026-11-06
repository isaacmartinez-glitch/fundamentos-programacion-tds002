using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        // Validar que el numero este entre 1 y 12.
        do
        {
            Console.Write("Ingrese un numero entre 1 y 12: ");

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada invalida. Ingrese un numero entero.");
                numero = 0;
            }
            else if (numero < 1 || numero > 12)
            {
                Console.WriteLine("El numero debe estar entre 1 y 12.");
            }

        } while (numero < 1 || numero > 12);

        // Mostrar la tabla utilizando un ciclo while.
        Console.WriteLine($"\n===== TABLA DEL {numero} =====");

        int contador = 1;
        int suma = 0;

        while (contador <= 12)
        {
            int resultado = numero * contador;

            Console.WriteLine($"{numero} x {contador} = {resultado}");

            // Acumular los resultados.
            suma += resultado;

            contador++;
        }

        // Mostrar la suma total.
        Console.WriteLine($"\nLa suma de todos los resultados es: {suma}");
    }
}
