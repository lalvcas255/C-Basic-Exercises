// Declaración Datos

string textoOriginal = "bcd";

char[] caracteres = textoOriginal.ToCharArray();

// Inversión de caracteres

Array.Reverse(caracteres);

string textoInvertido = new string(caracteres);

Console.WriteLine("Texto original: " + textoOriginal);

Console.WriteLine("Texto invertido: " + textoInvertido);