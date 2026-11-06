using System;

class Program
{
    static void Main(string[] args)
    {
        decimal subtotal = 0;
        int cantidadProductos = 0;
        decimal precio;
        bool continuar = true;

        Console.WriteLine("===== CAJA REGISTRADORA =====");
        Console.WriteLine("Escriba 0 para terminar.");

        // Leer precios hasta que el usuario introduzca cero.
        do
        {
            Console.Write("Ingrese el precio del producto: ");

            if (!decimal.TryParse(Console.ReadLine(), out precio))
            {
                Console.WriteLine("Entrada invalida. Intente nuevamente.");
            }
            else if (precio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
            }
            else if (precio == 0)
            {
                continuar = false;
            }
            else
            {
                subtotal += precio;
                cantidadProductos++;
            }

        } while (continuar);

        // Calcular ITBIS y total.
        decimal itbis = subtotal * 0.18m;
        decimal total = subtotal + itbis;

        Console.WriteLine("\n===== FACTURA =====");
        Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
        Console.WriteLine($"Subtotal: RD$ {subtotal:N2}");
        Console.WriteLine($"ITBIS (18%): RD$ {itbis:N2}");
        Console.WriteLine($"Total: RD$ {total:N2}");
    }
}
