using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using FsqSharp.Entities;

namespace FsqSharp.ApiElements
{
    public class VenueApiEndpoint : FsqApiEndpoint
    {
        internal VenueApiEndpoint(FsqClient client)
            : base(client)
        {
            // NOP
        }

        public async Task<FsqVenue> GetVenueAsync(GetVenueParam param)
        {
            // NOTE: This API supports both calling with Access Token and calling with Client Id.

            var parameters = this.GetDefaultParameters(param.CallingWith);
            var baseUrl = $"{ApiConstantDefinition.BaseUrl}/venues/{param.VenueId}";

            return await this.GetRequestAsync<FsqVenue>(baseUrl, parameters);
        }

        public async Task<FsqVenue[]> SearchForVenueAsync(SearchForVenueParam param)
        {
            // NOTE: This API supports both calling with Access Token and calling with Client Id.

            var parameters = this.GetDefaultParameters(param.CallingWith);
            var baseUrl = $"{ApiConstantDefinition.BaseUrl}/venues/search";

            // Required parameters
            parameters["query"] = param.Query;

            // Option parameters
            if (param.LatLng != null)
                parameters["ll"] = param.LatLng.ToString();
            if (param.Radius.HasValue)
                parameters["radius"] = param.Radius.ToString();
            if (param.Limit.HasValue)
                parameters["limit"] = param.Limit.ToString();

            return await this.GetRequestAsync<FsqVenue[]>(baseUrl, parameters);
        }
    }
}
