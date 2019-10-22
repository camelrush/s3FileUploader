namespace S3FileUploader
{
    partial class frmUploader
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.lblBucket = new System.Windows.Forms.Label();
            this.txtBucket = new System.Windows.Forms.TextBox();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtUploadFolder = new System.Windows.Forms.TextBox();
            this.lnkUploaderFolder = new System.Windows.Forms.LinkLabel();
            this.lblMaxThread = new System.Windows.Forms.Label();
            this.txtMaxThread = new System.Windows.Forms.TextBox();
            this.cmdEnd = new System.Windows.Forms.Button();
            this.cmdUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "RegionName";
            // 
            // cboRegion
            // 
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(132, 70);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(129, 23);
            this.cboRegion.TabIndex = 1;
            // 
            // lblBucket
            // 
            this.lblBucket.AutoSize = true;
            this.lblBucket.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBucket.Location = new System.Drawing.Point(19, 102);
            this.lblBucket.Name = "lblBucket";
            this.lblBucket.Size = new System.Drawing.Size(82, 15);
            this.lblBucket.TabIndex = 2;
            this.lblBucket.Text = "BucketName";
            // 
            // txtBucket
            // 
            this.txtBucket.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBucket.Location = new System.Drawing.Point(132, 99);
            this.txtBucket.Name = "txtBucket";
            this.txtBucket.Size = new System.Drawing.Size(196, 23);
            this.txtBucket.TabIndex = 3;
            this.txtBucket.Text = "csv.s3.lambda.test.shinya";
            // 
            // txtUploadFolder
            // 
            this.txtUploadFolder.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtUploadFolder.Location = new System.Drawing.Point(132, 41);
            this.txtUploadFolder.Name = "txtUploadFolder";
            this.txtUploadFolder.Size = new System.Drawing.Size(347, 23);
            this.txtUploadFolder.TabIndex = 4;
            // 
            // lnkUploaderFolder
            // 
            this.lnkUploaderFolder.AutoSize = true;
            this.lnkUploaderFolder.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lnkUploaderFolder.Location = new System.Drawing.Point(19, 44);
            this.lnkUploaderFolder.Name = "lnkUploaderFolder";
            this.lnkUploaderFolder.Size = new System.Drawing.Size(83, 15);
            this.lnkUploaderFolder.TabIndex = 5;
            this.lnkUploaderFolder.TabStop = true;
            this.lnkUploaderFolder.Text = "UploadFolder";
            this.lnkUploaderFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUploaderFolder_LinkClicked);
            // 
            // lblMaxThread
            // 
            this.lblMaxThread.AutoSize = true;
            this.lblMaxThread.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMaxThread.Location = new System.Drawing.Point(19, 15);
            this.lblMaxThread.Name = "lblMaxThread";
            this.lblMaxThread.Size = new System.Drawing.Size(103, 15);
            this.lblMaxThread.TabIndex = 6;
            this.lblMaxThread.Text = "Thread(Max100)";
            // 
            // txtMaxThread
            // 
            this.txtMaxThread.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMaxThread.Location = new System.Drawing.Point(132, 12);
            this.txtMaxThread.MaxLength = 3;
            this.txtMaxThread.Name = "txtMaxThread";
            this.txtMaxThread.Size = new System.Drawing.Size(36, 23);
            this.txtMaxThread.TabIndex = 7;
            this.txtMaxThread.Text = "10";
            this.txtMaxThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdEnd
            // 
            this.cmdEnd.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdEnd.Location = new System.Drawing.Point(466, 149);
            this.cmdEnd.Name = "cmdEnd";
            this.cmdEnd.Size = new System.Drawing.Size(75, 36);
            this.cmdEnd.TabIndex = 8;
            this.cmdEnd.Text = "End";
            this.cmdEnd.UseVisualStyleBackColor = true;
            // 
            // cmdUpload
            // 
            this.cmdUpload.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdUpload.Location = new System.Drawing.Point(385, 149);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(75, 36);
            this.cmdUpload.TabIndex = 9;
            this.cmdUpload.Text = "Upload";
            this.cmdUpload.UseVisualStyleBackColor = true;
            this.cmdUpload.Click += new System.EventHandler(this.CmdUpload_Click);
            // 
            // frmUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 193);
            this.ControlBox = false;
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.cmdEnd);
            this.Controls.Add(this.txtMaxThread);
            this.Controls.Add(this.lblMaxThread);
            this.Controls.Add(this.lnkUploaderFolder);
            this.Controls.Add(this.txtUploadFolder);
            this.Controls.Add(this.txtBucket);
            this.Controls.Add(this.lblBucket);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label1);
            this.Name = "frmUploader";
            this.Text = "S3Uploader";
            this.Load += new System.EventHandler(this.FrmUploader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label lblBucket;
        private System.Windows.Forms.TextBox txtBucket;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.TextBox txtUploadFolder;
        private System.Windows.Forms.LinkLabel lnkUploaderFolder;
        private System.Windows.Forms.Label lblMaxThread;
        private System.Windows.Forms.TextBox txtMaxThread;
        private System.Windows.Forms.Button cmdEnd;
        private System.Windows.Forms.Button cmdUpload;
    }
}

