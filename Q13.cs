using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int highest=(a>b && a>c)?a:b>c?b:c;
            Console.WriteLine(highest);
        }
    }
}
