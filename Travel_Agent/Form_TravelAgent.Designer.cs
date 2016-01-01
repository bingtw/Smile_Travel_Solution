namespace Travel_Agent
{
    partial class Form_TravelAgent
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Config_DB = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Selector = new System.Windows.Forms.TabPage();
            this.button_ExportResult = new System.Windows.Forms.Button();
            this.button_AddSelection = new System.Windows.Forms.Button();
            this.dataGridView_Result = new System.Windows.Forms.DataGridView();
            this.dataGridView_TravelDataList = new System.Windows.Forms.DataGridView();
            this.label_SelectTable = new System.Windows.Forms.Label();
            this.button_RefreshTabList = new System.Windows.Forms.Button();
            this.label_TableChoice = new System.Windows.Forms.Label();
            this.comboBox_TableList = new System.Windows.Forms.ComboBox();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_DB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_DB_File = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Selector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TravelDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip_Main";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Config_DB});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // tsmi_Config_DB
            // 
            this.tsmi_Config_DB.Name = "tsmi_Config_DB";
            this.tsmi_Config_DB.Size = new System.Drawing.Size(134, 22);
            this.tsmi_Config_DB.Text = "資料庫來源";
            this.tsmi_Config_DB.Click += new System.EventHandler(this.tsmi_Config_DB_Click);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Selector);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 24);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1008, 660);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_Selector
            // 
            this.tabPage_Selector.Controls.Add(this.button_ExportResult);
            this.tabPage_Selector.Controls.Add(this.button_AddSelection);
            this.tabPage_Selector.Controls.Add(this.dataGridView_Result);
            this.tabPage_Selector.Controls.Add(this.dataGridView_TravelDataList);
            this.tabPage_Selector.Controls.Add(this.label_SelectTable);
            this.tabPage_Selector.Controls.Add(this.button_RefreshTabList);
            this.tabPage_Selector.Controls.Add(this.label_TableChoice);
            this.tabPage_Selector.Controls.Add(this.comboBox_TableList);
            this.tabPage_Selector.Controls.Add(this.statusStrip_Main);
            this.tabPage_Selector.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Selector.Name = "tabPage_Selector";
            this.tabPage_Selector.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Selector.Size = new System.Drawing.Size(1000, 634);
            this.tabPage_Selector.TabIndex = 0;
            this.tabPage_Selector.Text = "菜單組合";
            this.tabPage_Selector.UseVisualStyleBackColor = true;
            // 
            // button_ExportResult
            // 
            this.button_ExportResult.Location = new System.Drawing.Point(823, 6);
            this.button_ExportResult.Name = "button_ExportResult";
            this.button_ExportResult.Size = new System.Drawing.Size(168, 30);
            this.button_ExportResult.TabIndex = 8;
            this.button_ExportResult.Text = "儲存結果";
            this.button_ExportResult.UseVisualStyleBackColor = true;
            this.button_ExportResult.Click += new System.EventHandler(this.button_ExportResult_Click);
            // 
            // button_AddSelection
            // 
            this.button_AddSelection.Location = new System.Drawing.Point(455, 41);
            this.button_AddSelection.Name = "button_AddSelection";
            this.button_AddSelection.Size = new System.Drawing.Size(80, 564);
            this.button_AddSelection.TabIndex = 7;
            this.button_AddSelection.Text = "增加至清單";
            this.button_AddSelection.UseVisualStyleBackColor = true;
            this.button_AddSelection.Click += new System.EventHandler(this.button_AddSelection_Click);
            // 
            // dataGridView_Result
            // 
            this.dataGridView_Result.AllowUserToAddRows = false;
            this.dataGridView_Result.AllowUserToDeleteRows = false;
            this.dataGridView_Result.AllowUserToOrderColumns = true;
            this.dataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Result.Location = new System.Drawing.Point(541, 41);
            this.dataGridView_Result.MultiSelect = false;
            this.dataGridView_Result.Name = "dataGridView_Result";
            this.dataGridView_Result.ReadOnly = true;
            this.dataGridView_Result.RowTemplate.ReadOnly = true;
            this.dataGridView_Result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Result.Size = new System.Drawing.Size(450, 564);
            this.dataGridView_Result.TabIndex = 6;
            // 
            // dataGridView_TravelDataList
            // 
            this.dataGridView_TravelDataList.AllowUserToAddRows = false;
            this.dataGridView_TravelDataList.AllowUserToDeleteRows = false;
            this.dataGridView_TravelDataList.AllowUserToOrderColumns = true;
            this.dataGridView_TravelDataList.AllowUserToResizeRows = false;
            this.dataGridView_TravelDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TravelDataList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_TravelDataList.Location = new System.Drawing.Point(9, 41);
            this.dataGridView_TravelDataList.MultiSelect = false;
            this.dataGridView_TravelDataList.Name = "dataGridView_TravelDataList";
            this.dataGridView_TravelDataList.ReadOnly = true;
            this.dataGridView_TravelDataList.RowTemplate.ReadOnly = true;
            this.dataGridView_TravelDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TravelDataList.Size = new System.Drawing.Size(440, 564);
            this.dataGridView_TravelDataList.TabIndex = 5;
            // 
            // label_SelectTable
            // 
            this.label_SelectTable.AutoSize = true;
            this.label_SelectTable.Location = new System.Drawing.Point(6, 19);
            this.label_SelectTable.Name = "label_SelectTable";
            this.label_SelectTable.Size = new System.Drawing.Size(77, 12);
            this.label_SelectTable.TabIndex = 4;
            this.label_SelectTable.Text = "選擇資料表：";
            // 
            // button_RefreshTabList
            // 
            this.button_RefreshTabList.Location = new System.Drawing.Point(305, 16);
            this.button_RefreshTabList.Name = "button_RefreshTabList";
            this.button_RefreshTabList.Size = new System.Drawing.Size(82, 19);
            this.button_RefreshTabList.TabIndex = 3;
            this.button_RefreshTabList.Text = "重新整理";
            this.button_RefreshTabList.UseVisualStyleBackColor = true;
            this.button_RefreshTabList.Click += new System.EventHandler(this.button_RefreshTabList_Click);
            // 
            // label_TableChoice
            // 
            this.label_TableChoice.AutoSize = true;
            this.label_TableChoice.Location = new System.Drawing.Point(18, 19);
            this.label_TableChoice.Name = "label_TableChoice";
            this.label_TableChoice.Size = new System.Drawing.Size(0, 12);
            this.label_TableChoice.TabIndex = 2;
            // 
            // comboBox_TableList
            // 
            this.comboBox_TableList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TableList.FormattingEnabled = true;
            this.comboBox_TableList.Location = new System.Drawing.Point(94, 16);
            this.comboBox_TableList.Name = "comboBox_TableList";
            this.comboBox_TableList.Size = new System.Drawing.Size(205, 20);
            this.comboBox_TableList.TabIndex = 1;
            this.comboBox_TableList.SelectedIndexChanged += new System.EventHandler(this.comboBox_TableList_SelectedIndexChanged);
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Location = new System.Drawing.Point(3, 609);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(994, 22);
            this.statusStrip_Main.TabIndex = 0;
            // 
            // toolStripStatusLabel_DB
            // 
            this.toolStripStatusLabel_DB.Name = "toolStripStatusLabel_DB";
            this.toolStripStatusLabel_DB.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel_DB.Text = "目前使用資料庫:";
            // 
            // toolStripStatusLabel_DB_File
            // 
            this.toolStripStatusLabel_DB_File.Name = "toolStripStatusLabel_DB_File";
            this.toolStripStatusLabel_DB_File.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_TravelAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 684);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form_TravelAgent";
            this.Text = "Trave Agent";
            this.Load += new System.EventHandler(this.Form_TravelAgent_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Selector.ResumeLayout(false);
            this.tabPage_Selector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TravelDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Config_DB;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Selector;
        private System.Windows.Forms.Button button_RefreshTabList;
        private System.Windows.Forms.Label label_TableChoice;
        private System.Windows.Forms.ComboBox comboBox_TableList;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DB_File;
        private System.Windows.Forms.DataGridView dataGridView_TravelDataList;
        private System.Windows.Forms.Label label_SelectTable;
        private System.Windows.Forms.DataGridView dataGridView_Result;
        private System.Windows.Forms.Button button_AddSelection;
        private System.Windows.Forms.Button button_ExportResult;
    }
}

