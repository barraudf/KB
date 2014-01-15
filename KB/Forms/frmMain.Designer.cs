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
            this.pbActive = new System.Windows.Forms.PictureBox();
            this.pbReset = new System.Windows.Forms.PictureBox();
            this.windowSelector1 = new KB.Code.WindowSelector();
            this.pnlWindowInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).BeginInit();
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
            this.lstWindows.FormattingEnabled = true;
            resources.ApplyResources(this.lstWindows, "lstWindows");
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
            // pbActive
            // 
            this.pbActive.Image = global::KB.Properties.Resources.stop;
            resources.ApplyResources(this.pbActive, "pbActive");
            this.pbActive.Name = "pbActive";
            this.pbActive.TabStop = false;
            this.pbActive.Click += new System.EventHandler(this.pbActive_Click);
            // 
            // pbReset
            // 
            this.pbReset.Image = global::KB.Properties.Resources.cancel;
            resources.ApplyResources(this.pbReset, "pbReset");
            this.pbReset.Name = "pbReset";
            this.pbReset.TabStop = false;
            this.pbReset.Click += new System.EventHandler(this.pbReset_Click);
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
            this.Controls.Add(this.pbActive);
            this.Controls.Add(this.pbReset);
            this.Controls.Add(this.btnAutoDetect);
            this.Controls.Add(this.pnlWindowInfo);
            this.Controls.Add(this.lstWindows);
            this.Controls.Add(this.windowSelector1);
            this.Controls.Add(this.btnSettings);
            this.Name = "frmMain";
            this.pnlWindowInfo.ResumeLayout(false);
            this.pnlWindowInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowSelector1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pbReset;
        private System.Windows.Forms.PictureBox pbActive;
    }
}