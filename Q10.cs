using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n=int.Parse(Console.ReadLine());
            int a = 5;
            int sum = 0;
            while (a <= n)
            {
                sum += a * a * a;
                a++;
            }
            Console.WriteLine(sum);
        }
    }
}
