namespace hhh
{
    partial class UC_Cleaning
    {
        /// <summary> 
        /// متغيرات مكونات الواجهة
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCleanTemp;
        private System.Windows.Forms.Button btnCleanCache;
        private System.Windows.Forms.Button btnDNS;
        private System.Windows.Forms.Button btnAll;

        /// <summary> 
        /// تنظيف الموارد
        /// </summary>
        /// <param name="disposing">true إذا تم التخلص من الموارد.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region كود التهيئة
        private void InitializeComponent()
        {
            this.btnCleanTemp = new System.Windows.Forms.Button();
            this.btnCleanCache = new System.Windows.Forms.Button();
            this.btnDNS = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnCleanTemp
            this.btnCleanTemp.Location = new System.Drawing.Point(60, 40);
            this.btnCleanTemp.Size = new System.Drawing.Size(250, 45);
            this.btnCleanTemp.Text = "تنظيف ملفات TEMP";
            this.btnCleanTemp.Click += new System.EventHandler(this.btnCleanTemp_Click);

            // btnCleanCache
            this.btnCleanCache.Location = new System.Drawing.Point(60, 100);
            this.btnCleanCache.Size = new System.Drawing.Size(250, 45);
            this.btnCleanCache.Text = "تنظيف ملفات Cache";
            this.btnCleanCache.Click += new System.EventHandler(this.btnCleanCache_Click);

            // btnDNS
            this.btnDNS.Location = new System.Drawing.Point(60, 160);
            this.btnDNS.Size = new System.Drawing.Size(250, 45);
            this.btnDNS.Text = "مسح DNS Cache";
            this.btnDNS.Click += new System.EventHandler(this.btnDNS_Click);

            // btnAll
            this.btnAll.Location = new System.Drawing.Point(60, 220);
            this.btnAll.Size = new System.Drawing.Size(250, 45);
            this.btnAll.Text = "تنظيف الكل";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);

            // UC_Cleaning
            this.Controls.Add(this.btnCleanTemp);
            this.Controls.Add(this.btnCleanCache);
            this.Controls.Add(this.btnDNS);
            this.Controls.Add(this.btnAll);
            this.Name = "UC_Cleaning";
            this.Size = new System.Drawing.Size(400, 320);
            this.ResumeLayout(false);
        }
        #endregion
    }
}
