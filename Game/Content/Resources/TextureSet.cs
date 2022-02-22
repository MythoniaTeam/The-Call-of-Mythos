using System;
using System.Collections.Generic;
using System.Text;

using Xna = Microsoft.Xna.Framework;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;




namespace Mythonia.Game.Content.Resources
{
    /// <summary>
    /// 材质集的类
    /// </summary>
    class TextureSet
    {
        public Texture2D Texture;

        public string Name { get; set; }
        public int FrameAmount { get; set; }

        /// <summary>贴图的尺寸</summary>
        public Vector2 Size;

        /// <summary>
        /// 贴图旋转的中心<br/>
        /// default: (Size.X/2, Size.Y/2)
        /// </summary>
        private Vector2 Origin;

        public TextureSet(Xna.Content.ContentManager content, string name)
        {
            Texture = content.Load<Texture2D>(name);
            Json.Model.TextureSetMeta meta = Json.JsonManager.DeserializeJson<Json.Model.TextureSetMeta>(content.RootDirectory);
        }

    }
}
