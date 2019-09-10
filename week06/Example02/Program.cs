///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>

using System;


namespace Example02
{
    //参数的传递
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 99;
            Swap(a, b);
            Console.WriteLine("Main方法：a={0} && b={1}", a, b);
            Swap2(ref a, ref b);
            Console.WriteLine("Main方法：a={0} && b={1}", a, b);
        }

        static void Swap(int a,int b)
        {
            var temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Swap方法：a={0} && b={1}", a, b);
        }

        static void Swap2(ref int a,ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Swap2方法：a={0} && b={1}", a, b);
        }
    }
}
