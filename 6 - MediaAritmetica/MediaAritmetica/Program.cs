            // Introducir Valores

            Console.Write("Ingrese el primer número: ");

            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");

            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");

            double numero3 = Convert.ToDouble(Console.ReadLine());

            // Calcular la media 
            
            double mediaAritmetica = (numero1 + numero2 + numero3) / 3;

            Console.WriteLine($"La media aritmética de {numero1}, {numero2} y {numero3} es: {mediaAritmetica}");
        