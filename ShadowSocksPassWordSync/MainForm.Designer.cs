namespace ShadowSocksPassWordSync
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLoadJsonFile = new System.Windows.Forms.Button();
            this.txtJsonFileName = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLoadJsonFile
            // 
            this.btnLoadJsonFile.Location = new System.Drawing.Point(419, 27);
            this.btnLoadJsonFile.Name = "btnLoadJsonFile";
            this.btnLoadJsonFile.Size = new System.Drawing.Size(128, 23);
            this.btnLoadJsonFile.TabIndex = 0;
            this.btnLoadJsonFile.Text = "导入JSON文件";
            this.btnLoadJsonFile.UseVisualStyleBackColor = true;
            this.btnLoadJsonFile.Click += new System.EventHandler(this.btnLoadJsonFile_Click);
            // 
            // txtJsonFileName
            // 
            this.txtJsonFileName.Location = new System.Drawing.Point(24, 27);
            this.txtJsonFileName.Name = "txtJsonFileName";
            this.txtJsonFileName.Size = new System.Drawing.Size(389, 21);
            this.txtJsonFileName.TabIndex = 1;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(24, 76);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "同步密码";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.Filter = "json文件|*.json";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 117);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.txtJsonFileName);
            this.Controls.Add(this.btnLoadJsonFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ShadowSocks密码同步";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadJsonFile;
        private System.Windows.Forms.TextBox txtJsonFileName;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
    }
}

