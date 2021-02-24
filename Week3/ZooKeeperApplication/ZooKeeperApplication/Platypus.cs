using System;
//Tia Harris
//02/16/2021
//APA
//Synopsis: application to mimic Zoo animals and their interactions.

namespace ZooKeeperApplication
{
    public class Platypus : Animal
    {
        public Platypus() :base("Platypus","Insects & Larvae")
        {
        }

        public override string MakeNoise()
        {
            string platyNoise = $"\"Smack, Smack\" The platypus whacks his tail on the ground.";
            return platyNoise;
        }
    }
}
