using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeId = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeId:D8}");
            Console.WriteLine($"Salary: {salary:F2}");

            //var grade = 5.5334;
            //var percentage = 55;
            //Console.WriteLine("{0:F7}", grade); // 5.53
            //Console.WriteLine("{0:D10}", percentage); // 055

        }
    }
}
