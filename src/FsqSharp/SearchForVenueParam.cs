using System;
using System.Collections.Generic;
using System.Text;

namespace FsqSharp
{
    public class SearchForVenueParam
    {
        public string Query
        {
            get;
            set;
        }

        public LatLngParamSet LatLng
        {
            get;
            set;
        }

        // public string Near

        public int? Radius
        {
            get;
            set;
        }

        public int? Limit
        {
            get;
            set;
        }

        public FsqApiCallingWith CallingWith
        {
            get;
            set;
        }
    }
}
