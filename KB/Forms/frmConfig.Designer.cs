namespace KB.Forms
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.chkActivateOnStart = new System.Windows.Forms.CheckBox();
            this.chkAutoDetectOnStart = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstIgnoredKeys = new System.Windows.Forms.ListBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.txtAutodectName = new System.Windows.Forms.TextBox();
            this.lblIgnoredKeys = new System.Windows.Forms.Label();
            this.lblAutoDetectName = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkActivateOnStart
            // 
            resources.ApplyResources(this.chkActivateOnStart, "chkActivateOnStart");
            this.chkActivateOnStart.Name = "chkActivateOnStart";
            this.chkActivateOnStart.Tag = "";
            this.chkActivateOnStart.UseVisualStyleBackColor = true;
            // 
            // chkAutoDetectOnStart
            // 
            resources.ApplyResources(this.chkAutoDetectOnStart, "chkAutoDetectOnStart");
            this.chkAutoDetectOnStart.Name = "chkAutoDetectOnStart";
            this.chkAutoDetectOnStart.Tag = "";
            this.chkAutoDetectOnStart.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Tag = "";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.Tag = "";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lstIgnoredKeys
            // 
            this.lstIgnoredKeys.FormattingEnabled = true;
            resources.ApplyResources(this.lstIgnoredKeys, "lstIgnoredKeys");
            this.lstIgnoredKeys.Name = "lstIgnoredKeys";
            // 
            // cboLanguage
            // 
            this.cboLanguage.Items.AddRange(new object[] {
            resources.GetString("cboLanguage.Items"),
            resources.GetString("cboLanguage.Items1")});
            resources.ApplyResources(this.cboLanguage, "cboLanguage");
            this.cboLanguage.Name = "cboLanguage";
            // 
            // txtAutodectName
            // 
            resources.ApplyResources(this.txtAutodectName, "txtAutodectName");
            this.txtAutodectName.Name = "txtAutodectName";
            // 
            // lblIgnoredKeys
            // 
            resources.ApplyResources(this.lblIgnoredKeys, "lblIgnoredKeys");
            this.lblIgnoredKeys.Name = "lblIgnoredKeys";
            this.lblIgnoredKeys.Tag = "";
            // 
            // lblAutoDetectName
            // 
            resources.ApplyResources(this.lblAutoDetectName, "lblAutoDetectName");
            this.lblAutoDetectName.Name = "lblAutoDetectName";
            this.lblAutoDetectName.Tag = "";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Tag = "";
            // 
            // frmConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkActivateOnStart);
            this.Controls.Add(this.chkAutoDetectOnStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstIgnoredKeys);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.txtAutodectName);
            this.Controls.Add(this.lblIgnoredKeys);
            this.Controls.Add(this.lblAutoDetectName);
            this.Controls.Add(this.lblLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConfig";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfig_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActivateOnStart;
        private System.Windows.Forms.CheckBox chkAutoDetectOnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstIgnoredKeys;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.TextBox txtAutodectName;
        private System.Windows.Forms.Label lblIgnoredKeys;
        private System.Windows.Forms.Label lblAutoDetectName;
        private System.Windows.Forms.Label lblLanguage;
    }
}