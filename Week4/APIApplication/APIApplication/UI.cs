using System;
namespace APIApplication
{
    public class UI
    {
        public UI()
        {
        }

        public static void ActionText(string text)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
        }

        public static void Seperator()
        {
            //Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------");
        }



        public static void ColorTextOne(string text)
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(text);
        }

        public static void HeroTheme()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
