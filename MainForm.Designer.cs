namespace SystemOptimizer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSidebar;
        private Panel panelMain;
        private Button btnServices;
        private Button btnCleaning;
        private Button btnTweaks;

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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnTweaks = new System.Windows.Forms.Button();
            this.btnCleaning = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();

            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.panelSidebar.Controls.Add(this.btnTweaks);
            this.panelSidebar.Controls.Add(this.btnCleaning);
            this.panelSidebar.Controls.Add(this.btnServices);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Width = 150;

            // btnServices
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Text = "Services";
            this.btnServices.Height = 50;
            this.btnServices.Dock = DockStyle.Top;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);

            // btnCleaning
            this.btnCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleaning.ForeColor = System.Drawing.Color.White;
            this.btnCleaning.Text = "Cleaning";
            this.btnCleaning.Height = 50;
            this.btnCleaning.Dock = DockStyle.Top;
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);

            // btnTweaks
            this.btnTweaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTweaks.ForeColor = System.Drawing.Color.White;
            this.btnTweaks.Text = "Tweaks";
            this.btnTweaks.Height = 50;
            this.btnTweaks.Dock = DockStyle.Top;
            this.btnTweaks.Click += new System.EventHandler(this.btnTweaks_Click);

            // panelMain
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);

            // MainForm
            this.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Text = "System Optimizer";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(900, 600);

            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
