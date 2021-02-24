//Tia Harris
//02/16/2021
//APA
//Synopsis: application to mimic Zoo animals and their interactions.

using System;
using System.Collections.Generic;

namespace ZooKeeperApplication
{
    public abstract class Animal
    {
        //fields and properties

        //Create a property named species. This will hold the name of the type of animal.
        public string Species { get; set; }

        //create a field named _foodconsumed to keep track of how much food the animal consumes
        private int _foodConsumed;

        //create a field named _treat to store the name of the food the animal lieks to eat
        protected string _treat;

        public Animal(string species, string treats)
        {
            Species = species;
            _treat = treats;
        }


        //method to track how much food has been consumed
        public void Eat()
        {
            string eat = $"The {Species} ate {_treat} from the feeding pale.";
            Console.WriteLine(eat);
            //store the feeding in the food consumed variable
            _foodConsumed++;

           // Console.WriteLine($"The {Species} has eaten {_foodConsumed} times.");

            if (_foodConsumed > 4)
            {
                Pooped();
                //reset the food counter to allow the poop trigger to start over
                _foodConsumed = 0;
                Console.WriteLine(eat);

            }
        }

        //method that will return a string with the sound the animal makes
        public virtual string MakeNoise()
        {
            string noise = "This animal made a noise.";
            return noise;
        }

        //method that will run if the animal eats too much
        public void Pooped()
        {
            Console.Clear();
            Console.WriteLine($"The {Species} pooped.");
        }

       
    }
}
