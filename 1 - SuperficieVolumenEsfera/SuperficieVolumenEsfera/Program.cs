// Declaración Datos

double radio = 0;

double superficie = Math.PI * Math.Pow(radio, 2);

double volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);

// CCalcular Superficie y Volumen de una Esfera

Console.WriteLine($"Para descubrir la superficie y el volumen de la esfera, introduzca su radio:");

radio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"La superficie de la esfera es: {superficie}");

Console.WriteLine($"El volumen de la esfera es: {volumen}");


