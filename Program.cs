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

    Random random = new Random();
    
    int randomX = random.Next(0, width);
    int randomY = random.Next(0, height);

    var ratPos = (randomX, randomY);

    Dictionary<ConsoleKey, State> bussola = new Dictionary<ConsoleKey, State>
    {
      {ConsoleKey.W, State.norte},
      {ConsoleKey.S, State.sul},
      {ConsoleKey.D, State.leste},
      {ConsoleKey.A, State.oeste}
    };

    ConsoleKeyInfo key;

    Console.Clear();

    // RenderSnake

    while (true)
    {
      
      Console.SetCursorPosition(width/2, 0);
      Console.WriteLine($"Pontuação: {pointCount}");
 
      if(Console.KeyAvailable)
      {
        key = Console.ReadKey(true);
        
        if(bussola.TryGetValue(key.Key, out State direcao))
        {
          if (direcao == State.norte && direcaoAtual != State.sul)
          {
            direcaoAtual = direcao;
          }
          if (direcao == State.sul && direcaoAtual != State.norte)
          {
            direcaoAtual = direcao;
          }
          if (direcao == State.leste && direcaoAtual != State.oeste)
          {
            direcaoAtual = direcao;
          }
          if (direcao == State.oeste && direcaoAtual != State.leste)
          {
            direcaoAtual = direcao;
          }
        }
        else
        {
          System.Environment.Exit(1);
        }
      }

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
