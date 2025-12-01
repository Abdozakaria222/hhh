namespace hhh
{
    partial class UC_Tweaks
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRegistryTweaks;
        private System.Windows.Forms.Button btnFreeRAM;
        private System.Windows.Forms.Button btnOptimizeAll;

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
            this.btnRegistryTweaks = new System.Windows.Forms.Button();
            this.btnFreeRAM = new System.Windows.Forms.Button();
            this.btnOptimizeAll = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnRegistryTweaks
            this.btnRegistryTweaks.Location = new System.Drawing.Point(60, 40);
            this.btnRegistryTweaks.Size = new System.Drawing.Size(250, 45);
            this.btnRegistryTweaks.Text = "تطبيق تحسينات الريجستري";
            this.btnRegistryTweaks.Click += new System.EventHandler(this.btnRegistryTweaks_Click);

            // btnFreeRAM
            this.btnFreeRAM.Location = new System.Drawing.Point(60, 100);
            this.btnFreeRAM.Size = new System.Drawing.Size(250, 45);
            this.btnFreeRAM.Text = "تفريغ الذاكرة RAM";
            this.btnFreeRAM.Click += new System.EventHandler(this.btnFreeRAM_Click);

            // btnOptimizeAll
            this.btnOptimizeAll.Location = new System.Drawing.Point(60, 160);
            this.btnOptimizeAll.Size = new System.Drawing.Size(250, 45);
            this.btnOptimizeAll.Text = "تحسين الكل";
            this.btnOptimizeAll.Click += new System.EventHandler(this.btnOptimizeAll_Click);

            // UC_Tweaks
            this.Controls.Add(this.btnRegistryTweaks);
            this.Controls.Add(this.btnFreeRAM);
            this.Controls.Add(this.btnOptimizeAll);
            this.Name = "UC_Tweaks";
            this.Size = new System.Drawing.Size(400, 280);
            this.ResumeLayout(false);
        }
        #endregion
    }
}
