using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante con el año actual.
        const int ANIO_ACTUAL = 2026;

        // Variables.
        string nombre;
        int edad;
        double estatura;

        Console.WriteLine("===== DATOS PERSONALES =====");

        // Solicitar nombre.
        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine() ?? "";

        // Solicitar y validar edad.
        Console.Write("Ingrese su edad: ");
        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.Write("Edad invalida. Intente nuevamente: ");
        }

        // Solicitar y validar estatura.
        Console.Write("Ingrese su estatura en metros: ");
        while (!double.TryParse(Console.ReadLine(), out estatura) || estatura <= 0)
        {
            Console.Write("Estatura invalida. Intente nuevamente: ");
        }

        // Calcular año de nacimiento.
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Mostrar resultados usando interpolacion.
        Console.WriteLine("\n===== RESULTADOS =====");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura:F2} metros");
        Console.WriteLine($"Año de nacimiento aproximado: {anioNacimiento}");
    }
}
