///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>

using System;
using System.Collections.Generic;

/*
 * 利用一维数组求解问题。读入若干（1-15个）整数（一行输入，空格分隔），
 * 每个数在10-100之间的整数包括10和100。
 * 在读入每个数时，确认这个数的有效性（在10到100之间），
 * 并且若它和之前读入的数不一样，就把它存储到数组中，无效的数不存储。
 * 读完所有数之后，仅显示用户输入的不同的数值。
样例1：
输入：
12 34 99 123 12 123 78 0 12 99
输出：
12 34 99 78
样例2：
输入:
-9 -9 0 34 99 99 99 34 34 34
输出
34 99
 */
namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[15]; //记录数组
            int n = 0; //不同的数的个数
            var s = Console.ReadLine().Split(' ');
            for(int i=0;i<s.Length;i++)
            {
                //读入每一个数据
                var data = Convert.ToInt32(s[i]);
                if (data < 10 || data > 100)  //数据不和要求，直接进入下一轮
                    continue;
                //在存储的数组中查找
                bool exist = false;   //记录是否已经存在与数组中
                for(int j=0;j<n;j++)
                {
                    if (data==a[j])//已经存在
                    {
                        exist = true;
                        break;
                    }
                }
                if(!exist)  //不存在
                {
                    a[n] = data;   //加入到数组中
                    n++;   //计数+1
                }
            }
            //输出
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",a[i]);
            }
            Console.WriteLine();
            
            //用list更简洁
            var list = new List<int>();
            for(int i=0; i<s.Length;i++)
            {
                var data = Convert.ToInt32(s[i]);
                if (data >= 10 && data <= 100 && !list.Exists(x => x == data))
                {
                    list.Add(data);
                }
            }
            foreach(var d in list)
            {
                Console.Write("{0} ", d);
            }
            Console.WriteLine();
        }
    }
}
