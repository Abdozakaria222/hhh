namespace hhh
{
    partial class UC_Services
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRestore;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnStop
            this.btnStop.Location = new System.Drawing.Point(30, 40);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(260, 45);
            this.btnStop.Text = "Stop Unneeded Services";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // btnRestore
            this.btnRestore.Location = new System.Drawing.Point(30, 100);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(260, 45);
            this.btnRestore.Text = "Restore Default Services";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);

            // UC_Services
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRestore);
            this.Name = "UC_Services";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
        }
    }
}
