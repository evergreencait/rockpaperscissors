using Nancy;
using RockPaperScissorsCombo;
using System;

namespace RockPaperScissorsCombo
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      View["index.cshtml"];


      Get["/result"] = _ =>
      {
        string playerOne = Request.Query["player1-input"];
        string playerTwo = Request.Query["player2-input"];
        RockPaperScissors rockPaperScissorGame = new RockPaperScissors();
        string gameResult = rockPaperScissorGame.RockPaperScissorsResult(playerOne, playerTwo);
        return View["result.cshtml", gameResult];
      };
    }
  }
}
