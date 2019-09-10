///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  
using System;

namespace Example
{
    //静态函数和静态变量
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Sample();
            //s.SampleMethod()  //error
            var s1 = new Sample();
            Sample.SampleMethod();
            Console.WriteLine(Sample.count);
        }
    }

    class Sample
    {
        public static int count = 0;
        public int a = 0;
        public static void SampleMethod()
        {
            Console.WriteLine("The Static Method");
        }
        public Sample()
        {
            count++;
        }
    }
}
