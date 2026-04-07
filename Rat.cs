namespace SnakeTerminalGame
{
  public class Rat
  {
    
    private string Body {get; set;} = "*";
    private Random random = new Random();
    private int randomX;
    private int randomY;
    private (int x, int y) Position { get; set; } = (0, 0);
  
    public void Create(int width, int height)
    {

      randomX = random.Next(0, width);
      randomY = random.Next(0, height);

      Position = (randomX, randomY);

    }
  }
}
