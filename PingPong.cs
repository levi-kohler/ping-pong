using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Please input a number:");
    string stringNumber = Console.ReadLine();
    int yourNumber = int.Parse(stringNumber);

    Console.WriteLine("Here's your number list:");
    for (int i = 0; i < yourNumber; i ++)
    {
      int numberCheck = i + 1;
      bool divisibleThree = numberCheck % 3 == 0;
      bool divisibleFive = numberCheck % 5 == 0;
      bool divisibleBoth = numberCheck % 15 == 0;
      if (divisibleBoth)
      {
        Console.WriteLine("ping-pong");
      }
      else if (divisibleThree)
      {
        Console.WriteLine("ping");
      }
      else if (divisibleFive)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(numberCheck);
      }
    }
  }
}