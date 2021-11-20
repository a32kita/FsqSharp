using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    [JsonObject]
    public class FsqCheckinCollection : FsqReadOnlyCollectionBase<FsqCheckin>
    {
        //[JsonProperty("count")]
        //public int CountAll
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("items")]
        //public FsqCheckin[] Items
        //{
        //    get;
        //    set;
        //}
    }
}
