﻿using System;
namespace Tykeeja_Harris_CE03

//  Name: Harris, Tykeeja
// Date: 2/11/2021
// Course: APA
// Synopsis: CEO2


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

        public string Address
        {
            get { return _address; }
        }

        //constructor
        public Employee(string name, string address)
        {
            _name = name;
            _address = address;
        }




        //virtual method to calculate pay
        //otherclasses will override this class
        public virtual decimal CalculatePay()
        {
            //This method will be overriden
            decimal weekly = 0;
            decimal hourly= 0;

           decimal yearly = weekly * hourly;

            return yearly;

        }
    }

   
}
