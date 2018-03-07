using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6MilesToKM
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            //double mile = 0.621371;
            double km = 1.60934;
            double b = a * km;
            Console.WriteLine($"{b:F2}");

        }
    }
}
