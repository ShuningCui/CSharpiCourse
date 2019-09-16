///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   
using System;

//复数类
namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Complete(1, 2);
            var c2 = new Complete(2, 3);
            var c3 = c1.Add(c2);
            Console.WriteLine("{0} + {1} = {2}", c1, c2, c3);
        }
    }
  
    class Complete
    {
        public double Real { get; set; }
        public double Image { get; set; }
        public Complete()
        {
            Real = Image = 0;
        }
        public Complete(double real,double image)
        {
            Real = real;
            Image = image;
        }
        public Complete Add(Complete x)
        {
            return new Complete(Real + x.Real, Image + x.Image);
        }
        public Complete Sub(Complete x)  //Add的写法更简洁，sub的较为清晰
        {
            var temp = new Complete();
            temp.Real = Real - x.Real;
            temp.Image = Image - x.Image;
            return temp;
        }
        public override string ToString()
        {
            return string.Format("{0}+{1}i", Real, Image);
        }
    }
}
