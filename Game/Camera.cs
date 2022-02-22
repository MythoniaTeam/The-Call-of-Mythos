using System;
using System.Collections.Generic;
using System.Text;

using Xna = Microsoft.Xna.Framework;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace Mythonia.Game
{
    class Camera
    {
        Vector2 Position;
        float ZoomRate;

        public Camera(float x = 0 , float y = 0, float zoomRate = 1f)
        {
            Position = new Vector2(x, y);
            ZoomRate = zoomRate;
        }
    }
}
