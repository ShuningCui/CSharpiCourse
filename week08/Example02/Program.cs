///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

using System;

//龟兔赛跑
namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Running();
            r1.Run();
        }
    }

    //乌龟类
    class Tortoise
    {
        private int t = 1;  //位置
        private Random r = new Random();
        //计算当前位置
        public int GetPosition()
        {
            switch(r.Next(10))  //掷骰子
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    t += 3;
                    break;
                case 5:
                case 6:
                    t = t - 6 > 0 ? t - 6 : 1;
                    break;
                case 7:
                case 8:
                case 9:
                    t += 1;
                    break;
            }
            return t;
        }
    }
    class Hare
    {
        private int h = 1;  //位置
        private Random r = new Random();
        //计算当前位置
        public int GetPosition()
        {
            switch (r.Next(10))  //掷骰子
            {
                case 0:
                case 1:
                    break;
                case 2:
                case 3:
                    h += 9;
                    break;
                case 4:
                    h = h - 12 > 0 ? h - 12 : 1;
                    break;
                case 5:
                case 6:               
                case 7:
                    h++;
                    break;
                case 8:
                case 9:
                    h = h - 2 > 0 ? h - 2 : 1;
                    break;
            }
            return h;
        }
    }
    class Running
    {
        private Tortoise tortoise = new Tortoise();
        private Hare hare = new Hare();
        public void Run()
        {
            Console.WriteLine("ON YOUR MARK GET SET");
            Console.WriteLine("BANG!!!");
            Console.WriteLine("AND THEY ARE OFF!");
            var tPos = tortoise.GetPosition();
            var hPos = hare.GetPosition();
            while(tPos<=70 && hPos<=70)
            {
                Display(tPos, hPos);
                tPos = tortoise.GetPosition();
                hPos = hare.GetPosition();
                System.Threading.Thread.Sleep(1000);
            }
            if (tPos > 70)
            {
                Console.WriteLine("Tortoise Win!!");
            }
            else
            {
                Console.WriteLine("Hare Win!!");
            }
        }
        private void Display(int tPos,int hPos)
        {
            var dis = new char[75];
            for(int i=0;i<75;i++)
            {
                dis[i] = ' ';
            }
            if(tPos==hPos)
            {
                dis[tPos - 1] = 'O';
                dis[tPos] = 'U';
                dis[tPos + 1] = 'C';
                dis[tPos + 2] = 'H';
                dis[tPos + 3] = '!';
            }
            else
            {
                dis[tPos - 1] = 'T';
                dis[hPos - 1] = 'H';
            }
            dis[69] = '|';
            Console.WriteLine(new string(dis));
        }
    }
}
