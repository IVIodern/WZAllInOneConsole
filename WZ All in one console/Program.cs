﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Diagnostics; 

namespace WZ_All_in_one_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i == 1)
            {
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                // string rcon = ""; ---- i failed here, previously it was Console.ReadLine = rcon below, but since it was the wrong syntax it didn't need to use the string
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=================================================");
                Console.WriteLine("What Application would you like to open?");
                Console.WriteLine("The variables are");
                Console.WriteLine("1) WZ RCON Client");
                Console.WriteLine("2) Demo Uploader");
                Console.WriteLine("3) Remote Desktop");
                Console.WriteLine("4) Close the Application");
                Console.WriteLine("=================================================");

                string readline = Console.ReadLine();
                if (readline == "1")
                {
                    // tries to launch the program, does catch if it can't
                    try
                    {
                        Process.Start(@"wzsoftware\wz_rcon_v2.1.exe");
                        Console.WriteLine("Use your WarZone Gaming credentials to logon. Hit a Key to continue.");
                        
                        continue;
                    }

                    catch
                    {
                        // pointing the obvious
                        Console.WriteLine("You don't have the RCON client installed.");

                        Directory.CreateDirectory(@"wzsoftware\");

                        Console.WriteLine("Downloading the RCON tool...");

                        WebClient webClient = new WebClient();


                        webClient.DownloadFile("http://warzone-gaming.co.uk/downloads/wz_rcon_v2.1.exe", @"wzsoftware\wz_rcon_v2.1.exe");

                        Console.WriteLine("Download Complete, launching now.");


                        // once it's downloaded, launch it 

                        Process.Start(@"wzsoftware\wz_rcon_v2.1.exe");
                        Console.WriteLine("Use your WarZone Gaming credentials to logon.");
                        
                        continue;





                    }



                }

                if (readline == "2")
                {
                    // tries to launch the program, does catch if it can't
                    try
                    {
                        Process.Start(@"wzsoftware\emoUploader2.exe");
                        Console.WriteLine("Use your WarZone Gaming credentials to logon.");
                        
                        continue;
                    }

                    catch
                    {
                        // pointing the obvious
                        Console.WriteLine("You don't have the Demo Uploader client installed.");

                        Directory.CreateDirectory(@"wzsoftware\");

                        Console.WriteLine("Downloading the Demo Uploader tool...");

                        WebClient webClient = new WebClient();


                        webClient.DownloadFile("http://warzone-gaming.co.uk/downloads/DemoUploader2.exe", @"wzsoftware\DemoUploader2.exe");

                        Console.WriteLine("Download Complete, launching now.");


                        // once it's downloaded, launch it 

                        Process.Start(@"wzsoftware\DemoUploader2.exe");
                        Console.WriteLine("Use your WarZone Gaming credentials to logon.");
                      
                        continue;





                    }



                }

                if (readline == "3")
                {

                    try
                    {
                        Process.Start("mstsc.exe");
                        Console.WriteLine("Remote Desktop Launched, now launching the thread with logon details.");
                        Process.Start("http://warzone-gaming.co.uk/forums/index.php?/topic/4715-rcon-firewall-access-v20/");
                       
                        continue;
                    }
                    catch
                    {
                        Console.WriteLine("Outdated operating system. Must be Vista or higher.");
                       
                        continue;
                    }
                }


                if (readline == "4")
                {
                    Console.WriteLine("Exiting Application. Click any key to continue.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Only choose 1, 2, 3 or 4!");

                    continue;

                }


            }

        }


    }
}
