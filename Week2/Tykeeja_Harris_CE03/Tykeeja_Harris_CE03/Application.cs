﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Tykeeja_Harris_CE03
{
    public class Application
    {
        //create a list of employees
        List<Employee> employees = new List<Employee>();
        FullTime fulltime;

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
                        decimal hpw = decimal.Parse(data[2]);

                        decimal pph = decimal.Parse(data[3]);
                        fulltime = new FullTime(data[0], data[1], pph, hpw);
                        //add fulltime employee to list
                        employees.Add(fulltime);


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
            List<string> userList = new List<string>() { "Add Employee", "Remove Employee", "Display Payroll", "Exit" };
            menu user = new menu(userList);

            bool display = true;
            while (display)
            {
                //Display title
                UI.ActionText("\r\nAdd Employee");
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


        //create a method that allows you to add empployees
        public void AddEmployee()
        {

            List<string> userList = new List<string>() { "FullTime", "PartTime", "Salaried", "Manager" };
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

                //ask the user for the selection
                Console.WriteLine("Please enter your selection:");
                //catch the user repsonse
                string response = Console.ReadLine();
                //make sure the response is not blank
                Validation.StringValidation(response);


              //  Begin switch statement that runs the option the user selected
                        switch (response.ToLower())

                {
                    case "fulltime":
                    case "1":
                        Console.Clear();
                        //ask for the employees name
                        Console.WriteLine("What is the employee's name?");
                        //catch the employees name
                        string empName = Console.ReadLine();
                        //validate the user entered valid input
                        Validation.StringValidation(empName);
                        //ask the employees address
                        Console.WriteLine("What is the employees address?");
                        //catch the user response
                        string empAdd = Console.ReadLine();
                        //validate the user entered valid input
                        Validation.StringValidation(empAdd);
                        //ask for the employers hourly wage
                        Console.WriteLine("How much money do they make per hour?");
                        //catch the response
                        string empHour = Console.ReadLine();
                        //validate the user entered a number
                        Validation.IntegerValidation(empHour);
                        //ask the user how many hours they work in a week
                        Console.WriteLine("How many hours do they work a week?");
                        //catch the response
                        string empWeek = Console.ReadLine();
                        //valid date the user entered a number
                        Validation.IntegerValidation(empWeek);

                        //convert the int variables to decimals
                        decimal hpw = decimal.Parse(empWeek);
                        decimal pph = decimal.Parse(empHour);

                        //create the fulltime employee
                        FullTime addFullTime = new FullTime(empName,empAdd,pph,hpw);
                        employees.Add(addFullTime);

                        //tell the user the employee has been added
                        Console.WriteLine($"\r\n{employees[employees.Count-1].Name} has been added.");
                        //allow the user to continue
                        Console.WriteLine("\r\nPress any key to continue...");
                        Console.ReadKey();
                        break;

                
                    case "2":
                    case "parttime":
                        Console.Clear();
                        Console.WriteLine("case 2");
                        break;
                    case "3":
                    case "salaried":
                        Console.Clear();
                        Console.WriteLine("case 3");
                        break;
                    case "4":
                    case "manager":
                        Console.WriteLine("case 4");
                        break;

                    default:
                        Console.WriteLine("You did not enter a valid response. Please re-enter.");
                        response = Console.ReadLine();
                        break;

                }

                display = false;
               
                }

            List<string> addList = new List<string>() { "Add Another Employee", "Return to the Main Menu" };
            menu addEmployeeList = new menu(addList);

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();

                //Display title
                UI.ActionText("\r\nEmployee Tracker");
                UI.Seperator();
                //reset the color
                Console.ResetColor();

                //Instantiate
                Console.WriteLine("\r\n");
                addEmployeeList.DisplayMethod();
                Console.WriteLine("\r\n");

                //ask the user for the selection
                Console.WriteLine("Please enter your selection:");
                //catch the user repsonse
                string options = Console.ReadLine();
                //make sure the response is not blank
                Validation.StringValidation(options);

                int newOption = int.Parse(options);
                Validation.Range((newOption), 2, 1);

                //Begin switch statement that runs the option  the user selected
                switch (newOption)

                {
                    case 1:
                        Console.Clear();
                        AddEmployee();
                        break;

                    case 2:
                        Console.Clear();
                        keepGoing = false;
                        break;


                }
            }



            //Exit Message
            Console.WriteLine("Have a nice day!");


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

                Console.WriteLine("{0,-20} {1,5}  {2,15}\n", employees[i].Name, employees[i].Address, employees[i].CalculatePay()) ;

            }


            //Press any key to continue
            Console.WriteLine("\r\nPress any key to continue.");
            Console.ReadKey();
        }
    }

}
