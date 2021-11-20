using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    [JsonObject]
    public class FsqPhotoCollection : FsqReadOnlyCollectionBase<FsqPhoto>
    {
        //[JsonProperty("count")]
        //public int CountAll
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("items")]
        //public FsqPhoto[] Items
        //{
        //    get;
        //    set;
        //}
    }
}
