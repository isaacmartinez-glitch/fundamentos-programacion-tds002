using System;

class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int edad;
        double estatura;
        bool trabaja;

        Console.WriteLine("===== FICHA PERSONAL =====");

        // Solicitar el nombre.
        do
        {
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(nombre))
                Console.WriteLine("El nombre no puede estar vacio.");

        } while (string.IsNullOrWhiteSpace(nombre));

        // Solicitar y validar la edad.
        Console.Write("Ingrese su edad: ");

        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.Write("Edad invalida. Ingrese una edad valida: ");
        }

        // Solicitar y validar la estatura.
        Console.Write("Ingrese su estatura en metros: ");

        while (!double.TryParse(Console.ReadLine(), out estatura) || estatura <= 0)
        {
            Console.Write("Estatura invalida. Ingrese un valor mayor que cero: ");
        }

        // Solicitar si trabaja.
        Console.Write("¿Trabaja? (true/false): ");

        while (!bool.TryParse(Console.ReadLine(), out trabaja))
        {
            Console.Write("Respuesta invalida. Escriba true o false: ");
        }

        // Calcular el año en que cumplira 30 años.
        int anioCumplira30 = DateTime.Now.Year + (30 - edad);

        // Mostrar la ficha personal.
        Console.WriteLine("\n===== DATOS PERSONALES =====");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura:F2} metros");
        Console.WriteLine($"¿Trabaja?: {trabaja}");

        if (edad < 30)
            Console.WriteLine($"Cumplira 30 años en el año: {anioCumplira30}");
        else if (edad == 30)
            Console.WriteLine("Este es el año en que cumple 30 años.");
        else
            Console.WriteLine($"Cumplio 30 años aproximadamente en el año: {anioCumplira30}");
    }
}
