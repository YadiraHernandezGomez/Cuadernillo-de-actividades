using System;

namespace promedio_c4
{
    class Program
    {
        public static void Main()
        {

            double c, contc, t, p;

            t = 0; contc = 1;


            Console.WriteLine("- promedio de 10 actividades de Algebra lineal -");

            while (contc <= 10)
            {
                Console.WriteLine("INGRESA LA CALIFICACION");
                c = Convert.ToInt32(Console.ReadLine());
                t = t + c;
                contc = contc + 1;

            }

            p = t / 10;

            Console.WriteLine("\nel total de las 10 calificaciones es: " + t);
            Console.WriteLine("\n el promedio es de: " + p);

            if (p >= 8) Console.WriteLine("felicitaciones has aprovado");
            else Console.WriteLine("lo siento, has reprobado");

        }

    }
}
