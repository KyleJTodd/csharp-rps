using System;
using System.Threading;

namespace rps2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Beep();
      Console.Clear();
      Console.WriteLine(@"
__________               __                           
\______   \ ____   ____ |  | __                       
 |       _//  _ \_/ ___\|  |/ /                       
 |    |   (  <_> )  \___|    <                        
 |____|_  /\____/ \___  >__|_ \                       
        \/            \/     \/  ");
      Thread.Sleep(500);
      Console.WriteLine(@"
__________                                            
\______   \_____  ______   ___________                
 |     ___/\__  \ \____ \_/ __ \_  __ \               
 |    |     / __ \|  |_> >  ___/|  | \/               
 |____|    (____  /   __/ \___  >__|                  
                \/|__|        \/        ");
      Console.Beep();
      Thread.Sleep(500);
      Console.WriteLine(@"
  _________      .__                                  
 /   _____/ ____ |__| ______ _________________  ______
 \_____  \_/ ___\|  |/  ___//  ___/  _ \_  __ \/  ___/
 /        \  \___|  |\___ \ \___ (  <_> )  | \/\___ \ 
/_______  /\___  >__/____  >____  >____/|__|  /____  >
        \/     \/        \/     \/                 \/ ");
      Console.Beep();
      Thread.Sleep(500);
      string greeting = "Rock, Paper, Scissors";

      for (int i = 0; i < greeting.Length; i++)
      {
        Thread.Sleep(100);
        Console.Write(greeting[i]);
      }
      System.Console.WriteLine();
      Thread.Sleep(500);

      Console.WriteLine("Make Your Choice: ");

      string pChoice = Console.ReadLine().ToLower();

      Random rnd = new Random();
      int cResult = rnd.Next(1, 3);
      Thread.Sleep(500);
      if (cResult == 1 && pChoice == "paper")
      {
        System.Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
Computer Chose Rock");


        System.Console.WriteLine("You have defeated the machine!");
      }
      else if (cResult == 2 && pChoice == "paper")
      {
        System.Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
        Computer Chooses Scissors ");
        System.Console.WriteLine("You have been destroyed by the machine!");
      }
      else if (cResult == 3 && pChoice == "paper")
      {
        System.Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
        Computer Chooses Paper ");
        System.Console.WriteLine("You have tied with the machine...");
      }
      else if (cResult == 1 && pChoice == "rock")
      {
        System.Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
Computer Chose Rock ");
        System.Console.WriteLine("You have tied with the machine...");
      }
      else if (cResult == 2 && pChoice == "rock")
      {
        System.Console.WriteLine(@"
    _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
Computer Chooses Paper ");
        System.Console.WriteLine("You have been destroyed by the machine!");
      }
      else if (cResult == 3 && pChoice == "rock")
      {
        System.Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
        Computer Chooses Scissors ");
        System.Console.WriteLine("You have destroyed the machine!");
      }
      else if (cResult == 1 && pChoice == "scissors")
      {
        System.Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
Computer Chose Rock ");
        System.Console.WriteLine("You have been destroyed by the machine!");
      }
      else if (cResult == 2 && pChoice == "scissors")
      {
        System.Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
Computer Chooses Paper ");
        System.Console.WriteLine("You have destroyed the machine!");
      }
      else if (cResult == 3 && pChoice == "scissors")
      {
        System.Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
 Computer Chooses Scissors ");
        System.Console.WriteLine("You have tied with the machine...");
      }
    }
  }
}
