using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            while (a <= 40)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
