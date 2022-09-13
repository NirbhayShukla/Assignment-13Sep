using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= a; i++) fact *= i;
            Console.WriteLine(fact);
        }
    }
}
