using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        //public abstract decimal CalculateMonthlyPayment();

        public int GetInt() 
        {
            return 5;
        }
        public virtual decimal CalculateMonthlyPayment()
        {
            return 12000;
        }

        public int GetPaymentDays()
        {
            return 30;
        }
    }

    public class Secretary : Employee
    {
        public override decimal CalculateMonthlyPayment()
        {
            return 15000;
        }
    }

    public class Manager : Employee
    {
        public override decimal CalculateMonthlyPayment() => 30000;
    }

    public class Developer : Employee
    {
        public new int GetPaymentDays() {  return 20; }
    }
}
