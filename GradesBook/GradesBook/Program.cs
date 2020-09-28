using System;
using System.Collections.Generic;

namespace GradesBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 15.15, 10.50, 30.17 };
            grades.Add(15.7);

            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result = result / grades.Count;
            Console.WriteLine($" The average is {result:N1}");
        }
    }
}
