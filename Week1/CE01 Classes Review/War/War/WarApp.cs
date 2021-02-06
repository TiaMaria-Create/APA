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
        private List<Player> _players = new List<Player>();
        int _scoreOne = 0;
        int _scoreTwo = 0;


        public WarApp()
        {
            // Create a variable to store a deck and get the deck from the
            // DeckUtility class's CreateDeck method

            List<Card> newDeck = DeckUtility.CreateDeck();


            // Welcome the user
            Console.WriteLine("Welcome to the Card game of War!");
            // Ask the user for the name of player 1 and player 2. Be sure to validate.
            Console.WriteLine("What is the name of player one?");
            string playerOneName = Console.ReadLine();
            Validation.StringValidation(playerOneName);
            Console.WriteLine("What is the name of player two?");
            string playerTwoName = Console.ReadLine();
            Validation.StringValidation(playerTwoName);

            // Create two player objects using the info from the user 
            Player playerOne = new Player(playerOneName);
            Player playerTwo = new Player(playerTwoName);

            // and store them in the players list you created earlier
            _players.Add(playerOne);
            _players.Add(playerTwo);

            //shuffle the deck
             List<Card> shuffledDeck = DeckUtility.ShuffleDeck(newDeck);

            // Give each player half of the deck using the DivideDeck method
            Dictionary<string, List <Card>> playerDeck = DeckUtility.DivideDeck(shuffledDeck);

            playerOne.PlayerHand = playerDeck["first_half"];
            playerTwo.PlayerHand = playerDeck["second_half"];

            Play();


        }


        public void Play() 

        {
             // Announce the two players by name
            Console.WriteLine($"There's two players! {_players[0].Name} and {_players[1].Name}.");
            // Ask the user if they would like to play a round
            Console.WriteLine("Want to play a round? [Y/N]?");
            string response = Console.ReadLine();
            Validation.YesNo(response);

            // Loop as long as the users have cards in their hands and the user
            // answers "yes" to this question

            while (response.ToUpper() == "Y")
             {

            //Console.Clear();

            while (_players[0].PlayerHand.Count != 0)
                    {
                        Round();
                        Console.WriteLine("Want to play another round? [Y/N]?");
                        response = Console.ReadLine();
                        Validation.YesNo(response);

                    }

                if (_players[0].PlayerHand.Count == 0)
                {
                    Console.WriteLine("\r\n===============================================");
                    Console.WriteLine("There are no more cards in the players decks.");
                        response = "N";
                }
            }



            // When this loop is over you should call the EndGame() method.
            EndGame();
        }

        public void Round()
        {

            //store card from player in variable to compare them and then remove the card

     

                var cardValueOne = _players[0].PlayerHand[0].CardValue;
                var cardValueTwo = _players[1].PlayerHand[0].CardValue;

                string playerOneDraw = _players[0].PlayerHand[0].DisplayCard();
                Console.WriteLine($"{_players[0].Name} played {playerOneDraw}.");
                string playerTwoDraw = _players[1].PlayerHand[0].DisplayCard();
                Console.WriteLine($"{_players[1].Name} played {playerTwoDraw}.");



                // Evaluate who won the round using the cards, adjust the score


                if (cardValueOne > cardValueTwo)
                {
                    Console.WriteLine($"{_players[0].Name} wins this hand.");
                    _scoreOne++;

                }
                else if (cardValueTwo > cardValueOne)
                {
                    Console.WriteLine($"{_players[1].Name} wins this hand.");
                    _scoreTwo++;

                }
                 
                else Console.WriteLine("It's a draw.");

                // display it using the DisplayScore method
                DisplayScore();

                // Draw a card from each player's hand. Be sure to remove it entirely.
                _players[0].PlayerHand.Remove(_players[0].PlayerHand[0]);
                _players[1].PlayerHand.Remove(_players[1].PlayerHand[0]);

        }
        public void DisplayScore()
        {
            int roundsLeft = _players[0].PlayerHand.Count;

            Console.WriteLine("\r\n===============================================");
            Console.WriteLine($"{_players[0].Name}: {_scoreOne} {_players[1].Name}: {_scoreTwo}");
            // Display each player's name and score and how many cards are left in
            // each player's hand
            Console.WriteLine($"Each player has {roundsLeft-1} cards left.");
            Console.WriteLine("===============================================");

        }

        public void EndGame()
        {
            // Announce the end of the game
            Console.WriteLine("\r\n===============================================");
            Console.WriteLine("Great game!");

            // User the player's score to determine who has won the game
            if (_scoreOne > _scoreTwo)
            {
                Console.WriteLine("\r\n--------------------------");
                Console.WriteLine($"|      {_players[0].Name} won!           |");
                Console.WriteLine("--------------------------");

            }

            else if (_scoreTwo > _scoreOne)
            {

                Console.WriteLine("\r\n--------------------------");
                Console.WriteLine($"|      {_players[1].Name} won!            |");
                Console.WriteLine("--------------------------");
                
            } else
                Console.WriteLine("No one won. It was a draw!");

            // Announce the winner or if the game was a tie.
        }
    }
}
