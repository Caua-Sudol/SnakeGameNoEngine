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

      Console.Clear();

      snake.Create(x, y);
      rat.Create(width, height);

      render.Draw(x, 0, score.YourScore); 
      render.Draw(rat.Position.x, rat.Position.y, rat.Body); 
      for(int i = 0; i <= snake.Length; i++)
      {
        render.Draw(x, y, snake.Body);
      }

      while (true)
      {
        move = snake.Move(inputHandler.InitialDirection);
        render.Erase(x , y);
        render.Draw(move.x, move.y, snake.Body);

        ConsoleKeyInfo inputKey = Console.ReadKey(true);

        currentDirection = inputHandler.KeyDirection(inputKey);

        move = snake.Move(currentDirection);
        render.Erase(x , y);
        render.Draw(move.x, move.y, snake.Body);

        if(snake.Head == rat.Position)
        {
          score.UpScore();

          render.Erase(width/2, 0);
          render.Draw(width/2, 0, score.YourScore);

          render.Erase(rat.Position.x, rat.Position.y);
          rat.Create(width, height);
          render.Draw(rat.Position.x, rat.Position.y, rat.Body);

          snake.Bigger(x, y);
          render.Draw(move.x, move.y, snake.Body);
        }

        snake.Dead(move.x, move.y, width, height);

        if(snake.IsDead == true)
        {
          System.Environment.Exit(0);
        }
        Thread.Sleep(250); 
      }
    }
  }
}
