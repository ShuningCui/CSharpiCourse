///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   

using System;

/*
 * 定义圆类Circle，包含半径r，属性R能判断半径r的合理性（r>=0），计算圆面积的方法double Area()。
 * 从Circle类派生出圆柱体类Cylinder类，新增圆柱体的高h，属性H能判断高h的合理性（h>=0），
 * 新增计算圆柱体体积的方法double Volume()。
 * 在主方法中，创建一个Cylinder对象，并输出该对象的底面半径，高以及体积。
 * （要求：不使用构造方法，并且类中的域为私有，方法为公有）。
 */
namespace Homework08
{
    class Program
    {
        static void Main(string[] args)
        {
            var cy = new Cylinder();
            cy.R = 10;
            cy.H = 12;
            Console.WriteLine("半径：{0}，高{1}，体积：{2}", cy.R, cy.H, cy.Volume());
        }
    }
    class Circle
    {
        private double r;
        public double R
        {
            get { return r; }
            set { r = value >= 0 ? r : 0; }
        }
        public double Area()
        {
            return Math.PI * R * R;
        }
    }
    class Cylinder : Circle
    {
        private double h;
        public double H
        {
            get { return h; }
            set { h = value >= 0 ? value : 0; }
        }
        public double Volume()
        {
            return Area() * H;
        }
    }
}
