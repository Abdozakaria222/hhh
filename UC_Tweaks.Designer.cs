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
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRegistryTweaks = new System.Windows.Forms.Button();
            this.btnFreeRAM = new System.Windows.Forms.Button();
            this.btnOptimizeAll = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnRegistryTweaks
            this.btnRegistryTweaks.Location = new System.Drawing.Point(30, 40);
            this.btnRegistryTweaks.Size = new System.Drawing.Size(260, 45);
            this.btnRegistryTweaks.Text = "Apply Registry Tweaks";
            this.btnRegistryTweaks.Click += new System.EventHandler(this.btnRegistryTweaks_Click);

            // btnFreeRAM
            this.btnFreeRAM.Location = new System.Drawing.Point(30, 100);
            this.btnFreeRAM.Size = new System.Drawing.Size(260, 45);
            this.btnFreeRAM.Text = "Free RAM";
            this.btnFreeRAM.Click += new System.EventHandler(this.btnFreeRAM_Click);

            // btnOptimizeAll
            this.btnOptimizeAll.Location = new System.Drawing.Point(30, 160);
            this.btnOptimizeAll.Size = new System.Drawing.Size(260, 45);
            this.btnOptimizeAll.Text = "Optimize All";
            this.btnOptimizeAll.Click += new System.EventHandler(this.btnOptimizeAll_Click);

            // UC_Tweaks
            this.Controls.Add(this.btnRegistryTweaks);
            this.Controls.Add(this.btnFreeRAM);
            this.Controls.Add(this.btnOptimizeAll);
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
        }
    }
}
