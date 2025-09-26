Console.Write("Ingrese el número inicial (x): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número final (y): ");
        int y = int.Parse(Console.ReadLine());

for (int i = x; i >= y; i--)
{
    if (i % 2 != 0)
        Console.Write(i + " ");


}