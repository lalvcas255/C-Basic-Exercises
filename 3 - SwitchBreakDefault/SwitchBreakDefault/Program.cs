 // Ingresar Nota
 
    Console.WriteLine("Introduzca la nota del alumno:");
   
   int nota = Convert.ToInt32(Console.ReadLine());

// Seleccionar Calificación

    switch (nota)
    {

    case 0:

        Console.WriteLine("Suspenso");

        break;

    case 5:

        Console.WriteLine("Aprobado");

        break;

    case 8:

        Console.WriteLine("Notable");

        break;

    case 9:

        Console.WriteLine("Sobresaliente");

        break;

    case 10:

        Console.WriteLine("Matrícula de honor");

        break;

}
    
