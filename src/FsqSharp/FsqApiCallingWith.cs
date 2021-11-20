using System;
using System.Collections.Generic;
using System.Text;

namespace FsqSharp
{
    public enum FsqApiCallingWith
    {
        /// <summary>
        /// (Default)
        /// If you already authenticated client with user, then call API with Access Token.
        /// If not the case, calling API with Client Id and Client Secret.
        /// </summary>
        Auto = 0,

        /// <summary>
        /// Calling API with Access Token.
        /// </summary>
        AccessToken = 1,

        /// <summary>
        /// Calling API with Client Id and Client Secret.
        /// </summary>
        ClientId = 2,
    }
}
