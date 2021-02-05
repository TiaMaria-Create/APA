using System;
using System.Collections.Generic;

//  Name: Harris, Tykeeja
// Date: 02/3/2021
// Course: APA
// Synopsis: Lesson 1.1 | Class Review


namespace War
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the war application

            Console.Title = "BlackJackLight";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  .-----------. ");
            Console.WriteLine(" /------------/|");
            Console.WriteLine("/.-----------/||");
            Console.WriteLine("| ♥       ♥  |||");
            Console.WriteLine("| Let's Play |||");
            Console.WriteLine("|            |||");
            Console.WriteLine("|     ♥      |||");
            Console.WriteLine("|            |||");
            Console.WriteLine("|    War     |||");
            Console.WriteLine("| ♥       ♥  ||/");
            Console.WriteLine("\\-----------./  ");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------");



            Card test = new Card(2, 7);
            string testString = test.DisplayCard();
            Console.WriteLine(testString);

      
        }
    }
}
