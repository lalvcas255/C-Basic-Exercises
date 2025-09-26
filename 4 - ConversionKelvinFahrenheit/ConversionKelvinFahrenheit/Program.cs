// The user must insert the quantity of celsius, to convert it to kelvin and farenheit

Console.WriteLine("¡Welcome to the Celsius to Converse Program!");

Console.WriteLine("Insert Celsius:");

double celsius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Kelvin: " + (celsius + 273));

// Instead of dividing 18/10, which returned and integer value, 9.0/5.0 was used

Console.WriteLine("Fahrenheit: " + (celsius * ((9.0 / 5.0 ) + 32)));
