// Operación Infinita Hasta Insertar 0

double num;

do
{
    Console.WriteLine("Inserte un número (0 para salir): ");

    num = Convert.ToDouble(Console.ReadLine());

    if (num != 0)
    {
        Console.WriteLine("Resultado: " + (10 * num));
    }

} while (num != 0);
