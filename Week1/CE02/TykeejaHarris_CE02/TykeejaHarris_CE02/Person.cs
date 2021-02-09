using System;
namespace TykeejaHarris_CE02
{
    public class Person
    {
        //fields
        protected string _name;
        private string _description;
        protected int _age;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {

            get { return _age; }
            set { _age = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //constructor
        public Person(string name, string description, int age)

        {
            _name = name;
            _description = description;
            _age = age;
        }
    }
}
