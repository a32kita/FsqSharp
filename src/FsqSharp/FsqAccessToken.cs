using System;
using System.Collections.Generic;
using System.Text;

namespace FsqSharp
{
    public class FsqAccessToken
    {
        public string Token
        {
            get;
            private set;
        }


        public FsqAccessToken(string token)
        {
            this.Token = token;
        }
    }
}
