using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoidSpooferV2
{
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: ""
        );

        static void KillProcess(string proc)
        {
            Process[] ps = Process.GetProcessesByName(proc);

            foreach (Process p in ps)
                p.Kill();
        }

        void LoopKill()
        {
            KillProcess("EpicGamesLauncher");
            KillProcess("BEService");
            KillProcess("FortniteClient-Win64-Shipping");
            KillProcess("FortniteClient-Win64-Shipping-EAC");
            KillProcess("FortniteClient-Win64-Shipping-BE");
            KillProcess("vgtray");
            KillProcess("vanguard");
            KillProcess("dnSpy");
            KillProcess("x64dbg");
            KillProcess("x32dbg");
            KillProcess("ida64");
            KillProcess("ida32");
            KillProcess("FolderChangesView");
            KillProcess("MegaDumper");
            KillProcess("ExtremeDumper");
            KillProcess("VALORANT");

            LoopKill();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread loop = new Thread(LoopKill);
            loop.Start();
            if (File.Exists(@"C:\Windows\System32\drivers\spoof.login"))
            {
                string bruh = File.ReadAllText(@"C:\Windows\System32\drivers\spoof.login");
                gunaLineTextBox1.Text = bruh;
            }
            KeyAuthApp.init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(gunaLineTextBox1.Text);
            if (KeyAuthApp.response.success)
            {
                File.Create(@"C:\Windows\System32\drivers\spoof.login").Dispose();
                File.WriteAllText(@"C:\Windows\System32\drivers\spoof.login", gunaLineTextBox1.Text);
                spoofui ui = new spoofui();
                ui.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Invalid License", "0x00", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
