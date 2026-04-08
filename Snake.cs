namespace SnakeTerminalGame
{
  public class Snake
  {
    public string Body { get; private set; } = "#"; 
    public bool IsDead { get; private set; } = false;
    private Queue<(int x, int y)> snake = new Queue<(int, int)>();
    public int Length { get; private set; } = 0;
    public (int xH, int yH) Head { get; private set; } = (0, 0);

    public void Create(int x, int y)
    {
      
      for (int i = 0; i < 3; i++)
      {
        snake.Enqueue((x+i, y+i));
      }
      Length = snake.Count;
      Head = (x+2, y+2);
    }

    public void Dead(int x, int y, int width, int height)
    {
      if(x < width && x >= 0 && y < height && y>= 0)
      {
        Head = (x, y);

        foreach (var row in snake.Skip(1))
        {
          if(Head == (row.x, row.y))
          {
            IsDead = true;
          }
        }
      }
      else
      {
        IsDead = true;
      }
    }

    public void Bigger(int x, int y)
    {
      snake.Enqueue((x, y));
    }

    public (int, int) Move(Direction currentDirection)
    {
      int x = Head.xH;
      int y = Head.yH;

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

      snake.Enqueue((x, y));
      snake.Dequeue();
      return (x, y);
    }
  }
}
