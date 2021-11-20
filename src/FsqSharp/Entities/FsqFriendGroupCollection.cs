using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqFriendGroupCollection
    {
        [JsonProperty("count")]
        public int CountAll
        {
            get;
            set;
        }

        [JsonProperty("groups")]
        public FsqFriendGroup[] Groups
        {
            get;
            set;
        }
    }
}
