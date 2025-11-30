using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SystemOptimizer
{
    public partial class UC_Cleaning : UserControl
    {
        public UC_Cleaning()
        {
            InitializeComponent();
        }

        private void CleanFolder(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);

                foreach (var f in di.GetFiles()) try { f.Delete(); } catch { }
                foreach (var d in di.GetDirectories()) try { d.Delete(true); } catch { }
            }
            catch {}
        }

        private void btnCleanTemp_Click(object sender, EventArgs e)
        {
            CleanFolder(Path.GetTempPath());
            CleanFolder(@"C:\Windows\Temp");
            MessageBox.Show("تم تنظيف TEMP.");
        }

        private void btnCleanCache_Click(object sender, EventArgs e)
        {
            CleanFolder(@"C:\Windows\Prefetch");
            CleanFolder(@"C:\Windows\SoftwareDistribution\Download");
            MessageBox.Show("تم تنظيف الكاش.");
        }

        private void btnDNS_Click(object sender, EventArgs e)
        {
            Process.Start("ipconfig", "/flushdns");
            MessageBox.Show("تم مسح DNS Cache.");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnCleanTemp_Click(sender, e);
            btnCleanCache_Click(sender, e);
            btnDNS_Click(sender, e);
        }
    }
}
