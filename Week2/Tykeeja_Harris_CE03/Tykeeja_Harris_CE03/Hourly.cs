using System;
namespace Tykeeja_Harris_CE03
{
    public class Hourly  : Employee
    {
        protected decimal _payPerHour;
        protected decimal _hourPerWeek;

        public Hourly(string name, string address, decimal pph, decimal hpw) : base (name, address)
        {
            _payPerHour = pph;
            _hourPerWeek = hpw;
            _name = name;
            _address = address;
        }
    }
}
