///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary> 

using System;

//在数组中顺序查找

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            //随机数填充数组
            var a = new int[100];
            var r = new Random();
            for(int i=0;i<a.Length;i++)
            {
                a[i] = r.Next(1, 100);
            }
            //输入要查找的数
            var m = Convert.ToInt32(Console.ReadLine());
            //顺序查找
            for(int i=0;i<a.Length;i++)
            {
                //找到
                if(m==a[i])
                {
                    //输出，退出程序
                    Console.WriteLine("m的位置是{0}", i);
                    return;
                }
            }
        }
    }
}
