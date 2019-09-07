///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   
///
using System;

namespace Example01
{
    //随机填充一维数组，随机数：[1,100)，数组大小200，整型
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[200];
            var r = new Random();
            for(int i=0;i<a.Length;i++)
            {
                a[i] = r.Next(1, 100);
            }

            foreach(var k in a)
            {
                Console.WriteLine(k);
            }
        }
    }
}
