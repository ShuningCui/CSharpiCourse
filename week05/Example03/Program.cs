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
/*程序应该先随机掷出第一个骰子，
 * 再随机掷出第二个骰子。
 * 然后计算两个值的和。（
 * 注意：由于每个骰子显示1-6之间的一个整数值，
 * 因此这两个值的和在2-12之间变动，
 * 其中7是出现频率最高的值，2-12是出现频率最低的值。）
程序应该掷出这两个骰子3600次。请利用一个一维数组记录每个可能的和出现的次数。
*/
namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var dice = new int[11];
            for(int i=0;i<3600;i++)
            {
                var d1 = r.Next(1, 7);
                var d2 = r.Next(1, 7);
                //统计
                dice[d1 + d2 - 2]++;
            }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("和是{0}的次数：{1}", i + 2, dice[i]);
            }
        }
    }
}
