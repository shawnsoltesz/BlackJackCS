﻿using System;
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
    public static void DeckCreationAndShuffle()
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
        Console.WriteLine("Let's begin!\n");
        
      } 
    
    static void Main(string[] args)
    {
        OpeningGreeting();

        DeckCreationAndShuffle();

          var firstCard = deckOfCards[0];
           //Console.WriteLine(firstCard);
           Console.WriteLine($"{name}'s first card is: {firstCard}");
 
          var thirdCard = deckOfCards[2];
          Console.WriteLine($"{name}'s second card is: {thirdCard}");

          var secondCard = deckOfCards[1];
           //Console.WriteLine(firstCard);
           Console.WriteLine($"Dealer's second card is: {secondCard}");
 
          var fourthCard = deckOfCards[3];
          Console.WriteLine($"Dealer's second card is: (Face Down)");
        

    }
  }
}