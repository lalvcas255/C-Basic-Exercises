// Ingresar Valores

double num;
double suma;

do
{
    Console.WriteLine("Ingrese números para sumarlos (escriba 0 para terminar):");

    num = Convert.ToDouble(Console.ReadLine());

    suma += num;

} while (num != 0); 

        // Mostramos el resultado final
        Console.WriteLine($"La suma total es: {suma}");
        Console.WriteLine("Terminado.");