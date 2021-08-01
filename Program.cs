using System;
using System.Collections.Generic;

namespace BlackJackCS
{
  class Program
  {
    static void OpeningGreeting()
    {   
      Console.WriteLine("Welcome to Black Jack\n");
      Console.WriteLine("Rules of the Game");
      Console.WriteLine("1. ");
      Console.WriteLine("2. ");
      Console.WriteLine("3. ");
      Console.WriteLine("Text\n");
      Console.WriteLine("Text\n");
    }
    static void DeckCreationAndShuffle()
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
 
        {
          var firstCard = deckOfCards[0];
           //Console.WriteLine(firstCard);
           Console.WriteLine($"The Player's first card is: {firstCard}");
 
          var secondCard = deckOfCards[1];
          Console.WriteLine($"The Dealer's first card is: {secondCard}");

          var thirdCard = deckOfCards[2];
           //Console.WriteLine(firstCard);
           Console.WriteLine($"The Player's second card is: {thirdCard}");
 
          var fourthCard = deckOfCards[3];
          Console.WriteLine($"The Dealer's second card is: (Face Down)");
        }
      } 
    
    static void Main(string[] args)
    {
        OpeningGreeting();

        DeckCreationAndShuffle();

    }
  }
}