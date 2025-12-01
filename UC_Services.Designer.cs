namespace hhh
{
    partial class UC_Services
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStop;
        private Button btnRestore;

        private void InitializeComponent()
        {
            this.btnStop = new Button();
            this.btnRestore = new Button();
            this.SuspendLayout();

            // btnStop
            this.btnStop.Text = "إيقاف الخدمات";
            this.btnStop.Location = new System.Drawing.Point(50, 50);
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // btnRestore
            this.btnRestore.Text = "استعادة الإعدادات";
            this.btnRestore.Location = new System.Drawing.Point(50, 110);
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);

            // UC_Services
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRestore);
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
        }
    }
}
