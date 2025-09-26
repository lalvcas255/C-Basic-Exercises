Console.WriteLine("Introduzca un número entero para averiguar si es primo");

int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < num; i++)

{
    if (num % i == 0)

    {
        Console.WriteLine("El número no es primo");

        break;
    }

    else if (num % num == 0 && num % 1 == 0)
    {

        Console.WriteLine("El número es primo");

    }
}
