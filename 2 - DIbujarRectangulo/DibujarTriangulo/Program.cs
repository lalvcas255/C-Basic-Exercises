
        //Introducir Número A Mostrar Para la Figura
        
        Console.Write("Ingrese un número: ");
     
        string? input = Console.ReadLine();

        int x = input != null ? int.Parse(input) : 0;

        // Dibujar el Triángulo
                
                for (int i = 0; i <= 3; i++)
        {


            for (int j = 0; j <= 5; j++)
            {

                Console.Write(x + " ");
            }
        }
