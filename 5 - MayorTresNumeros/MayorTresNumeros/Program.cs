    // Insertar Valores
    
    Console.WriteLine("Inserte el primer número");
    
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Inserte el segundo número");
    
    double num2 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Inserte el tercer número");
    
    double num3 = Convert.ToDouble(Console.ReadLine());
    
    // Condicional Mayor Número
    
    if (num1 >= num2 && num2 >= num3)

    {

        Console.WriteLine("El número más grande es: " + num1);

    }
    
    else if (num2 >= num1 && num2 >= num3)
    
    {

        Console.WriteLine("El número más grande es: " + num2);

    }
    else if (num3 >= num1 && num3 >= num2)
    {

        Console.WriteLine("El número más grande es: " + num3);


    }
