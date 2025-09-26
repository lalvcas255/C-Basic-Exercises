class Program
{
    // Método para saludar con parámetro
    static void Saludar(string nombre)
    {
        Console.WriteLine($"¡Hola {nombre}!");
    }

    // Método para despedirse
    static void Despedirse()
    {
        Console.WriteLine("¡Adiós!");
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine() ?? string.Empty;

        Saludar(nombre);
        Despedirse();
    }
}
