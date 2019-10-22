using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace S3FileUploader
{
    public partial class frmUploader : Form
    {
        private static readonly String APPLICATION_TITLE = "S3FileUploader";
        private TaskManager taskManager;

        public frmUploader()
        {
            InitializeComponent();
        }

        private void FrmUploader_Load(object sender, EventArgs e)
        {
            // regionにS3リージョンを設定
            foreach (RegionEndpoint region in RegionEndpoint.EnumerableAllRegions)
            {
                cboRegion.Items.Add(region.SystemName);
            }
            cboRegion.Text = "ap-northeast-1";
        }

        private void LnkUploaderFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // アップロードフォルダを指定
            dlgFolder.SelectedPath = txtUploadFolder.Text;
            dlgFolder.ShowDialog();
            txtUploadFolder.Text = dlgFolder.SelectedPath;
        }

        private void CmdUpload_Click(object sender, EventArgs e)
        {
            taskManager = new TaskManager(cboRegion.Text ,txtBucket.Text);

            // 入力チェック
            if (!InputCheck()) return;

            // フォルダ内ファイル取得
            DirectoryInfo di = new DirectoryInfo(txtUploadFolder.Text);
            FileInfo[] files = di.GetFiles("*.csv");

            // アップロードリスト追加
            foreach (FileInfo f in files)
            {
                // タスク作成・追加
                taskManager.Add(f);
            }

            // 最大Thread数を設定
            taskManager.MaxThread = int.Parse(txtMaxThread.Text);

            // アップロードを開始
            taskManager.Run();

            // 終了通知
            MessageBox.Show("Upload Finished.", APPLICATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool InputCheck()
        {
            if (txtMaxThread.Text == "")
            {
                MessageBox.Show("No input Threads.", APPLICATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsNumeric(txtMaxThread.Text))
            {
                MessageBox.Show("Wrong Threads.", APPLICATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtUploadFolder.Text == "")
            {
                MessageBox.Show("No input Upload Folder.", APPLICATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.IO.Directory.Exists(txtUploadFolder.Text)) 
            {
                MessageBox.Show("Not Exists Upload Folder.", APPLICATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboRegion.Text == "")
            {
                MessageBox.Show("No input Region.",APPLICATION_TITLE ,MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                return false;
            }

            if (txtBucket.Text == "")
            {
                MessageBox.Show("No input Bucket.", APPLICATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static bool IsNumeric(string stTarget)
        {
            double dNullable;

            return double.TryParse(
                stTarget,
                System.Globalization.NumberStyles.Any,
                null,
                out dNullable
            );
        }
    }
}
