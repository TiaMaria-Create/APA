using System;
using System.Collections.Generic;

//Tia Harris
//02/16/2021
//APA
//Synopsis: application to mimic Zoo animals and their interactions.

namespace ZooKeeperApplication
{
    public class Elephant : Animal, ITrainable
    {
        private Dictionary<string, string> _behaviors = new Dictionary<string, string>();
        public Dictionary<string, string> Behaviors { get { return _behaviors; } set { _behaviors = value; } }

        public Elephant() :base("Elephant", "Fruit & Bark") { }
      
        public override string MakeNoise()
        {
            string eleNoise = $"The elephant lifts his trunk and bellows out \"brrrrrrrmmmmmmmmphhh.\" ";
            return eleNoise;
        }

        public void Perform(string signal)
        {

            if (Behaviors.ContainsKey(signal))
            {
                foreach (KeyValuePair<string, string> x in Behaviors)
                {
                    if (signal == x.Key)
                    {
                        Console.WriteLine($"When you signaled {signal} the {Species} performed {x.Value}.");
                    }
                }
            }
            else
            {
                Console.WriteLine("The animal does not know that behavior yet. Please train them first.");
            }
        }

        public void Train(string signal, string behavior)
        {
            //store the signal and behavior in the dictionary as the key and value

            if (Behaviors.ContainsKey(signal))
            {
                Console.WriteLine($"The {Species} has already learned this behavior.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
            else
            {

                Behaviors.Add(signal, behavior);

                Console.WriteLine($"The {Species} learned a trick. When you {signal} the {Species} will {behavior}. ");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
        }
    }
}
