using System;
namespace Tykeeja_Harris_CE03
{
    public class Manager : Salaried
    {
        //private field for bonus
        private decimal bonus;

        public Manager(string name, string address, decimal salary, decimal bonus) : base (name, address, salary)
        {
        }

        //manager yearly income is base amount +bonus
    }
}
