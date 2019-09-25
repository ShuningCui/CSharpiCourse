///<summary>
///说明:代码可以在GitHub下载
///下载地址:https://github.com/AndrewChui/CSharpiCourse
///作者:Cui Shuning
///提示:请使用https访问Github,系统在上传时，自动删除了s！！
///</summary>   

using System;
//员工工资

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new SalariedEmployee("Jhon", "111-111-111", 800M); 
            employees[1] = new HourEmployee("Karen", "222-222-222", 16.78M, 39M); 
            employees[2] = new CommissionEmployee("Sue", "333-333-333", 10000M, 0.05M);
            employees[3] = new BasePlusCommissionEmployess("Bob", "444-444-444", 20000M, 0.05M, 300M);
            foreach (var currentEmployee in employees) //foreach (Employee currentEmployee.....
            {
                Console.WriteLine(currentEmployee);
                Console.WriteLine(currentEmployee.Earn());
            }
        }
    }

    abstract class Employee
    {
        public string Name { get; private set; }
        public string SSD { get; private set; }
        public Employee(string name,string ssd)
        {
            Name = name;
            SSD = ssd;
        }
        public override string ToString()
        {
            return string.Format("Name:{0},ID:{1}", Name, SSD);
        }
        public abstract decimal Earn();
    }
    class SalariedEmployee : Employee
    {
        private decimal weekSalary;
        public decimal WeeSalary
        {
            get { return weekSalary; }
            set { weekSalary = value > 0 ? value : 0; }
        }
        public SalariedEmployee(string name,string ssd,decimal wSalary) 
            :base(name,ssd)
        {
            WeeSalary = wSalary;
        }
        public override decimal Earn()
        {
            return WeeSalary;
        }
        public override string ToString()
        {
            return string.Format("SalayeEmployee: {0}\n{1:C}",
                base.ToString(), WeeSalary);
        }
    }
    class HourEmployee : Employee
    {
        private decimal hour;
        private decimal wage;
        public decimal Hour
        {
            get { return hour; }
            set { hour = value > 0 ? value : 0; }
        }
        public decimal Wage
        {
            get { return wage; }
            set { wage = value > 0 ? value : 0; }
        }
        public HourEmployee(string name,string ssd,decimal w,decimal h)
            :base(name,ssd)
        {
            Wage = w;
            Hour = h;
        }
        public override decimal Earn()
        {
            if(Hour<=40)
            {
                return Hour * Wage;
            }
            else
            {
                return Wage * 40 + (Hour - 40) * 1.5M * Wage;
            }
        }
        public override string ToString()
        {
            return string.Format("HourlyEmployee:{0} \n HourlyWage:{1:C} " +
                "HoursWorked {2}", base.ToString(), Wage, Hour);
        }
    }
    class CommissionEmployee : Employee
    {
        private decimal grossSale;
        private decimal commissionRate;
        public decimal GrossSale
        {
            get { return grossSale; }
            set { grossSale = value > 0 ? value : 0; }
        }
        public decimal CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value > 0 ? value : 0; }
        }
        public CommissionEmployee(string name,string ssd,decimal g,decimal c)
            :base(name,ssd)
        {
            GrossSale = g;
            commissionRate = c;
        }
        public override decimal Earn()
        {
            return CommissionRate * GrossSale;
        }
        public override string ToString()
        {
            return string.Format("CommissionEmployee {0} \n " +
                "GrossSale: {1:C} Rate{2}", base.ToString(), GrossSale, CommissionRate);
        }
    }
    class BasePlusCommissionEmployess : CommissionEmployee
    {
        private decimal baseSalary;
        private decimal BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value > 0 ? value : 0; }
        }
        public BasePlusCommissionEmployess(string name,string ssd,decimal g,
            decimal c,decimal b):base(name,ssd,g,c)
        {
            BaseSalary = b;
        }
        public override decimal Earn()
        {
            return base.Earn() + BaseSalary;
        }
        public override string ToString()
        {
            return string.Format("BasePlusCommissionEmployess:{0}\n" +
                "BaseSalary{1:C}", base.ToString(), BaseSalary);
        }
    }
}
