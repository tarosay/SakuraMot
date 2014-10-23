namespace SakuraMot
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblMotfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMotfile
            // 
            this.lblMotfile.AllowDrop = true;
            this.lblMotfile.AutoSize = true;
            this.lblMotfile.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMotfile.Location = new System.Drawing.Point(3, 9);
            this.lblMotfile.Name = "lblMotfile";
            this.lblMotfile.Size = new System.Drawing.Size(221, 21);
            this.lblMotfile.TabIndex = 0;
            this.lblMotfile.Text = "Please drag the mot file.";
            this.lblMotfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblMotfile_DragDrop);
            this.lblMotfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblMotfile_DragEnter);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 41);
            this.Controls.Add(this.lblMotfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SakuraMot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMotfile;
    }
}

