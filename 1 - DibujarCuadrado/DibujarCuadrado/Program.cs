        // Introducir el Número Que Se Mostrará
        
        Console.Write("Ingrese un número: ");
     
        string? inputX = Console.ReadLine();
        
        int x = inputX != null ? int.Parse(inputX) : 0;

        // Introducir el ancho del cuadrado
        
        Console.Write("Ingrese el ancho del cuadrado: ");
        
        string? inputAncho = Console.ReadLine();
        int ancho = inputAncho != null ? int.Parse(inputAncho) : 0;

        // Dibujar el cuadrado

        for (int i = 0; i < ancho; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write(x + " ");

            }
        }
