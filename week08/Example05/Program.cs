///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>  

using System;

//银行账户
namespace Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            var sa = new SavingAccount(23, 0.23);
            sa.Credit(34);
            Console.WriteLine(sa.Balance);
            var ca = new CheckingAccount(34, 1);
            ca.Debit(15);
            Console.WriteLine(ca.Balance);
        }
    }
    class Account
    {
        public double Balance { get; private set; }
        public Account()
        {
            Balance = 0;
        }
        public Account(double b)
        {
            Balance = b > 0 ? b : 0;
        }
        public void Credit(double m)
        {
            Balance += m > 0 ? m : 0;
        }
        public bool Debit(double m)
        {
            if (Balance - m >= 0)
            {
                Balance -= m;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class SavingAccount : Account
    {
        private double interest;
        public SavingAccount(double b,double i):base(b)
        {
            interest = i;
        }
        public double CalculateInterest()
        {
            return interest * Balance;
        }
    }
    class CheckingAccount : Account
    {
        private double fee;
        public CheckingAccount(double b,double f):base(b)
        {
            fee = f;
        }
        public new bool Debit(double m)
        {
            return base.Debit(m + fee);
        }
    }
}
