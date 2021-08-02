using System;
using System.Collections.Generic;

namespace BlackJackCS
{
  class Program
  {
    public static string OpeningGreeting()
    {   
      Console.WriteLine("Welcome to Black Jack\n");
      Console.Write("What is your name? ");
      var name = Console.ReadLine();
      Console.WriteLine($"Hi {name}, press any key to begin.");
      Console.ReadLine();
      Console.Write("");
      
      return name;
    }
    
    
    static void Main(string[] args)
    {
        OpeningGreeting();

        Console.WriteLine("Let's begin!\n"); 
    }
  }
}