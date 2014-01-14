using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
