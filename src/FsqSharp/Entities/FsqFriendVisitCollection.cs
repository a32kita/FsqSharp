using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    [JsonObject]
    public class FsqFriendVisitCollection : FsqReadOnlyCollectionBase<FsqFriendVisit>
    {
        [JsonProperty("summary")]
        public string Summary
        {
            get;
            set;
        }
    }
}
