using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqFriendVisit
    {
        [JsonProperty("visitedCount")]
        public int VisitedCount
        {
            get;
            set;
        }

        [JsonProperty("liked")]
        public bool Liked
        {
            get;
            set;
        }

        [JsonProperty("disliked")]
        public bool Disliked
        {
            get;
            set;
        }

        [JsonProperty("oked")]
        public bool Oked
        {
            get;
            set;
        }

        [JsonProperty("user")]
        public FsqUser User
        {
            get;
            set;
        }
    }
}
