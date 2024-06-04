using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _0604
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あっち向いてほい");

            //オブジェクトを作成
            Class1 p1 = new Class1("山田");
            p1.show();
            Class1 p2 = new Class1("福田");
            p2.show();


            while (true)
            {
                Console.WriteLine("あっちむいて・・・・");
                Console.WriteLine("1…上↑　２…右→　3…下↓　4…左　5…斜め上↗　6…斜め下↙");

            //入力内容を待つ
            p1.Hand = int .Parse(Console.ReadLine());

                //
                p1.show(p1.Name, p1.Hand);

                Random random = new Random();
                p2.Hand = random.Next(1, 7);

                p1.show(p1.Name, p1.Hand);
                p2.show(p2.Name, p2.Hand);

                //条件分岐
                if (p1.Hand == p2.Hand)
                {
                    Console.WriteLine("引き分け");
                    continue;
                }
                else if ((p1.Hand == 1 && p2.Hand == 2) || (p1.Hand == 2 && p2.Hand == 3) || (p1.Hand == 3 && p2.Hand == 4) || (p1.Hand == 4 && p2.Hand == 5) || (p1.Hand == 5 && p2.Hand == 6) || (p1.Hand == 6 && p2.Hand == 1))
                {
                    Console.WriteLine("かち！！おめでとう！！！！");
                    continue;
                   
                }
                else if (p1.Hand == 1 || p1.Hand == 2 || p1.Hand == 3 || p1.Hand == 4 || p1.Hand == 5 || p1.Hand == 6)
                {
                    Console.WriteLine("まけ・・・・残念でした。");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("該当しません他の数字で試して下さい。");
                    continue;
                }
             }
            Console.WriteLine("終了");
            Console.ReadKey();

        }

        


    }
}
