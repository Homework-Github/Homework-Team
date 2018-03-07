using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {    //TO DO insert number five!
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numOne:D4} {numTwo:D4} {numThree:D4} {numFour:D4}");

        }
    }
}
