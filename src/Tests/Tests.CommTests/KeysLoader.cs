using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FsqSharp;

/*
 * Documents フォルダに保存された次のファイルから、疎通テスト用のクライアント情報をロードします。
 * 
 * 1 行目: Client Id
 * 2 行目: Client Secret
 * 3 行目: Redirect URL
 * 4 行目: Access Token (任意) → 3 行目がない、或いは空行の場合は、Client Id を使用して認証を行います。
 *         (Foursquare へのログインが必要)
 * 
 */

namespace Tests.CommTests
{
    public static class KeysLoader
    {
        private static string s_configFile;

        static KeysLoader()
        {
            var myDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            s_configFile = Path.Combine(myDocument, "FsqSharp_TestAccountConfig.txt");
        }


        public static FsqClientInfo LoadClientInfo()
        {
            if (File.Exists(s_configFile) == false)
            {
                Console.WriteLine("[Error] Config file is not found.");
                Console.WriteLine("[Error] {0}", s_configFile);
                _termination();
            }
            else if (new FileInfo(s_configFile).Length > 10000)
            {
                Console.WriteLine("[Error] Config file is too large.");
                Console.WriteLine("[Error] {0}", s_configFile);
                _termination();
            }

            var lines = File.ReadAllLines(s_configFile);
            if (lines.Length < 3)
            {
                Console.WriteLine("[Error] Config file is invalid.");
                Console.WriteLine("[Error] {0}", s_configFile);
                _termination();
            }

            return new FsqClientInfo(lines[0], lines[1], new Uri(lines[2]));
        }

        public static FsqAccessToken LoadAccessToken()
        {
            if (File.Exists(s_configFile) == false)
            {
                Console.WriteLine("[Error] Config file is not found.");
                Console.WriteLine("[Error] {0}", s_configFile);
                _termination();
            }
            else if (new FileInfo(s_configFile).Length > 10000)
            {
                Console.WriteLine("[Error] Config file is too large.");
                Console.WriteLine("[Error] {0}", s_configFile);
                _termination();
            }

            var lines = File.ReadAllLines(s_configFile);
            if (lines.Length < 4)
            {
                Console.WriteLine("[Error] There is no definition of Access Token.");
                Console.WriteLine("[Error] {0}", s_configFile);
                _termination();
            }

            return new FsqAccessToken(lines[3]);
        }

        private static void _termination()
        {
            Console.WriteLine();
            Console.WriteLine("Please press [Enter] to exit.");
            Console.ReadLine();

            Environment.Exit(1);
        }
    }
}
