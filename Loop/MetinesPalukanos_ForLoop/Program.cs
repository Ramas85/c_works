using System;

namespace MetinesPalukanos_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type sum (Integer number) that you want to add");
            string sumnumber = Console.ReadLine();
            int sum;
            while (!int.TryParse(sumnumber, out sum))
            {
                Console.WriteLine("This is not a number or is'n integer number, please insert right number");
                sumnumber = Console.ReadLine();
            }
            Console.WriteLine("How many years?");
            string years = Console.ReadLine();
            int sumyears;
            while (!int.TryParse(years, out sumyears))
            {
                Console.WriteLine("This is not a number or is'n integer number, please insert right number");
                years = Console.ReadLine();
            }

            double palukanos = 1.02;
            double result = sum;

            for (int cnt = 1; cnt < sumyears + 1; cnt++)
            {
                Console.WriteLine(cnt + " metais palukanos bus " + Math.Round((result * palukanos), 2));
                result = result * palukanos;
            }
        }
    }
}
