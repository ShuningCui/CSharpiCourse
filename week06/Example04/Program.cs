///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>

using System;

namespace Example04
{
    //Out 修饰的参数
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int x2 = 5;
            AddM(x1, x2, out int x3, out int x4);
            Console.WriteLine("{0} {1}", x3, x4);
        }
        static void AddM(int x1,int x2,out int x3,out int x4)
        {
            x3 = x1 + x2;
            x4 = x1 - x2;
        }
    }
}
