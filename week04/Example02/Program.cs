///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   

using System;

namespace Example02
{
    class Program
    {
        //a+aa+aaa....
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            const int N = 7;
            var sum = 0;
            var aNext = a;
            int n = 0;
            while(n<N)
            {
                sum += aNext;
                aNext = aNext * 10 + a;
                n++;
            }
            Console.WriteLine("While: Sum={0}", sum);

            sum = n = 0;
            aNext = a;
            do
            {
                sum += aNext;
                aNext = aNext * 10 + a;
                n++;
            } while (n < N);
            Console.WriteLine("Do-While: Sum={0}", sum);

            sum = n = 0;
            aNext = a;
            for(int i=0;i<N;i++)
            {
                sum += aNext;
                aNext = aNext * 10 + a;
            }
            Console.WriteLine("For: Sum={0}", sum);
        }
    }
}
