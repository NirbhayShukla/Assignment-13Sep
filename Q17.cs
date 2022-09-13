using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string s = Console.ReadLine();
            string rev = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i];
            }
            Console.WriteLine(rev);
        }
    }
}
