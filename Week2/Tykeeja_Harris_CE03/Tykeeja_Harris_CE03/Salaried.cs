using System;
namespace Tykeeja_Harris_CE03
{
    public class Salaried : Employee
    {
        //private field for salary
        protected decimal _salary;

        public Salaried(string name, string address, decimal salary) :base (name, address)
        {
        }

        public override decimal CalculatePay()
        {
            decimal yearlyPay;
            yearlyPay = _salary;
            return yearlyPay;
        }
    }
}
