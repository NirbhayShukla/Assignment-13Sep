using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment1
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            int oddCount = 0, evenCount = 0;
            Console.WriteLine("Enter 10 numbers");
            for(int i = 0; i < 10; i++)
            {
                int temp=int.Parse(Console.ReadLine());
                if (temp % 2 == 0) evenCount++;
                else oddCount++;
                   
            }
            Console.WriteLine($"Total even numbers = {evenCount} \nTotal odd count = {oddCount}");
        }
    }
}
