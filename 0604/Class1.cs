using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0604
{
    public class Class1
    {
        //フィールドの定義
        private string name;
        public int hand;

        //コンストラクタの設定
        public Class1(string name)
        {
            this.name = name;
        }

        //セッター、ゲッターメゾットorプロパティ

        public string Name
        {

            get { return name; }
        }
        public int Hand
        {
            get { return hand; }
            set { hand = value; }

        }

        //引数なし、戻り値なし
        public void show()
        {
            Console.WriteLine("私は{0}です", this.name);
        }

        //オーバーロードしてshowメゾットをつくる
        public void show(string name, int hand)
        {
            switch (hand)
            {
                case 1:
                    Console.WriteLine("{0}は上↑を指しました", name);
                    break;
                case 2:
                    Console.WriteLine("{0}は右→を指しました", name);
                    break;
                case 3:
                    Console.WriteLine("{0}は下↓を指しました", name);
                    break;
                case 4:
                    Console.WriteLine("{0}は左←を指しました", name);
                    break;
                case 5:
                    Console.WriteLine("{0}は斜め上↗を指しました", name);
                    break;
                case 6:
                    Console.WriteLine("{0}は斜め下を指しました", name);
                    break;
            }
          

        }
    }
}

