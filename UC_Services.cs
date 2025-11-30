using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Windows.Forms;

namespace SystemOptimizer
{
    public partial class UC_Services : UserControl
    {
        public UC_Services()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string[] svcs = {
                "DiagTrack","WSearch","WerSvc","Fax",
                "RemoteRegistry","XblAuthManager","XblGameSave",
                "XboxNetApiSvc","WMPNetworkSvc"
            };

            foreach (string svc in svcs)
            {
                try
                {
                    ServiceController sc = new ServiceController(svc);
                    if (sc.Status != ServiceControllerStatus.Stopped)
                        sc.Stop();
                }
                catch { }
            }

            MessageBox.Show("تم إيقاف الخدمات غير الضرورية.", "Done");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Process.Start("sc.exe", "config WSearch start= auto");
            Process.Start("sc.exe", "config DiagTrack start= auto");
            MessageBox.Show("تم استعادة الخدمات.", "تم");
        }
    }
}
