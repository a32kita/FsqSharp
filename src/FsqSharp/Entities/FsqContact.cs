using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqContact
    {
        [JsonProperty("email")]
        public string Email
        {
            get;
            set;
        }

        [JsonProperty("falcebook")]
        public string Facebook
        {
            get;
            set;
        }

        [JsonProperty("facebookUsername")]
        public string FacebookUsername
        {
            get;
            set;
        }

        [JsonProperty("facebookName")]
        public string FacebookName
        {
            get;
            set;
        }

        [JsonProperty("instagram")]
        public string Instagram
        {
            get;
            set;
        }

        [JsonProperty("twitter")]
        public string Twitter
        {
            get;
            set;
        }

        [JsonProperty("phone")]
        public string Phone
        {
            get;
            set;
        }

        [JsonProperty("formattedPhone")]
        public string FormattedPhone
        {
            get;
            set;
        }

        [JsonProperty("verifiedPhone")]
        public string VerifiedPhone
        {
            get;
            set;
        }
    }
}
