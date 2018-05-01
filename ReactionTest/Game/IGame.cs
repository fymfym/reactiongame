using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactionTest.Hardware;

namespace ReactionTest.Game
{
    public delegate void OnGameStopDelegate();
    public delegate void OnGameresultDelegate(IGameResult gameSucess);

    public interface IGame
    {
        event OnGameStopDelegate OnGameStop;
        event OnGameresultDelegate OnGameResult;

        void SetUp(IHardware hardware);

        void StartGame();
        void StopGame();

    }
}
