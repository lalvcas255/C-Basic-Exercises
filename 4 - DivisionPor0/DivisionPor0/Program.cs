
// Introducir Valores

try

{
    Console.WriteLine("Inserte el dividendo:");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Inserte el divisor:");
    double y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("La división de ambos números tiene como resultado: " + (x / y));

}


// Excepciones

catch (DivideByZeroException)

{

    Console.WriteLine("No se puede dividir por 0.");

}

catch (FormatException)

{
    Console.WriteLine("Error: Debe ingresar valores numéricos.");
}