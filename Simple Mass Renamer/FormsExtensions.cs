using System;
using System.Windows.Forms;

namespace SimpleMassRenamer
{
    public static class FormsExtensions
    {
        public static void AppendLine(this TextBox textBox, string newLine)
        {
            textBox.AppendText(Environment.NewLine + newLine);
        }
    }
}
