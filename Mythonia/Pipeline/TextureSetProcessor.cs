using Microsoft.Xna.Framework.Content.Pipeline;
using Mythonia.Pipeline.Json;
using Mythonia.Pipeline.Json.Model;
using Mythonia.Game.Content.Resources;

using Newtonsoft.Json;

using TInput = System.String;
using TOutput = Mythonia.Game.Content.Resources.TextureSet;


namespace PipelineExtension
{
    [ContentProcessor(DisplayName = "TextureSetProcessor")]
    class TextureSetProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            TextureSetMeta meta = JsonConvert.DeserializeObject<TextureSetMeta>(input);
            return new TextureSet(meta);
        }
    }
}
