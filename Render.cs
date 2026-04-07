namespace SnakeTerminalGame
{
    public class Render
    {
      public void Draw(int x, int y, string draw)
      {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(draw);
      }

      public void Erase(int x, int y)
      {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(" ");
      }

    }
}
