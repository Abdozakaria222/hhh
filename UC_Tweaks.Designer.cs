using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Tweaks : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnRegistryTweaks, btnFreeRAM, btnOptimizeAll;

        public UC_Tweaks() { InitializeComponent(); }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnRegistryTweaks = new Button();
            btnFreeRAM = new Button();
            btnOptimizeAll = new Button();
            SuspendLayout();

            btnRegistryTweaks.Location = new Point(50, 50);
            btnRegistryTweaks.Size = new Size(250, 45);
            btnRegistryTweaks.Text = "Apply Registry Tweaks";
            btnRegistryTweaks.Click += (s, e) => MessageBox.Show("Applying registry optimizations...");

            btnFreeRAM.Location = new Point(50, 110);
            btnFreeRAM.Size = new Size(250, 45);
            btnFreeRAM.Text = "Free RAM";
            btnFreeRAM.Click += (s, e) => MessageBox.Show("Freeing RAM...");

            btnOptimizeAll.Location = new Point(50, 170);
            btnOptimizeAll.Size = new Size(250, 45);
            btnOptimizeAll.Text = "Optimize All";
            btnOptimizeAll.Click += (s, e) => MessageBox.Show("Applying all tweaks...");

            Controls.AddRange(new Control[] { btnRegistryTweaks, btnFreeRAM, btnOptimizeAll });
            Size = new Size(700, 500);
            ResumeLayout(false);
        }
    }
