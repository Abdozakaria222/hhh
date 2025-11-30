using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Tweaks : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnRegistryTweaks;
        private Button btnFreeRAM;
        private Button btnOptimizeAll;

        public UC_Tweaks()
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
            this.btnRegistryTweaks = new Button();
            this.btnFreeRAM = new Button();
            this.btnOptimizeAll = new Button();
            this.SuspendLayout();

            // btnRegistryTweaks
            this.btnRegistryTweaks.Location = new Point(30, 40);
            this.btnRegistryTweaks.Size = new Size(260, 45);
            this.btnRegistryTweaks.Text = "Apply Registry Tweaks";
            this.btnRegistryTweaks.Click += new EventHandler(this.btnRegistryTweaks_Click);

            // btnFreeRAM
            this.btnFreeRAM.Location = new Point(30, 100);
            this.btnFreeRAM.Size = new Size(260, 45);
            this.btnFreeRAM.Text = "Free RAM";
            this.btnFreeRAM.Click += new EventHandler(this.btnFreeRAM_Click);

            // btnOptimizeAll
            this.btnOptimizeAll.Location = new Point(30, 160);
            this.btnOptimizeAll.Size = new Size(260, 45);
            this.btnOptimizeAll.Text = "Optimize All";
            this.btnOptimizeAll.Click += new EventHandler(this.btnOptimizeAll_Click);

            // UC_Tweaks
            this.Controls.Add(this.btnRegistryTweaks);
            this.Controls.Add(this.btnFreeRAM);
            this.Controls.Add(this.btnOptimizeAll);
            this.Name = "UC_Tweaks";
            this.Size = new Size(700, 500);
            this.ResumeLayout(false);
        }
    }
}
