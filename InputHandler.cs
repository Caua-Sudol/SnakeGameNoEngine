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
      private Direction InitialDirection { get; set;} = Direction.Left;
      private Dictionary<ConsoleKey, Direction> compass = new Dictionary<ConsoleKey, Direction>
      {
        {ConsoleKey.W, Direction.Up},
        {ConsoleKey.S, Direction.Down},
        {ConsoleKey.D, Direction.Left},
        {ConsoleKey.A, Direction.Right}
      };

      public enum KeyDirection(inputKey)
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
          return currentDirection
        }
      }
    }
}
