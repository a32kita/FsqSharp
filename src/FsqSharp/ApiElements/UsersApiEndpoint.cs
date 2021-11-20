using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using FsqSharp.Entities;

namespace FsqSharp.ApiElements
{
    public class UsersApiEndpoint : FsqApiEndpoint
    {
        internal UsersApiEndpoint(FsqClient client)
            : base(client)
        {
            // NOP
        }

        public async Task<FsqUser> GetUserAsync(GetUserParam param)
        {
            var parameters = this.GetDefaultParameters(FsqApiAuthParameter.AccessToken);
            var baseUrl = $"{ApiConstantDefinition.BaseUrl}/users/{param.UserId}";

            return await this.GetRequestAsync<FsqUser>(baseUrl, parameters);
        }

        public async Task<FsqCheckinCollection> GetUserCheckinsAsync(GetUserCheckinsParam param)
        {
            var parameters = this.GetDefaultParameters(FsqApiAuthParameter.AccessToken);
            var baseUrl = $"{ApiConstantDefinition.BaseUrl}/users/{param.UserId}/checkins";

            return await this.GetRequestAsync<FsqCheckinCollection>(baseUrl, parameters);
        }
    }
}
