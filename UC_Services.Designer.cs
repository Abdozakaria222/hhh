namespace hhh
{
    partial class UC_Services
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRestore;

        /// <summary> 
        /// تنظيف الموارد المُستخدمة.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region كود التهيئة
        private void InitializeComponent()
        {
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(60, 40);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(250, 45);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "إيقاف الخدمات غير الضرورية";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(60, 100);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(250, 45);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "استعادة الإعدادات الافتراضية";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);

            // 
            // UC_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRestore);
            this.Name = "UC_Services";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);
        }
        #endregion
    }
}
