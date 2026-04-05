namespace SnakeTerminalGame
{

    public enum Direction
    {
      Up,
      Down,
      Left,
      Right
    }

    public class Snake
    {
      Direction currentDirection = Direction.Left;
      string snakePartBody = "#"; 
      Queue<(int X, int Y)> snake = new Queue<(int, int)>();
      bool isDead = false;
      var headSnakePos;

     public var CreateSnake(int x, int y)
     {
       
       for (int i = 0; i < 3; i++)
       {
         snake.Enqueue((x+i, y+i));
       }

       headSnakePos = (x+2, y+2);

       return headSnakePos
     }

     public int updateDirectionSnake(int x, int y, currentDirection)
     {
        if (currentDirection == Direction.Up)
        {
          y -= 1;
        }
        if(currentDirection == Direction.Down)
        {
          y += 1;
        }
        if(currentDirection == Direction.Left)
        {
          x -= 1;
        }
        if(currentDirection == Direction.Right)
        {
          x += 1;
        }

        return x, y;
     }

    public var updatePositionSnake(int x, int y, int width, int height)
    {
            
      if(x < width && x >= 0 && y < height && y>= 0)
      {
        headSnakePos = (x, y);

        foreach (var row in snake.Skip(1))
        {
          if(headSnakePos == (row.X, row.Y))
          {
            System.Environment.Exit(0);
          }
        }

        snake.Enqueue((x, y));
        Console.SetCursorPosition(snake.Peek().X, snake.Peek().Y);
        Console.WriteLine(" ");
        snake.Dequeue();
      }
      return headSnakePos;
    }

    public void RenderSnake(Queue<int, int> snake)
    {
          
      foreach (var row in snake)
      {
        Console.SetCursorPosition(row.X, row.Y);
        Console.WriteLine(snakePartBody);
      }

    }
}
