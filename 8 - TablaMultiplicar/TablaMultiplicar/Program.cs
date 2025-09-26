// Calcular Tabla de Multiplicar

Console.WriteLine("Inserte un número para ver su tabla de multiplicar del 1 al 10");

int num = int.Parse(Console.ReadLine());
4
for (int i = 0; i <= 10; i++)
{

    Console.WriteLine(num + " * " + i + " = " + (num * i));

}