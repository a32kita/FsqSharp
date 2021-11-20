using System;
using System.Collections.Generic;
using System.Text;

namespace FsqSharp.ApiElements
{
    public enum FsqApiAuthParameter
    {
        None         = 0b0000,
        All          = 0b1111,

        ClientInfo   = 0b0011,

        ClientId     = 0b0001,
        ClientSecret = 0b0010,

        AccessToken  = 0b0100,
    }
}
