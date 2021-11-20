using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqSticker
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

        //public FsqImage Image

        [JsonProperty("stickerType")]
        public string StickerType
        {
            get;
            set;
        }

        // public FsqStickerGroupPosition Group

        // public FsqStickerPickerPosition PickerPosition

        [JsonProperty("teaseText")]
        public string TeaseText
        {
            get;
            set;
        }

        [JsonProperty("unlockText")]
        public string UnlockText
        {
            get;
            set;
        }

        [JsonProperty("bonusText")]
        public string BonusText
        {
            get;
            set;
        }

        [JsonProperty("points")]
        public int BonusPoint
        {
            get;
            set;
        }

        [JsonProperty("bonusStatus")]
        public string BonusStatus
        {
            get;
            set;
        }
    }
}
