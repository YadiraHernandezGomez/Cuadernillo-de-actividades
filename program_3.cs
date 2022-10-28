using System;
namespace juguete_c3
{
class Program
{
static void Main(string[] args)
{
int CT;
double Cj, Cp;
Console.WriteLine("Ingresa el costo del juguete que juan y pedro compraran juntos");
CT = int.Parse(Console.ReadLine());
if ( CT > 0 && CT < 200 )

{
Cj = CT * 0.80;
Cp = CT * 0.20;

Console.WriteLine("Juan pagara el 80 porciento de " + CT + "\n lo cual es: " + Cj + " y pedro el 20 porciento el
cual es: " + Cp);
Console.ReadKey();
}

else if ( CT >= 200 && CT <= 500 )

{
Cj = CT * 0.50;
Cp = CT * 0.50;

Console.WriteLine("Juan pagara " + CT + "y pedro: " + Cp);
Console.ReadKey();
}

else if (CT > 500)

{

Console.WriteLine("No compraran el juguete ya que exede el su costo maximo");
Console.ReadKey();
}

else

{
Console.WriteLine("Costo invalido");
Console.ReadKey();
}
}
}
}