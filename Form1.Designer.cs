
namespace UTF8_Convert_Setup
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
            this.edtInstallPath = new System.Windows.Forms.TextBox();
            this.btnFindInstallPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgInstallPath = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgTargetFile = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.edtTargwetFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportScruipts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edtInstallPath
            // 
            this.edtInstallPath.Location = new System.Drawing.Point(10, 66);
            this.edtInstallPath.Name = "edtInstallPath";
            this.edtInstallPath.Size = new System.Drawing.Size(378, 20);
            this.edtInstallPath.TabIndex = 0;
            this.edtInstallPath.Text = "C:\\Program Files\\UTF8 Script";
            // 
            // btnFindInstallPath
            // 
            this.btnFindInstallPath.Location = new System.Drawing.Point(394, 66);
            this.btnFindInstallPath.Name = "btnFindInstallPath";
            this.btnFindInstallPath.Size = new System.Drawing.Size(36, 21);
            this.btnFindInstallPath.TabIndex = 2;
            this.btnFindInstallPath.Text = "...";
            this.btnFindInstallPath.UseVisualStyleBackColor = true;
            this.btnFindInstallPath.Click += new System.EventHandler(this.btnFindInstallPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Script Install/Extract Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Targetted File";
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Location = new System.Drawing.Point(396, 137);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(36, 21);
            this.btnBrowseTarget.TabIndex = 6;
            this.btnBrowseTarget.Text = "...";
            this.btnBrowseTarget.UseVisualStyleBackColor = true;
            this.btnBrowseTarget.Click += new System.EventHandler(this.btnBrowseTarget_Click);
            // 
            // edtTargwetFile
            // 
            this.edtTargwetFile.Location = new System.Drawing.Point(12, 137);
            this.edtTargwetFile.Name = "edtTargwetFile";
            this.edtTargwetFile.Size = new System.Drawing.Size(378, 20);
            this.edtTargwetFile.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Setup the UTF8 Conversion Scripts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportScruipts
            // 
            this.btnExportScruipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportScruipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportScruipts.Location = new System.Drawing.Point(149, 167);
            this.btnExportScruipts.Name = "btnExportScruipts";
            this.btnExportScruipts.Size = new System.Drawing.Size(148, 30);
            this.btnExportScruipts.TabIndex = 9;
            this.btnExportScruipts.Text = "Export Scripts";
            this.btnExportScruipts.UseVisualStyleBackColor = true;
            this.btnExportScruipts.Click += new System.EventHandler(this.btnExportScruipts_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 209);
            this.Controls.Add(this.btnExportScruipts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseTarget);
            this.Controls.Add(this.edtTargwetFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindInstallPath);
            this.Controls.Add(this.edtInstallPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTF8 Converter Script - Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtInstallPath;
        private System.Windows.Forms.Button btnFindInstallPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog dlgInstallPath;
        private System.Windows.Forms.OpenFileDialog dlgTargetFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseTarget;
        private System.Windows.Forms.TextBox edtTargwetFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportScruipts;
    }
}

