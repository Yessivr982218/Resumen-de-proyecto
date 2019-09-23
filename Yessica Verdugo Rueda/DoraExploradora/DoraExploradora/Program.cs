using System;

namespace DoraExploradora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tiempo1 = DateTime.Now;

            long x;
            long y;
            long n, e, g;





            Console.WriteLine("Ingrese el valor de X: ");
            while (!long.TryParse(Console.ReadLine(), out x))
            {

                Console.WriteLine("Valores erroneos");
            }
            Console.WriteLine("\nIngresa el valor de Y: ");
            while (!long.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Valores erroneos");
            }



            n = (x + y) - 1;

            if (x > 0 && x <= 2000000000)
            {
                g = (n + 1) * (n / 2);
                e = (g - x) + 1;


                if (y > 0 && y <= 2000000000)
                {

                    g = (n + 1) * (n / 2);
                    e = (g - y) + 1;
                    Console.WriteLine("De acuerdo a las coordenadas, Dora se encuentra en: " + e);
                    Console.ReadLine();

                }

                else
                {
                    Console.WriteLine("No puede ser aceptado");
                }

                DateTime tiempo2 = DateTime.Now;
                TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
                Console.Write("TIEMPO: " + total.ToString());
                Console.ReadLine();
            }
        }
    }
}
   
         
 
    

