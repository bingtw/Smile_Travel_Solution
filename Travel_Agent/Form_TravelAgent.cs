using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agent
{
    public partial class Form_TravelAgent : Form
    {
        private const string CONFIG_FILE = "TravelAgent.config";

        private string _DB_File_Name = string.Empty;

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
    }
}
