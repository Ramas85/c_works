using System;

namespace PirmaPaskaita
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite pirma skaiciu");
            int pirmas = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int antras = int.Parse(Console.ReadLine());

            Console.WriteLine("Sudedam?");
            int sudedam = pirmas + antras;
            Console.WriteLine(sudedam);


            /*int n = int.Parse(Console.ReadLine());
            int tarpas = n;
            int zv = 0;
            for (int eilute = 0; eilute < n + 1; eilute++)
            {
                Console.Write(new string(' ', tarpas));
                Console.WriteLine();
                Console.Write(new string('*', zv));

                tarpas--;
                zv++;
            }
            */
        }
    }
}
