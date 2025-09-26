         // Introducir Valores

        Console.WriteLine("Inserte el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Pedimos al usuario el segundo número del rango
        Console.WriteLine("Inserte el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Condicional Comprueba Por Qué Número Empezar
        if (num1 > num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

      // Mostrar Serie de Números
        

        Console.WriteLine($"\nLos números en el rango de {num1} a {num2} son:");
        for (int i = num1; i <= num2; i++)
        {
            Console.Write(i + " ");
        }
    