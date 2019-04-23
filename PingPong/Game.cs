using System;

using System.Collections.Generic;

namespace PingPong
{
  public class Game
  {
    public static void Main()
    {
      List<int> Numbers = new List<int>() {};
      Console.WriteLine("Let's play PingPong, what's your favorite number?");

      int inputNumber = int.Parse(Console.ReadLine());
      Numbers.Add(inputNumber);
      Console.WriteLine("Your Number is: "+ Numbers[0]);

    }
  }
}
