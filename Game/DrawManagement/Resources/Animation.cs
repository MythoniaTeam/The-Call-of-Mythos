using System;
using System.Collections.Generic;
using System.Text;

using Xna = Microsoft.Xna.Framework;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Mythonia.Game.Draw.Resources
{
    /// <summary>
    /// 动画类，存储了一组Texture，作为动画的每帧<br/>
    /// 会按照各种数据计算当前动画应该显示的帧
    /// </summary>
    class Animation
    {        
        private List<Texture2D> TextureFrames;

        /// <summary>贴图的尺寸</summary>
        public Vector2 Size;

        /// <summary>
        /// 贴图旋转的中心<br/>
        /// default: (Size.X/2, Size.Y/2)
        /// </summary>
        private Vector2 Origin;


        public Texture2D GetTextureFrame()
        {
            return TextureFrames[0];
        }
    }
}
