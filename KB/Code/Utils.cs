using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace KB.Code
{
    public static class Utils
    {
        public static void ShowError(Exception ex, IWin32Window owner = null)
        {
            if (owner != null)
                System.Windows.Forms.MessageBox.Show(owner, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string Localize(string key)
        {
            try
            {
                ResourceManager rm = new ResourceManager("KB.Localisation.Strings", System.Reflection.Assembly.GetExecutingAssembly());
                return rm.GetString(key);
            }
            catch
            {
                throw;
            }
        }
    }
}
