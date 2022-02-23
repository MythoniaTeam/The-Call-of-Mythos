using System;
using System.Collections.Generic;
using System.Text;

using Xna = Microsoft.Xna.Framework;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace Mythonia.Game
{
    class GameModule
    {
        public static Camera Camera;

        private static GameMain game;
        public static GameMain Game
        {
            get
            {
                if(game == null)
                {
                    throw (new System.NullReferenceException());
                }
                return game;
            }
            set
            {
                game = value;
            }
        }

        public static void SetGame(GameMain game)
        {
            Game = game;
        }
    }
}
