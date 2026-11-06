using System;

class Program
{
    static void Main(string[] args)
    {
        const decimal ITBIS = 0.18m;

        string producto;
        int cantidad;
        decimal precio;

        Console.WriteLine("===== SISTEMA DE FACTURACION =====");

        // Solicitar el nombre del producto.
        do
        {
            Console.Write("Ingrese el nombre del producto: ");
            producto = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(producto))
                Console.WriteLine("El nombre del producto no puede estar vacio.");

        } while (string.IsNullOrWhiteSpace(producto));

        // Solicitar y validar la cantidad.
        do
        {
            Console.Write("Ingrese la cantidad: ");

            if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Ingrese una cantidad entera mayor que cero.");
                cantidad = 0;
            }

        } while (cantidad <= 0);

        // Solicitar y validar el precio.
        do
        {
            Console.Write("Ingrese el precio por unidad: ");

            if (!decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)
            {
                Console.WriteLine("Ingrese un precio valido.");
                precio = -1;
            }

        } while (precio < 0);

        // Calcular subtotal, ITBIS y total.
        decimal subtotal = cantidad * precio;
        decimal impuesto = subtotal * ITBIS;
        decimal total = subtotal + impuesto;

        // Mostrar la factura con columnas alineadas.
        Console.WriteLine("\n================ FACTURA ================");
        Console.WriteLine($"{"Producto",-20} {"Cantidad",10} {"Precio",10}");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"{producto,-20} {cantidad,10} {precio,10:N2}");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"{"Subtotal:",30} {subtotal,10:N2}");
        Console.WriteLine($"{"ITBIS (18%):",30} {impuesto,10:N2}");
        Console.WriteLine($"{"TOTAL:",30} {total,10:N2}");
        Console.WriteLine("==========================================");
    }
}
