using System;
using System.Collections.Generic;
namespace ZooKeeperApplication
{
    public class Validation
    {



        //Create a validation method to validate user input against a dynamic list of approved answers
        public static string DynamicList(string userInput, List<string> correctAnswers)
        {
            while (!(correctAnswers.Contains(userInput)))
            {


                Console.WriteLine("User and or password not found.");
                //restate the question
                Console.WriteLine($"You entered {userInput} Plese enter valid input.");
                //catch the response
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        //Create a validation method for validating a number
        public static int IntegerValidation(string num)
        {
            //create a variable to store the converted string
            int convertedNum;

            //Vaidation
            while (!(int.TryParse(num, out convertedNum)))

            {
                //Tell the user the problem
                Console.WriteLine("\r\nPlease only type in whole numbers.");

                //Restate the question
                Console.WriteLine("Please type in your number.");

                //catch the users response
                num = Console.ReadLine();

            }

            return convertedNum;
        }

        //Create a validation method for validating a string isnt left empty
        public static string StringValidation(string response)
        {

            while (string.IsNullOrWhiteSpace(response))
            {
                Console.Write("\r\nPlease do not leave this empty. Try again: ");
                response = Console.ReadLine();
            }

            //return the validated string
            return response;
        }


        //Create a validation method for validating a range of numbers
        public static int Range(int input, int a, int b)
        {
            while (input > a || input < b)
            {
                Console.WriteLine($"Please enter a number between {a} and {b}.");
                string text = Console.ReadLine();
                input = int.Parse(text);

            }
            return input;
        }
    }
}
