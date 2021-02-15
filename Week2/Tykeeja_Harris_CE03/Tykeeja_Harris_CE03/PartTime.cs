using System;

//  Name: Harris, Tykeeja
// Date: 2/11/2021
// Course: APA
// Synopsis: CEO2

namespace Tykeeja_Harris_CE03
{
    public class PartTime : Hourly
    {
        public PartTime(string name, string address, decimal pph, decimal hpw) : base(name,address,pph, hpw)
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
