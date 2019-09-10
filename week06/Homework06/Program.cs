///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

using System;

/*
 * 开发计算机辅助教学程序，教小学生学乘法。
 * 程序功能：
（1）程序开始时让用户选择“年级”为1或2。
一年级使只用1位数乘法；二年级使用2位数乘法。
（2）用Random对象产生两个1位或2位正整数，
然后输入以下问题，例如：
How much is 6 times 7?
然后学生输入答案，程序检查学生的答案。
如果正确，则打印“Very good!”，
然后提出另一个乘法问题。如果不正确，
则打印“No,Please try again.”，
然后让学生重复回答这个问题，直到答对。
（3）答对3道题后程序结束。
（4）使用一个单独方法产生每个新问题， 
这个方法在程序开始时和每次用户答对时调用。
 */

namespace Homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            var teachTimes = new TeachTimes();
            teachTimes.Run();
        }
    }
    enum Grade { One = 1, Two }  //枚举年级
    class TeachTimes
    {
        private int right = 0;  //答对的次数
        private Random r = new Random();
        Grade grade=Grade.One;
        private int x1;  //乘数和被乘数
        private int x2;
        /// <summary>
        /// 产生一个新问题
        /// </summary>
        private void NewQuestion()
        {
            //
            if (grade==Grade.One)
            {
                x1 = r.Next(0, 10);
                x2 = r.Next(0, 10);
            }
            else
            {
                x1 = r.Next(0, 100);
                x2 = r.Next(0, 100);
            }
        }
        /// <summary>
        /// 练习开始
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Choose your grade=1 or 2");
            grade = (Grade)(Convert.ToInt32(Console.ReadLine()));
            while(right<3)
            {
                NewQuestion();
                for(; ; )
                {
                    Console.WriteLine("How much is {0} times {1}", x1, x2);
                    var answer = Convert.ToInt32(Console.ReadLine());
                    if(answer==x1*x2)  //答对了
                    {
                        Console.WriteLine("Very good!");
                        right++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No,Please try again.");
                    }
                }
                
            }
            Console.WriteLine("===END===");
        }
    }
}
