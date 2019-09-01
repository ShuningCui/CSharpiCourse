///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>

/*输入一个总的秒数，将该秒数换算为相应的时、分、秒。如输入3600秒，
则输出结果为1小时；输入3610秒，结果为1小时10秒。
样例1：
3601
1小时1秒
样例2：
67
0小时1分7秒
*/

using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入秒数
            var input = Convert.ToInt32(Console.ReadLine());
            var hour = input / 3600;  //小时数
            var minute = (input - hour * 3600) / 60;
            var second = input % 60;

            Console.Write("{0}小时", hour);

            //对于分和秒，大于0的数据才输出
            if(minute>0)
            {
                Console.Write("{0}分", minute);
            }
            if(second>0)
            {
                Console.Write("{0}秒", second);
            }
        }
    }
}
