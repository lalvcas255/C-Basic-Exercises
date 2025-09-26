            // Introducir Valores
            
            Console.WriteLine("Distinguir Número Positivo y Negativo");


            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // Condicional Positivo, Negativo o Cero
                        
                        if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }

          
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        
   
