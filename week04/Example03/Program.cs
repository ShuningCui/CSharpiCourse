///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>     
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    //成绩转换
    class Program
    {
        static void Main(string[] args)
        {
            var grade = Convert.ToInt32(Console.ReadLine());
            int f = 0;
            switch(grade / 10)
            {
                case 10:
                case 9:
                    f = 5;
                    break;
                case 8:
                    f = 4;
                    break;
                case 7:
                    f = 3;
                    break;
                case 6:
                    f = 2;
                    break;
                default:
                    f = 1;
                    break;
            }
            Console.WriteLine(f);
        }
    }
}
