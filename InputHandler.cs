namespace SnakeTerminalGame
{

    public enum Direction
    {
      Up,
      Down,
      Left,
      Right
    }  

    public class InputHandler
    {
      public Direction InitialDirection { get; private set;} = Direction.Left;
      private Direction currentDirection;
      private Dictionary<ConsoleKey, Direction> compass = new Dictionary<ConsoleKey, Direction>
      {
        {ConsoleKey.W, Direction.Up},
        {ConsoleKey.S, Direction.Down},
        {ConsoleKey.D, Direction.Left},
        {ConsoleKey.A, Direction.Right}
      };

      public Direction KeyDirection(ConsoleKeyInfo inputKey)
      {
        if(Console.KeyAvailable)
        {
          if(compass.TryGetValue(inputKey.Key, out Direction direction))
          {
            if (direction == Direction.Up && currentDirection!= Direction.Down)
            {
              currentDirection= direction;
            }
            if (direction == Direction.Down && currentDirection!= Direction.Up)
            {
              currentDirection= direction;
            }
            if (direction == Direction.Left && currentDirection!= Direction.Right)
            {
              currentDirection= direction;
            }
            if (direction == Direction.Right && currentDirection!= Direction.Left)
            {
              currentDirection= direction;
            }
          }
          else
          {
            System.Environment.Exit(1);
          }
          return currentDirection;
        }
        return currentDirection;
      }
    }
}
