using System;
using System.Diagnostics;

namespace optimizer
{
    public class Optimize
    {

        public static void Main()
        {
            optimize();
        }

           
        public static void optimize()
        {
            Console.Title = "Storage Optimizer";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Author: https://github.com/K1netikS | https://t.me/K1n_eopseo\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type 1 to optimize system: ");
            string input = Console.ReadLine();

            int selectedOption;
            if (int.TryParse(input, out selectedOption))
            {
                if (selectedOption == 1)
                {
                    DateTime now = DateTime.Now;
                 

                    Console.WriteLine("\nflushing data...");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Convert.ToString(now) + " Clearing Flush...");
                    flushDNS();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing Temp...");
                    temp();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing Win Temp...");
                    wintemp();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing Recycle Bin...");
                    RecycleBin();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing Prefectch...");
                    prefetch();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing Downloads...");
                    downloads();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing Logs...");
                    logs();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing LdPlayer Logs...");
                    LDlogs();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing Xamarin...");
                    Xamarin();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing Packages...");
                    Packages();
                    Thread.Sleep(100);
                    Console.WriteLine(Convert.ToString(now) + " Clearing D3DSCache...");
                    D3DSCache();
                    Thread.Sleep(1000);
                    Console.WriteLine("Done");
                    Thread.Sleep(500);

                }
            }
        }

        static void flushDNS()
        {
            Process cmd = new Process();
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("ipconfig/flushDNS");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
        }

        static void temp()
        {
            DirectoryInfo temp = new DirectoryInfo(@"C:\Users\Admin\AppData\Local\Temp");

            try
            {
                foreach (FileInfo file in temp.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in temp.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }

        }
        static void wintemp()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Temp");

            try
            {
                foreach (FileInfo file in dir.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in dir.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }

        }

        static void RecycleBin()
        {
            DirectoryInfo recycle = new DirectoryInfo(@"C:\$Recycle.Bin");

            try
            {
                foreach (FileInfo file in recycle.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in recycle.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }
        }

        static void prefetch()
        {
            DirectoryInfo prefetch = new DirectoryInfo(@"C:\Windows\Prefetch");

            try
            {
                foreach (FileInfo file in prefetch.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in prefetch.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }

        }

        static void downloads()
        {
            DirectoryInfo downloads = new DirectoryInfo(@"C:\Users\Admin\Downloads");

            try
            {
                foreach (FileInfo file in downloads.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in downloads.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }
            
        }


        static void logs()
        {
            DirectoryInfo logs = new DirectoryInfo(@"C:\Windows\Logs");

            try
            {
                foreach (FileInfo file in logs.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in logs.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }

        }

        static void LDlogs()
        {
            DirectoryInfo LDlogs = new DirectoryInfo(@"E:\LDPlayer9\vms\leidian0\Logs");

            try
            {
                foreach (FileInfo file in LDlogs.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in LDlogs.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }

        }


        static void Xamarin()
        {
            DirectoryInfo Xamarin = new DirectoryInfo(@"C:\Users\Admin\AppData\Local\Xamarin");

            try
            {
                foreach (FileInfo file in Xamarin.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in Xamarin.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }

        }

        static void D3DSCache()
        {
            DirectoryInfo D3DSCache = new DirectoryInfo(@"C:\Users\Admin\AppData\Local\D3DSCache");

            try
            {
                foreach (FileInfo file in D3DSCache.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in D3DSCache.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }

        }


        static void Packages()
        {
            DirectoryInfo Packages = new DirectoryInfo(@"C:\Users\Admin\AppData\Local\Packages");

            try
            {
                foreach (FileInfo file in Packages.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo direct in Packages.EnumerateDirectories())
                {
                    direct.Delete(true);
                }
            }
            catch { }

        }

    }
}