using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FsqSharp;

namespace Tests.CommTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // クライアントとユーザーの認証情報 (ハードコーディングは非推奨)
            //var fsqClientInfo = new FsqClientInfo("CLIENT_ID", "CLIENT_SECRET", new Uri("REDIRECT_URL"));
            //var fsqOAuthToken = new FsqAccessToken("ACCESS_TOKEN"); // null の場合は、ユーザー認証無しで API をコールします

            // 上記認証情報をファイルからロード (上記の代わりにこちらを推奨)
            var fsqClientInfo = KeysLoader.LoadClientInfo();
            var fsqOAuthToken = KeysLoader.LoadAccessToken();

            // クライアントを初期化
            var fsqClient = new FsqClient(fsqClientInfo, fsqOAuthToken);


            // メッセージ出力
            Console.WriteLine("FsqSharp: Library communication test");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            

            if (fsqClient.IsAuthenticated || true)
            {
                // NOP
            }
            else
            {
            auth:
                Console.WriteLine("Authentication app with your account;");
                Console.WriteLine(fsqClient.AuthenticationUrl);
                Console.WriteLine();
                Console.WriteLine("Please input redirected url");
                Console.Write(">");

                try
                {
                    fsqClient.AuthenticationWithRedirectedUrlAsync(new Uri(Console.ReadLine())).Wait();
                }
                catch
                {
                    Console.WriteLine("[Error] Invalid URL!");
                    goto auth;
                }
            }

            Console.WriteLine("[Debug] Token={0}", fsqClient.AccessToken?.Token);
            Console.WriteLine();

            Console.WriteLine("Challenging to load user info ...");

            // 各種 API コール (本編)
            try
            {
                // ***** 自分の情報を取得する
                var myself = fsqClient.Users.GetUserAsync(new GetUserParam() { UserId = "self" }).Result;
                Console.WriteLine("Name = {0}", myself.FirstName);
                Console.WriteLine("Twitter = {0}", myself.Contact.Twitter);
                Console.WriteLine();

                // ***** 自分のチェックイン情報を取得する *****
                //var myCheckins = fsqClient.Users.GetUserCheckinsAsync(new GetUserCheckinsParam() { UserId = "self" }).Result;
                //Console.WriteLine("Checkins count = {0}", myCheckins.CountAll);
                //Console.WriteLine("Received count = {0}", myCheckins.Count);
                //Console.WriteLine();
                //foreach (var checkin in myCheckins)
                //{
                //    Console.WriteLine("{0}: {1} @ {2}", checkin.Venue?.Name, checkin.Shout, checkin.CreatedAt.ToLocalTime());
                //}
                //Console.WriteLine();

                // ***** 亀山湖のベニューを (ID 決め打ちで) 取得する *****
                //var kameyamako = fsqClient.Venues.GetVenueAsync(new GetVenueParam() { VenueId = "5bd53b2cefa82a002c2fa882" }).Result;
                ////var kameyamako = fsqClient.Venues.GetVenueAsync(new GetVenueParam() { VenueId = "5bd53b2cefa82a002c2fa882", CallingWith = FsqApiCallingWith.ClientId }).Result;
                //Console.WriteLine("(亀山湖！)");
                //Console.WriteLine("Name     = {0}", kameyamako.Name);
                //Console.WriteLine("Category = {0}", kameyamako.Categories?.First()?.Name);
                //Console.WriteLine("Friend   = {0}", kameyamako.FriendVisits?.First()?.User?.FirstName);
                //Console.WriteLine();

                // ***** 亀山湖でのチェックインを (ID 決め打ちで) 取得する *****
                //var kameyamakoCheckin = fsqClient.Checkins.GetCheckinAsync(new GetCheckinParam() { CheckinId = "6190a6fb21ef9e6fe7f5d394" }).Result;
                //Console.WriteLine("(I'm at 亀山湖！)");
                //Console.WriteLine("{0} said '{1}' at '{2}'",
                //    kameyamakoCheckin.User?.FirstName,
                //    kameyamakoCheckin.Shout,
                //    kameyamakoCheckin.Venue?.Name);
                //Console.WriteLine();

                // ***** 船橋駅周辺のベニューを検索する *****
                //var aroundFunabashiSta = fsqClient.Venues.SearchForVenueAsync(new SearchForVenueParam()
                //{
                //    Query = "船橋",
                //    LatLng = LatLngParamSet.Parse("35.4206,139.5907"),
                //    Radius = 100000,
                //    Limit = 10,
                //}).Result;
                //Console.WriteLine("(船橋駅周辺)");
                //foreach (var venue in aroundFunabashiSta)
                //{
                //    Console.WriteLine("{0}: {1} ({2})", venue.Categories?.First()?.Name, venue.Name, venue.Location.Address);
                //}
                //Console.WriteLine();

                // ***** 千葉県にチェックインする (注意: 現バージョンではこちらのメソッドは弾かれる / 調査中) *****
                //var chibakenCheckin = fsqClient.Checkins.CreateCheckinAsync(new CreateCheckinParam()
                //{
                //    VenueId = "4f1d71b4e4b0889e074fb443",
                //    LatLng = LatLngParamSet.Parse("35.4206,139.5907"),
                //    Shout = "これは FsqSharp ライブラリの動作試験です",
                //    Broadcast = FsqBroadcastCheckinTo.Twitter,
                //}).Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Error] Failed to calling API: {0}", ex.GetType().Name);
            }

            Console.WriteLine("Please press [Enter] to exit ...");
            Console.ReadLine();
        }
    }
}
