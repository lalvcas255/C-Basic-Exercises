    //Introducir Valores
    
    Console.WriteLine("Inserte el primer número");
    
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Inserte el segundo número");
    
    double num2 = Convert.ToDouble(Console.ReadLine());

    // Seleccionar Operacion
    
    Console.WriteLine("Seleccione una operacion");
    
    Console.WriteLine("(Suma(+)");
    
    Console.WriteLine("(Resta(-)");
    
    Console.WriteLine("(Multiplicacion(*)");
    
    Console.WriteLine("(Division(/)");


    char operador = '0';

    string? input = Console.ReadLine();

    // Condicional Excepción Operador Vacío

    if (!string.IsNullOrEmpty(input))

    {
        operador = Convert.ToChar(input);
    }

    else

    {
        Console.WriteLine("No se ha introducido ningún operador. Saliendo del programa.");
        return;
    }

    switch (operador)

    {

    case '+':

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));

        break;

    case '-':

        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));

        break;

    case '*':

        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));

        break;

    case '/':

        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));

        break;

}
