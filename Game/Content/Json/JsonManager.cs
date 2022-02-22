using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Mythonia.Game.Content.Json
{
    class JsonManager
    {
        /// <summary>
        /// 解析给定路径的Json文件
        /// </summary>
        /// <typeparam name="t">解析后的类型</typeparam>
        /// <param name="path">Json文件路径</param>
        /// <returns>返回解析后的t类型对象</returns>
        public static t DeserializeJson<t>(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader fileStream = new StreamReader(fs);
            string file = "";
            string line;
            while ((line = fileStream.ReadLine()) != null)
            {
                file += line;
            }



            return JsonConvert.DeserializeObject<t>(file);
        }
    }
}
