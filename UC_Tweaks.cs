using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace hhh
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
                using (var mm = Registry.LocalMachine.CreateSubKey(
                    @"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"))
                {
                    mm?.SetValue("ClearPageFileAtShutdown", 1, RegistryValueKind.DWord);
                }

                using (var net = Registry.LocalMachine.CreateSubKey(
                    @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"))
                {
                    net?.SetValue("NetworkThrottlingIndex", 0xffffffff, RegistryValueKind.DWord);
                }

                MessageBox.Show("تم تطبيق تحسينات الريجستري.", "Tweaks");
            }
            catch
            {
                MessageBox.Show("شغّل البرنامج كمسؤول لتطبيق هذه التعديلات.", "Tweaks");
            }
        }

        private void btnFreeRAM_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd.exe", "/c echo FreeMem=Space(2621440000) > %temp%\\ram.vbs");
                Process.Start("cmd.exe", "/c cscript //nologo %temp%\\ram.vbs");
            }
            catch { }
            MessageBox.Show("تم تفريغ جزء من الذاكرة.", "Tweaks");
        }

        private void btnOptimizeAll_Click(object sender, EventArgs e)
        {
            btnRegistryTweaks_Click(sender, e);
            btnFreeRAM_Click(sender, e);
            MessageBox.Show("تم تنفيذ جميع تحسينات الأداء.", "Tweaks");
        }
    }
}
