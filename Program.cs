using System;
using System.Collections.Generic;
using System.Threading;

class SnakeTerminalGame
{
  public enum State
    {
      norte,
      sul,
      leste,
      oeste
    }

  static void Main(string[] args)
  {
    int width = Console.WindowWidth;
    int height = Console.WindowHeight;
    int initPosX  = width/2;
    int initPosY = height/2;

    State direcaoAtual = State.leste;

    Random random = new Random();
    
    int randomX = random.Next(0, width);
    int randomY = random.Next(0, height);

    string snakePartBody = "#";
    string rat = "*";

    Queue<(int X, int Y)> snake = new Queue<(int, int)>();

    for (int i = 0; i < 3; i++)
    {
      snake.Enqueue((initPosX+i, initPosY+i));
    }

    var headSnakePos = snake.Peek();
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

    foreach (var row in snake)
    {
      Console.SetCursorPosition(row.X, row.Y);
      Console.WriteLine(snakePartBody);
    }

    while (true)
    {
 
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
      if (direcaoAtual == State.norte)
      {
        initPosY -= 1;
      }
      if(direcaoAtual == State.sul)
      {
        initPosY += 1;
      }
      if(direcaoAtual == State.oeste)
      {
        initPosX -= 1;
      }
      if(direcaoAtual == State.leste)
      {
        initPosX += 1;
      }

      if(initPosX < width && initPosX >= 0 && initPosY < height && initPosY >= 0)
      {
        snake.Enqueue((initPosX, initPosY));
        Console.Clear();
        snake.Dequeue();

        headSnakePos = snake.Peek();

        if(headSnakePos == ratPos)
        {
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
          Console.WriteLine(rat);
        }

        foreach (var row in snake)
        {
            Console.SetCursorPosition(row.X, row.Y);
            Console.WriteLine(snakePartBody); 
        }
      }
      else
      {
        System.Environment.Exit(0);
      }

      Thread.Sleep(250); 
    }
  }
}
