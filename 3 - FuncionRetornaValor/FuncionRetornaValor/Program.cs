class Program

{
    // Función que retorna la suma de dos enteros
    
    static int Sumar(int a, int b)
{
    return a + b;
}

    static void Main(string[] args)
    {
        Console.Write("Ingresa el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = Sumar(num1, num2);
        Console.WriteLine($"La suma de {num1} + {num2} = {resultado}");
    }
}
