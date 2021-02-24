using System;
//Tia Harris
//02/16/2021
//APA
//Synopsis: application to mimic Zoo animals and their interactions.

namespace ZooKeeperApplication
{
    public class Owl : Animal
    {
        public Owl() :base("Owl", "Lemmings & Fish")
        {
        }

        public override string MakeNoise()
        {
            string owlHoot = $" The owl's eyes get big and he goes \"hoooooot, hoooooooot.\" ";
            return owlHoot;
        }
    }
}
