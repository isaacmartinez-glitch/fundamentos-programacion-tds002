using System;

class Program
{
    static void Main(string[] args)
    {
        const decimal PORCENTAJE_AFP = 0.0287m;
        const decimal PORCENTAJE_SFS = 0.0304m;

        string nombre;
        decimal horas;
        decimal pagoPorHora;

        Console.WriteLine("===== SISTEMA DE NOMINA =====");

        // Solicitar el nombre del empleado.
        do
        {
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine() ?? "";
            
            if (string.IsNullOrWhiteSpace(nombre))
                Console.WriteLine("El nombre no puede estar vacio.");

        } while (string.IsNullOrWhiteSpace(nombre));

        // Solicitar y validar las horas trabajadas.
        do
        {
            Console.Write("Ingrese las horas trabajadas: ");

            if (!decimal.TryParse(Console.ReadLine(), out horas) || horas < 0)
            {
                Console.WriteLine("Ingrese una cantidad de horas valida.");
                horas = -1;
            }

        } while (horas < 0);

        // Solicitar y validar el pago por hora.
        do
        {
            Console.Write("Ingrese el pago por hora: ");

            if (!decimal.TryParse(Console.ReadLine(), out pagoPorHora) || pagoPorHora < 0)
            {
                Console.WriteLine("Ingrese un pago por hora valido.");
                pagoPorHora = -1;
            }

        } while (pagoPorHora < 0);

        // Calcular salario bruto y deducciones.
        decimal salarioBruto = horas * pagoPorHora;
        decimal afp = salarioBruto * PORCENTAJE_AFP;
        decimal sfs = salarioBruto * PORCENTAJE_SFS;
        decimal salarioNeto = salarioBruto - afp - sfs;

        // Mostrar los resultados de la nomina.
        Console.WriteLine("\n===== DETALLE DE NOMINA =====");
        Console.WriteLine($"Empleado: {nombre.ToUpper()}");
        Console.WriteLine($"Salario bruto: RD$ {salarioBruto:N2}");
        Console.WriteLine($"AFP (2.87%): RD$ {afp:N2}");
        Console.WriteLine($"SFS (3.04%): RD$ {sfs:N2}");
        Console.WriteLine($"Salario neto: RD$ {salarioNeto:N2}");
    }
}
