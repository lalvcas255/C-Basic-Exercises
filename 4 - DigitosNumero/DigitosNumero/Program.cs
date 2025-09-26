 // Ingresar Valores
 
 Console.WriteLine("Introduzca un número para averiguar sus digitos");
    
    int num = Convert.ToInt32(Console.ReadLine());

// Descomposición del Número en Dígitos en un Array

if (num > 0)
{

    int[] array = new int[] { num };

    for (int i = 0; i < array.Length; i++)
    {

        Console.WriteLine("El número: " + num + " tiene: " + i + " dígitos");


    }

}