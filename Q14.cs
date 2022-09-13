using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers");
            int smallest = int.Parse(Console.ReadLine());
            for(int i = 0; i < 4; i++)
            {
                int temp=int.Parse(Console.ReadLine());
                if (smallest > temp) smallest = temp;
            }
            Console.WriteLine($"Smallest = {smallest}");
        }
    }
}
