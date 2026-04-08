namespace SnakeTerminalGame
{
    public class Score
    {
      private int Value { get; set; } = 0;
      public string YourScore { get; private set; } = "";

      public Score()
      {
        this.Value = Value;
        this.YourScore = $"Pontuação: {Value}";
      }

      public void UpScore()
      {
        this.Value += 1;
        this.YourScore = $"Pontuação: {Value}";
      }
    }
}
