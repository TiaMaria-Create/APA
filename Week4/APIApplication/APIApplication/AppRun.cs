using System;
using System.Collections.Generic;

namespace APIApplication
{
    public class AppRun
    {
        public AppRun()
        {


            APIConnect api = new APIConnect();

            //create an array to store the list of characters the choose from
            List<Character> heros = new List<Character>();
            List<string> heroNames = new List<string>();

            UI.HeroTheme();
            Console.Clear();

            UI.ActionText("\r\nHeros and Villains");
           // Console.ResetColor();
            UI.Seperator();

            Console.WriteLine($"Instructions: Type in the name of your favorite super hero or villian.\r\nThere are 731 characters in this immense library!");

            UI.ColorTextOne("\r\nPopular Heros & Villains to Try");
            //Console.ResetColor();
            UI.Seperator();
            //list the id's of heros the user can choose from
            string batman = "69";
            string hanSolo = "307";
            string harryPotter = "310";
            string masterChief = "435";
            string medusa = "441";
            string sinestro = "601";
            string jamesBond = "352";

            //create the character objects
            Character bats = api.GetCharacter(batman);
            Character han = api.GetCharacter(hanSolo);
            Character harry = api.GetCharacter(harryPotter);
            Character master = api.GetCharacter(masterChief);
            Character med = api.GetCharacter(medusa);
            Character sines = api.GetCharacter(sinestro);
            Character james = api.GetCharacter(jamesBond);

            //Add them to the heros list
            heros.Add(bats);
            heros.Add(han);
            heros.Add(harry);
            heros.Add(master);
            heros.Add(med);
            heros.Add(sines);
            heros.Add(james);
            heroNames.Add(bats.Name);
            heroNames.Add(han.Name);
            heroNames.Add(harry.Name);
            heroNames.Add(master.Name);
            heroNames.Add(med.Name);
            heroNames.Add(sines.Name);
            heroNames.Add(james.Name);
             

            //Display the popular heros for the user to choose from
            Menu heroMenu = new Menu(heroNames);
            heroMenu.DisplayMethodTwo();
            //Console.WriteLine("\r\n");


            bool search = true;

            while (search) {

                Console.WriteLine("\r\nWhat character are you looking for?");
                string name = Console.ReadLine();
                string validatedName = Validation.StringValidation(name);
                // string uid = heros[1].CharacterID;
                Character c2 = api.ByName(name);
                string uid = c2.CharacterID;

                //store the selected heros power stats in a list to loop through
                List<PowerStats> powers = api.ReturnPowerStats(uid);

                //Display the Power Stats
                Console.Clear();
                UI.Seperator();
                UI.ActionText($"{name}'s PowerStats:");
                UI.Seperator();
                Console.WriteLine("\r\n");

                foreach (PowerStats ps in powers)
                {
                    Console.WriteLine($"Intelligence: {ps.Intelligence}");
                    Console.WriteLine($"Strength: {ps.Strength}");
                    Console.WriteLine($"Speed: {ps.Speed}");
                    Console.WriteLine($"Durability: {ps.Durable}");
                    Console.WriteLine($"Power: {ps.Power}");
                    Console.WriteLine($"Combat: {ps.Combat}");

                }

                search = Validation.PlayAgain("Would you like to look up another character? [Y/N]");
              //  string response = Console.ReadLine();

               
            }
        }
    }
}
