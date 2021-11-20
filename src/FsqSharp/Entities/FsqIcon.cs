using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqIcon
    {
        [JsonProperty("prefix")]
        public string Prefix
        {
            get;
            set;
        }

        [JsonProperty("mapPrefix")]
        public string MapPrefix
        {
            get;
            set;
        }

        [JsonProperty("suffix")]
        public string Suffix
        {
            get;
            set;
        }
    }
}
