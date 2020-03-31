using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DataParsing_OutputCOVID_19
{
    class JsonParser
    {

        public string Parser(Stream downloaded)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            
            settings.NullValueHandling = NullValueHandling.Ignore;
            JsonConvert.DeserializeObject(reader);
            return 
        }

    }
}
