using Microsoft.Xna.Framework.Content.Pipeline;
using Mythonia

using TInput = System.String;
using TOutput = ;

namespace PipelineExtension
{
    [ContentProcessor(DisplayName = "TextureSetProcessor")]
    class TextureSetProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            return default(TOutput);
        }
    }
}
