using System;
using System.IO;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Cleaning : UserControl
    {
        public UC_Cleaning()
        {
            InitializeComponent();
        }

        private void btnCleanTemp_Click(object sender, EventArgs e)
        {
            CleanFolder(Path.GetTempPath());
            CleanFolder(@"C:\Windows\Temp");
            MessageBox.Show("تم تنظيف TEMP.", "Cleaning");
        }

        private void btnCleanCache_Click(object sender, EventArgs e)
        {
            CleanFolder(@"C:\Windows\Prefetch");
            CleanFolder(@"C:\Windows\SoftwareDistribution\Download");
            MessageBox.Show("تم تنظيف Cache.", "Cleaning");
        }

        private void btnDNS_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start("ipconfig", "/flushdns"); }
            catch { }
            MessageBox.Show("تم مسح DNS Cache.", "Cleaning");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnCleanTemp_Click(sender, e);
            btnCleanCache_Click(sender, e);
            btnDNS_Click(sender, e);
        }

        private static void CleanFolder(string path)
        {
            try
            {
                var di = new DirectoryInfo(path);
                foreach (var f in di.GetFiles()) { try { f.Delete(); } catch { } }
                foreach (var d in di.GetDirectories()) { try { d.Delete(true); } catch { } }
            }
            catch { }
        }
    }
}
