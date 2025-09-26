// Introducir Valores

Console.Write("Ingrese el valor de a: ");

double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de b: ");

double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el valor de c: ");

double c = Convert.ToDouble(Console.ReadLine());    

// Calcular y Mostrar Resultados

double resultado1 = (a + b) * c;
double resultado2 = a * c + b * c;

Console.WriteLine($"El resultado de (a + b) * c es: {resultado1}");
Console.WriteLine($"El resultado de a * c + b * c es: {resultado2}");
Console.WriteLine();

if (resultado1 == resultado2)
{
    Console.WriteLine("Los resultados son equivalentes.");
}   
else
{
    Console.WriteLine("Los resultados no son equivalentes.");
}       
