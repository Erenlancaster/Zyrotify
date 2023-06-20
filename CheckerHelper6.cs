using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace god_checker
{
    internal class CheckerHelper6
    {
        public static int total;

        public static int bad = 0;

        public static int hits = 0;

        public static int premium = 0;

        public static int free = 0;

        public static int uhd = 0;

        public static int hd = 0;

        public static int err = 0;

        public static int check = 0;

        public static int accindex = 0;

        public static List<string> proxies = new List<string>();

        public static string proxytype = "";

        public static int proxyindex = 0;

        public static int proxytotal = 0;

        public static int stop = 0;

        public static List<string> accounts = new List<string>();

        public static int CPM = 0;

        public static int CPM_aux = 0;

        public static int threads;


        public static void LoadCombos(string fileName)
        {
            using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                {
                    using (StreamReader streamReader = new StreamReader(bufferedStream))
                    {
                        while (streamReader.ReadLine() != null)
                        {
                            CheckerHelper6.total++;
                        }
                    }
                }
            }
        }

        public static void LoadProxies(string fileName)
        {
            using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                {
                    using (StreamReader streamReader = new StreamReader(bufferedStream))
                    {
                        while (streamReader.ReadLine() != null)
                        {
                            CheckerHelper6.proxytotal++;
                        }
                    }
                }
            }
        }

        public static void UpdateTitle()
        {
            for (; ; )
            {
                CheckerHelper6.CPM = CheckerHelper6.CPM_aux;
                CheckerHelper6.CPM_aux = 0;
                Console.Title = string.Format("Zyrotify | Module: Account Creator | Checked {0} - Remaining {1} | Hits {2} - Fails {4} - CPM ", new object[]
                {
                        CheckerHelper6.check,
                        CheckerHelper6.total,
                        CheckerHelper6.hits,
                        CheckerHelper6.free,
                        CheckerHelper6.bad,
                        CheckerHelper6.err,
                }) + CheckerHelper6.CPM * 60;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
                                   
                            ███████▒▓██   ██▓ ██▀███   ▒█████   ████████ ██▓  █████▒▓██   ██▓
                            ▒ ▒ ▒ ▄▀░ ▒██  ██▒▓██ ▒ ██▒▒██▒  ██▒▓  ██▒ ▓▒▓██▒▓██   ▒  ▒██  ██▒
                            ░ ▒ ▄▀▒░   ▒██ ██░▓██ ░▄█ ▒▒██░  ██▒▒ ▓██░ ▒░▒██▒▒████ ░   ▒██ ██░
                              ▄▀▒   ░  ░ ▐██▓░▒██▀▀█▄  ▒██   ██░░ ▓██▓ ░ ░██░░▓█▒  ░   ░ ▐██▓░
                            ▒███████▒  ░ ██▒▓░░██▓ ▒██▒░ ████▓▒░  ▒██▒ ░ ░██░░▒█░      ░ ██▒▓░
                            ░▒▒ ▓░▒░▒   ██▒▒▒ ░ ▒▓ ░▒▓░░ ▒░▒░▒░   ▒ ░░   ░▓   ▒ ░       ██▒▒▒ 
                            ░░▒ ▒ ░ ▒ ▓██ ░▒░   ░▒ ░ ▒░  ░ ▒ ▒░     ░     ▒ ░ ░       ▓██ ░▒░ 
                            ░ ░ ░ ░ ░ ▒ ▒ ░░    ░░   ░ ░ ░ ░ ▒    ░       ▒ ░ ░ ░     ▒ ▒ ░░  
                              ░ ░     ░ ░        ░         ░ ░            ░           ░ ░     
                            ░         ░ ░                                             ░ ░   
                                                                    
                                                        
                                                    
                                    
                ");
                // Check Info
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Module : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Account Creator");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] CPM : ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(CheckerHelper6.CPM * 60);
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Error : ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(CheckerHelper6.err);
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Checked / Total : ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(CheckerHelper6.check); Console.Write(" / "); Console.Write(CheckerHelper6.total);
                Console.WriteLine("");


                Console.WriteLine("");

                // HIT Stats

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] CREATED : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(CheckerHelper6.hits);


                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] BAN : ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(CheckerHelper6.free);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] BADS : ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(CheckerHelper6.bad);

                Console.WriteLine("");

                Thread.Sleep(1000);
            }
        }

        public static void Check()
        {
            for (; ; )
            {
                if (CheckerHelper6.proxyindex > CheckerHelper6.proxies.Count<string>() - 2)
                {
                    CheckerHelper6.proxyindex = 0;
                }
                try
                {
                    Interlocked.Increment(ref CheckerHelper6.proxyindex);
                    using (HttpRequest req = new HttpRequest())
                    {
                        if (CheckerHelper6.accindex >= CheckerHelper6.accounts.Count<string>())
                        {
                            CheckerHelper6.stop++;
                            break;
                        }
                        Interlocked.Increment(ref CheckerHelper6.accindex);
                        string[] array = CheckerHelper6.accounts[CheckerHelper6.accindex].Split(new char[]
                        {
                            ':',
                            ';',
                            '|'
                        });
                        string text = array[0] + ":" + array[1];
                        try
                        {
                            if (CheckerHelper6.proxytype == "HTTP")
                            {
                                req.Proxy = HttpProxyClient.Parse(CheckerHelper6.proxies[CheckerHelper6.proxyindex]);
                                req.Proxy.ConnectTimeout = 5000;
                            }
                            if (CheckerHelper6.proxytype == "SOCKS4")
                            {
                                req.Proxy = Socks4ProxyClient.Parse(CheckerHelper6.proxies[CheckerHelper6.proxyindex]);
                                req.Proxy.ConnectTimeout = 5000;
                            }
                            if (CheckerHelper6.proxytype == "SOCKS5")
                            {
                                req.Proxy = Socks5ProxyClient.Parse(CheckerHelper6.proxies[CheckerHelper6.proxyindex]);
                                req.Proxy.ConnectTimeout = 5000;
                            }
                            if (CheckerHelper6.proxytype == "PROXYLESS")
                            {
                                req.Proxy = null;
                            }
                            if (CheckerHelper6.check >= CheckerHelper6.total)
                            {
                                break;
                            }
                            string giris = req.Post("https://spclient.wg.spotify.com/signup/public/v1/account", "gender=male&password=" + array[1] + "&password_repeat=" + array[1] + "&birth_month=8&birth_year=2000&creation_point=client_mobile&email=" + array[0] + "&birth_day=1&displayname=" + array[0] + "&key=bff58e9698f40080ec4f9ad97a2f21e0&platform=iOS-ARM&creation_flow=mobile_email&iagree=1", "application/x-www-form-urlencoded").ToString();

                            if (giris.Contains("status\":1"))
                            {

                                CheckerHelper6.CPM_aux++;
                                CheckerHelper6.check++;
                                CheckerHelper6.hits++;
                                CheckerHelper6.Good2(text);
                            }
                            else if (giris.Contains("status\":100"))
                            {
                                CheckerHelper6.CPM_aux++;
                                CheckerHelper6.check++;
                                CheckerHelper6.bad++;
                                CheckerHelper6.Bad2(text);
                            }
                            else if (giris.Contains("status\":130"))
                            {
                                CheckerHelper6.CPM_aux++;
                                CheckerHelper6.check++;
                                CheckerHelper6.bad++;
                                CheckerHelper6.Bad2(text);
                            }
                            else if (giris.Contains("status\":20"))
                            {
                                CheckerHelper6.CPM_aux++;
                                CheckerHelper6.check++;
                                CheckerHelper6.free++;

                            }
                            else
                            {
                                CheckerHelper6.accounts.Add(text);
                            }
                        }
                        catch (Exception)
                        {
                            CheckerHelper6.accounts.Add(text);
                        }
                    }
                    continue;
                }
                catch
                {
                    Interlocked.Increment(ref CheckerHelper6.err);
                }
            }
        }

        public static void Good2(string account)
        {
            try
            {
                using (StreamWriter sw = File.AppendText("results/acccreator/Created.txt"))
                {
                    sw.WriteLine(account);
                }
            }
            catch
            {

            }
        }
        public static void Bad2(string account)
        {
            try
            {
                using (StreamWriter sw = File.AppendText("results/mailaccess/Bad.txt"))
                {
                    sw.WriteLine(account);
                }
            }
            catch
            {

            }
        }


        public static string Parse(string source, string left, string right)
        {
            return source.Split(new string[1] { left }, StringSplitOptions.None)[1].Split(new string[1]
            {
                right
            }, StringSplitOptions.None)[0];
        }
    }
}

