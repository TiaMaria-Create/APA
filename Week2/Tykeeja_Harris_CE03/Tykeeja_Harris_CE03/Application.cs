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
           

            //Add employees from text file
            //define a string for the file location of the text file
            string fileLocation = "../../../output/";
            //define a variable for the file name
            string userTextFile = "employee.txt";
            //define a variable for the file name and location
            string path = fileLocation + userTextFile;
            //define a string to store the lines from the text file
            string line;

            //check if file exists
            if (File.Exists(path))
            {
                //read through the entire file using streamreader
                using (StreamReader sr = new StreamReader(path))
                {
                    //loop through each line
                    while ((line = sr.ReadLine()) != null)
                    {
                        //split each line into an array
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
                //Display title
                UI.ActionText("\r\nEmployee Tracker");
                UI.Seperator();
                //reset the color
                Console.ResetColor();

                //Instantiate
                Console.WriteLine("\r\n");
                user.DisplayMethod();
                Console.WriteLine("\r\n");


                Console.WriteLine("Please enter your selection:");
                string response = Console.ReadLine();

                Validation.IntegerValidation(response);
                int selection = int.Parse(response);
                Validation.Range((selection), 4, 1);

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
                    case 4:
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

            //Display title
            UI.ActionText("\r\nEmployees");
            UI.Seperator();
            //reset the color
            Console.ResetColor();


            //Display all the employees in the list
            Console.WriteLine("\n{0,-20} {1,5}  {2, 20}\n", "Name", "Address", "Pay");
            //loop through the employee list to display the employee data
            for (int i =0; i < employees.Count; i++)
            {

                Console.WriteLine("{0,-20} {1,5}  {2,15}\n", employees[i].Name, employees[i].Address,"$10000" );

            }


            //Press any key to continue
            Console.WriteLine("\r\nPress any key to continue.");
            Console.ReadKey();
        }
    }

}
