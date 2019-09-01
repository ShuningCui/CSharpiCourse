///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary> 

/*编程实现在一行内输入若干个整数（不超过30个），输出最大的一个整数。
样例：
输入（在一行内输入，空格分隔）：
5 6 78 -89 0 23 100 4 6
输出：
100
*/

using System;


namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputSplit = input.Split(' '); //分割输入的数据
            var max = Convert.ToInt32(inputSplit[0]);  //存储输入的第一个数据到max中
            //从第二个数开始，依次和max比较，如果比max大，则替换max中的数
            //比较之前先要把数据从字符串类型转换为整数
            for (int i = 1; i < inputSplit.Length; i++)
            {
                var temp = Convert.ToInt32(inputSplit[i]);
                if(temp>max)
                {
                    max = temp;
                }
            }
            Console.WriteLine(max);
        }
    }
}
