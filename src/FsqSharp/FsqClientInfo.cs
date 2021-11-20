using System;
using System.Collections.Generic;
using System.Text;

namespace FsqSharp
{
    /// <summary>
    /// クライアントの基本情報を取得します。
    /// </summary>
    public class FsqClientInfo
    {
        // 公開プロパティ

        /// <summary>
        /// クライアントの Client Id を取得します。
        /// </summary>
        public string ClientId
        {
            get;
            private set;
        }

        /// <summary>
        /// クライアントの Client Secret を取得します。
        /// </summary>
        public string ClientSecret
        {
            get;
            private set;
        }

        /// <summary>
        /// クライアントのユーザーアクセス認証時のリダイレクト先 URL を取得します。
        /// </summary>
        public Uri AuthenticationRedirectUrl
        {
            get;
            private set;
        }


        // コンストラクタ

        /// <summary>
        /// <see cref="FsqClientInfo"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="clientId">クライアントの Client Id</param>
        /// <param name="clientSecret">クライアントの Client Secret</param>
        /// <param name="authenticationRedirectUrl">クライアントのユーザーアクセス認証時のリダイレクト先 URL</param>
        public FsqClientInfo(string clientId, string clientSecret, Uri authenticationRedirectUrl)
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.AuthenticationRedirectUrl = authenticationRedirectUrl;
        }
    }
}
