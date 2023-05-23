using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidSpooferV2
{
    public partial class spoofui : Form
    {

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32", SetLastError = true)]
        static extern bool FreeConsole();

        public spoofui()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("github.com/soarcheats | soarcheats.xyz");
        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            gameseeds seed = new gameseeds();
            seed.Show();
        }

        private void guna2GradientTileButton8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void spoofui_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (variables.fallguys == true)
            {
                label4.Text = "Seed - Fall Guys";
            }
            if (variables.apex == true)
            {
                label4.Text = "Seed - Apex Legends";
            }
            if (variables.eft == true)
            {
                label4.Text = "Seed - EFT";
            }
            if (variables.rainbow == true)
            {
                label4.Text = "Seed - Rainbow Six Seige";
            }
            if (variables.fortnite == true)
            {
                label4.Text = "Seed - Fortnite";
            }
            if (variables.dbd == true)
            {
                label4.Text = "Seed - Dead By Daylight";
            }
            if (variables.dayz == true)
            {
                label4.Text = "Seed - DayZ";
            }
            if (variables.polygon == true)
            {
                label4.Text = "Seed - Polygon";
            }
            if (variables.randwoof == true)
            {
                label4.Text = "Seed - Randomize Disk";
            }
            if (variables.nullwoof == true)
            {
                label4.Text = "Seed - Null Disk";
            }
            if (variables.pubg == true)
            {
                label4.Text = "Seed - PUBG";
            }
        }


        static void KillProcess(string proc)
        {
            Process[] ps = Process.GetProcessesByName(proc);

            foreach (Process p in ps)
                p.Kill();
        }

        [DllImport("msvcrt.dll")]
        public static extern int system(string format);

        static void SpoofEAC()
        {
            AllocConsole();
            Console.Title = "HelixSpoofer - EasyAntiCheat - Public";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WindowWidth = 200;
            Console.WindowHeight = 32;
            Console.WriteLine(@" HHHHHHHHH     HHHHHHHHH                   lllllll   iiii                      ");
            Console.WriteLine(@" H:::::::H     H:::::::H                   l:::::l  i::::i                     ");
            Console.WriteLine(@" H:::::::H     H:::::::H                   l:::::l   iiii                      ");
            Console.WriteLine(@" HH::::::H     H::::::HH                   l:::::l                             ");
            Console.WriteLine(@"   H:::::H     H:::::H      eeeeeeeeeeee    l::::l iiiiiii xxxxxxx      xxxxxxx");
            Console.WriteLine(@"   H:::::H     H:::::H    ee::::::::::::ee  l::::l i:::::i  x:::::x    x:::::x ");
            Console.WriteLine(@"   H::::::HHHHH::::::H   e::::::eeeee:::::eel::::l  i::::i   x:::::x  x:::::x  ");
            Console.WriteLine(@"   H:::::::::::::::::H  e::::::e     e:::::el::::l  i::::i    x:::::xx:::::x   ");
            Console.WriteLine(@"   H:::::::::::::::::H  e:::::::eeeee::::::el::::l  i::::i     x::::::::::x    ");
            Console.WriteLine(@"   H::::::HHHHH::::::H  e:::::::::::::::::e l::::l  i::::i      x::::::::x     ");
            Console.WriteLine(@"   H:::::H     H:::::H  e::::::eeeeeeeeeee  l::::l  i::::i      x::::::::x     ");
            Console.WriteLine(@"   H:::::H     H:::::H  e:::::::e           l::::l  i::::i     x::::::::::x    ");
            Console.WriteLine(@" HH::::::H     H::::::HHe::::::::e         l::::::li::::::i   x:::::xx:::::x   ");
            Console.WriteLine(@" H:::::::H     H:::::::H e::::::::eeeeeeee l::::::li::::::i  x:::::x  x:::::x  ");
            Console.WriteLine(@" H:::::::H     H:::::::H  ee:::::::::::::e l::::::li::::::i x:::::x    x:::::x ");
            Console.WriteLine(@" HHHHHHHHH     HHHHHHHHH    eeeeeeeeeeeeee lllllllliiiiiiiixxxxxxx      xxxxxxx");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Helix] Helix Spoofer By github.com/soarcheats");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);
            Console.WriteLine("[Helix] Patching Windows.");
            WebClient wb = new WebClient();
            wb.DownloadFile("", @"C:\Windows\IME\eac.sys");
            wb.DownloadFile("", @"C:\Windows\IME\mapper.exe");
            system(@"C:\Windows\IME\mapper.exe C:\Windows\IME\eac.sys");
            File.Delete(@"C:\Windows\IME\eac.sys");
            File.Delete(@"C:\Windows\IME\mapper.exe");
            Thread.Sleep(2000);
            Console.WriteLine("[Helix] Attemtping BIOS Spoof");

            if (File.Exists(@"C:\Windows\System32\drivers\bios.exe"))
            {
                File.Delete(@"C:\Windows\System32\drivers\bios.exe");
            }
            wb.DownloadFile("", @"C:\Windows\System32\drivers\bios.exe");
            system(@"C:\Windows\System32\drivers\bios.exe");

            Thread.Sleep(1000);
            Console.WriteLine("[Helix] Patching Spoofer Results");
            KillProcess("WmiPrvSE.exe");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Helix] Spoof Success");
            Thread.Sleep(2000);
            FreeConsole();
        }

        static void SpoofBE()
        {
            AllocConsole();
            Console.Title = "HelixSpoofer - BattleEye - Public";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WindowWidth = 200;
            Console.WindowHeight = 32;
            Console.WriteLine(@" HHHHHHHHH     HHHHHHHHH                   lllllll   iiii                      ");
            Console.WriteLine(@" H:::::::H     H:::::::H                   l:::::l  i::::i                     ");
            Console.WriteLine(@" H:::::::H     H:::::::H                   l:::::l   iiii                      ");
            Console.WriteLine(@" HH::::::H     H::::::HH                   l:::::l                             ");
            Console.WriteLine(@"   H:::::H     H:::::H      eeeeeeeeeeee    l::::l iiiiiii xxxxxxx      xxxxxxx");
            Console.WriteLine(@"   H:::::H     H:::::H    ee::::::::::::ee  l::::l i:::::i  x:::::x    x:::::x ");
            Console.WriteLine(@"   H::::::HHHHH::::::H   e::::::eeeee:::::eel::::l  i::::i   x:::::x  x:::::x  ");
            Console.WriteLine(@"   H:::::::::::::::::H  e::::::e     e:::::el::::l  i::::i    x:::::xx:::::x   ");
            Console.WriteLine(@"   H:::::::::::::::::H  e:::::::eeeee::::::el::::l  i::::i     x::::::::::x    ");
            Console.WriteLine(@"   H::::::HHHHH::::::H  e:::::::::::::::::e l::::l  i::::i      x::::::::x     ");
            Console.WriteLine(@"   H:::::H     H:::::H  e::::::eeeeeeeeeee  l::::l  i::::i      x::::::::x     ");
            Console.WriteLine(@"   H:::::H     H:::::H  e:::::::e           l::::l  i::::i     x::::::::::x    ");
            Console.WriteLine(@" HH::::::H     H::::::HHe::::::::e         l::::::li::::::i   x:::::xx:::::x   ");
            Console.WriteLine(@" H:::::::H     H:::::::H e::::::::eeeeeeee l::::::li::::::i  x:::::x  x:::::x  ");
            Console.WriteLine(@" H:::::::H     H:::::::H  ee:::::::::::::e l::::::li::::::i x:::::x    x:::::x ");
            Console.WriteLine(@" HHHHHHHHH     HHHHHHHHH    eeeeeeeeeeeeee lllllllliiiiiiiixxxxxxx      xxxxxxx");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Helix] Helix Spoofer By github.com/soarcheats");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);
            Console.WriteLine("[Helix] Patching Windows.");
            WebClient wb = new WebClient();
            wb.DownloadFile("", @"C:\Windows\IME\be.sys");
            wb.DownloadFile("", @"C:\Windows\IME\mapper.exe");
            system(@"C:\Windows\IME\mapper.exe C:\Windows\IME\be.sys");
            File.Delete(@"C:\Windows\IME\be.sys");
            File.Delete(@"C:\Windows\IME\mapper.exe");
            Thread.Sleep(2000);
            Console.WriteLine("[Helix] Attemtping BIOS Spoof");

            if (File.Exists(@"C:\Windows\System32\drivers\bios.exe"))
            {
                File.Delete(@"C:\Windows\System32\drivers\bios.exe");
            }
            wb.DownloadFile("", @"C:\Windows\System32\drivers\bios.exe");
            system(@"C:\Windows\System32\drivers\bios.exe");

            Thread.Sleep(1000);
            Console.WriteLine("[Helix] Patching Spoofer Results");
            KillProcess("WmiPrvSE.exe");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Helix] Spoof Success");
            Thread.Sleep(2000);
            FreeConsole();
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            if (label4.Text == "Seed - Non Selected")
            {
                MessageBox.Show("Game Seed Not Selected, Please Select One Of The Game Seeds!","0x00",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (variables.fallguys == true)
            {
                SpoofEAC();
            }
            if (variables.apex == true)
            {
                SpoofEAC();
            }
            if (variables.eft == true)
            {
                SpoofBE();
            }
            if (variables.rainbow == true)
            {
                SpoofBE();
            }
            if (variables.fortnite == true)
            {
                SpoofEAC();
            }
            if (variables.dbd == true)
            {
                SpoofEAC();
            }
            if (variables.dayz == true)
            {
                SpoofBE();
            }
            if (variables.polygon == true)
            {
                SpoofEAC();
            }
            if (variables.randwoof == true)
            {
                SpoofEAC();
            }
            if (variables.nullwoof == true)
            {
                SpoofBE();
            }
            if (variables.pubg == true)
            {
                SpoofBE();
            }
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            if (File.Exists(@"C:\Windows\System32\clean.exe"))
            {
                File.Delete(@"C:\Windows\System32\clean.exe");
            }
            wb.DownloadFile("", @"C:\Windows\System32\clean.exe");
            Process.Start(@"C:\Windows\System32\clean.exe");
        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            if (File.Exists(@"C:\Windows\System32\drivers\checker.bat"))
            {
                File.Delete(@"C:\Windows\System32\drivers\checker.bat");
            }
            wb.DownloadFile("", @"C:\Windows\System32\drivers\checker.bat");
            Process.Start(@"C:\Windows\System32\drivers\checker.bat");
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
