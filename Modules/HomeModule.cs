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


      Post["/result"] = _ =>
      {
        // playerOne: storing an input value from Player 1 (ex: "rock", "paper", "scissors")
        string playerOne = Request.Form["player1-input"];
        // playerTwo: storing an input value from Player 2 (ex: "rock", "paper", "scissors")
        string playerTwo = Request.Form["player2-input"];
        // Storing RockPaperScissors (class) from the Object cs file as a variable called 'rockPaperScissorGame'
        RockPaperScissors rockPaperScissorGame = new RockPaperScissors();
        // Storing the returned value (ex: "Draw", "Player 1 won", "Player 2 won") by passing two string parameters into the method called 'RockPaperScissorsResult' as a variable called 'gameResult'
        string gameResult = rockPaperScissorGame.RockPaperScissorsResult(playerOne, playerTwo);
        // Passing in the returned valled called gameResult so that we can display the result on result.cshtml
        return View["result.cshtml", gameResult];
      };
    }
  }
}
