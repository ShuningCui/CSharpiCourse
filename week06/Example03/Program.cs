///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

using System;

namespace Example03
{
    //引用类型参数的传递
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            AddOne(a);
            foreach(var k in a)
            {
                Console.WriteLine(k);
            }
            AddOne2(ref a);
            foreach (var k in a)
            {
                Console.WriteLine(k);
            }
        }
        static void AddOne(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                a[i]++;
            }
        }

        static void AddOne2(ref int[]a)
        {
            a = new int[4] { 11, 12, 13, 14 };
            for(int i=0;i<a.Length;i++)
            {
                a[i]++;
            }
        }
    }
}
