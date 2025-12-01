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
            sidebar = new Panel();
            btnServices = new Button();
            btnCleaning = new Button();
            btnTweaks   = new Button();
            contentPanel = new Panel();
            SuspendLayout();

            // sidebar
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 150;
            sidebar.BackColor = Color.FromArgb(40, 40, 40);

            // buttons
            btnServices.Text = "Services";
            btnServices.Dock = DockStyle.Top;
            btnServices.Height = 50;
            btnServices.Click += btnServices_Click;

            btnCleaning.Text = "Cleaning";
            btnCleaning.Dock = DockStyle.Top;
            btnCleaning.Height = 50;
            btnCleaning.Click += btnCleaning_Click;

            btnTweaks.Text = "Tweaks";
            btnTweaks.Dock = DockStyle.Top;
            btnTweaks.Height = 50;
            btnTweaks.Click += btnTweaks_Click;

            // content
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.WhiteSmoke;

            // compose
            sidebar.Controls.Add(btnTweaks);
            sidebar.Controls.Add(btnCleaning);
            sidebar.Controls.Add(btnServices);

            ClientSize = new Size(900, 600);
            Controls.Add(contentPanel);
            Controls.Add(sidebar);
            Text = "Windows Optimizer";

            ResumeLayout(false);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new UC_Services { Dock = DockStyle.Fill });
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new UC_Cleaning { Dock = DockStyle.Fill });
        }

        private void btnTweaks_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new UC_Tweaks { Dock = DockStyle.Fill });
        }
    }
}
