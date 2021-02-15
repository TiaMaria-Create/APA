using System;
namespace Tykeeja_Harris_CE03

//  Name: Harris, Tykeeja
// Date: 2/11/2021
// Course: APA
// Synopsis: CEO2
{
    public class UI
    {
        //create a method for the header
        public static void AllCapsMethod(string text)
        {
            Console.WriteLine("=============================");
            Console.WriteLine(text.ToUpper());
            Console.WriteLine("=============================");


        }



        //create a method for the footer
        public static void Footer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================");
            Console.WriteLine(text);
        }




        //created a method for the seperator
        public static void Seperator()
        {
            //Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------");
        }



        public static void Boarder(string text)
        {
            //Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================");
            Console.WriteLine(text.ToUpper());
            Console.WriteLine("=============================");


        }


        public static void HorrorTheme()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        public static void NeonTheme()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void ActionText(string text)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
        }
    }



}