namespace KB.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSettings = new System.Windows.Forms.Button();
            this.lstWindows = new System.Windows.Forms.ListBox();
            this.lblHandle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlWindowInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutoDetect = new System.Windows.Forms.Button();
            this.btnRecordSequence = new System.Windows.Forms.Button();
            this.btnPlaySequence = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.windowSelector1 = new KB.Code.WindowSelector();
            this.pnlWindowInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowSelector1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::KB.Properties.Resources.cog;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Tag = "";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lstWindows
            // 
            resources.ApplyResources(this.lstWindows, "lstWindows");
            this.lstWindows.FormattingEnabled = true;
            this.lstWindows.Name = "lstWindows";
            // 
            // lblHandle
            // 
            resources.ApplyResources(this.lblHandle, "lblHandle");
            this.lblHandle.Name = "lblHandle";
            // 
            // lblText
            // 
            resources.ApplyResources(this.lblText, "lblText");
            this.lblText.Name = "lblText";
            // 
            // pnlWindowInfo
            // 
            this.pnlWindowInfo.Controls.Add(this.label2);
            this.pnlWindowInfo.Controls.Add(this.label1);
            this.pnlWindowInfo.Controls.Add(this.lblHandle);
            this.pnlWindowInfo.Controls.Add(this.lblText);
            resources.ApplyResources(this.pnlWindowInfo, "pnlWindowInfo");
            this.pnlWindowInfo.Name = "pnlWindowInfo";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnAutoDetect
            // 
            this.btnAutoDetect.Image = global::KB.Properties.Resources.wand;
            resources.ApplyResources(this.btnAutoDetect, "btnAutoDetect");
            this.btnAutoDetect.Name = "btnAutoDetect";
            this.btnAutoDetect.Tag = "";
            this.btnAutoDetect.UseVisualStyleBackColor = true;
            this.btnAutoDetect.Click += new System.EventHandler(this.btnAutoDetect_Click);
            // 
            // btnRecordSequence
            // 
            this.btnRecordSequence.Image = global::KB.Properties.Resources.control_record_blue;
            resources.ApplyResources(this.btnRecordSequence, "btnRecordSequence");
            this.btnRecordSequence.Name = "btnRecordSequence";
            this.btnRecordSequence.UseVisualStyleBackColor = true;
            this.btnRecordSequence.Click += new System.EventHandler(this.btnRecordSequence_Click);
            // 
            // btnPlaySequence
            // 
            this.btnPlaySequence.Image = global::KB.Properties.Resources.control_play_blue;
            resources.ApplyResources(this.btnPlaySequence, "btnPlaySequence");
            this.btnPlaySequence.Name = "btnPlaySequence";
            this.btnPlaySequence.UseVisualStyleBackColor = true;
            this.btnPlaySequence.Click += new System.EventHandler(this.btnPlaySequence_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::KB.Properties.Resources.cancel;
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkActive
            // 
            resources.ApplyResources(this.chkActive, "chkActive");
            this.chkActive.Image = global::KB.Properties.Resources.stop;
            this.chkActive.Name = "chkActive";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnPlaySequence);
            this.groupBox1.Controls.Add(this.btnRecordSequence);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.lstWindows);
            this.groupBox2.Controls.Add(this.btnAutoDetect);
            this.groupBox2.Controls.Add(this.pnlWindowInfo);
            this.groupBox2.Controls.Add(this.windowSelector1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.chkActive);
            this.groupBox3.Controls.Add(this.btnSettings);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // windowSelector1
            // 
            this.windowSelector1.Image = global::KB.Properties.Resources.application_add;
            resources.ApplyResources(this.windowSelector1, "windowSelector1");
            this.windowSelector1.Name = "windowSelector1";
            this.windowSelector1.TabStop = false;
            this.windowSelector1.WindowOutlineColor = System.Drawing.Color.Black;
            this.windowSelector1.WindowOutlineFrameStyle = System.Windows.Forms.FrameStyle.Thick;
            this.windowSelector1.WindowSelect += new System.EventHandler<KB.Code.WindowSelect_EventArgs>(this.windowSelector1_WindowSelect);
            this.windowSelector1.WindowOver += new System.EventHandler<KB.Code.WindowSelect_EventArgs>(this.windowSelector1_WindowOver);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.pnlWindowInfo.ResumeLayout(false);
            this.pnlWindowInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windowSelector1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private Code.WindowSelector windowSelector1;
        private System.Windows.Forms.ListBox lstWindows;
        private System.Windows.Forms.Label lblHandle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel pnlWindowInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutoDetect;
        private System.Windows.Forms.Button btnRecordSequence;
        private System.Windows.Forms.Button btnPlaySequence;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}