///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>


using System;
/*
 * 定义SavingsAccount类，类中有如下成员：
静态变量annualInterestRate存储所有账户持有者的年利率

类的每个对象包含一个专用实例变量savingBalance，表示该存款账户当前的金额。

定义CalculateMonthlyInterest方法，
将annualInterestRate与savingBalance相乘后除以12得到月利息，
这个月利息加进savingBalance中。

定义静态方法ModifyInterestRate，将savingBalance设置为新值。

测试SavingsAccount类，创建两个SavingsAccount的对象saver1和saver2，
结余分别为2000.0美元和3000.0美元。
将annualInterestRate设置为4%，然后计算月息,
并将月息加入账户结余后，输出两个账户的新结余。
然后将annualInterestRate设置为5%，
再次输出新的结余。
 */
namespace Homework07
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class SavingsAccount
    {
        private static double annualInterestRate = 0.04;
        private double savingBalance = 0;
        public SavingsAccount(double sa)
        {
            savingBalance = sa >= 0 ? sa : 0;
        }
        public void CalculateMonthlyInterest()
        {
            savingBalance += (savingBalance * annualInterestRate) / 12;
        }
        public static void ModifyInterestRate(double newAnnualInterestRate)
        {
            annualInterestRate = newAnnualInterestRate;
        }
        public void Show()
        {
            Console.WriteLine("SavingBalance:{0}", savingBalance);
        }
    }
}
