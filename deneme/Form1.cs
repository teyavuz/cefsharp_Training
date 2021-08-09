using CefSharp;
using CefSharp.WinForms;
using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser chrome;
        ChromiumWebBrowser chrome2;
        ChromiumWebBrowser chrome3;
        ChromiumWebBrowser chrome4;

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();

            Cef.Initialize(settings);
            string urltext = "https://www.google.com";
            string urltext2 = "https://www.youtube.com";
            string urltext3 = "https://www.dermoeczanem.com";
            string urltext4 = "https://www.dermomarket.com";
            chrome = new ChromiumWebBrowser(urltext);
            chrome2 = new ChromiumWebBrowser(urltext2);
            chrome3 = new ChromiumWebBrowser(urltext3);
            chrome4 = new ChromiumWebBrowser(urltext4);
            this.pContainer.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            this.pContainer2.Controls.Add(chrome2);
            chrome2.Dock = DockStyle.Fill;
            this.pContainer3.Controls.Add(chrome3);
            chrome3.Dock = DockStyle.Fill;
            this.pContainer4.Controls.Add(chrome4);
            chrome4.Dock = DockStyle.Fill;
        }
        

        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chrome.Reload();
        }

        private void btnTimer2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            chrome2.Reload();
        }

        private void btnTimer1Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnTimer2Stop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            chrome3.Reload();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            chrome4.Reload();
        }

        private void txtPanel1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
