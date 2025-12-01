using System;
using System.Diagnostics;
using System.ServiceProcess;   // مهم لهذا الـ UserControl
using System.Windows.Forms;

namespace hhh
{
    public partial class UC_Services : UserControl
    {
        public UC_Services()
        {
            InitializeComponent();    // لازم تكون موجودة في ملف الـ Designer
        }

        // إيقاف مجموعة خدمات غير ضرورية (لو موجودة على الجهاز)
        private void btnStop_Click(object sender, EventArgs e)
        {
            string[] svcs =
            {
                "DiagTrack",          // Telemetry
                "WSearch",            // Windows Search
                "WerSvc",             // Error Reporting
                "Fax",
                "RemoteRegistry",
                "XblAuthManager",
                "XblGameSave",
                "XboxNetApiSvc",
                "WMPNetworkSvc"
            };

            foreach (var name in svcs)
            {
                try
                {
                    using (var sc = new ServiceController(name))
                    {
                        if (sc.Status != ServiceControllerStatus.Stopped &&
                            sc.Status != ServiceControllerStatus.StopPending)
                        {
                            sc.Stop();
                            sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                        }
                    }
                }
                catch { /* الخدمة غير موجودة أو صلاحيات غير كافية — تجاهل بأمان */ }
            }

            MessageBox.Show("تمت محاولة إيقاف الخدمات المحددة (إن وُجدت).", "Services",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // استرجاع الوضع الافتراضي لعدد من الخدمات الشائعة
        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                RunSc("config WSearch start= delayed-auto");
                RunSc("config DiagTrack start= auto");
                RunSc("start WSearch");
            }
            catch { /* نتجاهل أي أخطاء فردية */ }

            MessageBox.Show("تمت محاولة استعادة الإعدادات الافتراضية.", "Services",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void RunSc(string args)
        {
            using (var p = new Process())
            {
                p.StartInfo.FileName = "sc.exe";
                p.StartInfo.Arguments = args;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.WaitForExit(8000);
            }
        }
    }
}
