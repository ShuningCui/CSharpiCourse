///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

//结构和枚举

using System;

namespace Example01
{
    class Program
    {
        struct Student
        {
            public int age;
            public string name;
        }

        enum DayOFTime : long
        {
            Morning=9,
            Noon=9,
            Afternoon
        }
        static void Main(string[] args)
        {
            Student s1;
            s1.age = 18;
            Student[] ss = new Student[100];
            DayOFTime d1;
            d1 = DayOFTime.Noon;
        }
    }
}
