using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FsqSharp.ApiElements
{
    public abstract class FsqApiEndpoint : IDisposable
    {
        // 非公開静的フィールド
        private static HttpClient s_httpClient;
        private static int s_instanceCount;


        // 限定公開プロパティ

        protected bool IsDisposed
        {
            get;
            private set;
        }

        internal FsqClient Client
        {
            get;
            private set;
        }


        // コンストラクタ

        internal FsqApiEndpoint(FsqClient client)
        {
            this.Client = client;

            if (s_httpClient == null)
                this._initializeHttpClient();

            s_instanceCount++;
        }


        // 静的コンストラクタ

        static FsqApiEndpoint()
        {
            s_httpClient = null;
            s_instanceCount = 0;
        }


        // 非公開メソッド

        private void _initializeHttpClient()
        {
            s_httpClient = new HttpClient();
            s_httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:94.0) Gecko/20100101 Firefox/94.0");

            //var ua = s_httpClient.DefaultRequestHeaders.UserAgent;
            //Console.WriteLine(ua);
        }


        // 限定公開メソッド

        protected virtual void OnDispose()
        {
            // NOP
        }

        protected virtual void AddDefaultParameterValuesTo(IDictionary<string, string> parameters, FsqApiAuthParameter authParameters)
        {
            parameters["v"] = ApiConstantDefinition.VersionCode;

            if ((authParameters & FsqApiAuthParameter.ClientId) == FsqApiAuthParameter.ClientId)
                parameters["client_id"] = this.Client.ClientInfo.ClientId;

            if ((authParameters & FsqApiAuthParameter.ClientSecret) == FsqApiAuthParameter.ClientSecret)
                parameters["client_secret"] = this.Client.ClientInfo.ClientSecret;

            if ((authParameters & FsqApiAuthParameter.AccessToken) == FsqApiAuthParameter.AccessToken)
                parameters["oauth_token"] = this.Client.AccessToken.Token;
        }

        protected void AddDefaultParameterValuesTo(IDictionary<string, string> parameters, FsqApiCallingWith callingWith)
        {
            switch (callingWith)
            {
                case FsqApiCallingWith.AccessToken:
                    this.AddDefaultParameterValuesTo(parameters, FsqApiAuthParameter.AccessToken);
                    return;
                case FsqApiCallingWith.ClientId:
                    this.AddDefaultParameterValuesTo(parameters, FsqApiAuthParameter.ClientInfo);
                    return;
            }

            // Auto mode
            
            if (this.Client.IsAuthenticated)
            {
                this.AddDefaultParameterValuesTo(parameters, FsqApiAuthParameter.AccessToken);
                return;
            }

            this.AddDefaultParameterValuesTo(parameters, FsqApiAuthParameter.ClientInfo);
            return;
        }

        protected IDictionary<string, string> GetDefaultParameters(FsqApiAuthParameter authParameters)
        {
            var parameters = new Dictionary<string, string>();
            this.AddDefaultParameterValuesTo(parameters, authParameters);

            return parameters;
        }

        protected IDictionary<string, string> GetDefaultParameters(FsqApiCallingWith callingWith)
        {
            var parameters = new Dictionary<string, string>();
            this.AddDefaultParameterValuesTo(parameters, callingWith);

            return parameters;
        }

        protected async Task<TResponse> GetRequestAsync<TResponse>(string endpointUrl, IDictionary<string, string> parameters)
        {
            // URL 生成
            var queryString = String.Join("&", parameters.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}"));
            var fullUrl = endpointUrl + "?" + queryString;

            // リクエスト送信
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, fullUrl))
            {
                return await this.SendRequestAsync<TResponse>(httpRequest);
            }
        }

        protected async Task<TResponse> PostRequestAsync<TResponse>(string endpointUrl, IDictionary<string, string> parameters)
        {
            // URL 生成
            var queryString = String.Join("&", parameters.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}"));
            var fullUrl = endpointUrl + "?" + queryString;

            // リクエスト送信
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, fullUrl))
            {
                return await this.SendRequestAsync<TResponse>(httpRequest);
            }
        }

        protected async Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage httpRequest)
        {
            try
            {
                using (var httpResponse = await s_httpClient.SendAsync(httpRequest))
                {
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.Forbidden)
                    {
                        // bot detection
                        await Task.Delay(3000);

                        var httpRequest2 = new HttpRequestMessage(
                            httpRequest.Method, httpRequest.RequestUri);

                        using (var httpResponse2 = await s_httpClient.SendAsync(httpRequest2))
                        {
                            var responseContent2 = await httpResponse.Content.ReadAsStringAsync();
                            var responseObject2 = JObject.Parse(responseContent2);

                            return responseObject2["response"].First.First.ToObject<TResponse>();
                        }
                    }
                    

                    var responseContent = await httpResponse.Content.ReadAsStringAsync();
                    var responseObject = JObject.Parse(responseContent);

                    return responseObject["response"].First.First.ToObject<TResponse>();
                }
            }
            catch (Exception ex)
            {
                // NOP
                throw ex;
            }
        }


        // 公開メソッド

        public void Dispose()
        {
            if (this.IsDisposed)
                return;

            this.OnDispose();

            s_instanceCount--;
            if (s_instanceCount <= 0)
            {
                s_httpClient?.Dispose();
                s_httpClient = null;
            }

            this.IsDisposed = true;
        }
    }
}
