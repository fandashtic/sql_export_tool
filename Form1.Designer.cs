namespace SP_Export
{
    partial class Frm_Sp_Export
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cmd_Stop = new System.Windows.Forms.Button();
            this.cmd_Start = new System.Windows.Forms.Button();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.txt_Log = new System.Windows.Forms.RichTextBox();
            this.cmd_Connect = new System.Windows.Forms.Button();
            this.chk_ExportTables = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Tables = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chk_TableList = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_TableList = new System.Windows.Forms.RichTextBox();
            this.chk_SelectAllTables = new System.Windows.Forms.CheckBox();
            this.cmd_Clear = new System.Windows.Forms.Button();
            this.Tables.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Location = new System.Drawing.Point(87, 6);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(297, 20);
            this.txt_ServerName.TabIndex = 4;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(87, 58);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(122, 20);
            this.txt_UserName.TabIndex = 6;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(87, 84);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(122, 20);
            this.txt_Password.TabIndex = 7;
            // 
            // cmd_Stop
            // 
            this.cmd_Stop.BackColor = System.Drawing.Color.Pink;
            this.cmd_Stop.Location = new System.Drawing.Point(339, 81);
            this.cmd_Stop.Name = "cmd_Stop";
            this.cmd_Stop.Size = new System.Drawing.Size(44, 23);
            this.cmd_Stop.TabIndex = 8;
            this.cmd_Stop.Text = "Stop";
            this.cmd_Stop.UseVisualStyleBackColor = false;
            this.cmd_Stop.Click += new System.EventHandler(this.Cmd_Stop_Click);
            // 
            // cmd_Start
            // 
            this.cmd_Start.BackColor = System.Drawing.Color.GreenYellow;
            this.cmd_Start.Location = new System.Drawing.Point(278, 81);
            this.cmd_Start.Name = "cmd_Start";
            this.cmd_Start.Size = new System.Drawing.Size(56, 23);
            this.cmd_Start.TabIndex = 9;
            this.cmd_Start.Text = "Start";
            this.cmd_Start.UseVisualStyleBackColor = false;
            this.cmd_Start.Click += new System.EventHandler(this.Cmd_Start_Click);
            // 
            // txt_Database
            // 
            this.txt_Database.Location = new System.Drawing.Point(87, 32);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(297, 20);
            this.txt_Database.TabIndex = 5;
            // 
            // txt_Log
            // 
            this.txt_Log.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txt_Log.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log.Location = new System.Drawing.Point(15, 119);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.Size = new System.Drawing.Size(369, 87);
            this.txt_Log.TabIndex = 10;
            this.txt_Log.Text = "";
            // 
            // cmd_Connect
            // 
            this.cmd_Connect.BackColor = System.Drawing.Color.Cyan;
            this.cmd_Connect.Location = new System.Drawing.Point(215, 81);
            this.cmd_Connect.Name = "cmd_Connect";
            this.cmd_Connect.Size = new System.Drawing.Size(57, 23);
            this.cmd_Connect.TabIndex = 11;
            this.cmd_Connect.Text = "Connect";
            this.cmd_Connect.UseVisualStyleBackColor = false;
            this.cmd_Connect.Click += new System.EventHandler(this.Cmd_Connect_Click);
            // 
            // chk_ExportTables
            // 
            this.chk_ExportTables.AutoSize = true;
            this.chk_ExportTables.Location = new System.Drawing.Point(278, 57);
            this.chk_ExportTables.Name = "chk_ExportTables";
            this.chk_ExportTables.Size = new System.Drawing.Size(91, 17);
            this.chk_ExportTables.TabIndex = 12;
            this.chk_ExportTables.Text = "Export Tables";
            this.chk_ExportTables.UseVisualStyleBackColor = true;
            this.chk_ExportTables.CheckedChanged += new System.EventHandler(this.Chk_ExportTables_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(424, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(101, 64);
            this.checkedListBox1.TabIndex = 14;
            // 
            // Tables
            // 
            this.Tables.Controls.Add(this.tabPage1);
            this.Tables.Controls.Add(this.tabPage2);
            this.Tables.Location = new System.Drawing.Point(402, 9);
            this.Tables.Name = "Tables";
            this.Tables.SelectedIndex = 0;
            this.Tables.Size = new System.Drawing.Size(202, 202);
            this.Tables.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_SelectAllTables);
            this.tabPage1.Controls.Add(this.chk_TableList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(194, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chk_TableList
            // 
            this.chk_TableList.FormattingEnabled = true;
            this.chk_TableList.Location = new System.Drawing.Point(3, 36);
            this.chk_TableList.Name = "chk_TableList";
            this.chk_TableList.Size = new System.Drawing.Size(188, 139);
            this.chk_TableList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_TableList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(194, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_TableList
            // 
            this.txt_TableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TableList.Location = new System.Drawing.Point(3, 3);
            this.txt_TableList.Name = "txt_TableList";
            this.txt_TableList.Size = new System.Drawing.Size(188, 170);
            this.txt_TableList.TabIndex = 0;
            this.txt_TableList.Text = "";
            // 
            // chk_SelectAllTables
            // 
            this.chk_SelectAllTables.AutoSize = true;
            this.chk_SelectAllTables.Location = new System.Drawing.Point(6, 13);
            this.chk_SelectAllTables.Name = "chk_SelectAllTables";
            this.chk_SelectAllTables.Size = new System.Drawing.Size(70, 17);
            this.chk_SelectAllTables.TabIndex = 1;
            this.chk_SelectAllTables.Text = "Select All";
            this.chk_SelectAllTables.UseVisualStyleBackColor = true;
            this.chk_SelectAllTables.CheckedChanged += new System.EventHandler(this.Chk_SelectAllTables_CheckedChanged);
            // 
            // cmd_Clear
            // 
            this.cmd_Clear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cmd_Clear.Location = new System.Drawing.Point(215, 56);
            this.cmd_Clear.Name = "cmd_Clear";
            this.cmd_Clear.Size = new System.Drawing.Size(57, 23);
            this.cmd_Clear.TabIndex = 16;
            this.cmd_Clear.Text = "Clear";
            this.cmd_Clear.UseVisualStyleBackColor = false;
            this.cmd_Clear.Click += new System.EventHandler(this.Cmd_Clear_Click);
            // 
            // Frm_Sp_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 218);
            this.Controls.Add(this.cmd_Clear);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chk_ExportTables);
            this.Controls.Add(this.cmd_Connect);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.cmd_Start);
            this.Controls.Add(this.cmd_Stop);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_Database);
            this.Controls.Add(this.txt_ServerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Sp_Export";
            this.Text = "Sp Export Tool";
            this.Tables.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ServerName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button cmd_Stop;
        private System.Windows.Forms.Button cmd_Start;
        private System.Windows.Forms.TextBox txt_Database;
        private System.Windows.Forms.RichTextBox txt_Log;
        private System.Windows.Forms.Button cmd_Connect;
        private System.Windows.Forms.CheckBox chk_ExportTables;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabControl Tables;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckedListBox chk_TableList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txt_TableList;
        private System.Windows.Forms.CheckBox chk_SelectAllTables;
        private System.Windows.Forms.Button cmd_Clear;
    }
}

