using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqTipGroup
    {
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("count")]
        public int CountAll
        {
            get;
            set;
        }

        [JsonProperty("items")]
        public FsqTip[] Items
        {
            get;
            set;
        }
    }
}
