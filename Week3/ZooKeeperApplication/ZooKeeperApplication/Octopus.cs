using System;
//Tia Harris
//02/16/2021
//APA
//Synopsis: application to mimic Zoo animals and their interactions.

namespace ZooKeeperApplication
{
    public class Octopus : Animal
    {
        public Octopus() :base("Octopus", "Fish & Shrimp")
        {
            //Species = "Octopus";
            //_treat = "Fish & Shrimp";
        }

        public override string MakeNoise()
        {
            string OctoNoise = $"\"Splash, Splash.\" The octopus splashes water at you.";
            return OctoNoise;
        }
    }
}
