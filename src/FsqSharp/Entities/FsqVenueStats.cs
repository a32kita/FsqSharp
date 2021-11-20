using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqVenueStats
    {
        [JsonProperty("tipCount")]
        public int TipCount
        {
            get;
            set;
        }

        [JsonProperty("UsersCount")]
        public int UsersCount
        {
            get;
            set;
        }

        [JsonProperty("checkinsCount")]
        public int CheckinsCount
        {
            get;
            set;
        }
    }
}
