using System;

    namespace elevacion;

class program
{
    static void Main(string[] args)
    {
        double n1, n2,res;

        Console.WriteLine("Ingresa un numero");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa a que nuemero lo quieres elevar");
        n2 = Convert.ToDouble(Console.ReadLine());

        res = Math.Pow(n1, n2);

        Console.WriteLine("El resultado del numero " + n1 + " elevado a " + n2 + " es: " +res);
        Console.ReadKey();
    }

}
