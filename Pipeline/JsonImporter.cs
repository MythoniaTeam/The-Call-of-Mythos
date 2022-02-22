using Microsoft.Xna.Framework.Content.Pipeline;

using TImport = System.String;

namespace PipelineExtension
{ 
    [ContentImporter(".json", DisplayName = "JsonImporter", DefaultProcessor = "TextureSetProcessor")]
    public class JsonImporter : ContentImporter<TImport>
    {
        public override TImport Import(string filename, ContentImporterContext context)
        {
            return default(TImport);
        }
    }
}
