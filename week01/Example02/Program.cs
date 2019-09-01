///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   

using System;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            //在一行中输入多个数据
            var s = Console.ReadLine();
            var sSplit = s.Split(' ');
            var a = new double[sSplit.Length];
            var sum = 0.0;
            for (var i = 0; i < sSplit.Length; i++)
            {
                a[i] = Convert.ToDouble(sSplit[i]);
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
        }
    }
}
