namespace SnakeTerminalGame
{
  public class Rat
  {
    
    public string Body {get; private set;} = "*";
    private Random random = new Random();
    private int randomX;
    private int randomY;
    public (int x, int y) Position { get; private set; } = (0, 0);
  
    public void Create(int width, int height)
    {

      randomX = random.Next(0, width);
      randomY = random.Next(0, height);

      Position = (randomX, randomY);

    }
  }
}
