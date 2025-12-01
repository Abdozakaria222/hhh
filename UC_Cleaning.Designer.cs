using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Cleaning : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTemp, btnCache, btnDNS, btnAll;

        public UC_Cleaning() { InitializeComponent(); }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnTemp  = new Button();
            btnCache = new Button();
            btnDNS   = new Button();
            btnAll   = new Button();
            SuspendLayout();

            btnTemp.Location = new Point(50, 50);
            btnTemp.Size = new Size(250, 45);
            btnTemp.Text = "Clean TEMP";
            btnTemp.Click += (s, e) => MessageBox.Show("Cleaning TEMP files...");

            btnCache.Location = new Point(50, 110);
            btnCache.Size = new Size(250, 45);
            btnCache.Text = "Clean Cache";
            btnCache.Click += (s, e) => MessageBox.Show("Cleaning Cache...");

            btnDNS.Location = new Point(50, 170);
            btnDNS.Size = new Size(250, 45);
            btnDNS.Text = "Flush DNS";
            btnDNS.Click += (s, e) => MessageBox.Show("Flushing DNS cache...");

            btnAll.Location = new Point(50, 230);
            btnAll.Size = new Size(250, 45);
            btnAll.Text = "Clean All";
            btnAll.Click += (s, e) => MessageBox.Show("Cleaning all system caches...");

            Controls.AddRange(new Control[] { btnTemp, btnCache, btnDNS, btnAll });
            Size = new Size(700, 500);
            ResumeLayout(false);
        }
    }
}
