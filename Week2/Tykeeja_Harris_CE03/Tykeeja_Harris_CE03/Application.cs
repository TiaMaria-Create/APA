using System;
using System.Collections.Generic;
using System.IO;

namespace Tykeeja_Harris_CE03
{
    public class Application
    {
        //create a list of employees
        List<Employee> employees = new List<Employee>();

        public Application()
        {

            string fileLocation = "../../../output/";
            string userTextFile = "employee.txt";
            string path = fileLocation + userTextFile;
            string line;

            if (File.Exists(path))
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');

                        //Instantiate new movie object
                        Employee employee = new Employee(data[0], data[1]);
                        //add employee to list
                        employees.Add(employee); 
                        

                    }

                  
                }

            }

            else

            {
                //if no file
                //create the file
                using (File.Create(path))
                {
                    Console.WriteLine("No employees listed.");
                }
            }

            //instantiate a dynamic menu of movie objects
            List<string> userList = new List<string>() { "Add Employee", "Remove Employee", "Display Payroll", "Exit"};
            menu user = new menu(userList);

            bool display = true;
            while (display)
            {
                //define this menu in the while loop to be able to redfine for future added movies
                //menu movies = new menu(MovieTitles);

                //Instantiate
                Console.WriteLine("\r\n");
                user.DisplayMethod();
                Console.WriteLine("\r\n");


                Console.WriteLine("Please enter your selection:");
                string response = Console.ReadLine();

                Validation.IntegerValidation(response);
                int selection = int.Parse(response);
                Validation.Range((selection), userList.Count + 1, 1);

                //Begin switch statement that runs the class challenge the user selected
                switch (selection)

                {
                    case 1:
                        Console.Clear();
                        AddEmployee();
                        break;

                    case 2:
                        Console.Clear();
                        RemoveEmployee();
                        break;
                    case 3:
                        Console.Clear();
                        DisplayPayroll();
                        break;
                    default:
                        display = false;
                        break;
                      

                }
            }

            //Exit Message
            Console.WriteLine("Have a nice day!");

        }

        

        public void AddEmployee()
        {

        }


        public void RemoveEmployee()
        {

        }


        public void DisplayPayroll()
        {

        }
    }

}
