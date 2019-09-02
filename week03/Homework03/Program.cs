///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary> 
/*
 * 定义并实现一个公民类Citizen，
 * 该类包括的特征信息有：
 * 身份证号ID、姓名Name、性别Gender、
 * 年龄Age、籍贯Birthplace、家庭住址Familyaddress属性以
 * 及构造方法（不含参数）、
 * 输入公民信息方法Input以及输出公民信息方法Print，
 * 要求能够对该类对象进行初始化、输入和输出操作。
 */
using System;


namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen c1 = new Citizen();
            c1.Input("610101205012120000", "旺财", "火星", "交大", 2, Gender.female);
            c1.Print();
        }
    }
    /// <summary>
    /// 性别的枚举
    /// </summary>
    enum Gender
    {
        male,
        female,
        x
    }

    class Citizen
    {
        public string ID { get; set; }
        public string Name { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            //年龄的值如果不正确则设置为-1
            set { age = value > 0 && value < 130 ? value : -1; }
        }

        public Gender Gender { get; set; }
        public string BirthPlace { get; set; }
        public string FamilyAddress { get; set; }
        /// <summary>
        /// 构造方法
        /// </summary>
        public Citizen()
        {
            ID = Name = BirthPlace = FamilyAddress = "";
            Gender = Gender.x;
            Age = 20;
        }
        /// <summary>
        /// 输入方法
        /// </summary>
        /// <param name="id">身份证</param>
        /// <param name="name">名字</param>
        /// <param name="birthPlace">出生地</param>
        /// <param name="familyAddress">家庭住址</param>
        /// <param name="age">年龄</param>
        /// <param name="gender">性别</param>
        public void Input(string id, string name, string birthPlace,
            string familyAddress,int age,Gender gender)
        {
            ID = id;
            Name = name;
            BirthPlace = birthPlace;
            FamilyAddress = familyAddress;
            Age = age;
            Gender = gender;
        }

        public void Print()
        {
            Console.WriteLine("姓名：{0}, 身份证：{1}", Name, ID);
            Console.WriteLine("出生地：{0}, 家庭住址：{1}", BirthPlace, FamilyAddress);
            Console.WriteLine("年龄：{0}, 性别：{1}", Age, Gender);
        }
    }

}
