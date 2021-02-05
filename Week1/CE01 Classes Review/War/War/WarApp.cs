using System;
using System.Collections.Generic;

//  Name: Harris, Tykeeja
// Date: 02/3/2021
// Course: APA
// Synopsis: Lesson 1.1 | Class Review

namespace War
{
    public class WarApp
    {
        //create a private list that holds your Players.
        private List<Player> players = new List<Player>();

        public WarApp()
        {
            // Create a variable to store a deck and get the deck from the
            List<Card> newDeck = DeckUtility.CreateDeck();
            // DeckUtility class's CreateDeck method

            // Welcome the user
            Console.WriteLine("Welcome to the Card game of War!");
            // Ask the user for the name of player 1 and player 2. Be sure to validate.
            Console.WriteLine("What is the name of player one?");
            string playerOneName = Console.ReadLine();
            Console.WriteLine("What is the name of player one?");
            string playerTwoName = Console.ReadLine();

            // Create two player objects using the info from the user 
            Player playerOne = new Player(playerOneName);
            Player playerTwo = new Player(playerTwoName);

            // and store them in the players list you created earlier
            players.Add(playerOne);
            players.Add(playerTwo);
            // Give each player half of the deck using the DivideDeck method

            Play();
        }
        public void Play()
        {
            // Announce the two players by name
            // Ask the user if they would like to see a round
            Console.WriteLine("Do You want to play another hand?");
            // Loop as long as the users have cards in their hands and the user
            // answers "yes" to this question

            // When this loop is over you should call the EndGame() method.
        }
        public void Round()
        {
            // Draw a card from each player's hand. Be sure to remove it entirely.
            // Evaluate who won the round using the cards, adjust the score, and
            // display it using the DisplayScore method

        }
        public void DisplayScore()
        {
            // Display each player's name and score and how many cards are left in
            // each player's hand
        }
        public void EndGame()
        {
            // Announce the end of the game
            // User the player's score to determine who has won the game
            // Announce the winner or if the game was a tie.
        }
    }
}
