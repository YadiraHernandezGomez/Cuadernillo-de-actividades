using System;
using System.Linq;

namespace Conductor_c9
{
public static class Program
{
public static void Main()
{
int D, P ;

Console.WriteLine("Ingresa cuanto dinero obtuvo al final del dia");
D = int.Parse(Console.ReadLine());

P = D / 10;

Console.WriteLine("Usted ha transportado a: " + P);

if ( P >= 80)
{
Console.WriteLine("Ha cumplido con la meta diaria");
}

else
{
Console.WriteLine("No ha cumplido con la meta diaria");
}

}
}
}