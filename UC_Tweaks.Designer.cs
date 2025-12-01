using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Tweaks : UserControl
    {
        private Button btnRegistryTweaks;
        private Button btnRAM;
        private Button btnOptimize;

        public UC_Tweaks()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnRegistryTweaks = new Button();
            this.btnRAM = new Button();
            this.btnOptimize = new Button();
            this.SuspendLayout();

            this.btnRegistryTweaks.Location = new Point(50, 50);
            this.btnRegistryTweaks.Size = new Size(250, 45);
            this.btnRegistryTweaks.Text = "Apply Registry Tweaks";
            this.btnRegistryTweaks.Click += (s, e) => MessageBox.Show("Applying registry optimizations...");

            this.btnRAM.Location = new Point(50, 110);
            this.btnRAM.Size = new Size(250, 45);
            this.btnRAM.Text = "Free RAM";
            this.btnRAM.Click += (s, e) => MessageBox.Show("Freeing up RAM...");

            this.btnOptimize.Location = new Point(50, 170);
            this.btnOptimize.Size = new Size(250, 45);
            this.btnOptimize.Text = "Optimize All";
            this.btnOptimize.Click += (s, e) => MessageBox.Show("Applying all system tweaks...");

            this.Controls.Add(this.btnRegistryTweaks);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnOptimize);
            this.Size = new Size(700, 500);
            this.ResumeLayout(false);
        }
    }
}
