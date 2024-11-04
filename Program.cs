using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("катет 1: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("катет 2: ");
            double side2 = double.Parse(Console.ReadLine());
            double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
            Console.WriteLine($"Гипотенуза: {hypotenuse}");
        }
    }
}
