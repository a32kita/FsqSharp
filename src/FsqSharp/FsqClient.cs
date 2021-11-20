using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using FsqSharp.ApiElements;

namespace FsqSharp
{
    public class FsqClient
    {
        // 公開プロパティ

        public FsqClientInfo ClientInfo
        {
            get;
            private set;
        }

        public FsqAccessToken AccessToken
        {
            get;
            private set;
        }

        public Uri AuthenticationUrl
        {
            get;
            private set;
        }

        public bool IsAuthenticated
        {
            get => this.AccessToken != null;
        }

        public UsersApiEndpoint Users
        {
            get;
            private set;
        }

        public VenueApiEndpoint Venues
        {
            get;
            private set;
        }

        public CheckinApiEndpoint Checkins
        {
            get;
            private set;
        }


        // コンストラクタ

        public FsqClient(FsqClientInfo clientInfo, FsqAccessToken accessToken)
        {
            this.ClientInfo = clientInfo;
            this.AccessToken = accessToken;

            this.AuthenticationUrl = new Uri("https://foursquare.com/oauth2/authenticate" +
                $"?client_id={this.ClientInfo.ClientId}" +
                $"&response_type=code" +
                $"&redirect_uri={this.ClientInfo.AuthenticationRedirectUrl}");

            // Instantiate Endpoint objects
            this.Users = new UsersApiEndpoint(this);
            this.Venues = new VenueApiEndpoint(this);
            this.Checkins = new CheckinApiEndpoint(this);
        }

        public FsqClient(FsqClientInfo clientInfo)
            : this(clientInfo, null)
        {
            // NOP
        }


        // 公開メソッド

        public async Task AuthenticationWithRedirectedUrlAsync(Uri redirectedUrl)
        {
            if (this.IsAuthenticated)
                throw new InvalidOperationException("Client is already authenticated.");

            try
            {
                var query = redirectedUrl.Query;
                var code = query.Substring(query.LastIndexOf("code=") + "code=".Length);

                var authorizeUrl = "https://foursquare.com/oauth2/access_token" +
                    $"?client_id={this.ClientInfo.ClientId}" +
                    $"&client_secret={this.ClientInfo.ClientSecret}" +
                    $"&grant_type=authorization_code" +
                    $"&redirect_uri={this.ClientInfo.AuthenticationRedirectUrl}" +
                    $"&code={code}";

                using (var httpClient = new HttpClient())
                using (var httpResponse = await httpClient.GetAsync(authorizeUrl))
                {
                    var respJson = await httpResponse.Content.ReadAsStringAsync();
                    var accessToken = JObject.Parse(respJson)["access_token"].ToString();

                    this.AccessToken = new FsqAccessToken(accessToken);
                }
            }
            catch
            {
                throw new ArgumentException();
            }
        }


        public void Design()
        {
            /*
             * var fsqClientInfo = new FsqClientInfo("xx", "yy", "https://www.a32kita.net/hoge");
             * var fsqOAuthToken = new FsqOAuthToken("xxxxtoken");
             * var fsqClient = new FsqClient(fsqClientInfo, fsqOAuthToken);
             * 
             * var myDetail = fsqClient.Users.GetDetail(new GetUserDetailParam() { UserId = "self" });
             * 
             * var myCheckins = fsqClient.Users.GetCheckins(new GetUserCheckinsParam() { UserId = "self" });
             * var myCheckinsMany = fsqClient.Users.GetCheckins(new GetUserCheckinsParam() { UserId = "self", limit = 150 });
             * 
             * 
             */
        }
    }
}
