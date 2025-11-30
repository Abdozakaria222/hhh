using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SystemOptimizer
{
    public partial class UC_Tweaks : UserControl
    {
        public UC_Tweaks()
        {
            InitializeComponent();
        }

        private void btnRegistryTweaks_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey k1 = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management");
                k1.SetValue("ClearPageFileAtShutdown", 1, RegistryValueKind.DWord);

                RegistryKey k2 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile");
                k2.SetValue("NetworkThrottlingIndex", 0xffffffff, RegistryValueKind.DWord);

                MessageBox.Show("تم تطبيق تحسينات الريجستري.");
            }
            catch
            {
                MessageBox.Show("قم بتشغيل البرنامج كمسؤول.");
            }
        }

        private void btnFreeRAM_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c echo FreeMem=Space(2621440000) > %temp%\\ram.vbs");
            Process.Start("cmd.exe", "/c cscript %temp%\\ram.vbs");
            MessageBox.Show("تم تفريغ الرام.");
        }

        private void btnOptimizeAll_Click(object sender, EventArgs e)
        {
            btnRegistryTweaks_Click(sender, e);
            btnFreeRAM_Click(sender, e);
            MessageBox.Show("تم التحسين الكامل!");
        }
    }
}
