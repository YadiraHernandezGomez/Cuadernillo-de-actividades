using System;

namespace descuento_c7
{
    class Program
    {
        static void Main(string[] args)
        {
            int  Selec = 0;
            double C, CF;
            Console.WriteLine("Ingresa el costo del automovil");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione una forma de pago: \n 1.- Contado \n 2.- Mensualidades (Mas un aumento del 17 porciento)");
            Selec = int.Parse(Console.ReadLine());

            if (Selec == 2) { CF = C + (C * 0.17); }
            else if (Selec == 1) { CF = C; }
            else { Console.WriteLine("Seleccion invalida"); return; }

            Console.WriteLine("El costo del vehiculo sera: " + CF );
        }
    }
}