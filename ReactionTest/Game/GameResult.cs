using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactionTest.Game
{
    public class GameResult : IGameResult
    {
        public bool Success { get ; set; }
        public long ReactiontimeMillisseconds { get; set; }
    }
}
