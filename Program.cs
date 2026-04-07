using System;
using System.Collections.Generic;
using System.Threading;

class SnakeTerminalGame
{

  static void Main(string[] args)
  {
    int width = Console.WindowWidth;
    int height = Console.WindowHeight;
    int initPosX  = width/2;
    int initPosY = height/2;
    int pointCount = 0;


    Console.Clear();

    // RenderSnake

    while (true)
    {
      
      Console.SetCursorPosition(width/2, 0);
      Console.WriteLine($"Pontuação: {pointCount}");
      ConsoleKeyInfo inputKey = Console.ReadKey(true);

     if(headSnakePos == ratPos)
        {
          pointCount += 1;
          Console.SetCursorPosition(randomX, randomY);
          Console.WriteLine(" ");
          randomX = random.Next(0, width);
          randomY = random.Next(0, height);

          ratPos = (randomX, randomY);

          Console.SetCursorPosition(randomX, randomY);
          Console.WriteLine(rat);

          snake.Enqueue((initPosX, initPosY));
        }
        else
        {
          Console.SetCursorPosition(randomX, randomY);
          Console.WriteLine(" ");
          Console.SetCursorPosition(randomX, randomY);
          Console.WriteLine(rat);
        }

        // RenderSnake

      }
      else
      {
        System.Environment.Exit(0);
      }

      Thread.Sleep(250); 
    }
  }
}
