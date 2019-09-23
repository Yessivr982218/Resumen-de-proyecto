using System;

namespace Dora
{
    class Program
    {

        static void Main(string[] args)
        {
         
            long x,y,n,e,g;
         
            Console.WriteLine("Ingresa el valor de X:");
            Console.ReadLine();
            Console.WriteLine("\nIngresa el valor de Y:");
            Console.ReadLine();



            if (x >= 1 && x <= 2000000000)
            {
                e = (n + 1) * (n / 2);
                g = (e - x) + 1;
                if (y >= 1 && y <= 2000000000)
                {
                    e = (n + 1) * (n / 2);
                    g = (e - y) + 1;
                    Console.WriteLine("De acuerdo a las coordenadas, Dora se encuentra en: " + g);
                    Console.ReadLine();
                }

                else
                {

                    Console.WriteLine("No puede ser aceptado");
                    Console.ReadLine();

                }
            }
        }
    }
 }



