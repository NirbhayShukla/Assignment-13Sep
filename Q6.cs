using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperatue in Fahrenheit");
            double temp = double.Parse(Console.ReadLine());
            temp -= 32;
            temp = temp * 5 / 9;
            Console.WriteLine("Temperature in Celsius : "+temp);
        }
    }
}
