using System;
using System.Windows.Forms;
using KB.Code;

namespace KB.Forms
{
    public partial class frmMain : Form
    {
        #region Main
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = Config.Current.Culture;
            System.Threading.Thread.CurrentThread.CurrentCulture = Config.Current.Culture;
            Application.Run(new frmMain());
        }
        #endregion Main

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmConfig frm = new frmConfig())
                {
                    frm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex, this);
            }
        }
    }
}
