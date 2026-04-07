namespace TerminalSnakeGame
{
  public class Rat
  {
    
    private string rat = "*";
    private Random random = new Random();
    private int randomX;
    private int randomY;
    private (int x, int y) ratPos;
  
    public (int randomX, int randomY) CreateRat(int x, int y, int width, int height)
    {

      randomX = random.Next(0, width);
      randomY = random.Next(0, height);

      ratPos = (randomX, randomY);

      return ratPos

    }
  }
}
