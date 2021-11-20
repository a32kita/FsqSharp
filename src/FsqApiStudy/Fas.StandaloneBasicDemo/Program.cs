using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fas.StandaloneBasicDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Foursquare の認証フローを確認するための検証コード

            Console.WriteLine("Foursquare API Study");
            Console.Write("Please press any key to continue>");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Please input your Client Id;");
            Console.Write(">");
            var clientId = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Please input your Client Authorize Redirect Url;");
            Console.Write(">");
            var clientRedirectUrl = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Please access that URL for authorize apps ...");
            Console.WriteLine("https://foursquare.com/oauth2/authenticate" +
                $"?client_id={clientId}" +
                $"&response_type=code" +
                $"&redirect_uri={clientRedirectUrl}");

            Console.WriteLine();
            Console.WriteLine("Please accept to accessing your account from app.");
            Console.WriteLine("Please input redirected URL after accepting;");
            Console.Write(">");
            var redirectedUrl = Console.ReadLine();
            var accessCode = redirectedUrl.Substring(redirectedUrl.LastIndexOf("?code=") + "?code=".Length);

            Console.WriteLine();
            Console.WriteLine("========= ACCESS CODE =========");
            Console.WriteLine(accessCode);
            Console.WriteLine("===============================");
            Console.WriteLine();

            Console.Write("Please press any key to continue>");
            Console.ReadKey();

            Console.WriteLine("Please press any key to exit>");
            Console.ReadKey();
        }
    }
}
