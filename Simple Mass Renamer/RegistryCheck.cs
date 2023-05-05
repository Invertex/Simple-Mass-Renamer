using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading.Tasks;
using System;

namespace SimpleMassRenamer
{
    static class RegistryCheck
    {
        private static readonly string regPath = @"SOFTWARE\SimpleMassRenamer";
        private static readonly string contextRegPath = @"SOFTWARE\Classes\Directory\Background\shell\SimpleMassRenamer";

        public static async void Initialize()
        {
            await Task.Yield();
            var exePath = $"\"{System.Reflection.Assembly.GetExecutingAssembly().Location}\"";

            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
            using (var key = hklm.OpenSubKey(regPath, true))
            {
                if (key == null)
                {
                    Console.WriteLine("no reg path");
                    using (var appKey = hklm.CreateSubKey(regPath, true)){ appKey.SetValue("Location", exePath); }
                    RightClickContextSetup(hklm, exePath);
                }
                else
                {
                    var loc = key.GetValue("Location");
                    if(loc == null || loc.ToString() != exePath)
                    {
                        key.SetValue("Location", exePath);
                        RightClickContextSetup(hklm, exePath);
                    }
                }
            }
        }

        private static void RightClickContextSetup(RegistryKey hklm, string exePath)
        {
            if (MessageBox.Show("Add shortcut to open from explorer right-click context?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var ck = hklm.CreateSubKey(contextRegPath, true))
                {
                    ck.SetValue("Icon", exePath + ", 0");
                    ck.SetValue("Location", exePath);
                    using (var command = ck.CreateSubKey("command", true))
                    {
                        command.SetValue("", exePath);
                    }
                }
            }
        }
    }
}
