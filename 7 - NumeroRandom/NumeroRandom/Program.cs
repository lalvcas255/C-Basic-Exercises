  
  // Declaración del Rango de Valores
  
  int valorMenor = 1;
  int valorMayor = 101;

  // Generar un Número Random Dentro del Rango
  
  Random rnd = new Random();
        
        int numeroAleatorio = rnd.Next(valorMenor, valorMayor);

  // Mostrar el número Random
   
  Console.WriteLine($"El número aleatorio entre {valorMenor} y {valorMayor-1} es: {numeroAleatorio}");
        