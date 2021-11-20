using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqVenueBeenhere
    {
        [JsonProperty("lastCheckinExpiredAt")]
        public long LastCheckinExpiredAtAsUnixTime
        {
            get;
            set;
        }
    }
}
