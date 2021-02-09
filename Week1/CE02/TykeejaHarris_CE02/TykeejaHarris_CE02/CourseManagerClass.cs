using System;
using System.Collections.Generic;



namespace TykeejaHarris_CE02
{
    public class CourseManagerClass
    {
        //create a course variable to use for the current course
        private Course _currentCourse;

        public CourseManagerClass()
        {
            //Console.WriteLine("Course Tracker:");
            //Console.WriteLine("======================================\r\n");

            //create a menu to the user to display the options
            //the options will be divided into method within the class
            //Program should run until the user chooses to exit
            bool run = true;
            while (run)
            {
                //create a list that will hold a collection of menu options
                List<string> courseTrackerMenu = new List<string>() { "Create Course", "Create Teacher", "Add Students", "Display", "Exit", };
                //instantiate a new menu object and pass the list of menu strings in as an argument
                Menu displayMenu = new Menu(courseTrackerMenu);

                UI.ActionText("Course Tracker: ");
                Console.WriteLine("======================================\r\n");
                displayMenu.DisplayMethod();

                Console.WriteLine("\r\nPlease enter your selection... ");
                string userSelection = Console.ReadLine();
                validation.IntegerValidation(userSelection);
                int selection = int.Parse(userSelection);
                validation.Range((selection), courseTrackerMenu.Count + 1, 0);

                //Begin switch statement that runs the class challenge the user selected
                switch (selection)

                {
                    case 1:
                        Console.Clear();
                        CreateCourse();
                        Console.WriteLine("\r\nPress any key to return to main menu");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        Console.Clear();
                        CreateTeacher();
                        Console.WriteLine("\r\nPress any key to return to main menu");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 3:
                        Console.Clear();
                        AddStudent();
                        Console.WriteLine("\r\nPress any key to return to main menu");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 4:
                        Console.Clear();
                        Display();
                        Console.WriteLine("\r\nPress any key to return to main menu");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 5: run = false;
                        break;


                }


            }





        }


        public void CreateCourse()
        {
            //Prompt the user the for information needed to create a new course objects
            Console.WriteLine("Hello! Please enter the course name.");
            string courseName = Console.ReadLine();
            string cName = validation.StringValidation(courseName);
            Console.WriteLine("Please enter a description of the course");
            string description = Console.ReadLine();
            validation.StringValidation(description);
            Console.WriteLine("How many students are in this course?");
            string students = Console.ReadLine();
            int studentNum = validation.IntegerValidation(students);
            //int studentNum = int.Parse(students);

            //assign the a new course object to the course variable.
            _currentCourse = new Course(cName, description, studentNum);

            //check and tell the user if the course was created.
            if (_currentCourse != null)
            {
                Console.WriteLine($"\r\nThank you! You have created the {_currentCourse.CourseName} course.");
            }
        }

        public void CreateTeacher()
        {
            //DO NOT ALLOW THE USER TO CRASH THE PROGRAM
            //create statement that checks if course has been created
            if (_currentCourse == null)
            {
                Console.WriteLine("You have to create a course first.");
            }

            else
            {
                Console.WriteLine("Please enter the teachers name: ");
                string teacherName = Console.ReadLine();
                validation.StringValidation(teacherName);
                Console.WriteLine("Please enter the teachers age: ");
                string age = Console.ReadLine();
                int teacherAge = validation.IntegerValidation(age);
                Console.WriteLine("Please enter the teachers email address.");
                string emailForArray = Console.ReadLine();
                validation.StringValidation(emailForArray);
                Console.WriteLine("What is the teachers phone number? Use Format 888-777-4444.");
                //going to leave this a string for the string array
                string phoneForArray = Console.ReadLine();
                validation.StringValidation(phoneForArray);

                //define an array for the teacher constructor
                string[] teacherKnowledge = new string[] { emailForArray, phoneForArray };
                //instantiate a new teacher object to fill out and assign to currentCourse
                Teacher newTeacher = new Teacher(teacherName, "Teacher", teacherAge, teacherKnowledge);
                //assign the teacher object to the current course's teacher
                _currentCourse.Teacher = newTeacher;

            }
        }

        public void AddStudent()

        {
            int count = 1;
            Student newStudent;

            //DO NOT ALLOW THE USER TO CRASH THE PROGRAM
            //create statement that checks if course has been created
            if (_currentCourse == null)
            {
                Console.WriteLine("You have to create a course first.");
            }

            else
            {

                Console.WriteLine($"There are {_currentCourse.Students.Length} students in this class.");

                for (int j = 0; j < _currentCourse.Students.Length; j++)
                {
                    Console.WriteLine($"What is the student number {count++}'s name?");
                    string studentName = Console.ReadLine();
                    validation.StringValidation(studentName);
                    Console.WriteLine($"What is the students age?");
                    string age = Console.ReadLine();
                    int studentAge = validation.IntegerValidation(age);
                    Console.WriteLine("What is the student's current grade in this course?");
                    string grade = Console.ReadLine();
                    int studentGrade = validation.IntegerValidation(grade);
                    newStudent = new Student(studentName, "Student", studentAge, studentGrade);

                    _currentCourse.Students[j] = newStudent;

                }
            }
        }

        public void Display()
        {
            //DO NOT ALLOW THE USER TO CRASH THE PROGRAM
            //create statement that checks if course has a teacher, students, or if course was created
            if (_currentCourse == null)
            {
                Console.WriteLine("There is nothing to display. You have to create a course first.");
            }
            else if (_currentCourse.Teacher == null)
            {
                Console.WriteLine("You have to add a teacher first.");
            }
            else if (_currentCourse.Students == null)
            {
                Console.WriteLine("You have to add students first.");
            }
            else
            {
                //display the course information
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"{_currentCourse.CourseName}");
                Console.WriteLine("----------------------------------------");

                //display the teacher info
                Console.WriteLine($"{_currentCourse.Teacher.Description}: ");
                Console.WriteLine($"Name: {_currentCourse.Teacher.Name} Age: {_currentCourse.Teacher.Age} Email: {_currentCourse.Teacher.Knowledge[0]} Phone Number: {_currentCourse.Teacher.Knowledge[1]}");

                //loop through the student array to display the student course information
                for (int i = 0; i < _currentCourse.Students.Length; i++)
                {

                    Console.WriteLine($"\r\n{_currentCourse.Students[i].Description}: ");
                    Console.WriteLine($"Name {_currentCourse.Students[i].Name} Age: {_currentCourse.Students[i].Age} Grade: {_currentCourse.Students[i].Grades} ");

                }
            }
        }
    }
}
