namespace CSGO_Config_Installer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbSteamDir = new System.Windows.Forms.TextBox();
            this.btnBrowseSteamDir = new System.Windows.Forms.Button();
            this.btnAutoFindSteamDir = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnInstall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSteamDir
            // 
            this.tbSteamDir.Location = new System.Drawing.Point(6, 316);
            this.tbSteamDir.Name = "tbSteamDir";
            this.tbSteamDir.Size = new System.Drawing.Size(352, 20);
            this.tbSteamDir.TabIndex = 1;
            this.tbSteamDir.TextChanged += new System.EventHandler(this.tbSteamDir_TextChanged);
            this.tbSteamDir.Enter += new System.EventHandler(this.tbSteamDir_Enter);
            this.tbSteamDir.Leave += new System.EventHandler(this.tbSteamDir_Leave);
            // 
            // btnBrowseSteamDir
            // 
            this.btnBrowseSteamDir.Location = new System.Drawing.Point(6, 345);
            this.btnBrowseSteamDir.Name = "btnBrowseSteamDir";
            this.btnBrowseSteamDir.Size = new System.Drawing.Size(75, 22);
            this.btnBrowseSteamDir.TabIndex = 0;
            this.btnBrowseSteamDir.Text = "Browse";
            this.btnBrowseSteamDir.UseVisualStyleBackColor = true;
            this.btnBrowseSteamDir.Click += new System.EventHandler(this.btnBrowseSteamDir_Click);
            // 
            // btnAutoFindSteamDir
            // 
            this.btnAutoFindSteamDir.Location = new System.Drawing.Point(142, 345);
            this.btnAutoFindSteamDir.Name = "btnAutoFindSteamDir";
            this.btnAutoFindSteamDir.Size = new System.Drawing.Size(75, 23);
            this.btnAutoFindSteamDir.TabIndex = 2;
            this.btnAutoFindSteamDir.Text = "Auto Find";
            this.btnAutoFindSteamDir.UseVisualStyleBackColor = true;
            this.btnAutoFindSteamDir.Click += new System.EventHandler(this.btnAutoFindSteamDir_Click);
            // 
            // listFiles
            // 
            this.listFiles.AllowDrop = true;
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(6, 41);
            this.listFiles.MultiSelect = false;
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(352, 262);
            this.listFiles.TabIndex = 3;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listFiles_DragDrop);
            this.listFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listFiles_DragEnter);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "text icons.png");
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(283, 345);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 5;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listFiles);
            this.groupBox1.Controls.Add(this.btnInstall);
            this.groupBox1.Controls.Add(this.tbSteamDir);
            this.groupBox1.Controls.Add(this.btnBrowseSteamDir);
            this.groupBox1.Controls.Add(this.btnAutoFindSteamDir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 376);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config Installer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Drag and drop the config files in the box below.";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 397);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CSGO Config Installer - by gresan6";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSteamDir;
        private System.Windows.Forms.Button btnBrowseSteamDir;
        private System.Windows.Forms.Button btnAutoFindSteamDir;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

