using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class MainForm : Form
    {
        private Panel sidebar;
        private Button btnServices;
        private Button btnCleaning;
        private Button btnTweaks;
        private Panel contentPanel;

        private void InitializeComponent()
        {
            this.sidebar = new Panel();
            this.btnServices = new Button();
            this.btnCleaning = new Button();
            this.btnTweaks = new Button();
            this.contentPanel = new Panel();
            this.SuspendLayout();

            // Sidebar
            this.sidebar.Dock = DockStyle.Left;
            this.sidebar.Width = 150;
            this.sidebar.BackColor = Color.FromArgb(40, 40, 40);

            // Buttons
            this.btnServices.Text = "Services";
            this.btnServices.Dock = DockStyle.Top;
            this.btnServices.Height = 50;
            this.btnServices.Click += new EventHandler(this.btnServices_Click);

            this.btnCleaning.Text = "Cleaning";
            this.btnCleaning.Dock = DockStyle.Top;
            this.btnCleaning.Height = 50;
            this.btnCleaning.Click += new EventHandler(this.btnCleaning_Click);

            this.btnTweaks.Text = "Tweaks";
            this.btnTweaks.Dock = DockStyle.Top;
            this.btnTweaks.Height = 50;
            this.btnTweaks.Click += new EventHandler(this.btnTweaks_Click);

            // Content Panel
            this.contentPanel.Dock = DockStyle.Fill;
            this.contentPanel.BackColor = Color.WhiteSmoke;

            // Add to sidebar
            this.sidebar.Controls.Add(this.btnTweaks);
            this.sidebar.Controls.Add(this.btnCleaning);
            this.sidebar.Controls.Add(this.btnServices);

            // MainForm
            this.ClientSize = new Size(900, 600);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebar);
            this.Text = "Windows Optimizer";

            this.ResumeLayout(false);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new UC_Services() { Dock = DockStyle.Fill });
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new UC_Cleaning() { Dock = DockStyle.Fill });
        }

        private void btnTweaks_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new UC_Tweaks() { Dock = DockStyle.Fill });
        }
    }
}
