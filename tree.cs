using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 聖誕樹
{
    class Program
    {
        static void Main(string[] args)
        {   int l = 80;
            int a = l;
            int b = 1;
            int t = 1;
            while (t <= l)
            {
                int i = 0;
                while (i < a)
                {
                    Console.Write(" ");
                    i = i + 1;
                }
                int q = 1;
                while(q<=b)
                { q = q + 1;
                    Console.Write("*");
                }
                Console.WriteLine();
                t = t + 1;
                a = a - 1;
                b = b + 2;
            }
        }
    }
}
