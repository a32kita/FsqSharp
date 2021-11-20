using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqMayorshipCollection
    {
        [JsonProperty("count")]
        public int CountAll
        {
            get;
            set;
        }

        //[JsonProperty("items")]
        //public FsqMayorship[] Items
        //{
        //    get;
        //    set;
        //}
    }
}
