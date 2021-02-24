using System;
using System.Collections.Generic;

//Tia Harris
//02/16/2021
//APA
//Synopsis: application to mimic Zoo animals and their interactions.


namespace ZooKeeperApplication
{


    public interface ITrainable
    {
        //Property to store and retrieve the behaviors for the animal to perform and learn
        public Dictionary<string, string> Behaviors { get; set; }

        public string Species { set;}

        public void Perform(string signal);
      

        public void Train(string signal, string behavior);
        

    }


}
