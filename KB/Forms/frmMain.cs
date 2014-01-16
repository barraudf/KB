using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using KB.Code;
using System.Threading.Tasks;

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
        protected SequenceRecorder _Recorder = new SequenceRecorder();

        public bool Active
        {
            get { return chkActive.Checked; }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        public frmMain()
        {
            InitializeComponent();
            KeyboardListener.s_KeyEventHandler += new EventHandler(KeyboardListener_s_KeyEventHandler);
            RefreshWindows();
            UpdateSequenceButtons();
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

        private void KeyboardListener_s_KeyEventHandler(object sender, EventArgs e)
        {
            try
            {
                KeyboardListener.UniversalKeyEventArgs eventArgs = (KeyboardListener.UniversalKeyEventArgs)e;
                KeyboardEventInfo kei = new KeyboardEventInfo(eventArgs);

                if (Config.Current.IgnoredKeys.Contains((int)eventArgs.m_Key))
                    return;

                WindowInfo curWindow = new WindowInfo(GetForegroundWindow());
                
                if (_Windows.Contains(curWindow) == true)
                {
                    if (Active == true)
                    {
                        foreach (WindowInfo i in _Windows)
                        {
                            if (i.Equals(curWindow) == false)
                                kei.PostMessage(i.Handle);
                        }
                    }

                    if (_Recorder != null && _Recorder.Recording == true)
                    {
                        _Recorder.Add(kei);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex);
            }

        }

        private async void btnPlaySequence_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Recorder.Recording == true || _Recorder.Playing == true)
                    return;

                Task play = _Recorder.Play(_Windows.ToArray());

                UpdateSequenceButtons();

                await play;

                UpdateSequenceButtons();
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex);
            }
        }

        private void btnRecordSequence_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Recorder.Recording == true)
                    _Recorder.StopRecording();
                else
                    _Recorder.StartRecording();

                UpdateSequenceButtons();
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex);
            }
        }

        private void UpdateSequenceButtons()
        {
            try
            {
                btnRecordSequence.Enabled = btnPlaySequence.Enabled = !_Recorder.Playing;

                if (_Recorder.Recording == true)
                {
                    btnPlaySequence.Enabled = false;
                    btnRecordSequence.Image = KB.Properties.Resources.control_stop_blue;
                    btnRecordSequence.Text = Utils.Localize("Stop");
                }
                else
                {
                    btnRecordSequence.Image = KB.Properties.Resources.control_record_blue;
                    btnRecordSequence.Text = Utils.Localize("Record");
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                _Windows.Clear();
                RefreshWindows();
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex);
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Active == false)
                    chkActive.Image = KB.Properties.Resources.stop;
                else
                    chkActive.Image = KB.Properties.Resources.start;
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex);
            }
        }
    }
}
