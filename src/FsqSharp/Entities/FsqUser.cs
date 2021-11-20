
using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqUser
    {
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty("firstName")]
        public string FirstName
        {
            get;
            set;
        }

        [JsonProperty("gender")]
        public string Gender
        {
            get;
            set;
        }

        [JsonProperty("address")]
        public string Address
        {
            get;
            set;
        }

        [JsonProperty("city")]
        public string City
        {
            get;
            set;
        }

        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }

        [JsonProperty("countryCode")]
        public string CountryCode
        {
            get;
            set;
        }

        [JsonProperty("relationship")]
        public string Relationship
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

        [JsonProperty("photo")]
        public FsqPhoto Photo
        {
            get;
            set;
        }

        [JsonProperty("friends")]
        public FsqFriendGroupCollection Friends
        {
            get;
            set;
        }

        [JsonProperty("birthday")]
        public long BirthdayAsUnixTime
        {
            get;
            set;
        }

        //public DateTime Birthday
        //{
        //}

        [JsonProperty("isAnonymous")]
        public bool IsAnonymous
        {
            get;
            set;
        }

        [JsonProperty("tips")]
        public FsqTipGroup Tips
        {
            get;
            set;
        }

        [JsonProperty("homeCity")]
        public string HomeCity
        {
            get;
            set;
        }

        [JsonProperty("bio")]
        public string Bio
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

        [JsonProperty("photos")]
        public FsqPhotoCollection Photos
        {
            get;
            set;
        }

        [JsonProperty("checkinPings")]
        public string CheckinPings
        {
            get;
            set;
        }

        [JsonProperty("pings")]
        public bool Pings
        {
            get;
            set;
        }

        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }

        [JsonProperty("mayorships")]
        public FsqMayorshipCollection Mayorships
        {
            get;
            set;
        }

        [JsonProperty("checkins")]
        public FsqCheckinCollection Checkins
        {
            get;
            set;
        }
    }
}
