///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   

using System;

namespace Example04
{
    //洗牌与发牌模拟
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.Deal();
            card.Shuffle();
            card.Deal();
        }
    }
    /// <summary>
    /// 枚举一副牌的4个花色
    /// </summary>
    enum CardSuit
    {
        Club,Diamond,Heart,Spade
    }
    /// <summary>
    /// 枚举每个花色13个面值
    /// </summary>
    enum CardFace
    {
        Ace=1,Two,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King
    }
    /// <summary>
    /// 一张牌的结构
    /// </summary>
    struct CNode
    {
        public CardSuit cardSuit;
        public CardFace cardFace;
        /// <summary>
        /// 显示输出
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var s=string.Empty;
            switch ((int)cardSuit)
            {
                case 0:
                    s += "梅花";
                    break;
                case 1:
                    s += "方块";
                    break;
                case 2:
                    s += "红心";
                    break;
                case 3:
                    s += "黑桃";
                    break;
            }
            switch((int)cardFace)
            {
                case 1:
                    s += "A";
                    break;
                case 11:
                    s += "J";
                    break;
                case 12:
                    s += "Q";
                    break;
                case 13:
                    s += "K";
                    break;
                default:
                    s += ((int)cardFace).ToString();
                    break;
            }
            return s;
        }
    }

    class Card
    {
        private const int CARDNUMBER = 52;
        private const int FACENUMBER = 13;
        private CNode[] deck = new CNode[CARDNUMBER];
        /// <summary>
        /// 构造方法
        /// </summary>
        public Card()
        {
            //初始化一副新牌，52张牌按顺序放置
            for (int i = 0; i < CARDNUMBER; i++)
            {
                deck[i].cardFace = (CardFace)(i % FACENUMBER + 1);
                deck[i].cardSuit = (CardSuit)(i / FACENUMBER);
            }
        }
        /// <summary>
        /// 发牌
        /// </summary>
        public void Deal()
        {
            Console.WriteLine("===========52张牌的发牌次序============");
            Console.WriteLine("\t 东 \t 西 \t 南 \t 北");
            for (int i = 0; i < CARDNUMBER; i++)
            {
                Console.Write("第{0,2}张{1}\t", i + 1, deck[i]);
                if((i+1)%4==0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(); 
        }
        /// <summary>
        /// 洗牌，任意交换2张牌的位置
        /// </summary>
        public void Shuffle()
        {
            var r = new Random();
            for(int i=0;i<CARDNUMBER;i++)
            {
                var j = r.Next(CARDNUMBER);
                var temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
    }
}
