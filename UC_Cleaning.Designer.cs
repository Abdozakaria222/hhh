using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Cleaning : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCleanTemp;
        private Button btnCleanCache;
        private Button btnDNS;
        private Button btnAll;

        public UC_Cleaning()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCleanTemp = new Button();
            this.btnCleanCache = new Button();
            this.btnDNS = new Button();
            this.btnAll = new Button();
            this.SuspendLayout();

            // btnCleanTemp
            this.btnCleanTemp.Location = new Point(30, 40);
            this.btnCleanTemp.Size = new Size(260, 45);
            this.btnCleanTemp.Text = "Clean TEMP";
            this.btnCleanTemp.Click += new EventHandler(this.btnCleanTemp_Click);

            // btnCleanCache
            this.btnCleanCache.Location = new Point(30, 100);
            this.btnCleanCache.Size = new Size(260, 45);
            this.btnCleanCache.Text = "Clean Cache";
            this.btnCleanCache.Click += new EventHandler(this.btnCleanCache_Click);

            // btnDNS
            this.btnDNS.Location = new Point(30, 160);
            this.btnDNS.Size = new Size(260, 45);
            this.btnDNS.Text = "Flush DNS";
            this.btnDNS.Click += new EventHandler(this.btnDNS_Click);

            // btnAll
            this.btnAll.Location = new Point(30, 220);
            this.btnAll.Size = new Size(260, 45);
            this.btnAll.Text = "Clean All";
            this.btnAll.Click += new EventHandler(this.btnAll_Click);

            // UC_Cleaning
            this.Controls.Add(this.btnCleanTemp);
            this.Controls.Add(this.btnCleanCache);
            this.Controls.Add(this.btnDNS);
            this.Controls.Add(this.btnAll);
            this.Name = "UC_Cleaning";
            this.Size = new Size(700, 500);
            this.ResumeLayout(false);
        }
    }
}
