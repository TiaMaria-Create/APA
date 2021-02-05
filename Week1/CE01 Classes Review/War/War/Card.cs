using System;
namespace War

//  Name: Harris, Tykeeja
// Date: 02/3/2021
// Course: APA
// Synopsis: Lesson 1.1 | Class Review


{
    public class Card
    {
        // Create a private field for the card's suit (This should be an integer)
        // It will eventually store a number from 0 to 3
        private int _cardSuit;

        //============================================================

        //need properties for the suit and value
        //Define a property for the card's suit
        public int CardSuite
        {
            get { return _cardSuit; }
        }

        // Create a public property for the value of the card. This will hold a
        // number from 1 to 13

        public int CardValue { get; set;}

        //============================================================

        //constructor that has a parameter so it can accept the suit and value of the class.
        // Create a constructor that accepts suit and value in parameters and
        // sets the value and suit classmember variables accordingly

        public Card (int suit, int value)
        {
            _cardSuit = suit;
            CardValue = value;
        }

        //============================================================

        //Create a method to display the value of the card. This should return a string.
        // Assume a suit of 0 is Spades, 1 is Hearts, 2 is Diammonds & 3 is Clubs
        // If the card value is 12 and suit is 0 the card
        // then this method should return "The Queen of Spades"

        public string DisplayCard ()
        {
            string suit = "blank";
            string value = CardValue.ToString();

            //set the suit of the card
            if (_cardSuit == 0)
            {
                suit = "Spades";
            }
            else if (_cardSuit == 1)
            {
                suit = "Hearts";
            }
            else if (_cardSuit == 2)
            {
                suit = "Diamonds";
            }
            else if (_cardSuit == 3)
            {
                suit = "Clubs";
            }


            //set the value of the card
            if (CardValue < 12 && CardValue < 0)
            {
                value = CardValue.ToString();
            }
            else if (CardValue == 12)
            {
                value = "Queen";
            }
            else if (CardValue == 13)
            {
                value = "King";
            }
            else if (CardValue == 0)
            {
                value = "Ace";
            }

            //return a string that reveals the suit and value of the card
            return value + " of " + suit;
        }

    }
}
