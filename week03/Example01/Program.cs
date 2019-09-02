///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>

using System;


namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero heroOne = new Hero(); //通过类创建对象
            heroOne.AddLife(); //调用对象的成员方法
            //使用属性
            heroOne.Life = 90;  
            var life = heroOne.Life;
        }
    }
    /// <summary>
    /// 简单的类的示例
    /// </summary>
    class Hero
    {
        private string name;//私有成员
        private int life = 50;  //声明时可以给出初值
        /// <summary>
        /// 属性，通过属性存取私有成员的值
        /// </summary>
        public int Life
        {
            get { return life; }
            set
            {
                life = value < 0 ? 0 : (value > 100 ? 100 : value);
            }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 匿名属性
        /// </summary>
        public int Age { get; set; }
        
        /// <summary>
        /// 类中一个普通的方法（函数）
        /// </summary>
        public void AddLife()
        {
            life++;
        }
        /// <summary>
        /// 构造方法（构造函数）
        /// </summary>
        public Hero()
        {
            life = 0;
            name = "";
        }
        /// <summary>
        /// 一个类只能有一个析构方法（函数）。 
        ///析构方法既没有修饰符，也没有参数
        /// </summary>
        ~Hero()
        {

        }
    }
}
