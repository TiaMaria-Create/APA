using System;
using System.Collections.Generic;

//  Name: Harris, Tykeeja
// Date: 02/3/2021
// Course: APA
// Synopsis: Lesson 1.1 | Class Review


namespace War
{
    public class Player
    {
        // Create a List that will hold the player's hand of cards.
        // This should be a list of card objects.
        List<Card> playerHand = new List<Card>();

        //============================================================

        //store the player's name and score in such a way that you can access it from the WarApp application class
        // Create a property to store the player's name
        public string Name { get; set; }
        // Create a property to store the player's score
        public int Score { get; set; }

        //============================================================

        // Create a constructor method that accepts the name
        // and stores the name in the Name Property
        public Player (string name)
        {
            Name = name;
        }

        //============================================================

    }
}
