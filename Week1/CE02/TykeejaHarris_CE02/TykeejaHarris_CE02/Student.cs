using System;
namespace TykeejaHarris_CE02
{
    public class Student : Person

    {

        private int _grades;

        public int Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        public Student(string name, string description, int age, int grades) : base(name, description, age)
        {
            _grades = grades;
        }
    }
}
