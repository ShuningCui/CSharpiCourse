///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary> 

using System;

namespace Examp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var x = Convert.ToInt32(s);
            s = Console.ReadLine();
            var y = Convert.ToInt32(s);
            var z = x + y;
            Console.WriteLine(z);
        }
    }
}
