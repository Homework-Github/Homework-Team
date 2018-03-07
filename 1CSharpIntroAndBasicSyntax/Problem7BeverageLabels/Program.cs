using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double ml = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double energyContent = ml * energy / 100;
            double sugarContent = ml * sugar / 100;

            Console.WriteLine($"{ml}ml {product}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");

        }
    }
}