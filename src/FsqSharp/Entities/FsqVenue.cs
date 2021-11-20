using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqVenue
    {
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("contact")]
        public FsqContact Contact
        {
            get;
            set;
        }

        [JsonProperty("location")]
        public FsqLocation Location
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

        [JsonProperty("categories")]
        public FsqVenueCategory[] Categories
        {
            get;
            set;
        }

        [JsonProperty("verified")]
        public bool Verified
        {
            get;
            set;
        }

        [JsonProperty("stats")]
        public FsqVenueStats Stats
        {
            get;
            set;
        }

        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        [JsonProperty("urlSig")]
        public string UrlSignature
        {
            get;
            set;
        }

        [JsonProperty("like")]
        public bool Like
        {
            get;
            set;
        }

        [JsonProperty("dislike")]
        public bool Dislike
        {
            get;
            set;
        }

        [JsonProperty("ok")]
        public bool OK
        {
            get;
            set;
        }

        [JsonProperty("allowMenuUrlEdit")]
        public bool AllowMenuUrlEdit
        {
            get;
            set;
        }

        [JsonProperty("venueRatingBlacklisted")]
        public bool VenueRatingBlacklisted
        {
            get;
            set;
        }

        [JsonProperty("friendVisits")]
        public FsqFriendVisitCollection FriendVisits
        {
            get;
            set;
        }

        [JsonProperty("beenHere")]
        public FsqVenueBeenhere BeenHere
        {
            get;
            set;
        }
    }
}
