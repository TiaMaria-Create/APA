using System;
namespace Tykeeja_Harris_CE03
{
    public class Manager : Salaried
    {
        //private field for bonus
        protected decimal _bonus;

        public Manager(string name, string address, decimal salary, decimal bonus) : base (name, address, salary)
        {
        }

        //manager yearly income is base amount +bonus

        public override decimal CalculatePay()
        {
            decimal yearlyPay = _salary + _bonus;
            return yearlyPay;
        }
    }

}
