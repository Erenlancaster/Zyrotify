﻿using System;
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
    internal class PlaylistFollower
    {
        [STAThread]
        public static void PlaylistFoll0wer()
        {
            ServicePointManager.DefaultConnectionLimit = 100000000;
            Console.Title = "Zyrotify V1.0 | Module : Playlist Follower |";

            Console.WriteLine();
            Console.Write(" Threads");
            Console.Write(": ");

            try
            {
                CheckerHelper.threads = int.Parse(Console.ReadLine());
            }
            catch
            {
                CheckerHelper.threads = 100;
            }
            Console.Clear();
            Console.WriteLine();
            for (; ; )
            {
                Console.Write(" Proxys Type ");
                Console.Write("[HTTP/SOCKS4/SOCKS5/PROXYLESS]");
                Console.Write(": ");
                CheckerHelper.proxytype = Console.ReadLine();
                CheckerHelper.proxytype = CheckerHelper.proxytype.ToUpper();
                if (CheckerHelper.proxytype == "HTTP" || CheckerHelper.proxytype == "SOCKS4" || CheckerHelper.proxytype == "SOCKS5" || CheckerHelper.proxytype == "PROXYLESS")
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
                CheckerHelper.UpdateTitle();
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

            CheckerHelper.accounts = new List<string>(File.ReadAllLines(fileName));
            CheckerHelper.LoadCombos(fileName);

            Console.Write("Successfully uploaded ");
            Console.Write(CheckerHelper.total);
            Console.WriteLine(" combo lines\n");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine();
            if (CheckerHelper.proxytype != "NO")
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

                CheckerHelper.proxies = new List<string>(File.ReadAllLines(fileName));
                CheckerHelper.LoadProxies(fileName);
                Console.Clear();
                Thread.Sleep(2000);
                Console.Clear();


                int i = 0;
                while (i < 5)
                {
                    Thread birgay = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ikigay = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ucgay = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread dort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread bes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread alti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread sekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread dokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread on = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread onbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread oniki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread onuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ondort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread onbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread onalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread onyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread onsekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ondokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmibir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmiiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmiuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmidort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmibes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmialti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmiyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmisekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yirmidokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuzbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuziki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuzuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuzdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuzbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuzalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuzyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuzsekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread otuzdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirk = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirkbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirkiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirkuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirkdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirkbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirkalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirkyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirksekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread kirkdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread elli = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ellibir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread elliiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread elliuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ellidort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ellibes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ellialti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread elliyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ellisekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ellidokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmis = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmisbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmisiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmisuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmisdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmisbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmisalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmisyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmissekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread altmisdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmis = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmisbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmisiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmisuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmisdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmisbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmisalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmisyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmissekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yetmisdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksen = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksenbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread sekseniki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksenuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksendort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksenbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksenalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksenyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksensekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread seksendokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksan = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksanbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksaniki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksanuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksandort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksanbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksanalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksanyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksansekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread doksandokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuziki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzsekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzon = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzonbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzoniki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzonuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzondort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzonbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzonalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzonyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzonsekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzondokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmibir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmiiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmiuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmidort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmibes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmialti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmiyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmisekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyirmidokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuzbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuziki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuzuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuzdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuzbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuzalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuzyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuzsekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzotuzdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirk = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirkbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirkiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirkuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirkdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirkbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirkalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirkyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirksekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzkirkdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzelli = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzellibir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzelliiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzelliuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzellidort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzellibes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzellialti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzelliyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzellisekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzellidokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmis = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmisbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmisiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmisuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmisdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmisbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmisalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmisyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmissekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzaltmisdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmis = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmisbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmisiki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmisuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmisdort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmisbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmisalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmisyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmissekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzyetmisdokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksen = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksenbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzsekseniki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksenuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksendort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksenbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksenalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksenyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksensekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzseksendokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksan = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksanbir = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksaniki = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksanuc = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksandort = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksanbes = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksanalti = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksanyedi = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksansekiz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread yuzdoksandokuz = new Thread(new ThreadStart(CheckerHelper.Check));
                    Thread ikiyuz = new Thread(new ThreadStart(CheckerHelper.Check));

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
                    yuzellibir.Start();
                    yuzelliiki.Start();
                    yuzelliuc.Start();
                    yuzellidort.Start();
                    yuzellibes.Start();
                    yuzellialti.Start();
                    yuzelliyedi.Start();
                    yuzellisekiz.Start();
                    yuzellidokuz.Start();
                    yuzaltmis.Start();
                    yuzaltmisbir.Start();
                    yuzaltmisiki.Start();
                    yuzaltmisuc.Start();
                    yuzaltmisdort.Start();
                    yuzaltmisbes.Start();
                    yuzaltmisalti.Start();
                    yuzaltmisyedi.Start();
                    yuzaltmissekiz.Start();
                    yuzaltmisdokuz.Start();
                    yuzyetmis.Start();
                    yuzyetmisbir.Start();
                    yuzyetmisiki.Start();
                    yuzyetmisuc.Start();
                    yuzyetmisdort.Start();
                    yuzyetmisbes.Start();
                    yuzyetmisalti.Start();
                    yuzyetmisyedi.Start();
                    yuzyetmissekiz.Start();
                    yuzyetmisdokuz.Start();
                    yuzseksen.Start();
                    yuzseksenbir.Start();
                    yuzsekseniki.Start();
                    yuzseksenuc.Start();
                    yuzseksendort.Start();
                    yuzseksenbes.Start();
                    yuzseksenalti.Start();
                    yuzseksenyedi.Start();
                    yuzseksensekiz.Start();
                    yuzseksendokuz.Start();
                    yuzdoksan.Start();
                    yuzdoksanbir.Start();
                    yuzdoksaniki.Start();
                    yuzdoksanuc.Start();
                    yuzdoksandort.Start();
                    yuzdoksanbes.Start();
                    yuzdoksanalti.Start();
                    yuzdoksansekiz.Start();
                    yuzdoksandokuz.Start();
                    ikiyuz.Start();

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
                    yuzellibir.Abort();
                    yuzelliiki.Abort();
                    yuzelliuc.Abort();
                    yuzellidort.Abort();
                    yuzellibes.Abort();
                    yuzellialti.Abort();
                    yuzelliyedi.Abort();
                    yuzellisekiz.Abort();
                    yuzellidokuz.Abort();
                    yuzaltmis.Abort();
                    yuzaltmisbir.Abort();
                    yuzaltmisiki.Abort();
                    yuzaltmisuc.Abort();
                    yuzaltmisdort.Abort();
                    yuzaltmisbes.Abort();
                    yuzaltmisalti.Abort();
                    yuzaltmisyedi.Abort();
                    yuzaltmissekiz.Abort();
                    yuzaltmisdokuz.Abort();
                    yuzyetmis.Abort();
                    yuzyetmisbir.Abort();
                    yuzyetmisiki.Abort();
                    yuzyetmisuc.Abort();
                    yuzyetmisdort.Abort();
                    yuzyetmisbes.Abort();
                    yuzyetmisalti.Abort();
                    yuzyetmisyedi.Abort();
                    yuzyetmissekiz.Abort();
                    yuzyetmisdokuz.Abort();
                    yuzseksen.Abort();
                    yuzseksenbir.Abort();
                    yuzsekseniki.Abort();
                    yuzseksenuc.Abort();
                    yuzseksendort.Abort();
                    yuzseksenbes.Abort();
                    yuzseksenalti.Abort();
                    yuzseksenyedi.Abort();
                    yuzseksensekiz.Abort();
                    yuzseksendokuz.Abort();
                    yuzdoksan.Abort();
                    yuzdoksanbir.Abort();
                    yuzdoksaniki.Abort();
                    yuzdoksanuc.Abort();
                    yuzdoksandort.Abort();
                    yuzdoksanbes.Abort();
                    yuzdoksanalti.Abort();
                    yuzdoksansekiz.Abort();
                    yuzdoksandokuz.Abort();
                    ikiyuz.Abort();
                    Thread.Sleep(1000);
                    Console.WriteLine("Threads started.");
                }

                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
