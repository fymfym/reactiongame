using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactionTest.Game
{
    public interface IGameResult
    {
        bool Success { get; set; }
        long ReactiontimeMillisseconds { get; set; }

    }
}
