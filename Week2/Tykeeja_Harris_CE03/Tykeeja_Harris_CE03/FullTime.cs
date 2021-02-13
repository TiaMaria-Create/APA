using System;
namespace Tykeeja_Harris_CE03
{
    public class FullTime : Hourly
    {
        public FullTime(string n, string add, decimal pph, decimal hpw ) : base(n, add, pph, 40)
        {
        }




        public override decimal CalculatePay()
        {
            decimal weeklyPay = _payPerHour * _hourPerWeek;
            decimal yearlyPay = weeklyPay * 52; //for 52 weeks in a year
            return yearlyPay;
        }
    }
}
