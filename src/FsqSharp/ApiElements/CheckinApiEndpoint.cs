using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using FsqSharp.Entities;

namespace FsqSharp.ApiElements
{
    public class CheckinApiEndpoint : FsqApiEndpoint
    {
        public CheckinApiEndpoint(FsqClient client)
            : base(client)
        {
            // NOP
        }

        public async Task<FsqCheckin> GetCheckinAsync(GetCheckinParam param)
        {
            var parameters = this.GetDefaultParameters(FsqApiAuthParameter.AccessToken);
            var baseUrl = $"{ApiConstantDefinition.BaseUrl}/checkins/{param.CheckinId}";

            return await this.GetRequestAsync<FsqCheckin>(baseUrl, parameters);
        }

        public async Task<FsqCheckin> CreateCheckinAsync(CreateCheckinParam param)
        {
            var parameters = this.GetDefaultParameters(FsqApiAuthParameter.AccessToken);
            var baseUrl = $"{ApiConstantDefinition.BaseUrl}/checkins/add";

            // Required parameters
            parameters["venueId"] = param.VenueId;
            parameters["ll"] = param.LatLng.ToString();

            // Option parameters
            if (String.IsNullOrEmpty(param.EventId) == false)
                parameters["eventId"] = param.EventId;
            if (String.IsNullOrEmpty(param.Shout) == false)
                parameters["shout"] = param.Shout;
            if (param.Broadcast != FsqBroadcastCheckinTo.None)
                parameters["broadcast"] = param.Broadcast.ToParameterString();

            return await this.PostRequestAsync<FsqCheckin>(baseUrl, parameters);
        }
    }
}
