using System;
using System.Collections.Generic;
using System.Text;

using Xna = Microsoft.Xna.Framework;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace Mythonia.Pipeline.Json.Model
{

    public class TextureSetMeta
    {
        public string Name { get; set; }
        public int FrameAmount { get; set; }
        public Vector2 Size { get; set; }
        public Vector2 Origin { get; set; }
        public AnimationMeta[] Animation { get; set; }
    }


    public class AnimationMeta
    {
        public string Name { get; set; }
        public int Delay { get; set; }
        public int[] Frame { get; set; }
        public int[] FrameRange { get; set; }
    }

}
