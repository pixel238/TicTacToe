using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Models;
using TicTacToe.Services;

namespace TicTacToe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        static int count = 0;
        // GET: api/Game
        [HttpGet]
        public Array Get()
        {
            return Board.board;
        }

        // GET: api/Game/12
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            count++;
            int x = id / 10-1;
            int y = id % 10-1;
            int player = count % 2;
            if (Board.board[x, y] == -1)
            {
                Board.board[x, y] = player;
                WinChecker winChecker = new WinChecker();
                if (winChecker.Won(player, x, y))
                {
                    return Ok("You win");
                }
            }
            else
            {
                count--;
                return BadRequest("Place already taken");
            }
            if (count == Board.board.Length)
                return Ok("DRAW");

            return Ok(Board.board);
        }

        // PUT: api/Game/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Board newBoard)
        {
            
        }

        // DELETE: api/ApiWithActions/5
        [Route("restart")]
        [HttpDelete("{id}")]
        public Array Delete(int id)
        {
            Board.board = new int[,] { { -1, -1, -1 }, { -1, -1, -1 }, { -1, -1, -1 } };
            count = 0;
            return Board.board;
        }
    }
}
