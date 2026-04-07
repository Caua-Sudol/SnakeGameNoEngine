namespace SnakeTerminalGame
{
    public class Score
    {
      private int Value { get;set; } = 0;
      private string YourScore { get; set; } = $"Pontuação: {Value}";

      public int UpScore()
      {
        Value += 1;
      }
    }
}
