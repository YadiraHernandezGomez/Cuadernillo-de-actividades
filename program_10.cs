using System;
using System.Linq;
namespace ParImpar_c10
{
public static class Program
{
public static void Main()
{
double N1, S;

Console.WriteLine("Ingresa un numero para saber si es par o si es impar");
N1 = double.Parse(Console.ReadLine());
S = N1 % 2;
if( S == 0 )
{
Console.WriteLine("El numero es par");
}
else
{
Console.WriteLine("El numero es impar");
}

}
}
}