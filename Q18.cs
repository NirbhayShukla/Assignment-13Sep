using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 word");
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            if(s.Equals(t)) Console.WriteLine("Equal");
            else Console.WriteLine("Not Equal");
        }
    }
}
