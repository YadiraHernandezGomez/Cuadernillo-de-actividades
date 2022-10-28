using System;

namespace presupuestoSB_c6
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;

            Console.WriteLine("Hola ingresa la cantidad de dinero con la que cuentas");
            p = int.Parse(Console.ReadLine());

            if (p > 100 && p < 500) Console.WriteLine("Usted puede comprar solo bancos");
            else if (p > 500) Console.WriteLine("Usted puede comprar Sillas o bancos");
            else Console.WriteLine("Presupuesto invalido");
            Console.ReadKey();
        }
    }
}
