using System;
using System.Windows.Forms;

namespace SystemOptimizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // تغيير المحتوى داخل panelMain
        private void LoadControl(Control ctrl)
        {
            panelMain.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ctrl);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Services());
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Cleaning());
        }

        private void btnTweaks_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Tweaks());
        }
    }
}
