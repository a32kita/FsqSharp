using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqLocation
    {
        [JsonProperty("address")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// 緯度を取得または設定します。
        /// </summary>
        [JsonProperty("lat")]
        public float Latitude
        {
            get;
            set;
        }

        /// <summary>
        /// 経度を取得または設定します。
        /// </summary>
        [JsonProperty("lng")]
        public float Longitude
        {
            get;
            set;
        }

        [JsonProperty("labeledLatLngs")]
        public FsqLabeledLatLng[] LabeledLatLngs
        {
            get;
            set;
        }

        [JsonProperty("postalCode")]
        public string PostalCode
        {
            get;
            set;
        }

        [JsonProperty("cc")]
        public string CountryCode
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

        [JsonProperty("country")]
        public string Country
        {
            get;
            set;
        }

        [JsonProperty("contextLine")]
        public string ContextLine
        {
            get;
            set;
        }

        [JsonProperty("contextGeoId")]
        public string ContextGeoId
        {
            get;
            set;
        }

        [JsonProperty("formattedAddress")]
        public string[] FormattedAddress
        {
            get;
            set;
        }
    }
}
