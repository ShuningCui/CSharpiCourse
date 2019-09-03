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
            //判断三角形的三边
            var s = Console.ReadLine().Split(' ');
            var a = Convert.ToDouble(s[0]);
            var b = Convert.ToDouble(s[1]);
            var c = Convert.ToDouble(s[2]);
            if(a+b>c && b+c>a && a+c>b)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
