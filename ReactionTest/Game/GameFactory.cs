using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactionTest.Game
{
    public class GameFactory
    {
        public enum GameTypes
        {
            PressTheLitButton,
            RepeatTheCombination
        }


        public IGame Construct(GameTypes game)
        {
            switch (game)
            {
                case GameTypes.PressTheLitButton:
                    return new PressTheLitButton();
                case GameTypes.RepeatTheCombination:
                    return new RepeatTheCombo();
            }

            return null;
        }
    }
}
