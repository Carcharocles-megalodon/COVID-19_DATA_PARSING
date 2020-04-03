using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections;

namespace downloader
{
    class JsonParser
    {
        public void Parse(string path)
        {

            string parsed = File.ReadAllText(path);
            var send = JsonConvert.DeserializeObject<IDictionary<string,List<Country>>>(parsed);
          
        }


    }
}
