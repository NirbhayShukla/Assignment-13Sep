using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q15
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 10 numbers");
            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            Console.WriteLine("Sum = "+sum);
            Console.WriteLine("Average = " + sum / 10);
            Array.Sort(a);
            int min = a[0];
            int max = a[9];
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximun = " + max);
            Console.WriteLine(String.Join(",",a));
            Array.Reverse(a);
            Console.WriteLine(String.Join(",", a));
        }
    }
}
