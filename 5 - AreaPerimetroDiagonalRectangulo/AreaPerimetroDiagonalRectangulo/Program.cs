
// Entrada de Valores

Console.WriteLine("Inserte el ancho del rectángulo:");

double x = Convert.ToDouble(Console.ReadLine());


// Calculo del Perímetro, Área y Diagonal

Console.WriteLine("Inserte la altura del rectángulo");

double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("El Perímetro es:" + ((2 * x) + (2 * y)));

Console.WriteLine("El área es: " + (x*y));

Console.WriteLine("La diagonal es: " + Math.Sqrt((x * x) + (y*y)));


