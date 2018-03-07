using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double numO = double.Parse(Console.ReadLine());
            double numT = double.Parse(Console.ReadLine());

            Console.WriteLine($"{numO * numT:F}");
        }
    }
}
