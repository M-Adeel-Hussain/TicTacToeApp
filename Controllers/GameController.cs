using Microsoft.AspNetCore.Mvc;
using TicTacToeApp.Models;

namespace TicTacToeApp.Controllers
{
    public class GameController : Controller
    {
        private static TicTacToe game = new TicTacToe();

        public IActionResult Play()
        {
            return View(game);
        }

        [HttpPost]
        public IActionResult MakeMove(int row, int col)
        {
            game.MakeMove(row, col);
            return RedirectToAction("Play");
        }

        public IActionResult Reset()
        {
            game = new TicTacToe(); // Reset game
            return RedirectToAction("Play");
        }
    }
}
