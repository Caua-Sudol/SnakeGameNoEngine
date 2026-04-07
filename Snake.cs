namespace SnakeTerminalGame
{
    public class Snake
    {
      private string snakePartBody = "#"; 
      private bool isDead = false;
      private Queue<(int x, int y)> snake = new Queue<(int, int)>();
      private (int xH, int yH) headSnakePos = (0, 0);

     public (int, int) CreateSnake(int x, int y)
     {
       
       for (int i = 0; i < 3; i++)
       {
         snake.Enqueue((x+i, y+i));
       }

       headSnakePos = (x+2, y+2);

       return headSnakePos
     }

     public bool IsDead(int x, int y, int width, int height)
     {
        if(x < width && x >= 0 && y < height && y>= 0)
        {
          headSnakePos = (x, y);

          foreach (var row in snake.Skip(1))
          {
            if(headSnakePos == (row.X, row.Y))
            {
              isDead = true;
              return isDead
            }
          }
        }
        else
        {
          isDead = true;
          return isDead
        }
     }

     public (int, int) Move(currentDirection)
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

        snake.Enqueue(x, y);
        snake.Dequeue();
        return (x, y);
     }
  }
