///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  
using System;

namespace Example06
{
    //递归 汉诺塔
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(3,'A','B','C');
        }
        static void Move(char from,char to)
        {
            Console.WriteLine("from {0} To {1}", from, to);
        }
        static void Hanoi(int n,char p1, char p2,char p3)
        {
            if(n==1)
            {
                Move(p1, p3);
            }
            else
            {
                Hanoi(n - 1, p1, p3, p2);
                Move(p1, p3);
                Hanoi(n - 1, p2, p1, p3);
            }
        }
    }
}
