using System;
using System.Collections.Generic;
using System.Text;

namespace FsqSharp
{
    public class CreateCheckinParam
    {
        public string VenueId
        {
            get;
            set;
        }

        public string EventId
        {
            get;
            set;
        }

        public string Shout
        {
            get;
            set;
        }

        //public string mentions

        public FsqBroadcastCheckinTo Broadcast
        {
            get;
            set;
        }

        public LatLngParamSet LatLng
        {
            get;
            set;
        }
    }
}
