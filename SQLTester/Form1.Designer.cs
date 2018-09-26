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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.RichTextBox();
            this.txtStringToSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUsefulQueries = new System.Windows.Forms.Button();
            this.grdRecord = new System.Windows.Forms.DataGridView();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpODBCDSNConfig.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(786, 321);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(187, 48);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "&Execute Statement";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(133, 300);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 20);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Record Count";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 625);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnNextTab);
            this.tabPage1.Controls.Add(this.grpODBCDSNConfig);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1011, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(775, 501);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNextTab
            // 
            this.btnNextTab.Location = new System.Drawing.Point(883, 501);
            this.btnNextTab.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(100, 28);
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
            this.grpODBCDSNConfig.Location = new System.Drawing.Point(24, 25);
            this.grpODBCDSNConfig.Margin = new System.Windows.Forms.Padding(4);
            this.grpODBCDSNConfig.Name = "grpODBCDSNConfig";
            this.grpODBCDSNConfig.Padding = new System.Windows.Forms.Padding(4);
            this.grpODBCDSNConfig.Size = new System.Drawing.Size(959, 123);
            this.grpODBCDSNConfig.TabIndex = 0;
            this.grpODBCDSNConfig.TabStop = false;
            this.grpODBCDSNConfig.Enter += new System.EventHandler(this.grpODBCConfig_Enter);
            // 
            // txtDDBCDSN_Password
            // 
            this.txtDDBCDSN_Password.Location = new System.Drawing.Point(133, 87);
            this.txtDDBCDSN_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txtDDBCDSN_Password.Name = "txtDDBCDSN_Password";
            this.txtDDBCDSN_Password.Size = new System.Drawing.Size(359, 22);
            this.txtDDBCDSN_Password.TabIndex = 10;
            // 
            // txtODBCDSN_Username
            // 
            this.txtODBCDSN_Username.Location = new System.Drawing.Point(133, 55);
            this.txtODBCDSN_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txtODBCDSN_Username.Name = "txtODBCDSN_Username";
            this.txtODBCDSN_Username.Size = new System.Drawing.Size(359, 22);
            this.txtODBCDSN_Username.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "DSN";
            // 
            // chkODBCDSN
            // 
            this.chkODBCDSN.AutoSize = true;
            this.chkODBCDSN.BackColor = System.Drawing.Color.White;
            this.chkODBCDSN.Checked = true;
            this.chkODBCDSN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkODBCDSN.Location = new System.Drawing.Point(8, -1);
            this.chkODBCDSN.Margin = new System.Windows.Forms.Padding(4);
            this.chkODBCDSN.Name = "chkODBCDSN";
            this.chkODBCDSN.Size = new System.Drawing.Size(102, 21);
            this.chkODBCDSN.TabIndex = 0;
            this.chkODBCDSN.Text = "ODBC DSN";
            this.chkODBCDSN.UseVisualStyleBackColor = false;
            this.chkODBCDSN.CheckedChanged += new System.EventHandler(this.chkODBC_CheckedChanged);
            // 
            // txtODBCDSN_DSN
            // 
            this.txtODBCDSN_DSN.Location = new System.Drawing.Point(133, 23);
            this.txtODBCDSN_DSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtODBCDSN_DSN.Name = "txtODBCDSN_DSN";
            this.txtODBCDSN_DSN.Size = new System.Drawing.Size(359, 22);
            this.txtODBCDSN_DSN.TabIndex = 1;
            this.txtODBCDSN_DSN.TextChanged += new System.EventHandler(this.txtODBCDSN_DSN_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtCommand);
            this.tabPage2.Controls.Add(this.txtStringToSearch);
            this.tabPage2.Controls.Add(this.btnFind);
            this.tabPage2.Controls.Add(this.btnUsefulQueries);
            this.tabPage2.Controls.Add(this.lblCount);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnExecute);
            this.tabPage2.Controls.Add(this.grdRecord);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1011, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(33, 323);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCommand.Size = new System.Drawing.Size(746, 257);
            this.txtCommand.TabIndex = 9;
            this.txtCommand.Text = "";
            // 
            // txtStringToSearch
            // 
            this.txtStringToSearch.Location = new System.Drawing.Point(863, 439);
            this.txtStringToSearch.Name = "txtStringToSearch";
            this.txtStringToSearch.Size = new System.Drawing.Size(109, 22);
            this.txtStringToSearch.TabIndex = 8;
            this.txtStringToSearch.TextChanged += new System.EventHandler(this.txtStringToSearch_TextChanged);
            this.txtStringToSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchString);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(789, 532);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(185, 48);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUsefulQueries
            // 
            this.btnUsefulQueries.Location = new System.Drawing.Point(786, 377);
            this.btnUsefulQueries.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsefulQueries.Name = "btnUsefulQueries";
            this.btnUsefulQueries.Size = new System.Drawing.Size(186, 48);
            this.btnUsefulQueries.TabIndex = 6;
            this.btnUsefulQueries.Text = "Useful Queries";
            this.btnUsefulQueries.UseVisualStyleBackColor = true;
            this.btnUsefulQueries.Click += new System.EventHandler(this.btnUsefulQueries_Click);
            // 
            // grdRecord
            // 
            this.grdRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecord.Location = new System.Drawing.Point(33, 7);
            this.grdRecord.Margin = new System.Windows.Forms.Padding(4);
            this.grdRecord.Name = "grdRecord";
            this.grdRecord.Size = new System.Drawing.Size(941, 286);
            this.grdRecord.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(785, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Repace";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(863, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 12;
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 638);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnUsefulQueries;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtStringToSearch;
        private System.Windows.Forms.RichTextBox txtCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

