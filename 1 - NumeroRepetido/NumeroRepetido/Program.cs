// INgresar Valores

Console.WriteLine("Introduzca el número base a multiplicar");

int num = Convert.ToInt32(Console.ReadLine());

// Ingresar Número de Veces Que Se Multiplica

Console.WriteLine("Introduzca el número de veces que se multiplicará");

int numVeces = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= numVeces; i++) {

Console.WriteLine(num + i);

int resultado = (num+i);

i += resultado;



}
