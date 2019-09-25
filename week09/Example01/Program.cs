///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   
using System;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(1);
            Console.WriteLine(Area(c1));
            Sphere s1 = new Sphere(1);
            Console.WriteLine(Area(s1));
            Cylinder cy1 = new Cylinder(1, 1);
            Console.WriteLine(Area(cy1));
        }
        static double Area(Circle c)
        {
            return c.Area();
        }
    }

    class Circle
    {
        protected double radius;
        public Circle(double r)
        {
            radius = r > 0 ? r : 0;
        }
        public virtual double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    class Sphere : Circle
    {
        public Sphere(double r) : base(r) { }
        public override double Area()
        {
            return Math.PI * radius * radius * 4;
        }
    }

    class Cylinder:Circle
    {
        protected double height;
        public Cylinder(double r,double h):base(r)
        {
            height = h >= 0 ? h : 0;
        }
        public override double Area()
        {
            return 2 * Math.PI * radius * radius + 2 * Math.PI * height * radius;
        }
    }
}
