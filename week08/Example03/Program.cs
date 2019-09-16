///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

//点和圆
using System;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Circle(2,3,4);
            Console.WriteLine(c1);
        }
    }

    class Point
    {
        protected double x = 0;
        protected double y = 0;
        public Point(double x1,double y1)
        {
            x = x1;
            y = y1;
        }
        public override string ToString()
        {
            return string.Format("x={0} y={1}", x, y);
        }
    }
    class Circle :Point
    {
        protected double r = 0;
        public Circle(double x1,double y1,double r1):base(x1,y1)
        {
            r = r1;
        }
        public double Area()
        {
            return Math.PI * r * r;
        }
        public override string ToString()
        {
            return string.Format("r={0}",r);
        }
    }
}
