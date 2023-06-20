using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Forms;



namespace god_checker
{

    class Program
    {


        
        public static string alqwe;
        public static string alqwe2;
        public static int doesnotexist = 0;

        [STAThread]
        public static void Main(string[] args)
        {

            HttpRequest req = new HttpRequest();
            string updater = req.Get("https://justpaste.it/856v7", null).ToString();
            if(updater.Contains("version3amk"))
            {
                System.Windows.Forms.MessageBox.Show("Nice, you are using latest version of Zyrotify AIO");
            }
            if (!updater.Contains("version3amk"))
            {
                System.Windows.Forms.MessageBox.Show("You are using old version of Zyrotify AIO, Please update to latest version Check #updates Channel");
                Environment.Exit(0);
            }

            //This connects your file to the Auth.GG API, and sends back your application settings and such
            OnProgramStart.Initialize("komut34", "982412", "9yVHUtlbbylIWsUoc8bpwyA9QzsgO24AVA3", "1");
            if (ApplicationSettings.Freemode)
            {
                //Usually when your application doesn't need a login and has freemode enabled you put the code here you want to do
                System.Windows.Forms.MessageBox.Show("Freemode is active, bypassing login!", "Zyrotify 1.2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!ApplicationSettings.Status)
            {
                //If application is disabled in your web-panel settings this action will occur
                System.Windows.Forms.MessageBox.Show("Application is disabled!", "Zyrotify 1.2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1); // closes the application
            }
            if (File.Exists("login.xml"))
            {
                foreach (string readAllLine in File.ReadAllLines("login.xml"))
                {
                    char[] chArray = new char[1] { ':' };
                    string[] strArray = readAllLine.Split(chArray);
                    if (API.Login(strArray[0], strArray[1]))
                    {
                        Console.Clear();
                        Console.Title = "ZyrotifyAIO v1.0";
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

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("");
                        Console.WriteLine("                                                   by ZyratosTeam");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("1");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("] -");
                        Console.Write(" Start");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("2");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("] -");
                        Console.Write(" Exit");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.Write(">> ");
                        bool exists = System.IO.Directory.Exists(@"results");
                        bool exists2 = System.IO.Directory.Exists(@"results/spotify");
                        bool exists3 = System.IO.Directory.Exists(@"results/acccreator");



                        if (!exists)
                        {
                            System.IO.Directory.CreateDirectory(@"results");
                            doesnotexist = 1;
                        }
                        if (!exists2)
                        {
                            System.IO.Directory.CreateDirectory(@"results/spotify");
                            doesnotexist = 1;
                        }
                        if (!exists3)
                        {
                            System.IO.Directory.CreateDirectory(@"results/acccreator");
                            doesnotexist = 1;

                        }
                        if (!File.Exists("results/spotify/Premium But No Capture.txt"))
                        {
                            doesnotexist = 1;

                            File.Create("results/spotify/Premium But No Capture.txt");
                        }
                        if (!File.Exists("results/spotify/Premium But with Visa.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Premium But with Visa.txt");
                        }
                        if (!File.Exists("results/spotify/Premium But with Mastercard.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Premium But with Mastercard.txt");
                        }
                        if (!File.Exists("results/spotify/Premium But Payment Failed.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Premium But Payment Failed.txt");
                        }
                        if (!File.Exists("results/spotify/Bad.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Bad.txt");
                        }
                        if (!File.Exists("results/spotify/Spotify Premium for Students.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Spotify Premium for Students.txt");
                        }
                        if (!File.Exists("results/spotify/Spotify Premium Duo.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Spotify Premium Duo.txt");
                        }
                        if (!File.Exists("results/spotify/Family Member.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Family Member.txt");
                        }
                        if (!File.Exists("results/spotify/Family Owner.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Family Owner.txt");
                        }
                        if (!File.Exists("results/spotify/Spotify Premium with Hulu.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Spotify Premium with Hulu.txt");
                        }
                        if (!File.Exists("results/spotify/Normal Premium.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Normal Premium.txt");
                        }
                        if (!File.Exists("results/spotify/Free.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Free.txt");
                        }
                        if (!File.Exists("results/spotify/Premium But with Unknown CC.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/spotify/Premium But with Unknown CC.txt");
                        }
                        if (!File.Exists("results/acccreator/Created.txt"))
                        {
                            doesnotexist = 1;
                            File.Create("results/acccreator/Created.txt");
                        }


                        if (doesnotexist == 1)
                        {
                            System.Windows.Forms.MessageBox.Show("Some folders are does not exist, so program is restarting...", "Zyrotify 1.2");
                            Environment.Exit(0);
                        }
                        var result = Console.ReadLine();
                        Convert.ToInt32(result);
                        if (result == "1")
                        {


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
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("1");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("] - CHECKER");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("2");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("] - ACCOUNT CREATOR");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("3");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("] - USER/ARTIST FOLLOWER");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("4");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("] - PLAYLIST FOLLOWER");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("5");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("] - PLAYLIST UNFOLLOWER");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("6");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("] - USER/ARTIST UNFOLLOWER");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.DarkGray;

                            Console.WriteLine("[0] - Close");
                            Console.WriteLine("");
                            Console.WriteLine("");


                            Console.Write(">> ");

                            var moduleresult = Console.ReadLine();
                            Convert.ToInt32(moduleresult);
                            if (moduleresult == "0")
                            {
                                Environment.Exit(0);
                            }
                            if (moduleresult == "5")
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Write your playlist id for unfollow");
                                Console.WriteLine("");

                                Console.Write(">> ");
                                string suryadaol = Console.ReadLine();
                                alqwe = suryadaol;
                                PlaylistUnFollower.AOL0();
                            }
                            if (moduleresult == "4")
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Write your playlist id for follow");
                                Console.WriteLine("");

                                Console.Write(">> ");
                                string suryadaol = Console.ReadLine();
                                alqwe = suryadaol;
                                PlaylistFollower.PlaylistFoll0wer();
                            }
                            if (moduleresult == "3")
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Write your user id for follow");
                                Console.WriteLine("");

                                Console.Write(">> ");
                                string suryadaol2 = Console.ReadLine();
                                alqwe2 = suryadaol2;
                                UserFollower.UserFoll0wer();
                            }
                            if (moduleresult == "6")
                            {
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Write your user id for unfollow");
                                Console.WriteLine("");

                                Console.Write(">> ");
                                string suryadaol2 = Console.ReadLine();
                                alqwe2 = suryadaol2;
                                UserUnFollower.UserUnFoll0wer();
                            }
                            else if (moduleresult == "1")
                            {
                                Console.Clear();
                                NormalChecker.skrtt();
                            }
                            else if (moduleresult == "2")
                            {
                                Console.Clear();
                                AccountCreator.create();
                            }
                        }
                    }
                }
            }
            else
            {
                Console.Title = "ZyrotifyAIO v1.2";
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

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("");
                Console.WriteLine("                                                   by ZyratosTeam");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("[1] Register");
                Console.WriteLine("[2] Login");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    if (!ApplicationSettings.Register)
                    {
                        //Register is disabled in application settings, will show a messagebox that it is not enabled
                        System.Windows.Forms.MessageBox.Show("Register is not enabled, please try again later!", "Zyrotify 1.2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(1); //closes the application
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Password:");
                        string password = Console.ReadLine();
                        Console.WriteLine("Email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("License:");
                        string license = Console.ReadLine();
                        if (API.Register(username, password, email, license))
                        {
                            System.Windows.Forms.MessageBox.Show("You have successfully registered!", "Zyrotify 1.2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Do code of what you want after successful register here!
                        }
                    }
                }
                else if (option == "2")
                {
                    if (!ApplicationSettings.Login)
                    {
                        //Register is disabled in application settings, will show a messagebox that it is not enabled
                        System.Windows.Forms.MessageBox.Show("Login is not enabled, please try again later!", "Zyrotify 1.2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0); //closes the application
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Password:");
                        string password = Console.ReadLine();
                        if (API.Login(username, password))
                        {
                            using (StreamWriter autologin = new StreamWriter("login.xml", true))
                                autologin.WriteLine(username + ":" + password);
                            System.Windows.Forms.MessageBox.Show("You have successfully logged in!", "Zyrotify 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Console.Clear();
                            // Success login stuff goes here
                            Console.ForegroundColor = ConsoleColor.White;
                            API.Log(username, "Logged in!"); //Logs this action to your web-panel, you can do this anywhere and for anything!
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Username -> {User.Username}");
                            Console.Clear();
                            Console.Title = "ZyrotifyAIO v1.2";
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

                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("");
                            Console.WriteLine("                                                   by ZyratosTeam");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("1");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("] -");
                            Console.Write(" Start");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("2");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("] -");
                            Console.Write(" Exit");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            Console.Write(">> ");
                            bool exists = System.IO.Directory.Exists(@"results");
                            bool exists2 = System.IO.Directory.Exists(@"results/spotify");
                            bool exists3 = System.IO.Directory.Exists(@"results/acccreator");



                            if (!exists)
                            {
                                System.IO.Directory.CreateDirectory(@"results");
                                doesnotexist = 1;
                            }
                            if (!exists2)
                            {
                                System.IO.Directory.CreateDirectory(@"results/spotify");
                                doesnotexist = 1;
                            }
                            if (!exists3)
                            {
                                System.IO.Directory.CreateDirectory(@"results/acccreator");
                                doesnotexist = 1;

                            }
                            if (!File.Exists("results/spotify/Premium But No Capture.txt"))
                            {
                                doesnotexist = 1;

                                File.Create("results/spotify/Premium But No Capture.txt");
                            }
                            if (!File.Exists("results/spotify/Premium But with Visa.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Premium But with Visa.txt");
                            }
                            if (!File.Exists("results/spotify/Premium But with Mastercard.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Premium But with Mastercard.txt");
                            }
                            if (!File.Exists("results/spotify/Premium But Payment Failed.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Premium But Payment Failed.txt");
                            }
                            if (!File.Exists("results/spotify/Bad.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Bad.txt");
                            }
                            if (!File.Exists("results/spotify/Spotify Premium for Students.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Spotify Premium for Students.txt");
                            }
                            if (!File.Exists("results/spotify/Spotify Premium Duo.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Spotify Premium Duo.txt");
                            }
                            if (!File.Exists("results/spotify/Family Member.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Family Member.txt");
                            }
                            if (!File.Exists("results/spotify/Family Owner.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Family Owner.txt");
                            }
                            if (!File.Exists("results/spotify/Spotify Premium with Hulu.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Spotify Premium with Hulu.txt");
                            }
                            if (!File.Exists("results/spotify/Normal Premium.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Normal Premium.txt");
                            }
                            if (!File.Exists("results/spotify/Free.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Free.txt");
                            }
                            if (!File.Exists("results/spotify/Premium But with Unknown CC.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/spotify/Premium But with Unknown CC.txt");
                            }
                            if (!File.Exists("results/acccreator/Created.txt"))
                            {
                                doesnotexist = 1;
                                File.Create("results/acccreator/Created.txt");
                            }


                            if (doesnotexist == 1)
                            {
                                System.Windows.Forms.MessageBox.Show("Some folders are does not exist, so program is restarting...", "Zyrotify 1.2");
                                Environment.Exit(0);
                            }
                            var result = Console.ReadLine();
                            Convert.ToInt32(result);
                            if (result == "1")
                            {


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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("1");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("] - CHECKER");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("2");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("] - ACCOUNT CREATOR");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("3");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("] - USER/ARTIST FOLLOWER");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("4");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("] - PLAYLIST FOLLOWER");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("5");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("] - PLAYLIST UNFOLLOWER");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("6");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("] - USER/ARTIST UNFOLLOWER");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.WriteLine("[0] - Close");
                                Console.WriteLine("");
                                Console.WriteLine("");


                                Console.Write(">> ");

                                var moduleresult = Console.ReadLine();
                                Convert.ToInt32(moduleresult);
                                if (moduleresult == "0")
                                {
                                    Environment.Exit(0);
                                }
                                if (moduleresult == "5")
                                {
                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Write your playlist id for unfollow");
                                    Console.WriteLine("");

                                    Console.Write(">> ");
                                    string suryadaol = Console.ReadLine();
                                    alqwe = suryadaol;
                                    PlaylistUnFollower.AOL0();
                                }
                                if (moduleresult == "4")
                                {
                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Write your playlist id for follow");
                                    Console.WriteLine("");

                                    Console.Write(">> ");
                                    string suryadaol = Console.ReadLine();
                                    alqwe = suryadaol;
                                    PlaylistFollower.PlaylistFoll0wer();
                                }
                                if (moduleresult == "3")
                                {
                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Write your user id for follow");
                                    Console.WriteLine("");

                                    Console.Write(">> ");
                                    string suryadaol2 = Console.ReadLine();
                                    alqwe2 = suryadaol2;
                                    UserFollower.UserFoll0wer();
                                }
                                if (moduleresult == "6")
                                {
                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Write your user id for unfollow");
                                    Console.WriteLine("");

                                    Console.Write(">> ");
                                    string suryadaol2 = Console.ReadLine();
                                    alqwe2 = suryadaol2;
                                    UserUnFollower.UserUnFoll0wer();
                                }
                                else if (moduleresult == "1")
                                {
                                    Console.Clear();
                                    NormalChecker.skrtt();
                                }
                                else if (moduleresult == "2")
                                {
                                    Console.Clear();
                                    AccountCreator.create();
                                }
                            }
                        }
                    }
                }


            }
        }
                }
            }


              

               