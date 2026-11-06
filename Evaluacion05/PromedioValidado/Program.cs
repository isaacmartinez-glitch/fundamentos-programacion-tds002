using System;

class Program
{
    static void Main(string[] args)
    {
        decimal nota;
        decimal suma = 0;
        decimal mayor = 0;
        decimal menor = 100;
        int cantidad = 0;

        Console.WriteLine("===== PROMEDIO VALIDADO =====");
        Console.WriteLine("Ingrese notas del 0 al 100.");
        Console.WriteLine("Escriba -1 para terminar.");

        // Solicitar notas hasta recibir -1.
        do
        {
            bool valida;

            // Validar cada entrada antes de procesarla.
            do
            {
                Console.Write("Ingrese una nota: ");

                valida = decimal.TryParse(Console.ReadLine(), out nota);

                if (!valida)
                {
                    Console.WriteLine("Debe ingresar un numero valido.");
                }
                else if (nota != -1 && (nota < 0 || nota > 100))
                {
                    Console.WriteLine("La nota debe estar entre 0 y 100, o ser -1 para salir.");
                    valida = false;
                }

            } while (!valida);

            if (nota != -1)
            {
                // Acumular notas y actualizar mayor y menor.
                suma += nota;
                cantidad++;

                if (nota > mayor)
                    mayor = nota;

                if (nota < menor)
                    menor = nota;
            }

        } while (nota != -1);

        // Mostrar resultados si se ingresaron notas.
        if (cantidad > 0)
        {
            decimal promedio = suma / cantidad;

            Console.WriteLine("\n===== RESULTADOS =====");
            Console.WriteLine($"Cantidad de notas: {cantidad}");
            Console.WriteLine($"Promedio: {promedio:N2}");
            Console.WriteLine($"Nota mayor: {mayor:N2}");
            Console.WriteLine($"Nota menor: {menor:N2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron notas.");
        }
    }
}
