using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 終極密碼
{
    class Program
    {
        static void Main(string[] args)
        {
            int 答案;
            答案 = (new Random().Next(1, 100));
            Console.WriteLine("從1到100共100個整數範圍的任意一個整數   為");
            Console.WriteLine("------------------------------------------");
            String 使用者猜的輸入;
            int 使用者猜的整數;
            bool 使用者輸入的是int;
            bool 猜對了 = true;
            while (猜對了)
            {
                Console.WriteLine();
                Console.WriteLine("請輸入一個從1到100的整數");
                使用者猜的輸入 = Console.ReadLine();
                使用者輸入的是int = int.TryParse(使用者猜的輸入, out 使用者猜的整數);
                if (使用者輸入的是int)
                {
                    Console.Write("使用者猜的整數     為 ");
                    Console.WriteLine(使用者猜的整數);

                    if (使用者猜的整數 > 答案)
                    {
                        Console.WriteLine("往小一點的方向猜");
                    }
                    if (使用者猜的整數 < 答案)
                    {
                        Console.WriteLine("往大一點的方向猜");
                    }
                    if (使用者猜的整數 == 答案)
                    {
                        猜對了 = true;
                        Console.WriteLine("猜對了");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("遊戲結束");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}




            
