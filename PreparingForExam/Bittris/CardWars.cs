﻿using System;
using System.Numerics;
class CardWars
{
    static void Main()
    {
        checked
        {
            int allGames = int.Parse(Console.ReadLine());
            const int cardsInGame = 3;
            BigInteger globalPlayerOneScore = 0;
            BigInteger globalPlayerTwoScore = 0;
            bool xCardDrawnByPlayerOne = false;
            bool xCardDrawnByPlayerTwo = false;
            int gamesWonByPlayerOne = 0;
            int gamesWonByPlayerTwo = 0;

            for (int i = 0; i < allGames; i++)
            {
                int playerOneLocalScore = 0;
                int playerTwoLocalScore = 0;

                for (int j = 0; j < cardsInGame; j++)
                {
                    string card = Console.ReadLine();

                    switch (card)
                    {
                        case "A": playerOneLocalScore += 1;
                            break;
                        case "J": playerOneLocalScore += 11;
                            break;
                        case "Q": playerOneLocalScore += 12;
                            break;
                        case "K": playerOneLocalScore += 13;
                            break;
                        case "Z": globalPlayerOneScore *= 2;
                            break;
                        case "Y": globalPlayerOneScore -= 200;
                            break;
                        case "X": xCardDrawnByPlayerOne = true;
                            break;
                        default: playerOneLocalScore += 12 - int.Parse(card);
                            break;
                    }
                }

                for (int j = 0; j < cardsInGame; j++)
                {
                    string card = Console.ReadLine();

                    switch (card)
                    {
                        case "A": playerTwoLocalScore += 1;
                            break;
                        case "J": playerTwoLocalScore += 11;
                            break;
                        case "Q": playerTwoLocalScore += 12;
                            break;
                        case "K": playerTwoLocalScore += 13;
                            break;
                        case "Z": globalPlayerTwoScore *= 2;
                            break;
                        case "Y": globalPlayerTwoScore -= 200;
                            break;
                        case "X": xCardDrawnByPlayerTwo = true;
                            break;
                        default: playerTwoLocalScore += 12 - int.Parse(card);
                            break;
                    }
                }

                if (xCardDrawnByPlayerOne && xCardDrawnByPlayerTwo)
                {
                    globalPlayerOneScore += 50;
                    globalPlayerTwoScore += 50;

                    xCardDrawnByPlayerOne = false;
                    xCardDrawnByPlayerTwo = false;
                }

                if (xCardDrawnByPlayerOne)
                {

                    break;
                }
                else if (xCardDrawnByPlayerTwo)
                {

                    break;
                }

                if (playerOneLocalScore > playerTwoLocalScore)
                {
                    globalPlayerOneScore += playerOneLocalScore;
                    gamesWonByPlayerOne++;
                }
                else if (playerOneLocalScore < playerTwoLocalScore)
                {
                    globalPlayerTwoScore += playerTwoLocalScore;
                    gamesWonByPlayerTwo++;
                }
            }

            if (xCardDrawnByPlayerOne)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");

            }
            else if (xCardDrawnByPlayerTwo)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");

            }
            else if (globalPlayerOneScore > globalPlayerTwoScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: " + globalPlayerOneScore);
                Console.WriteLine("Games won: " + gamesWonByPlayerOne);
            }
            else if (globalPlayerOneScore < globalPlayerTwoScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: " + globalPlayerTwoScore);
                Console.WriteLine("Games won: " + gamesWonByPlayerTwo);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: " + globalPlayerOneScore);
            }
        }
    }
}