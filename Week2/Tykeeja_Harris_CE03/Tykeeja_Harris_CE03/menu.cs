using System;
using System.Collections.Generic;

//  Name: Harris, Tykeeja
// Date: 2/11/2021
// Course: APA
// Synopsis: CEO2

namespace Tykeeja_Harris_CE03
{
    public class menu
    {
       
            //create a field that will hold a collection of movies options
            private List<string> _menu = new List<string>();

            public menu(List<string> menu)
            {
                _menu = menu;
            }

            //Create a method that will display the items in the array
            //Display the objects options
            public void DisplayMethod()
            {
                //Loop through the items in the  menu list to display them
                //count the movie items
                int count = 1;

                foreach (string item in _menu)
                {

                    Console.WriteLine($"[{count++}] {item}");

                }


            }


            public void DisplayMethodTwo()
            {
                //Loop through the items in the  menu list to display them
                //count the movie items

                foreach (string item in _menu)
                {

                    Console.WriteLine(item);

                }


            }

        }
    }
