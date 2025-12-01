using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Services : UserControl
    {
        public UC_Services()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string[] services =
            {
                "DiagTrack", "WSearch", "WerSvc",
                "Fax", "RemoteRegistry", "XblAuthManager",
                "XblGameSave", "XboxNetApiSvc", "WMPNetworkSvc"
            };

            foreach (var name in services)
            {
                try
                {
                    using (var sc = new ServiceController(name))
                    {
                        if (sc.Status != ServiceControllerStatus.Stopped)
                        {
                            sc.Stop();
                            sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                        }
                    }
                }
                catch { }
            }

            MessageBox.Show("تم إيقاف الخدمات المحددة بنجاح.", "Services");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("sc.exe", "config WSearch start= delayed-auto");
            }
            catch { }
        }
    }
}
