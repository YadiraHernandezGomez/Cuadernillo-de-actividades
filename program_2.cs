using System;

namespace temporada_c2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string estacion = " ";
            Console.WriteLine("Selecciona un mes para saber la temporada: \n 1- Enero \n 2.- Febrero \n 3- Marzo \n 4- Abril \n 5.- Mayo \n 6.- Junio \n 7.- Julio \n 8.- Agosto \n 9.- Septiembre \n 10.- Octubre \n 11.- Noviembre \n 12.- Diciembre ");
            a = int.Parse(Console.ReadLine());

            if (a == 12 || a == 1 || a == 2) { estacion = " Invierno "; }
            else if (a == 3 || a == 4 || a == 5 || a == 6) { estacion = "Primavera"; }
            else if (a == 7 || a == 8 || a == 9) { estacion = "Verano"; }
            else if (a == 10 || a == 11 ) { estacion = " Otoño "; }

            Console.WriteLine("La estacion es : " + estacion);
            Console.ReadKey();

        }
    }
}
