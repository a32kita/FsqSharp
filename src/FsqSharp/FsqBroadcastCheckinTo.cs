using System;
using System.Collections.Generic;
using System.Text;

namespace FsqSharp
{
    [Flags]
    public enum FsqBroadcastCheckinTo
    {
        None     = 0b00000000,
        All      = 0b11111111,

        Facebook = 0b00000001,
        Twitter  = 0b00000010,
    }

    internal static class FsqBroadcastCheckinToExtension
    {
        public static string ToParameterString(this FsqBroadcastCheckinTo value)
        {
            var list = new List<string>();
            
            if ((value & FsqBroadcastCheckinTo.Facebook) == FsqBroadcastCheckinTo.Facebook)
                list.Add("facebook");

            if ((value & FsqBroadcastCheckinTo.Twitter) == FsqBroadcastCheckinTo.Twitter)
                list.Add("twitter");

            return String.Join(",", list);
        }
    }
}
