struct Persona
{
    public string Nombre;
    public int Edad;
}

class Program
{
    static void Main()
    {
        Persona usuario;

        Console.WriteLine("Introduzca su nombre:");
        usuario.Nombre = Console.ReadLine();

        Console.WriteLine("Introduzca su edad:");
        usuario.Edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"¡Hola {usuario.Nombre}! Tienes {usuario.Edad} años.");
    }
}