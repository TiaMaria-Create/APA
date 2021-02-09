using System;
namespace TykeejaHarris_CE02
{
    public class Course
    {
        private string _title;
        private string _description;
        private Student[] _student;
        private Teacher _teach;

        public string CourseName
        {
            get {return _title; }
            set { _title = value; }
        }

        public Student[] Students
        {
            get { return _student; }
            set { _student = value; }
        }

        public Teacher Teacher {get; set;}

        public Course(string title, string description, int students)
        {
            _title = title;
            _description = description;
            _student = new Student[students];



        }
    }
}
