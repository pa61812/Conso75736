using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開始"); Console.WriteLine();
            Console.WriteLine();
            int x;
            
            bool 是質數;
            int a;
            Console.WriteLine("---------------------------");
            x = 6;
            while (x <= 15)
            {
                是質數 = true;
                a = 2;
                while ((a < x ) && 是質數)
                {
                    if (x % a == 0)
                    {
                        是質數 = false;
                    }
                   a += 1;
                }
                if (是質數)
                {
                    Console.Write(x + " ");
                }
                x += 1;
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("結束");
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine();
        }
    
    }
}
