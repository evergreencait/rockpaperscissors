using Xunit;
using System;
using System.Collections.Generic;

namespace RockPaperScissorsCombo
{
  public class RockPaperScissorsTest
  {
    [Fact]
    public void RockPaperScissorsTest_ForUserInputRR_Draw()
    {
      RockPaperScissors testRockRock = new RockPaperScissors();
      Assert.Equal("Draw", testRockRock.RockPaperScissorsResult("rock", "rock"));
    }

    [Fact]
    public void RockPaperScissorsTest_ForUserInputRS_P1Won()
    {
      RockPaperScissors testRockScissors = new RockPaperScissors();
      Assert.Equal("Player 1 won", testRockScissors.RockPaperScissorsResult("rock", "scissors"));
    }
  }
}
