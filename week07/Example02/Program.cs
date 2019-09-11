///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

using System;

//点和直线
namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line();
            Console.WriteLine("Distance Line1:{0}", line1.Distance());
            Line line2 = new Line(1, 1, 3, 3);
            Console.WriteLine("Distance Line2:{0}", line2.Distance());
            Line line3 = new Line(new Point(2, 3), new Point(4, 6));
            Console.WriteLine("Distance Line3:{0}", line3.Distance());
        }

    class Point
    {
        //点的坐标
        public double X { get; set; }
        public double Y { get; set; }
        //构造函数
        public Point()
        {
            X = Y = 0;
        }
        public Point(double x,double y)
        {
            X = x;
            Y = y;
        }
    }
    //直线类
    class Line
    {
        //两点构成一线
        private Point p1;
        private Point p2;
        //构造
        public Line()
        {
            p1 = new Point();
            p2 = new Point();
        }
        public Line(double x1,double y1,double x2,double y2)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
        }
        public Line(Point p1,Point p2)
        {
            this.p1 = p1;   //局部变量p1和成员p1重名，用this来区分
            this.p2 = p2;
        }
        public double Distance()
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) +
                (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}
