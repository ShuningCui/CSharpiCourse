///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary> 

using System;

namespace Example05
{
    //方法的重载
    class Program
    {
        static void Main(string[] args)
        {
            var area = TriangleArea(3, 4, Math.PI/2);
            Console.WriteLine(area);
            area = TriangleArea(3d, 4d, 5d);
            Console.WriteLine(area);
            area = TriangleArea(3, 4);
            Console.WriteLine(area);

        }

        static double TriangleArea(double a,double b,double c)
        {
            var s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static double TriangleArea(double a,double h)
        {
            return (a * h) / 2;
        }

        static double TriangleArea(int a, int b,double theta)
        {
            return (a * b * Math.Sin(theta)) / 2;
        }
    }
}
