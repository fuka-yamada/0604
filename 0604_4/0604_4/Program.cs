using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0604_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("計算機");

            while (true)
            {
                Console.WriteLine("1つ目の数字： ");
                var valuse1 = int.Parse(Console.ReadLine());

                Console.WriteLine("2つ目の数字： ");
                var valuse2 = int.Parse(Console.ReadLine());

                Console.WriteLine("計算の種類(+,-,/,*):");
                string ans = Console.ReadLine();

                Console.WriteLine("結果");

                if (ans == "+")
                {
                    Console.WriteLine(valuse1 + valuse2);
                }
                else if (ans == "-")
                {
                Console.WriteLine(valuse1 - valuse2);
                }
                else if(ans == "/")
                {
                    Console.WriteLine(valuse1 / valuse2);
                }
                else if(ans == "*")
                {
                    Console.WriteLine(valuse1 * valuse2);
                }
                else
                {
                    Console.WriteLine("+,-,/,*のどれかを入れてください。");
                }



            }
        }

    }
}
