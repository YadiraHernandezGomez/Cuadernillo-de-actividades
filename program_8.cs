using System;
using System.Linq;
namespace CostoBoleto_co8
{
public static class Program
{
public static void Main()
{
int C,ED;
double T;
Console.WriteLine("Ingresa El costo del boleto");
C = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa tu edad");
ED = int.Parse(Console.ReadLine());
if(ED > 0 && ED <18)
{
T = C - (C * 0.20);
}
else if(ED == 18)
{
T = C - (C * 0.07);

}

else if(ED > 18)
{
T = C;
}

else
{
Console.WriteLine("Edad invalida, no es posible realizar la venta");
return;
}
Console.WriteLine("El costo del boleto a una persona de " + ED + " años de edad es de: " + T);

}
}
}
