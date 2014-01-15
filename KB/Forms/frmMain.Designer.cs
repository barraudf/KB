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
            this.windowSelector1 = new KB.Code.WindowSelector();
            ((System.ComponentModel.ISupportInitialize)(this.windowSelector1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Tag = "";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // windowSelector1
            // 
            this.windowSelector1.Image = global::KB.Properties.Resources.application_add;
            resources.ApplyResources(this.windowSelector1, "windowSelector1");
            this.windowSelector1.Name = "windowSelector1";
            this.windowSelector1.TabStop = false;
            this.windowSelector1.WindowOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.windowSelector1.WindowOutlineFrameStyle = System.Windows.Forms.FrameStyle.Thick;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.windowSelector1);
            this.Controls.Add(this.btnSettings);
            this.Name = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.windowSelector1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private Code.WindowSelector windowSelector1;
    }
}