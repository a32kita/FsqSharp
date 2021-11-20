using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqLabeledLatLng
    {
        [JsonProperty("label")]
        public string Label
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
    }
}
