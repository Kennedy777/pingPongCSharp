using System;
using System.Collections.Generic;

namespace PingPong
{
   class Game
  {
    public static void Main()
    {
      Console.WriteLine("Let's play PingPong, what's your favorite number?");
      string initialString = Console.ReadLine();
      int inputNumber = int.Parse(initialString);

       for(int i=1; i<=inputNumber; i++)
        {
          if (i%5==0 && i%3==0)
          {
          Console.WriteLine("ping-pong");
          }
          else if (i%5 ==0)
          {
            Console.WriteLine("pong");
          }
          else if (i%3 == 0)
          {
            Console.WriteLine("ping");
          }
          else
          {
          Console.WriteLine(i);
          }
        }
    }
  }
}
