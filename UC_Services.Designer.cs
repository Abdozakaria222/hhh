using System;
using System.Drawing;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Services : UserControl
    {
        private Button btnStop;
        private Button btnRestore;

        public UC_Services()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnStop = new Button();
            this.btnRestore = new Button();
            this.SuspendLayout();

            this.btnStop.Location = new Point(50, 60);
            this.btnStop.Size = new Size(250, 45);
            this.btnStop.Text = "Stop Unneeded Services";
            this.btnStop.Click += new EventHandler(this.btnStop_Click);

            this.btnRestore.Location = new Point(50, 130);
            this.btnRestore.Size = new Size(250, 45);
            this.btnRestore.Text = "Restore Default Services";
            this.btnRestore.Click += new EventHandler(this.btnRestore_Click);

            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRestore);
            this.Size = new Size(700, 500);
            this.ResumeLayout(false);
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
