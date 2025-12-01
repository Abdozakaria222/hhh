using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Services : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStop;
        private Button btnRestore;

        public UC_Services() { InitializeComponent(); }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnStop = new Button();
            btnRestore = new Button();
            SuspendLayout();

            btnStop.Location = new Point(50, 60);
            btnStop.Size = new Size(250, 45);
            btnStop.Text = "Stop Unneeded Services";
            btnStop.Click += btnStop_Click;

            btnRestore.Location = new Point(50, 130);
            btnRestore.Size = new Size(250, 45);
            btnRestore.Text = "Restore Default Services";
            btnRestore.Click += btnRestore_Click;

            Controls.Add(btnStop);
            Controls.Add(btnRestore);
            Size = new Size(700, 500);
            ResumeLayout(false);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stopping unnecessary services...");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restoring default Windows services...");
        }
    }
}
