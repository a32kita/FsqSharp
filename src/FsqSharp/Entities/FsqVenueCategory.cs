using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqVenueCategory
    {
        [JsonProperty("id")]
        public string Id
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

        [JsonProperty("pluralName")]
        public string PluralName
        {
            get;
            set;
        }

        [JsonProperty("shortName")]
        public string ShortName
        {
            get;
            set;
        }

        [JsonProperty("icon")]
        public FsqIcon Icon
        {
            get;
            set;
        }

        [JsonProperty("primary")]
        public bool Primary
        {
            get;
            set;
        }
    }
}
