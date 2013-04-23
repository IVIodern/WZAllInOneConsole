using System;
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
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            // string rcon = ""; ---- i failed here, previously it was Console.ReadLine = rcon below, but since it was the wrong syntax it didn't need to use the string
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What Application would you like to open?");
            Console.WriteLine("The variables are");
            Console.WriteLine("1) WZ RCON Client");
            Console.WriteLine("2) Remote Desktop");
            if (Console.ReadLine() == "1")
            {
                // tries to launch the program, does catch if it can't
                try
                {
                    Process.Start(@"wzsoftware\wz_rcon_v2.1.exe");
                    Console.WriteLine("Use your WarZone Gaming credentials to logon.");
                    Console.ReadKey(); 
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
                    Console.ReadKey(); 
                
                    
               
                    
 
                } 


               
            }
            else
            {
                Console.WriteLine("Wrong!"); 

            }
           
       
        }

     


    }
}
