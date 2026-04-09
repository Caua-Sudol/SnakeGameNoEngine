using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeTerminalGame
{
  class SnakeGame
  {

    static void Main(string[] args)
    {
      int width = Console.WindowWidth;
      int height = Console.WindowHeight;

      int x = width/2;
      int y = height/2;

      (int x, int y) move = (0, 0);
      Direction currentDirection;

      Snake snake = new Snake();
      Rat rat = new Rat();
      Score score = new Score();

      InputHandler inputHandler = new InputHandler();
      Render render = new Render();

      currentDirection = inputHandler.InitialDirection;

      Console.Clear();

      snake.Create(x, y);
      rat.Create(width, height);

      render.Draw(x, 0, score.YourScore); 
      render.Draw(rat.Position.x, rat.Position.y, rat.Body); 
      for(int i = 0; i < snake.Length; i++)
      {
        render.Draw(x+i, y+i, snake.Body);
      }

      while (true)
      {
        currentDirection = inputHandler.KeyDirection();
        move = snake.Move(currentDirection);

        snake.Dead(move.x, move.y, width, height);
        if(snake.IsDead == true)
        {
          System.Environment.Exit(0);
        }

        render.Erase( snake.Tail.x, snake.Tail.y);
        render.Draw(move.x, move.y, snake.Body);

        if(snake.Head == rat.Position)
        {
          score.UpScore();

          render.Erase(width/2, 0);
          render.Draw(width/2, 0, score.YourScore);

          render.Erase(rat.Position.x, rat.Position.y);
          rat.Create(width, height);
          render.Draw(rat.Position.x, rat.Position.y, rat.Body);

          snake.Bigger(move.x, move.y);
          render.Draw(move.x, move.y, snake.Body);
        }

        Thread.Sleep(250); 
      }
    }
  }
}
