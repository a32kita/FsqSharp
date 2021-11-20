using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqPhoto
    {
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty("createdAt")]
        public long CreatedAtAsUnixTime
        {
            get;
            set;
        }

        [JsonProperty("source")]
        public FsqSource Source
        {
            get;
            set;
        }

        [JsonProperty("prefix")]
        public string Prefix
        {
            get;
            set;
        }

        [JsonProperty("suffix")]
        public string Suffix
        {
            get;
            set;
        }

        [JsonProperty("width")]
        public int Width
        {
            get;
            set;
        }

        [JsonProperty("height")]
        public int Height
        {
            get;
            set;
        }

        [JsonProperty("visibility")]
        public string Visibility
        {
            get;
            set;
        }

        [JsonProperty("venue")]
        public FsqVenue Venue
        {
            get;
            set;
        }

        [JsonProperty("checkin")]
        public FsqCheckin Checkin
        {
            get;
            set;
        }
    }
}
