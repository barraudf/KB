using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
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

        protected List<WindowInfo> _Windows = new List<WindowInfo>();
        protected bool _Active = false;

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(IntPtr hwnd, uint wMsg, int wParam, int lParam);

        public frmMain()
        {
            InitializeComponent();
            RefreshWindows();
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

        private void windowSelector1_WindowOver(object sender, WindowSelect_EventArgs e)
        {
            lblText.Text = e.Info.Text;
            lblHandle.Text = e.Info.Handle.ToString();
            pnlWindowInfo.Visible = true;
        }

        private void windowSelector1_WindowSelect(object sender, WindowSelect_EventArgs e)
        {
            if (_Windows.Contains(e.Info) == false)
            {
                _Windows.Add(e.Info);
                RefreshWindows();
            }
            pnlWindowInfo.Visible = false;
        }

        private void RefreshWindows()
        {
            lstWindows.DataSource = null;
            lstWindows.DataSource = _Windows;
        }

        private void btnAutoDetect_Click(object sender, EventArgs e)
        {
            try
            {
                _Windows = new List<WindowInfo>();
                
                Process[] ps = Process.GetProcessesByName(Config.Current.AutoDetectExeName);
                foreach (Process p in ps)
                {
                    _Windows.Add(new WindowInfo(p.MainWindowHandle));
                }
                RefreshWindows();
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex);
            }
        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            try
            {
                _Windows.Clear();
                RefreshWindows();
            }
            catch(Exception ex)
            {
                Utils.ShowError(ex);
            }
        }

        private void KeyboardListener_s_KeyEventHandler(object sender, EventArgs e)
        {
            try
            {
                KeyboardListener.UniversalKeyEventArgs eventArgs = (KeyboardListener.UniversalKeyEventArgs)e;

                if (Config.Current.IgnoredKeys.Contains((int)eventArgs.m_Key))
                    return;

                IntPtr curWindowPtr = GetForegroundWindow();
                WindowInfo curWindow = new WindowInfo(curWindowPtr);
                if (_Windows.Contains(curWindow) == true)
                {
                    uint lParam;
                    switch (eventArgs.m_Msg)
                    {
                        /*WM_KEYDOWN*/
                        case 0x0100: lParam = 0x00000001; break;
                        /*WM_KEYUP*/
                        case 0x0101: lParam = 0xC0000001; break;
                        /*WM_CHAR*/
                        case 0x0102: lParam = 0xC0000001; break;
                        /*WM_DEADCHAR*/
                        case 0x0103: lParam = 0xC0000001; break;
                        /*WM_SYSKEYDOWN*/
                        case 0x0104: lParam = 0x00000001; break;
                        /*WM_SYSKEYUP*/
                        case 0x0105: lParam = 0xC0000001; break;
                        default: lParam = 0x00000001; break;
                    }

                    foreach (WindowInfo i in _Windows)
                    {
                        if(i.Equals(curWindow) == false)
                            PostMessage(i.Handle, eventArgs.m_Msg, eventArgs.m_Key, (int)lParam);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex);
            }

        }

        private void pbActive_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Active == true)
                {
                    KeyboardListener.s_KeyEventHandler -= new EventHandler(KeyboardListener_s_KeyEventHandler);
                    _Active = false;
                    pbActive.Image = KB.Properties.Resources.stop;
                }
                else
                {
                    KeyboardListener.s_KeyEventHandler += new EventHandler(KeyboardListener_s_KeyEventHandler);
                    _Active = true;
                    pbActive.Image = KB.Properties.Resources.start;
                }
            }
            catch(Exception ex)
            {
                Utils.ShowError(ex);
            }
        }
    }
}
