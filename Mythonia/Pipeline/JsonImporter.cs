using Microsoft.Xna.Framework.Content.Pipeline;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;



using TImport = System.String;

namespace PipelineExtension
{ 
    [ContentImporter(".json", DisplayName = "JsonImporter", DefaultProcessor = "TextureSetProcessor")]
    public class JsonImporter : ContentImporter<TImport>
    {
        public override TImport Import(string filename, ContentImporterContext context)
        {

            return File.ReadAllText(filename);
        }
    }
}
