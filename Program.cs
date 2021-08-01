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
        static void Deck()
        {
           var suits = new List<string>() { "Hearts", "Spades", "Clubs", "Diamonds", };
           var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", };
           var deck = new List<string>();
           foreach (var suit in suits)
           {
               foreach (var rank in ranks)
               {
                   var card = $"{rank} of {suit}";
                   deck.Add(card);
               }
           }

        static void HandValue()
        {   
         //text here
        }

        static void BustHitStay()
        {   
         //text here
        }

        static void Hit()
        {   
         //text here
        }

        static void BlackJack()
        {   
         //text here
        }

        static void ClosingGreeting()
        {   
         //text here
        }

        }
    
          static void Main(string[] args)
       {
      OpeningGreeting();

      Deck();
      }
  }
}
