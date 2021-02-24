using System;
using System.Collections.Generic;

//Tia Harris
//02/16/2021
//APA
//Synopsis: application to mimic Zoo animals and their interactions.

namespace ZooKeeperApplication
{
    public class ZooKeeper
    {
        //a list that will contain the animals
        List<Animal> animals = new List<Animal>();



        public ZooKeeper()
        {
        }



        //method that welcomes the user
        public void WelcomeUser()
        {


            //welcome the user to the program
            UI.ActionText("Zoo Keeper");
            UI.Seperator();
            //reset the color
            Console.ResetColor();

            //add an instance of each the animals
            Otter otty = new Otter();
            Octopus horse = new Octopus();
            Orca orca = new Orca();
            Elephant elephant = new Elephant();
            Platypus platypus = new Platypus();
            Owl owl = new Owl();


            //add the animals to the animal list
            animals.Add(otty);
            animals.Add(horse);
            animals.Add(orca);
            animals.Add(elephant);
            animals.Add(platypus);
            animals.Add(owl);

            //display the species name for a menu
            List<string> speciesName = new List<string>();

            foreach (Animal animal in animals)
            {
                //display trainable next to the species that is trainable
                if (animal is ITrainable)
                {
                    speciesName.Add($"{animal.Species}(Trainable)");

                }
                else
                {

                    speciesName.Add(animal.Species);

                }
            }

            //instantiate a dynamic menu
            Menu main = new Menu(speciesName);
            bool zooOpen = true;

            while (zooOpen)
            {

                //Instantiate
                Console.WriteLine("Welcome to the Zoo!\r\n");
                main.DisplayMethod();
                Console.WriteLine("\r\n");


                Console.WriteLine("\r\nPlease select an animal or press 0 to exit.");


                string response = Console.ReadLine();
                int change = Validation.IntegerValidation(response);
               int selection = Validation.Range((change), animals.Count, 0);

          
                switch (selection)

                {
                    case 0:
                        zooOpen = false;
                        break;

                    default:
                        UI.PositiveText($"You have selected the {animals[selection - 1].Species}");
                        Console.ResetColor();
                        Console.WriteLine("\r\nPress any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        List<string> userList = new List<string>() {  $"Feed the {animals[selection - 1].Species}", $"Tickle the {animals[selection - 1].Species}, so they make a sound.", $"Train the {animals[selection - 1].Species}", $"Signal the {animals[selection - 1].Species} to Perform", "Select a different animal" };
                        Menu submenu = new Menu(userList);

                        bool display = true;
                        while (display)
                        {
                            Console.Clear();

                            //Display title
                            UI.ActionText("ZooKeeper");
                            UI.Seperator();
                            //reset the color
                            Console.ResetColor();

                            //Instantiate
                            submenu.DisplayMethod();
                            Console.WriteLine("\r\n");


                            Console.WriteLine($"How would you like to interact with the {animals[selection-1].Species}?");
                            string subMenuResponse = Console.ReadLine();
                            int select = Validation.IntegerValidation(subMenuResponse);
                            Validation.Range((select), userList.Count + 1, 1);

                            switch (select)
                            {
                                case 1:
                                    Console.Clear();
                                    animals[selection - 1].Eat();
                                    Console.WriteLine("\r\nPress any key to continue...");
                                    Console.ReadLine();
                                    break;

                                case 2:
                                    Console.Clear();

                                    string noise = animals[selection - 1].MakeNoise();
                                    Console.WriteLine(noise);
                                    Console.WriteLine("\r\nPress any key to continue...");
                                    Console.ReadLine();
                                    break;

                                case 3:

                                    if (animals[selection-1] is ITrainable) 
                                   {
                                        Console.WriteLine($"what behavior would you like to train the {animals[selection - 1].Species} to do?");
                                        string behavior = Console.ReadLine();
                                        Validation.StringValidation(behavior);
                                        Console.WriteLine($"What signal are you going to use to command the {animals[selection - 1].Species} to perform?");
                                        string signal = Console.ReadLine();
                                        Validation.StringValidation(signal);
                                        ((ITrainable)animals[selection-1]).Train(signal, behavior);
                      
                                    }
                                else
                                    {
                                        UI.ErrorText("\r\nThis animal can not be trained.");
                                        Console.ResetColor();
                                        Console.WriteLine("\r\nPress any key to continue...");
                                        Console.ReadLine();
                                    }
                                    break;

                                case 4:

                                    if (animals[selection-1] is ITrainable)
                                    {
                                        if (((ITrainable)animals[selection - 1]).Behaviors.Count == 0)
                                            {

                                                Console.WriteLine("There are no signals recorded.");
                                                Console.WriteLine("Press any key to continue");
                                                Console.ReadLine();

                                        }

                                            else
                                            {
                                                //display available signals
                                                Console.Write("Available Signals: ");
                                                foreach (KeyValuePair<string, string> kvp in ((ITrainable)animals[selection - 1]).Behaviors)
                                                {
                                                    Console.Write($"{kvp.Key}, ");
                                   
                                                }
                                    
                                                Console.WriteLine("\r\nWhich signal would you like to try?");
                                                string signal = Console.ReadLine();
                                                Validation.StringValidation(signal);
                                            ((ITrainable)animals[selection - 1]).Perform(signal);
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadLine();

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("This animal is not trainable and does not know any signals.");
                                        Console.WriteLine("Press any key to continue");
                                        Console.ReadLine();
                                    }


                                    break;

                                case 5:
                                    display = false;
                                    Console.Clear();

                                    break;
                            }


                        }
                        break;

                }


            }
        }

          
        }


    
}
