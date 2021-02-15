using System;

//  Name: Harris, Tykeeja
// Date: 2/11/2021
// Course: APA
// Synopsis: CEO2

namespace Tykeeja_Harris_CE03
{
    public class Manager : Salaried
    {
        //private field for bonus
        protected decimal _bonus;

        public Manager(string name, string address, decimal salary, decimal bonus) : base (name, address, salary)
        {
            _bonus = bonus;
        }

        //manager yearly income is base amount +bonus

        public override decimal CalculatePay()
        {
            decimal yearlyPay = _salary + _bonus;
            return yearlyPay;
        }
    }

}
