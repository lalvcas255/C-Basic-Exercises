

Console.WriteLine("Ingrese un texto:");

String? texto = Console.ReadLine();

try
{
    if (texto == null)
    {
        Console.WriteLine("No se ingresó ningún texto.");
    }
    else
    {
        int numero = Convert.ToInt32(texto);
        Console.WriteLine("El texto es un número: " + numero);
    }
}
catch (FormatException)
{
    Console.WriteLine("El texto no es un número.");
}

