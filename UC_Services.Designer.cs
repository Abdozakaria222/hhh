namespace SystemOptimizer
{
    partial class UC_Services
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStop;
        private Button btnRestore;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStop = new Button();
            this.btnRestore = new Button();

            // btnStop
            this.btnStop.Text = "Stop Unneeded Services";
            this.btnStop.Width = 250;
            this.btnStop.Height = 45;
            this.btnStop.Top = 50;
            this.btnStop.Left = 30;
            this.btnStop.Click += new EventHandler(this.btnStop_Click);

            // btnRestore
            this.btnRestore.Text = "Restore Default Services";
            this.btnRestore.Width = 250;
            this.btnRestore.Height = 45;
            this.btnRestore.Top = 110;
            this.btnRestore.Left = 30;
            this.btnRestore.Click += new EventHandler(this.btnRestore_Click);

            // UC_Services
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRestore);
            this.Size = new System.Drawing.Size(700, 500);
        }
    }
}
