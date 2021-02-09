using System;

namespace TykeejaHarris_CE02
{
    public class Teacher : Person

    {

        private string[] _knowledge;

        public string[] Knowledge
        {
            get { return _knowledge; }
            set { _knowledge = value; }
        }


        public Teacher(string name, string description, int age, string[] knowledge) : base(name, description, age)
        {

            _knowledge = knowledge;
        }
    }
}
