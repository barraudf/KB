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
            this.lstIgnoredKeys = new System.Windows.Forms.ListBox();
            this.ddlLanguage = new System.Windows.Forms.ComboBox();
            this.txtAutodectName = new System.Windows.Forms.TextBox();
            this.lblIgnoredKeys = new System.Windows.Forms.Label();
            this.lblAutoDetectName = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
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
            // lstIgnoredKeys
            // 
            resources.ApplyResources(this.lstIgnoredKeys, "lstIgnoredKeys");
            this.lstIgnoredKeys.FormattingEnabled = true;
            this.lstIgnoredKeys.Name = "lstIgnoredKeys";
            // 
            // ddlLanguage
            // 
            resources.ApplyResources(this.ddlLanguage, "ddlLanguage");
            this.ddlLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLanguage.Items.AddRange(new object[] {
            resources.GetString("ddlLanguage.Items"),
            resources.GetString("ddlLanguage.Items1")});
            this.ddlLanguage.Name = "ddlLanguage";
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
            // pbRemove
            // 
            resources.ApplyResources(this.pbRemove, "pbRemove");
            this.pbRemove.Image = global::KB.Properties.Resources.delete;
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // pbAdd
            // 
            resources.ApplyResources(this.pbAdd, "pbAdd");
            this.pbAdd.Image = global::KB.Properties.Resources.add;
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Image = global::KB.Properties.Resources.cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Tag = "";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Image = global::KB.Properties.Resources.accept;
            this.btnOK.Name = "btnOK";
            this.btnOK.Tag = "";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.chkActivateOnStart);
            this.Controls.Add(this.chkAutoDetectOnStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstIgnoredKeys);
            this.Controls.Add(this.ddlLanguage);
            this.Controls.Add(this.txtAutodectName);
            this.Controls.Add(this.lblIgnoredKeys);
            this.Controls.Add(this.lblAutoDetectName);
            this.Controls.Add(this.lblLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConfig";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfig_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActivateOnStart;
        private System.Windows.Forms.CheckBox chkAutoDetectOnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstIgnoredKeys;
        private System.Windows.Forms.ComboBox ddlLanguage;
        private System.Windows.Forms.TextBox txtAutodectName;
        private System.Windows.Forms.Label lblIgnoredKeys;
        private System.Windows.Forms.Label lblAutoDetectName;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.PictureBox pbAdd;
    }
}