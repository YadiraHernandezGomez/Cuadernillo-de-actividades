using System;
namespace DedolaresApesos
{
class Program
{
static void Main(string[] args)
{
double m, Total;
int selec;
Console.WriteLine("Selecciona que desea hacer: \n 1.- de dolares a pesos \n 2.- de pesos a dolares");
selec = int.Parse(Console.ReadLine());
if ( selec == 1 )

{
Console.WriteLine("Ingresa cuantos dolares tienes");
m = Convert.ToDouble(Console.ReadLine());
Total = m * 21.52;
Console.WriteLine("La cantidad en pesos de los " + dolar + " dolares es de: " + Total + " pesos");
Console.ReadKey();
}

else if (selec == 2)

{

Console.WriteLine("Ingresa cuantos pesos tienes");

m = Convert.ToDouble(Console.ReadLine());
Total = m / 21.52;
Console.WriteLine("La cantidad en dolares de los " + m + " pesos es de: " + Total + " dolares");
Console.ReadKey();
}
}
}
}