using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace god_checker
{
    internal class NormalChecker
    {
        [STAThread]
        public static void skrtt()
        {
            ServicePointManager.DefaultConnectionLimit = 100000000;
            Console.Title = "Zyrotify v1.0 | Module : Normal Checker |";

            Console.WriteLine();
            Console.Write(" Threads");
            Console.Write(": ");

            try
            {
                CheckerHelper3.threads = int.Parse(Console.ReadLine());
            }
            catch
            {
                CheckerHelper3.threads = 100;
            }
            Console.Clear();
            Console.WriteLine();
            for (; ; )
            {
                Console.Write(" Proxys Type ");
                Console.Write("[HTTP/SOCKS4/SOCKS5/PROXYLESS]");
                Console.Write(": ");
                CheckerHelper3.proxytype = Console.ReadLine();
                CheckerHelper3.proxytype = CheckerHelper3.proxytype.ToUpper();
                if (CheckerHelper3.proxytype == "HTTP" || CheckerHelper3.proxytype == "SOCKS4" || CheckerHelper3.proxytype == "SOCKS5" || CheckerHelper3.proxytype == "PROXYLESS")
                {
                    break;
                }
                Console.Write(" Please select a valid proxy format.\n\n");
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine();

            Task.Factory.StartNew(delegate()
            {
                CheckerHelper3.UpdateTitle();
            });

            Console.WriteLine();

            string fileName;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            do
            {
                Console.Write(" Please upload your combolist");
                Console.Write("..\n");
                Thread.Sleep(500);
                openFileDialog.Title = "Select Combo List";
                openFileDialog.DefaultExt = "txt";
                openFileDialog.Filter = "Text files|*.txt";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;
            }
            while (!File.Exists(fileName));

            CheckerHelper3.accounts = new List<string>(File.ReadAllLines(fileName));
            CheckerHelper3.LoadCombos(fileName);



            Console.Write("Successfully uploaded ");
            Console.Write(CheckerHelper3.total);
            Console.WriteLine(" combo lines\n");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine();
            if (CheckerHelper3.proxytype != "NO")
            {

                do
                {
                    Console.Write(" Please upload your proxies ");
                    Console.Write("..\n");
                    Thread.Sleep(500);
                    openFileDialog.Title = "Select Proxy List";
                    openFileDialog.DefaultExt = "txt";
                    openFileDialog.Filter = "Text files|*.txt";
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.ShowDialog();
                    fileName = openFileDialog.FileName;
                }
                while (!File.Exists(fileName));

                CheckerHelper3.proxies = new List<string>(File.ReadAllLines(fileName));
                CheckerHelper3.LoadProxies(fileName);
                Console.Clear();
                Thread.Sleep(2000);
                Console.Clear();


                int i = 0;
                while (i < 5)
                {
                    Thread birgay = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ikigay = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ucgay = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread dort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread bes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread alti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread sekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread dokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread on = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread onbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread oniki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread onuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ondort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread onbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread onalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread onyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread onsekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ondokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmibir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmiiki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmiuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmidort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmibes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmialti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmiyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmisekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yirmidokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuzbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuziki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuzuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuzdort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuzbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuzalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuzyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuzsekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread otuzdokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirk = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirkbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirkiki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirkuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirkdort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirkbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirkalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirkyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirksekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread kirkdokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread elli = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ellibir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread elliiki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread elliuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ellidort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ellibes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ellialti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread elliyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ellisekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread ellidokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmis = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmisbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmisiki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmisuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmisdort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmisbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmisalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmisyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmissekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread altmisdokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmis = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmisbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmisiki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmisuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmisdort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmisbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmisalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmisyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmissekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yetmisdokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksen = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksenbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread sekseniki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksenuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksendort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksenbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksenalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksenyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksensekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread seksendokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksan = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksanbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksaniki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksanuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksandort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksanbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksanalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksanyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksansekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread doksandokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuziki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzdort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzsekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzdokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzon = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzonbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzoniki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzonuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzondort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzonbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzonalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzonyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzonsekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzondokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmibir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmiiki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmiuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmidort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmibes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmialti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmiyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmisekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzyirmidokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuzbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuziki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuzuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuzdort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuzbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuzalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuzyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuzsekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzotuzdokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirk = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirkbir = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirkiki = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirkuc = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirkdort = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirkbes = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirkalti = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirkyedi = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirksekiz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzkirkdokuz = new Thread(new ThreadStart(CheckerHelper3.Check));
                    Thread yuzelli = new Thread(new ThreadStart(CheckerHelper3.Check));
                    

                    birgay.Start();
                    ikigay.Start();
                    ucgay.Start();
                    dort.Start();
                    bes.Start();
                    alti.Start();
                    yedi.Start();
                    sekiz.Start();
                    dokuz.Start();
                    on.Start();
                    onbir.Start();
                    oniki.Start();
                    onuc.Start();
                    ondort.Start();
                    onbes.Start();
                    onalti.Start();
                    onyedi.Start();
                    onsekiz.Start();
                    ondokuz.Start();
                    yirmi.Start();
                    yirmibir.Start();
                    yirmiiki.Start();
                    yirmiuc.Start();
                    yirmidort.Start();
                    yirmibes.Start();
                    yirmialti.Start();
                    yirmiyedi.Start();
                    yirmisekiz.Start();
                    yirmidokuz.Start();
                    otuz.Start();
                    otuzbir.Start();
                    otuziki.Start();
                    otuzuc.Start();
                    otuzdort.Start();
                    otuzbes.Start();
                    otuzalti.Start();
                    otuzyedi.Start();
                    otuzsekiz.Start();
                    otuzdokuz.Start();
                    kirk.Start();
                    kirkbir.Start();
                    kirkiki.Start();
                    kirkuc.Start();
                    kirkdort.Start();
                    kirkbes.Start();
                    kirkalti.Start();
                    kirkyedi.Start();
                    kirksekiz.Start();
                    kirkdokuz.Start();
                    elli.Start();
                    ellibir.Start();
                    elliiki.Start();
                    elliuc.Start();
                    ellidort.Start();
                    ellibes.Start();
                    ellialti.Start();
                    elliyedi.Start();
                    ellisekiz.Start();
                    ellidokuz.Start();
                    altmis.Start();
                    altmisbir.Start();
                    altmisiki.Start();
                    altmisuc.Start();
                    altmisdort.Start();
                    altmisbes.Start();
                    altmisalti.Start();
                    altmisyedi.Start();
                    altmissekiz.Start();
                    altmisdokuz.Start();
                    yetmis.Start();
                    yetmisbir.Start();
                    yetmisiki.Start();
                    yetmisuc.Start();
                    yetmisdort.Start();
                    yetmisbes.Start();
                    yetmisalti.Start();
                    yetmisyedi.Start();
                    yetmissekiz.Start();
                    yetmisdokuz.Start();
                    seksen.Start();
                    seksenbir.Start();
                    sekseniki.Start();
                    seksenuc.Start();
                    seksendort.Start();
                    seksenbes.Start();
                    seksenalti.Start();
                    seksenyedi.Start();
                    seksensekiz.Start();
                    seksendokuz.Start();
                    doksan.Start();
                    doksanbir.Start();
                    doksaniki.Start();
                    doksanuc.Start();
                    doksandort.Start();
                    doksanbes.Start();
                    doksanalti.Start();
                    doksanyedi.Start();
                    doksansekiz.Start();
                    doksandokuz.Start();
                    yuz.Start();
                    yuzbir.Start();
                    yuziki.Start();
                    yuzuc.Start();
                    yuzdort.Start();
                    yuzbes.Start();
                    yuzalti.Start();
                    yuzyedi.Start();
                    yuzsekiz.Start();
                    yuzdokuz.Start();
                    yuzon.Start();
                    yuzonbir.Start();
                    yuzoniki.Start();
                    yuzonuc.Start();
                    yuzondort.Start();
                    yuzonbes.Start();
                    yuzonalti.Start();
                    yuzonyedi.Start();
                    yuzonsekiz.Start();
                    yuzondokuz.Start();
                    yuzyirmi.Start();
                    yuzyirmibir.Start();
                    yuzyirmiiki.Start();
                    yuzyirmiuc.Start();
                    yuzyirmidort.Start();
                    yuzyirmibes.Start();
                    yuzyirmialti.Start();
                    yuzyirmiyedi.Start();
                    yuzyirmisekiz.Start();
                    yuzyirmidokuz.Start();
                    yuzotuz.Start();
                    yuzotuzbir.Start();
                    yuzotuziki.Start();
                    yuzotuzuc.Start();
                    yuzotuzdort.Start();
                    yuzotuzbes.Start();
                    yuzotuzalti.Start();
                    yuzotuzyedi.Start();
                    yuzotuzsekiz.Start();
                    yuzotuzdokuz.Start();
                    yuzkirk.Start();
                    yuzkirkbir.Start();
                    yuzkirkiki.Start();
                    yuzkirkuc.Start();
                    yuzkirkdort.Start();
                    yuzkirkbes.Start();
                    yuzkirkalti.Start();
                    yuzkirkyedi.Start();
                    yuzkirksekiz.Start();
                    yuzkirkdokuz.Start();
                    yuzelli.Start();
                    
                    
                    Thread.Sleep(60000);
                    Console.WriteLine("Threads restarting.");
                    birgay.Abort();
                    ikigay.Abort();
                    ucgay.Abort();
                    dort.Abort();
                    bes.Abort();
                    alti.Abort();
                    yedi.Abort();
                    sekiz.Abort();
                    dokuz.Abort();
                    on.Abort();
                    onbir.Abort();
                    oniki.Abort();
                    onuc.Abort();
                    ondort.Abort();
                    onbes.Abort();
                    onalti.Abort();
                    onyedi.Abort();
                    onsekiz.Abort();
                    ondokuz.Abort();
                    yirmi.Abort();
                    yirmibir.Abort();
                    yirmiiki.Abort();
                    yirmiuc.Abort();
                    yirmidort.Abort();
                    yirmibes.Abort();
                    yirmialti.Abort();
                    yirmiyedi.Abort();
                    yirmisekiz.Abort();
                    yirmidokuz.Abort();
                    otuz.Abort();
                    otuzbir.Abort();
                    otuziki.Abort();
                    otuzuc.Abort();
                    otuzdort.Abort();
                    otuzbes.Abort();
                    otuzalti.Abort();
                    otuzyedi.Abort();
                    otuzsekiz.Abort();
                    otuzdokuz.Abort();
                    kirk.Abort();
                    kirkbir.Abort();
                    kirkiki.Abort();
                    kirkuc.Abort();
                    kirkdort.Abort();
                    kirkbes.Abort();
                    kirkalti.Abort();
                    kirkyedi.Abort();
                    kirksekiz.Abort();
                    kirkdokuz.Abort();
                    elli.Abort();
                    ellibir.Abort();
                    elliiki.Abort();
                    elliuc.Abort();
                    ellidort.Abort();
                    ellibes.Abort();
                    ellialti.Abort();
                    elliyedi.Abort();
                    ellisekiz.Abort();
                    ellidokuz.Abort();
                    altmis.Abort();
                    altmisbir.Abort();
                    altmisiki.Abort();
                    altmisuc.Abort();
                    altmisdort.Abort();
                    altmisbes.Abort();
                    altmisalti.Abort();
                    altmisyedi.Abort();
                    altmissekiz.Abort();
                    altmisdokuz.Abort();
                    yetmis.Abort();
                    yetmisbir.Abort();
                    yetmisiki.Abort();
                    yetmisuc.Abort();
                    yetmisdort.Abort();
                    yetmisbes.Abort();
                    yetmisalti.Abort();
                    yetmisyedi.Abort();
                    yetmissekiz.Abort();
                    yetmisdokuz.Abort();
                    seksen.Abort();
                    seksenbir.Abort();
                    sekseniki.Abort();
                    seksenuc.Abort();
                    seksendort.Abort();
                    seksenbes.Abort();
                    seksenalti.Abort();
                    seksenyedi.Abort();
                    seksensekiz.Abort();
                    seksendokuz.Abort();
                    doksan.Abort();
                    doksanbir.Abort();
                    doksaniki.Abort();
                    doksanuc.Abort();
                    doksandort.Abort();
                    doksanbes.Abort();
                    doksanalti.Abort();
                    doksanyedi.Abort();
                    doksansekiz.Abort();
                    doksandokuz.Abort();
                    yuz.Abort();
                    yuzbir.Abort();
                    yuziki.Abort();
                    yuzuc.Abort();
                    yuzdort.Abort();
                    yuzbes.Abort();
                    yuzalti.Abort();
                    yuzyedi.Abort();
                    yuzsekiz.Abort();
                    yuzdokuz.Abort();
                    yuzon.Abort();
                    yuzonbir.Abort();
                    yuzoniki.Abort();
                    yuzonuc.Abort();
                    yuzondort.Abort();
                    yuzonbes.Abort();
                    yuzonalti.Abort();
                    yuzonyedi.Abort();
                    yuzonsekiz.Abort();
                    yuzondokuz.Abort();
                    yuzyirmi.Abort();
                    yuzyirmibir.Abort();
                    yuzyirmiiki.Abort();
                    yuzyirmiuc.Abort();
                    yuzyirmidort.Abort();
                    yuzyirmibes.Abort();
                    yuzyirmialti.Abort();
                    yuzyirmiyedi.Abort();
                    yuzyirmisekiz.Abort();
                    yuzyirmidokuz.Abort();
                    yuzotuz.Abort();
                    yuzotuzbir.Abort();
                    yuzotuziki.Abort();
                    yuzotuzuc.Abort();
                    yuzotuzdort.Abort();
                    yuzotuzbes.Abort();
                    yuzotuzalti.Abort();
                    yuzotuzyedi.Abort();
                    yuzotuzsekiz.Abort();
                    yuzotuzdokuz.Abort();
                    yuzkirk.Abort();
                    yuzkirkbir.Abort();
                    yuzkirkiki.Abort();
                    yuzkirkuc.Abort();
                    yuzkirkdort.Abort();
                    yuzkirkbes.Abort();
                    yuzkirkalti.Abort();
                    yuzkirkyedi.Abort();
                    yuzkirksekiz.Abort();
                    yuzkirkdokuz.Abort();
                    yuzelli.Abort();
                    
                    Thread.Sleep(1000);
                    Console.WriteLine("Threads started.");
                }

                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}

