using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Cleaning : UserControl
    {
        private Button btnTemp;
        private Button btnCache;
        private Button btnDNS;
        private Button btnAll;

        public UC_Cleaning()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnTemp = new Button();
            this.btnCache = new Button();
            this.btnDNS = new Button();
            this.btnAll = new Button();
            this.SuspendLayout();

            this.btnTemp.Location = new Point(50, 50);
            this.btnTemp.Size = new Size(250, 45);
            this.btnTemp.Text = "Clean TEMP";
            this.btnTemp.Click += (s, e) => MessageBox.Show("Cleaning TEMP files...");

            this.btnCache.Location = new Point(50, 110);
            this.btnCache.Size = new Size(250, 45);
            this.btnCache.Text = "Clean Cache";
            this.btnCache.Click += (s, e) => MessageBox.Show("Cleaning Cache...");

            this.btnDNS.Location = new Point(50, 170);
            this.btnDNS.Size = new Size(250, 45);
            this.btnDNS.Text = "Flush DNS";
            this.btnDNS.Click += (s, e) => MessageBox.Show("Flushing DNS cache...");

            this.btnAll.Location = new Point(50, 230);
            this.btnAll.Size = new Size(250, 45);
            this.btnAll.Text = "Clean All";
            this.btnAll.Click += (s, e) => MessageBox.Show("Cleaning all system caches...");

            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnCache);
            this.Controls.Add(this.btnDNS);
            this.Controls.Add(this.btnAll);
            this.Size = new Size(700, 500);
            this.ResumeLayout(false);
        }
    }
}
