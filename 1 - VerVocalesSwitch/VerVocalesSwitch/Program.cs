Cree un programa en C# que solicite al usuario una letra (x) y compruebe si es una vocal o otro símbolo.

Muestre por pantalla Vocal o Otro símbolo.+

Console.WriteLine("Ingrese una letra:");

char letra = Console.ReadKey().KeyChar;

switch (letra) {

    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
    
        Console.WriteLine("Vocal");

        break;

    default:
        Console.WriteLine("Ha introducido otro símbolo");

    break;
}