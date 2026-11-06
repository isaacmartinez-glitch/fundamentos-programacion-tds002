using System;

class Program
{
    static void Main(string[] args)
    {
        // Generar un numero secreto entre 1 y 100.
        int secreto = Random.Shared.Next(1, 101);
        int intento;
        int contador = 0;

        Console.WriteLine("===== ADIVINA EL NUMERO =====");
        Console.WriteLine("Estoy pensando en un numero del 1 al 100.");

        // Repetir hasta que el usuario adivine.
        while (true)
        {
            Console.Write("Escriba su intento: ");

            if (!int.TryParse(Console.ReadLine(), out intento))
            {
                Console.WriteLine("Ingrese un numero entero valido.");
                continue;
            }

            if (intento < 1 || intento > 100)
            {
                Console.WriteLine("El numero debe estar entre 1 y 100.");
                continue;
            }

            contador++;

            if (intento < secreto)
            {
                Console.WriteLine("El numero secreto es MAYOR.");
            }
            else if (intento > secreto)
            {
                Console.WriteLine("El numero secreto es MENOR.");
            }
            else
            {
                Console.WriteLine("Correcto! Adivinaste el numero.");
                break;
            }
        }

        // Mostrar la cantidad de intentos realizados.
        Console.WriteLine($"Cantidad de intentos: {contador}");
    }
}
