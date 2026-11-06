using System;

class Program
{
    static void Main(string[] args)
    {
        int nota;

        Console.WriteLine("===== SISTEMA DE CALIFICACIONES =====");
        Console.Write("Ingrese una nota entre 0 y 100: ");

        // Validar que la entrada sea un numero entero.
        if (!int.TryParse(Console.ReadLine(), out nota))
        {
            Console.WriteLine("Error: debe ingresar un numero entero.");
        }
        else if (nota < 0 || nota > 100)
        {
            Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
        }
        else if (nota >= 90)
        {
            Console.WriteLine("Calificacion: A");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("Calificacion: B");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Calificacion: C");
        }
        else
        {
            Console.WriteLine("Calificacion: F");
        }
    }
}
