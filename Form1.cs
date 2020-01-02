using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Export
{
    public partial class Frm_Sp_Export : Form
    {
        private string connectionString = string.Empty;
        SqlConnection connection = null;
        static bool isConnected = false;
        public Frm_Sp_Export()
        {
            InitializeComponent();
            this.Height = 257;
            this.Width = 411;
            Clear();
            cmd_Start.Enabled = false;
            cmd_Stop.Enabled = false;
            cmd_Connect.Enabled = true;
            chk_ExportTables.Enabled = false;
        }

        private void Cmd_Connect_Click(object sender, EventArgs e)
        {
            ConnectionValidation();
            if (isConnected)
            {
                cmd_Start.Enabled = true;
                cmd_Stop.Enabled = true;
                cmd_Connect.Enabled = false;
                chk_ExportTables.Enabled = true;
                txt_ServerName.Enabled = false;
                txt_Database.Enabled = false;
                txt_UserName.Enabled = false;
                txt_Password.Enabled = false;
            }
        }

        private void Cmd_Stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cmd_Start_Click(object sender, EventArgs e)
        {
            txt_Log.Clear();
            if (ConnectionValidation())
            {
                cmd_Clear.Enabled = false;
                connectionString = SingleConnection.Connect(txt_ServerName.Text, txt_Database.Text, txt_UserName.Text, txt_Password.Text);
                using (connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(";WITH ROUTINES AS ( SELECT o.type_desc AS ROUTINE_TYPE ,o.[name] AS ROUTINE_NAME ,m.definition AS ROUTINE_DEFINITION FROM sys.sql_modules AS m INNER JOIN sys.objects AS o ON m.object_id = o.object_id ) SELECT * FROM ROUTINES", connection)
                        {
                            CommandType = CommandType.Text
                        };
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                WriteIntoFile(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                            }
                        }
                        WriteLog("Process completed");
                    }
                    catch (Exception ex)
                    {
                        connection = null;
                        WriteLog("Connection failed. Pleasecheck the inputs");
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
                WriteTables();
                WriteLog("OverAll Completed");
                cmd_Clear.Enabled = true;
                MessageBox.Show("OverAll Completed");
                Application.Exit();
            }
        }

        private bool ConnectionValidation()
        {
            if (!string.IsNullOrEmpty(txt_ServerName.Text) && !string.IsNullOrEmpty(txt_Database.Text) && !string.IsNullOrEmpty(txt_UserName.Text) && !string.IsNullOrEmpty(txt_Password.Text))
            {
                try
                {
                    cmd_Clear.Enabled = false;
                    txt_Log.Clear();
                    connectionString = SingleConnection.Connect(txt_ServerName.Text, txt_Database.Text, txt_UserName.Text, txt_Password.Text);
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    WriteLog("Connected.");
                    cmd_Clear.Enabled = true;
                    isConnected = true;
                    return true;
                }
                catch (Exception ex)
                {
                    connection = null;
                    WriteLog("Connection failed. Please check the connection inputs");
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    cmd_Clear.Enabled = true;
                }
            }
            else
            {
                WriteLog("Connection failed. Please check the connection inputs");
            }
            return false;
        }

        private void WriteTables()
        {
            cmd_Clear.Enabled = false;
            WriteLog("Export Table process start");
            if (chk_ExportTables.Checked && !string.IsNullOrEmpty(txt_TableList.Text))
            {
                if (txt_TableList.Text.Contains(','))
                {
                    txt_TableList.Text.Split(',').ToList().ForEach(tableName =>
                    {
                        ExportCSV(tableName);
                    });
                }
                else
                {
                    txt_TableList.Text.Split('\n').ToList().ForEach(tableName =>
                    {
                        ExportCSV(tableName);
                    });
                }
            }
            if (chk_ExportTables.Checked && chk_TableList.Items.Count > 0)
            {
                for (int i = 0; i < chk_TableList.Items.Count; i++)
                {
                    if (chk_TableList.GetItemChecked(i))
                    {
                        ExportCSV((string)chk_TableList.Items[i]);
                    }
                }
            }
            cmd_Clear.Enabled = true;
            WriteLog("Export Table process end");
        }

        private void WriteIntoFile(string folder, string fileName, string content, string extn = "sql")
        {
            if (!content.Any())
            {
                return;
            }
            fileName = Regex.Replace(fileName, @"\t|\n|\r", "");
            var dir = Environment.CurrentDirectory + @"\"
                        + DateTime.UtcNow.ToString("yyyyMMdd") + @"\"
                        + folder.ToUpper();
            if (!Directory.Exists(dir))
            {
                WriteLog(string.Format("Create Folder: {0}.", dir));
                Directory.CreateDirectory(dir);
            }

            WriteLog(string.Format("Write File: {0}.", (fileName + ".sql")));
            File.WriteAllText(dir + @"\" + fileName + "." + extn, content);
        }

        private void ExportCSV(string tableName)
        {
            string constr = SingleConnection.Connect(txt_ServerName.Text, txt_Database.Text, txt_UserName.Text, txt_Password.Text);
            string csv = string.Empty;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM " + tableName))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            foreach (DataColumn column in dt.Columns)
                            {
                                csv += column.ColumnName + ',';
                            }
                            csv += "\r\n";
                            foreach (DataRow row in dt.Rows)
                            {
                                foreach (DataColumn column in dt.Columns)
                                {
                                    csv += row[column.ColumnName].ToString().Replace(",", ";") + ',';
                                }
                                csv += "\r\n";
                            }
                        }
                    }
                }
            }
            WriteIntoFile("Tables", tableName, csv, "csv");
        }

        private void WriteLog(string content)
        {
            txt_Log.AppendText(string.Format("{0}: {1}.", DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss"), content));
            txt_Log.AppendText(Environment.NewLine);
        }

        private void FillTablesList()
        {
            chk_TableList.Items.Clear();
            connectionString = SingleConnection.Connect(txt_ServerName.Text, txt_Database.Text, txt_UserName.Text, txt_Password.Text);
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT NAME FROM SYS.TABLES WHERE TYPE = 'U'", connection)
                    {
                        CommandType = CommandType.Text
                    };
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            chk_TableList.Items.Add(reader.GetString(0));
                        }
                    }
                    WriteLog("Table list added");
                }
                catch (Exception ex)
                {
                    connection = null;
                    WriteLog("Connection failed. Pleasecheck the inputs");
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void Chk_ExportTables_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ExportTables.Checked)
            {
                if (ConnectionValidation())
                {
                    this.Height = 257;
                    this.Width = 619;
                    FillTablesList();
                }
                else
                {
                    WriteLog("Connection Failed!");
                }
            }
            else
            {
                this.Height = 257;
                this.Width = 411;
            }
        }

        private void Chk_SelectAllTables_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SelectAllTables.Checked)
            {
                if (chk_TableList.Items.Count > 0)
                {
                    for (int i = 0; i < chk_TableList.Items.Count; i++)
                    {
                        chk_TableList.SetItemChecked(i, true);
                    }
                }
            }
            else
            {
                if (chk_TableList.Items.Count > 0)
                {
                    for (int i = 0; i < chk_TableList.Items.Count; i++)
                    {
                        chk_TableList.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void Cmd_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txt_Log.Clear();
            txt_ServerName.Text = "";
            txt_Database.Text = "";
            txt_UserName.Text = "";
            txt_Password.Text = "";
            chk_ExportTables.Checked = false;
            chk_SelectAllTables.Checked = false;
            txt_ServerName.Enabled = true;
            txt_Database.Enabled = true;
            txt_UserName.Enabled = true;
            txt_Password.Enabled = true;
        }
    }
}