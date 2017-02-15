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
  }
}
