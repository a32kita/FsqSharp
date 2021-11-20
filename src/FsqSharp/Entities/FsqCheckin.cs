using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqCheckin
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

        [JsonIgnore]
        public DateTimeOffset CreatedAt
        {
            get => DateTimeOffset.FromUnixTimeSeconds(this.CreatedAtAsUnixTime);
        }

        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }

        //[JsonProperty("entities")]
        //public Object[] Entities
        //{
        //    get;
        //    set;
        //}

        [JsonProperty("shout")]
        public string Shout
        {
            get;
            set;
        }

        [JsonProperty("canonicalUrl")]
        public string CanonicalUrl
        {
            get;
            set;
        }

        [JsonProperty("canonicalPath")]
        public string CanonicalPath
        {
            get;
            set;
        }

        [JsonProperty("timeZoneOffset")]
        public long TimeZoneOffset
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

        [JsonProperty("venue")]
        public FsqVenue Venue
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

        [JsonProperty("sticker")]
        public FsqSticker Sticker
        {
            get;
            set;
        }
    }
}
