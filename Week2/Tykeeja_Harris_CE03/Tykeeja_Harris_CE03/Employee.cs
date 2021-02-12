using System;
namespace Tykeeja_Harris_CE03
{
    public class Employee
    {
        //Create protected fields for name and address
        protected string _name;
        protected string _address;

        public string Name
        {
            get { return _name; }
        }

        //constructor
        public Employee(string name, string address)
        {
            _name = name;
            _address = address;
        }




        //virtual method to calculate pay
        //otherclasses will override this class
        public virtual  void CalculatePay()
        {

        }
    }

   
}
