
namespace sillentInstaller
{
    partial class silentInstallerByLink
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(silentInstallerByLink));
            this.lstPrograms = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInstall = new System.Windows.Forms.Button();
            this.lstInstalled = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPrograms
            // 
            this.lstPrograms.FormattingEnabled = true;
            this.lstPrograms.Location = new System.Drawing.Point(15, 70);
            this.lstPrograms.Name = "lstPrograms";
            this.lstPrograms.Size = new System.Drawing.Size(773, 154);
            this.lstPrograms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program List";
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(15, 230);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(773, 23);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lstInstalled
            // 
            this.lstInstalled.FormattingEnabled = true;
            this.lstInstalled.Location = new System.Drawing.Point(15, 296);
            this.lstInstalled.Name = "lstInstalled";
            this.lstInstalled.Size = new System.Drawing.Size(773, 95);
            this.lstInstalled.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Installed";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(15, 31);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(678, 20);
            this.txtDir.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(699, 29);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Directory";
            // 
            // silentInstallerByLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstInstalled);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPrograms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "silentInstallerByLink";
            this.Text = "Silent Installer HD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstPrograms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.ListBox lstInstalled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
    }
}

