using System;
using System.Collections.Generic;
using System.Text;

using Xna = Microsoft.Xna.Framework;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Mythonia.Game.Content.Resources;


namespace Mythonia.Game.Draw
{
    /// <summary>存储游戏对象绘制贴图时的信息</summary>
    class DrawManager
    {
        /// <summary>贴图的动画资源</summary>
        private Animation Animation;

        /*public Texture2D Texture
        {
            get
            {
                return Animation.GetTextureFrame();
            }
        }*/


        
        /// <summary>贴图的放大率<br/>default: (1, 1)</summary>
        public Vector2 Scale;

        /// <summary>贴图旋转的量 (角度制)</summary>
        public float Rotation;

        /// <summary>*当贴图是图集时使用*<br/>渲染时图片的切割范围</summary>
        private Rectangle SecRange;


        public DrawManager(Animation animation, Vector2? scale)
        {
            init(animation, scale);
        }

        public DrawManager(Animation animation, float scale = 1)
        {
            init(animation, new Vector2(scale));
        }

        private void init(Animation animation, Vector2? scale)
        {
            Animation = animation;

            //默认缩放率为(1, 1)
            Scale = scale ?? new Vector2(1);

        }


    }
}
