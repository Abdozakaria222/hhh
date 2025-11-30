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

        public UC_Services()
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
            this.btnStop = new Button();
            this.btnRestore = new Button();
            this.SuspendLayout();

            // btnStop
            this.btnStop.Location = new Point(30, 40);
            this.btnStop.Size = new Size(260, 45);
            this.btnStop.Text = "Stop Unneeded Services";
            this.btnStop.Click += new EventHandler(this.btnStop_Click);

            // btnRestore
            this.btnRestore.Location = new Point(30, 100);
            this.btnRestore.Size = new Size(260, 45);
            this.btnRestore.Text = "Restore Default Services";
            this.btnRestore.Click += new EventHandler(this.btnRestore_Click);

            // UC_Services
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRestore);
            this.Name = "UC_Services";
            this.Size = new Size(700, 500);
            this.ResumeLayout(false);
        }
    }
}
