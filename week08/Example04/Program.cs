///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   
using System;

//包裹投递
namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new ThreeDayPackage("XIAOWANG", "ZHANGL", 
                "SHANGHAICHINA", 1234.56m, 0.0023m, 0.034m);
            Console.WriteLine(tp.Calculate());
        }
    }
    class Package
    {
        //包裹的各种属性，发件人，收件人，地址等
        protected string SenderName { get; set; }
        protected string ReciverName { get; set; }
        protected string Address { get; set; }
        protected decimal weight;
        protected decimal Weight
        {
            get { return weight; }
            set { weight = value > 0 ? value : 0; }
        }

        protected decimal fee;
        protected decimal Fee
        {
            get { return fee; }
            set { fee = value > 0 ? value : 0; }
        }
        //构造函数
        public Package(string sn,string rn,string add,decimal w,decimal f)
        {
            SenderName = sn;
            ReciverName = rn;
            Address = add;
            Weight = w;
            Fee = f;
        }

        //计算费用
        public decimal Calculate()
        {
            return Fee * Weight;
        }
    }

    class ThreeDayPackage : Package
    {
        protected decimal exFee;
        protected decimal ExFee
        {
            get { return exFee; }
            set { exFee = value > 0 ? value : 0; }
        }
        public ThreeDayPackage(string sn, string rn, string add, decimal w, decimal f,decimal ex)
            :base(sn,rn,add,w,f)
        {
            ExFee = ex;
        }
        public new decimal Calculate()
        {
            return base.Calculate() + ExFee * Weight;
        }
    }
}
