using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Travel_Agent
{
    public partial class Form_TravelAgent : Form
    {
        private const string CONFIG_FILE = "TravelAgent.config";
        private const string CONNECTION_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";

        private string _DB_File_Name = string.Empty;
        private string _DB_Connection_String;

        public Form_TravelAgent()
        {
            InitializeComponent();
        }

        private void Form_TravelAgent_Load(object sender, EventArgs e)
        {
            // check DB file config first
            this._DB_File_Name = LoadDbFileFromConfigFile(CONFIG_FILE);
            if(string.IsNullOrEmpty(this._DB_File_Name) || !File.Exists(this._DB_File_Name))
            {
                MessageBox.Show("Please setup the DB file first!");
            }
            
        }

        private void tsmi_Config_DB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_DB = new OpenFileDialog();
            ofd_DB.DefaultExt = "accdb";
            ofd_DB.CheckFileExists = true;
            ofd_DB.CheckPathExists = true;
            ofd_DB.Multiselect = false;
            ofd_DB.Title = "設定 DB File";
            ofd_DB.Filter = "Access Database File (*.accdb)|*.accdb";
            if(ofd_DB.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(ofd_DB.FileName);
                bool result_saveconfig = false;
                try
                {
                    result_saveconfig = SaveDbFileToConfigFile(CONFIG_FILE, this._DB_File_Name);
                    this._DB_File_Name = ofd_DB.FileName;
                    this.toolStripStatusLabel_DB_File.Text = this._DB_File_Name;

                    // load table list from Access DB file
                    RefreshTableList();
                }
                catch(Exception ex)
                {
                    result_saveconfig = false;
                }

                if(result_saveconfig)
                {
                    MessageBox.Show("儲存DB檔案設定失敗!");
                }
            }
        }

        #region DB File Path Config
        private bool SaveDbFileToConfigFile(string configFilePath, string dbFilePath)
        {
            if(File.Exists(configFilePath))
            {
                File.WriteAllText(configFilePath, dbFilePath.Trim());
                return true;
            }

            return false;
        }
        private string LoadDbFileFromConfigFile(string configFilePath)
        {
            if (File.Exists(configFilePath))
            {
                string value = File.ReadAllText(configFilePath);
                return value.Trim();
            }
            return string.Empty;
        }
        #endregion

        private void button_RefreshTabList_Click(object sender, EventArgs e)
        {
            RefreshTableList();
        }

        private void RefreshTableList()
        {
            if(string.IsNullOrEmpty(this._DB_File_Name))
            {
                MessageBox.Show("請先選擇 Data Base 檔案!");
                return;
            }
            using (OleDbConnection conn = OleDbOpenConn(this._DB_File_Name))
            {
                string[] restrains = new string[4];
                restrains[3] = "Table";
                DataTable table = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, restrains);
                comboBox_TableList.DataSource = table;
                comboBox_TableList.DisplayMember = "TABLE_NAME";
            }
        }

        #region DB Connection
        public static OleDbConnection OleDbOpenConn(string dbFilePath)
        {
            string cnstr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbFilePath);
            OleDbConnection icn = new OleDbConnection();
            icn.ConnectionString = cnstr;
            if (icn.State == ConnectionState.Open) icn.Close();
            icn.Open();
            return icn;
        }
        #endregion

        private void comboBox_TableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)this.comboBox_TableList.SelectedItem;
            string table_name = row["TABLE_NAME"].ToString().Trim();
            if(!string.IsNullOrEmpty(table_name))
            {
                using (OleDbConnection conn = OleDbOpenConn(this._DB_File_Name))
                {
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT * FROM [{0}]", table_name);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView_TravelDataList.DataSource = table;
                }
            }
        }

        private void button_AddSelection_Click(object sender, EventArgs e)
        {
            // to copy the rows you need to have created the columns:
            foreach (DataGridViewColumn c in this.dataGridView_TravelDataList.Columns)
            {
                if(this.dataGridView_Result.Columns[c.HeaderText] == null)
                {
                    this.dataGridView_Result.Columns.Add(c.Clone() as DataGridViewColumn);
                }
            }

            //then you can copy the rows values one by one (working on the selectedrows collection)
            foreach (DataGridViewRow srcRow in this.dataGridView_TravelDataList.SelectedRows)
            {
                // initial a new row instance
                int index = this.dataGridView_Result.Rows.Add(srcRow.Clone() as DataGridViewRow);
                foreach(DataGridViewCell cell in srcRow.Cells)
                {
                    string colName = this.dataGridView_TravelDataList.Columns[cell.ColumnIndex].HeaderText;
                    this.dataGridView_Result[colName, index].Value = cell.Value;
                }

            }
        }

        private void button_ExportResult_Click(object sender, EventArgs e)
        {
            // data grid view row count is greater than 0, user had added some data
            if(this.dataGridView_Result.Rows.Count > 0)
            {
                SaveFileDialog sfdlg = new SaveFileDialog();
                sfdlg.AddExtension = true;
                sfdlg.DefaultExt = ".xlsx";
                sfdlg.Filter = "Microsoft Excel File (*.xlsx)|";

                if(sfdlg.ShowDialog() == DialogResult.OK)
                {
                    // conver DataGridView to DataTable first
                    DataTable dt = new DataTable("Result");
                    // generate DataTable columns
                    foreach(DataGridViewColumn col in this.dataGridView_Result.Columns)
                    {
                        if(col.Visible && !string.IsNullOrEmpty(col.Name))
                        {
                            dt.Columns.Add(col.Name);
                            dt.Columns[col.Name].Caption = col.HeaderText;
                        }
                    }
                    // copy every rows in DataGridView
                    foreach(DataGridViewRow row in this.dataGridView_Result.Rows)
                    {
                        // new a data table row first
                        DataRow dtRow = dt.NewRow();
                        // copy column values secondly
                        foreach(DataColumn col in dt.Columns)
                        {
                            dtRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                        }
                        // add completely row back to DataTable
                        dt.Rows.Add(dtRow);
                    }

                    // save data table to Excel worksheet
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        wb.AddWorksheet(dt);
                        wb.SaveAs(sfdlg.FileName);
                        MessageBox.Show("儲存成功!");
                    }
                }
            }
        }
    }
}
