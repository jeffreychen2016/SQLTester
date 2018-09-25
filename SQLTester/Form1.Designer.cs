namespace SQLTester
{
    partial class frmTester
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.grpODBCDSNConfig = new System.Windows.Forms.GroupBox();
            this.txtDDBCDSN_Password = new System.Windows.Forms.TextBox();
            this.txtODBCDSN_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkODBCDSN = new System.Windows.Forms.CheckBox();
            this.txtODBCDSN_DSN = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdRecord = new System.Windows.Forms.DataGridView();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpODBCDSNConfig.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(25, 261);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommand.Size = new System.Drawing.Size(574, 170);
            this.txtCommand.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(604, 261);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(126, 39);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "&Execute Statement";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(100, 244);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 16);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Record Count";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 460);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnNextTab);
            this.tabPage1.Controls.Add(this.grpODBCDSNConfig);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(756, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNextTab
            // 
            this.btnNextTab.Location = new System.Drawing.Point(662, 407);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(75, 23);
            this.btnNextTab.TabIndex = 1;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.UseVisualStyleBackColor = true;
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // grpODBCDSNConfig
            // 
            this.grpODBCDSNConfig.Controls.Add(this.txtDDBCDSN_Password);
            this.grpODBCDSNConfig.Controls.Add(this.txtODBCDSN_Username);
            this.grpODBCDSNConfig.Controls.Add(this.label3);
            this.grpODBCDSNConfig.Controls.Add(this.label4);
            this.grpODBCDSNConfig.Controls.Add(this.label2);
            this.grpODBCDSNConfig.Controls.Add(this.chkODBCDSN);
            this.grpODBCDSNConfig.Controls.Add(this.txtODBCDSN_DSN);
            this.grpODBCDSNConfig.Location = new System.Drawing.Point(18, 20);
            this.grpODBCDSNConfig.Name = "grpODBCDSNConfig";
            this.grpODBCDSNConfig.Size = new System.Drawing.Size(719, 100);
            this.grpODBCDSNConfig.TabIndex = 0;
            this.grpODBCDSNConfig.TabStop = false;
            this.grpODBCDSNConfig.Enter += new System.EventHandler(this.grpODBCConfig_Enter);
            // 
            // txtDDBCDSN_Password
            // 
            this.txtDDBCDSN_Password.Location = new System.Drawing.Point(100, 71);
            this.txtDDBCDSN_Password.Name = "txtDDBCDSN_Password";
            this.txtDDBCDSN_Password.Size = new System.Drawing.Size(270, 20);
            this.txtDDBCDSN_Password.TabIndex = 10;
            // 
            // txtODBCDSN_Username
            // 
            this.txtODBCDSN_Username.Location = new System.Drawing.Point(100, 45);
            this.txtODBCDSN_Username.Name = "txtODBCDSN_Username";
            this.txtODBCDSN_Username.Size = new System.Drawing.Size(270, 20);
            this.txtODBCDSN_Username.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DSN";
            // 
            // chkODBCDSN
            // 
            this.chkODBCDSN.AutoSize = true;
            this.chkODBCDSN.BackColor = System.Drawing.Color.White;
            this.chkODBCDSN.Checked = true;
            this.chkODBCDSN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkODBCDSN.Location = new System.Drawing.Point(6, -1);
            this.chkODBCDSN.Name = "chkODBCDSN";
            this.chkODBCDSN.Size = new System.Drawing.Size(82, 17);
            this.chkODBCDSN.TabIndex = 0;
            this.chkODBCDSN.Text = "ODBC DSN";
            this.chkODBCDSN.UseVisualStyleBackColor = false;
            this.chkODBCDSN.CheckedChanged += new System.EventHandler(this.chkODBC_CheckedChanged);
            // 
            // txtODBCDSN_DSN
            // 
            this.txtODBCDSN_DSN.Location = new System.Drawing.Point(100, 19);
            this.txtODBCDSN_DSN.Name = "txtODBCDSN_DSN";
            this.txtODBCDSN_DSN.Size = new System.Drawing.Size(270, 20);
            this.txtODBCDSN_DSN.TabIndex = 1;
            this.txtODBCDSN_DSN.TextChanged += new System.EventHandler(this.txtODBCDSN_DSN_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lblCount);
            this.tabPage2.Controls.Add(this.txtCommand);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnExecute);
            this.tabPage2.Controls.Add(this.grdRecord);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(756, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdRecord
            // 
            this.grdRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecord.Location = new System.Drawing.Point(25, 6);
            this.grdRecord.Name = "grdRecord";
            this.grdRecord.Size = new System.Drawing.Size(706, 232);
            this.grdRecord.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Useful Queries";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 466);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTester";
            this.Text = "SQL Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpODBCDSNConfig.ResumeLayout(false);
            this.grpODBCDSNConfig.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grdRecord;
        private System.Windows.Forms.GroupBox grpODBCDSNConfig;
        private System.Windows.Forms.CheckBox chkODBCDSN;
        private System.Windows.Forms.TextBox txtODBCDSN_DSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDDBCDSN_Password;
        private System.Windows.Forms.TextBox txtODBCDSN_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNextTab;
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

