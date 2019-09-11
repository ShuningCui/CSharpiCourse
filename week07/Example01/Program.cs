///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

using System;


//Time类
namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试
            Time t1 = new Time();
            t1.Show();
            Time t2 = new Time(12, 34, 57);
            t2.Show();
            t2.Second = 59;
            t2.Show();
        }
    }

    class Time
    {
        private int hour;
        private int minutes;
        private int second;

        //公有属性
        public int Hour
        {
            get { return hour; }
            set { hour = value >= 0 ? value : 0; }
        }
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value > 0 && value <= 59 ? value : 0; }
        }
        public int Second
        {
            get { return second; }
            set { second = value >= 0 && value <= 59 ? value : 0; }
        }
        //构造函数（不含参数）
        public Time()
        {
            hour = minutes = second = 0;
        }
        //构造函数，3个参数
        public Time(int h, int m, int s)
        {
            Hour = h;
            Minutes = m;
            Second = s;
        }
        //显示
        public void Show()
        {
            Console.WriteLine("Hour: {0:D2}, Minutes:{1,D2}, Second:{2,D2}",
                Hour, Minutes, Second);
        }
        //析构
        ~Time()
        { }
    }
}
