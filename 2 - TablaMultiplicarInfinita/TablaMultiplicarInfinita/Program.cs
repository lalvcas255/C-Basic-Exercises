    // Introducir Valores
    
    Console.WriteLine("Inserte el primer número");
    
    string? input1 = Console.ReadLine();
    int num1 = input1 != null ? int.Parse(input1) : 0; 
    
    string? input2 = Console.ReadLine();

    int num2 = input2 != null ? int.Parse(input2) : 0;

    // Bucle Crea Tabla Multiplcar
    
    for (int i = 0; i <= num2; i++)
    {

    for (int j = 0; j <= 10; j++)
    {


        Console.WriteLine(i + " * " + j + " = " + (i * j));

    }

}
