using System;
namespace Tykeeja_Harris_CE03
{
    public class FullTime : Hourly
    {
        public FullTime(string n, string add, decimal pph, decimal hpw ) : base(n, add, pph, 40)
        {
        }
    }
}
