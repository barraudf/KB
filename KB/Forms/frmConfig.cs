using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using KB.Code;

namespace KB.Forms
{
    public partial class frmConfig : Form
    {
        private List<int> _IgnoredKeys = null;
        private string _OldTitle = null;

        public frmConfig()
        {
            InitializeComponent();
            FillLanguages();
            SetUIValues();
        }

        private void frmConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (Enabled == false)
            {
                _IgnoredKeys.Add((int)e.KeyCode);
                UpdateKeysFromMemory();

                Enabled = true;
                Text = _OldTitle;
                e.Handled = true;
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape: btnCancel_Click(sender, e); e.Handled = true; break;
                    case Keys.Enter: btnOK_Click(sender, e); e.Handled = true; break;
                }
            }
        }

        private void SetUIValues()
        {
            try
            {
                if (ddlLanguage.Items.Contains(Config.Current.Culture))
                    ddlLanguage.SelectedItem = Config.Current.Culture;
                else
                    ddlLanguage.SelectedIndex = 0;

                txtAutodectName.Text = Config.Current.AutoDetectExeName;
                chkActivateOnStart.Checked = Config.Current.AutoStart;
                chkAutoDetectOnStart.Checked = Config.Current.AutoDetect;
                
                _IgnoredKeys = new List<int>(Config.Current.IgnoredKeys);
                UpdateKeysFromMemory();
            }
            catch
            {
                throw;
            }
        }

        private void ReadUIValues()
        {
            try
            {
                Config.Current.Culture = (CultureInfo)ddlLanguage.SelectedItem;
                Config.Current.AutoDetect = chkAutoDetectOnStart.Checked;
                Config.Current.AutoDetectExeName = txtAutodectName.Text.Trim();
                Config.Current.AutoStart = chkActivateOnStart.Checked;
                Config.Current.IgnoredKeys = _IgnoredKeys;
            }
            catch
            {
                throw;
            }
        }

        private void FillLanguages()
        {
            try
            {
                ddlLanguage.Items.Clear();
                ddlLanguage.Items.Add(new CultureInfo("en-GB"));
                ddlLanguage.Items.Add(new CultureInfo("fr-FR"));
            }
            catch
            {
                throw;
            }
        }

        private void UpdateKeysFromMemory()
        {
            try
            {
                lstIgnoredKeys.Items.Clear();
                foreach (int i in _IgnoredKeys)
                    lstIgnoredKeys.Items.Add(new System.Windows.Forms.KeysConverter().ConvertToString(i));
            }
            catch
            {
                throw;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                ReadUIValues();
                Config.Current.Save();
                this.Close();
            }
            catch
            {
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstIgnoredKeys.SelectedIndex != -1)
                {
                    _IgnoredKeys.RemoveAt(lstIgnoredKeys.SelectedIndex);
                    UpdateKeysFromMemory();
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex, this);
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            
            Enabled = false;
            _OldTitle = Text;
            Text = "Press a key";
        }
    }
}
