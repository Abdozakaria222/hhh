namespace hhh
{
    partial class UC_Cleaning
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnCleanTemp;
        private System.Windows.Forms.Button btnCleanCache;
        private System.Windows.Forms.Button btnDNS;
        private System.Windows.Forms.Button btnAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCleanTemp = new System.Windows.Forms.Button();
            this.btnCleanCache = new System.Windows.Forms.Button();
            this.btnDNS = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnCleanTemp
            this.btnCleanTemp.Location = new System.Drawing.Point(30, 40);
            this.btnCleanTemp.Size = new System.Drawing.Size(260, 45);
            this.btnCleanTemp.Text = "Clean TEMP";
            this.btnCleanTemp.Click += new System.EventHandler(this.btnCleanTemp_Click);

            // btnCleanCache
            this.btnCleanCache.Location = new System.Drawing.Point(30, 100);
            this.btnCleanCache.Size = new System.Drawing.Size(260, 45);
            this.btnCleanCache.Text = "Clean Cache";
            this.btnCleanCache.Click += new System.EventHandler(this.btnCleanCache_Click);

            // btnDNS
            this.btnDNS.Location = new System.Drawing.Point(30, 160);
            this.btnDNS.Size = new System.Drawing.Size(260, 45);
            this.btnDNS.Text = "Flush DNS";
            this.btnDNS.Click += new System.EventHandler(this.btnDNS_Click);

            // btnAll
            this.btnAll.Location = new System.Drawing.Point(30, 220);
            this.btnAll.Size = new System.Drawing.Size(260, 45);
            this.btnAll.Text = "Clean All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);

            // UC_Cleaning
            this.Controls.Add(this.btnCleanTemp);
            this.Controls.Add(this.btnCleanCache);
            this.Controls.Add(this.btnDNS);
            this.Controls.Add(this.btnAll);
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
        }
    }
}
