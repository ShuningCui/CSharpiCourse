///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary> 

/*
某城市最高的楼只有一部电梯。该电梯和一般电梯不同的是
它依照输入楼层数的先后次序运行。
电梯最初在0层。运行完一个输入序列后就停止在该楼层，
不返回0层。编写程序计算电梯运行一个序列的时间。
每次都假设电梯在0层开始，无论上一次运行到几层。
电梯每上1层需要6秒。每下1层需要4秒。如在某层停留，
无论上下人多少，均停留5秒。
输入：楼层的值大于等于1，小于100。
输出：计算每个序列电梯运行的时间。
输入： 
2 1
输出：
26
*/
using System;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;  //停留的时间
            int old = 0;  //上一个的楼层位置

            var s = Console.ReadLine().Split(' ');
            foreach(var s0 in s)
            {
                var floor = Convert.ToInt32(s0); //下一个到达的楼层数
                if (floor > old)   //电梯向上运动
                {
                    t = t + (floor - old) * 6 + 5;
                }
                else  //向下
                {
                    t = t + (old - floor) * 4 + 5;               
                }
                old = floor;  //更新楼层
            }
            Console.WriteLine(t);
        }
    }
    
}
