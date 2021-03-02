
namespace sillentInstaller
{
    partial class silentInstallerByJson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(silentInstallerByJson));
            this.btnInstall = new System.Windows.Forms.Button();
            this.lstInstalled = new System.Windows.Forms.ListBox();
            this.pctLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(12, 309);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(793, 23);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lstInstalled
            // 
            this.lstInstalled.FormattingEnabled = true;
            this.lstInstalled.Location = new System.Drawing.Point(12, 338);
            this.lstInstalled.Name = "lstInstalled";
            this.lstInstalled.Size = new System.Drawing.Size(793, 95);
            this.lstInstalled.TabIndex = 1;
            // 
            // pctLoading
            // 
            this.pctLoading.Image = global::sillentInstaller.Properties.Resources.loagin;
            this.pctLoading.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctLoading.InitialImage")));
            this.pctLoading.Location = new System.Drawing.Point(0, 22);
            this.pctLoading.Name = "pctLoading";
            this.pctLoading.Size = new System.Drawing.Size(817, 411);
            this.pctLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLoading.TabIndex = 2;
            this.pctLoading.TabStop = false;
            this.pctLoading.Visible = false;
            // 
            // silentInstallerByJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.pctLoading);
            this.Controls.Add(this.lstInstalled);
            this.Controls.Add(this.btnInstall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "silentInstallerByJson";
            this.Load += new System.EventHandler(this.silentInstallerByJson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.ListBox lstInstalled;
        private System.Windows.Forms.PictureBox pctLoading;
    }
}