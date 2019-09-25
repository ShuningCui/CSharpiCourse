///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

using System;

//C#的运算符重载
namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = new Complete(1, 2);
            var x2 = new Complete(3, 4);
            var x3 = x1.Add(x2);
            Console.WriteLine(x3);
            var x4 = x1 + x2;  //运算符重载
            Console.WriteLine(x4);
        }
    }
    class Complete
    {
        public double Real { get; set; }
        public double Image { get; set; }
        public Complete(double r,double i)
        {
            Real = r;
            Image = i;
        }
        public override string ToString()
        {
            return string.Format("{0}+i{1}", Real, Image);
        }
        public Complete Add(Complete x)
        {
            Complete temp = new Complete(0, 0);
            temp.Image = Image + x.Image;
            temp.Real = Real + x.Real;
            return temp;
        }
        //C#的运算符重载必须是static的，双目运算符重载必须传递2个参数
        //注意上面的Add只有一个参数
        public static Complete operator +(Complete x1,Complete x2)
        {
            return new Complete(x1.Real + x2.Real, x1.Image + x2.Image);
        }
    }
}
