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
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_DB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_DB_File = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox_TableList = new System.Windows.Forms.ComboBox();
            this.label_TableChoice = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Selector.SuspendLayout();
            this.statusStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(784, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip_Main";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Config_DB});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // tsmi_Config_DB
            // 
            this.tsmi_Config_DB.Name = "tsmi_Config_DB";
            this.tsmi_Config_DB.Size = new System.Drawing.Size(139, 22);
            this.tsmi_Config_DB.Text = "資料庫來源";
            this.tsmi_Config_DB.Click += new System.EventHandler(this.tsmi_Config_DB_Click);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Selector);
            this.tabControl_Main.Controls.Add(this.tabPage2);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 24);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(784, 537);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_Selector
            // 
            this.tabPage_Selector.Controls.Add(this.label_TableChoice);
            this.tabPage_Selector.Controls.Add(this.comboBox_TableList);
            this.tabPage_Selector.Controls.Add(this.statusStrip_Main);
            this.tabPage_Selector.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Selector.Name = "tabPage_Selector";
            this.tabPage_Selector.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Selector.Size = new System.Drawing.Size(776, 511);
            this.tabPage_Selector.TabIndex = 0;
            this.tabPage_Selector.Text = "菜單組合";
            this.tabPage_Selector.UseVisualStyleBackColor = true;
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_DB,
            this.toolStripStatusLabel_DB_File});
            this.statusStrip_Main.Location = new System.Drawing.Point(3, 486);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(770, 22);
            this.statusStrip_Main.TabIndex = 0;
            this.statusStrip_Main.Text = "statusStrip_Main";
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox_TableList
            // 
            this.comboBox_TableList.FormattingEnabled = true;
            this.comboBox_TableList.Location = new System.Drawing.Point(94, 18);
            this.comboBox_TableList.Name = "comboBox_TableList";
            this.comboBox_TableList.Size = new System.Drawing.Size(205, 21);
            this.comboBox_TableList.TabIndex = 1;
            // 
            // label_TableChoice
            // 
            this.label_TableChoice.AutoSize = true;
            this.label_TableChoice.Location = new System.Drawing.Point(18, 21);
            this.label_TableChoice.Name = "label_TableChoice";
            this.label_TableChoice.Size = new System.Drawing.Size(70, 13);
            this.label_TableChoice.TabIndex = 2;
            this.label_TableChoice.Text = "選擇資料表:";
            // 
            // Form_TravelAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Config_DB;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Selector;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DB_File;
        private System.Windows.Forms.Label label_TableChoice;
        private System.Windows.Forms.ComboBox comboBox_TableList;
    }
}

