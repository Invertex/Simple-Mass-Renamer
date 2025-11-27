using Microsoft.Win32;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMassRenamer
{
    static class RegistryCheck
    {
        private static readonly string regPath = @"SOFTWARE\SimpleMassRenamer";
        private static readonly string contextRegPath = @"SOFTWARE\Classes\Directory\Background\shell\SimpleMassRenamer";
        private static readonly string windowWidth_subkey = "Window_Width";
        private static readonly string windowHeight_subkey = "Window_Height";
        public static int windowWidth { get; private set; } = 600;
        public static int windowHeight { get; private set; } = 400;

        public static async void Initialize()
        {
            await Task.Yield();
            var exePath = $"\"{System.Reflection.Assembly.GetExecutingAssembly().Location}\"";

            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
            using (var key = hklm.OpenSubKey(regPath, true))
            {
                var rootKey = key;
                if (rootKey == null)
                {
                    rootKey = hklm.CreateSubKey(regPath, true);
                }
                if (rootKey != null)
                {
                    var loc = rootKey.GetValue("Location");
                    if (loc == null || loc.ToString() != exePath)
                    {
                        rootKey.SetValue("Location", exePath);
                        RightClickContextSetup(hklm, exePath);
                    }
                    var width = rootKey.GetValue(windowWidth_subkey);
                    if (width == null)
                    {
                        rootKey.SetValue(windowWidth_subkey, windowWidth, RegistryValueKind.DWord);
                    } else { windowWidth = (int)width; }

                    var height = rootKey.GetValue(windowHeight_subkey);
                    if (height == null)
                    {
                        rootKey.SetValue(windowHeight_subkey, windowHeight, RegistryValueKind.DWord);
                    } else { windowHeight = (int)height; }
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

        public static void UpdateWindowSizeReg(int width, int height)
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
            using (var key = hklm.OpenSubKey(regPath, true))
            {
                var rootKey = key;
                if (rootKey == null) { rootKey = hklm.CreateSubKey(regPath, true); }

                windowWidth = width;
                windowHeight = height;
                key.SetValue(windowWidth_subkey, width, RegistryValueKind.DWord);
                key.SetValue(windowHeight_subkey, height, RegistryValueKind.DWord);
            }
        }
    }
}
