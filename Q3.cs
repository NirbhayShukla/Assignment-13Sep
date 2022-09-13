using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter range");
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
