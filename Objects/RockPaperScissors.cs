using System;

namespace RockPaperScissorsCombo
{
  public class RockPaperScissors
  {
    public string RockPaperScissorsResult(string player1, string player2)
    {
      if (player1 == player2)
      {
        return "Draw";
      }
      else if (player1 == "rock" && player2 == "scissors")
      {
        return "Player 1 won";
      }
      return "";
    }
  }
}
