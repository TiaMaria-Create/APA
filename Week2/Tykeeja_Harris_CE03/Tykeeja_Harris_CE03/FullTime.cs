using System;
namespace Tykeeja_Harris_CE03
{
    public class FullTime : Hourly
    {
        const decimal _fullTime_hours = 40;

        public FullTime(string n, string add, decimal pph) : base(n, add, pph, _fullTime_hours)
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
