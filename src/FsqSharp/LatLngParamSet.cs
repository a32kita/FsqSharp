using System;
using System.Collections.Generic;
using System.Text;

namespace FsqSharp
{
    public class LatLngParamSet
    {
        public double Latitude
        {
            get;
            set;
        }

        public double Longitude
        {
            get;
            set;
        }


        public override string ToString()
        {
            return
                this.Latitude.ToString("0.0000") + "," +
                this.Longitude.ToString("0.0000");
        }


        public static LatLngParamSet Parse(string s)
        {
            var splitted = s.Split(',');
            if (splitted.Length != 2)
                throw new FormatException();

            var result = new LatLngParamSet();
            result.Latitude = Double.Parse(splitted[0]);
            result.Longitude = Double.Parse(splitted[1]);

            return result;
        }
    }
}
