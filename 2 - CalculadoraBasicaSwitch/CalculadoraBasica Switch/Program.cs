// Introducir Valores

Console.WriteLine("Calculadora Básica");

Console.WriteLine("Introduzca el primer número:");

double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduzca el segundo número:");

double num2 = Convert.ToDouble(Console.ReadLine());

// Seleccionar Operación

Console.WriteLine("Introduzca la operación (+, -, *, /):");

string? operacionInput = Console.ReadLine();

string operacion = operacionInput ?? "";

double resultado;

switch (operacion)
{
    case "+":
        resultado = num1 + num2;

        Console.WriteLine($"El resultado de {num1} + {num2} es: {resultado}");

        break;

    case "-":

        resultado = num1 - num2;

        Console.WriteLine($"El resultado de {num1} - {num2} es: {resultado}");
       
        break;

    case "*":

        resultado = num1 * num2;

        Console.WriteLine($"El resultado de {num1} * {num2} es: {resultado}");
       
        break;

    case "/":

        if (num2 != 0)

        {

            resultado = num1 / num2;

            Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");

        }

        else

        {

            Console.WriteLine("Error: División por cero no está permitida.");

        }

        break;

        default:

        Console.WriteLine("Operación no válida. Por favor, use +, -, * o /.");
        break;
}