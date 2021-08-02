using System;
using System.Collections.Generic;

namespace BlackJackCS
{
  class Program
  {
    public static void OpeningGreeting()
    {   
      Console.WriteLine("Welcome to Black Jack\n");
      Console.Write("What is your name? ");
      var name = Console.ReadLine();
      Console.WriteLine($"It is a pleasure to meet you {name}! Press any key to begin.");
      Console.ReadLine();
    }
    public static List<string> DeckCreationAndShuffle()
    {
      var suits = new List<string>() { "Hearts", "Spades", "Clubs", "Diamonds", };
      var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", };
      var deckOfCards = new List<string>();
      foreach (var suit in suits)
      {
        foreach (var rank in ranks)
        {
            var card = $"{rank} of {suit}";
            deckOfCards.Add(card);
 
        }
      
        return deckOfCards; 

      }
    
      var numberOfCards = deckOfCards.Count;
 
      for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
        {
          var randomNumberGenerator = new Random();
          var leftIndex = randomNumberGenerator.Next(rightIndex);
            
          var leftCard = deckOfCards[leftIndex];
          var rightCard = deckOfCards[rightIndex];
            
          deckOfCards[rightIndex] = leftCard;            
          deckOfCards[leftIndex] = rightCard;
        }
        
      } 
    
    static void Main(string[] args)
    {
        OpeningGreeting();

        Console.WriteLine("Let's begin!\n");

        string myDeckOfCards = DeckCreationAndShuffle();

        string playerFirstCard = myDeckOfCards[0];
        Console.WriteLine($"Player's first card is: {playerFirstCard}");
 
        string playersecondCard = myDeckOfCards[2];
        Console.WriteLine($"Player's second card is: {playersecondCard}");

        string dealerFirstCard = myDeckOfCards[1];
        Console.WriteLine($"Dealer's first card is: {dealerFirstCard}");
 
        string dealerSecondCard = myDeckOfCards[3];
        Console.WriteLine($"Dealer's second card is: (Face Down)");

    }
  }
}