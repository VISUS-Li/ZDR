namespace ZDRJC2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检测人管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加检测人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除检测人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加检测人事件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jCRDataSet = new ZDRJC2.JCRDataSet();
            this.btnselect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moreCon = new System.Windows.Forms.Button();
            this.checkGXRY = new System.Windows.Forms.CheckBox();
            this.checkXJZD = new System.Windows.Forms.CheckBox();
            this.checkLKDW = new System.Windows.Forms.CheckBox();
            this.checkLKJB = new System.Windows.Forms.CheckBox();
            this.checkJG = new System.Windows.Forms.CheckBox();
            this.sqlXJZD = new System.Windows.Forms.TextBox();
            this.sqlGXRY = new System.Windows.Forms.TextBox();
            this.sqlLKDW = new System.Windows.Forms.TextBox();
            this.sqlLKJB = new System.Windows.Forms.TextBox();
            this.sqlJG = new System.Windows.Forms.TextBox();
            this.sqlName = new System.Windows.Forms.TextBox();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.jCRJBXXTableAdapter = new ZDRJC2.JCRDataSetTableAdapters.JCRJBXXTableAdapter();
            this.gridSql = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jCRDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSql)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.管理员ToolStripMenuItem,
            this.检测人管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(232, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 主界面ToolStripMenuItem
            // 
            this.主界面ToolStripMenuItem.Name = "主界面ToolStripMenuItem";
            this.主界面ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.主界面ToolStripMenuItem.Text = "主界面";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem1});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.查询ToolStripMenuItem1.Text = "查询基本信息";
            this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.查询ToolStripMenuItem1_Click);
            // 
            // 管理员ToolStripMenuItem
            // 
            this.管理员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加管理员ToolStripMenuItem,
            this.删除管理员ToolStripMenuItem});
            this.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem";
            this.管理员ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.管理员ToolStripMenuItem.Text = "管理员";
            // 
            // 添加管理员ToolStripMenuItem
            // 
            this.添加管理员ToolStripMenuItem.Name = "添加管理员ToolStripMenuItem";
            this.添加管理员ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加管理员ToolStripMenuItem.Text = "添加管理员";
            this.添加管理员ToolStripMenuItem.Click += new System.EventHandler(this.添加管理员ToolStripMenuItem_Click);
            // 
            // 删除管理员ToolStripMenuItem
            // 
            this.删除管理员ToolStripMenuItem.Name = "删除管理员ToolStripMenuItem";
            this.删除管理员ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除管理员ToolStripMenuItem.Text = "删除管理员";
            this.删除管理员ToolStripMenuItem.Click += new System.EventHandler(this.删除管理员ToolStripMenuItem_Click);
            // 
            // 检测人管理ToolStripMenuItem
            // 
            this.检测人管理ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.检测人管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加检测人ToolStripMenuItem,
            this.删除检测人ToolStripMenuItem,
            this.添加检测人事件ToolStripMenuItem});
            this.检测人管理ToolStripMenuItem.Name = "检测人管理ToolStripMenuItem";
            this.检测人管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.检测人管理ToolStripMenuItem.Text = "监测人管理";
            // 
            // 添加检测人ToolStripMenuItem
            // 
            this.添加检测人ToolStripMenuItem.Name = "添加检测人ToolStripMenuItem";
            this.添加检测人ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加检测人ToolStripMenuItem.Text = "添加监测人";
            this.添加检测人ToolStripMenuItem.Click += new System.EventHandler(this.添加检测人ToolStripMenuItem_Click);
            // 
            // 删除检测人ToolStripMenuItem
            // 
            this.删除检测人ToolStripMenuItem.Name = "删除检测人ToolStripMenuItem";
            this.删除检测人ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.删除检测人ToolStripMenuItem.Text = "删除监测人";
            // 
            // 添加检测人事件ToolStripMenuItem
            // 
            this.添加检测人事件ToolStripMenuItem.Name = "添加检测人事件ToolStripMenuItem";
            this.添加检测人事件ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加检测人事件ToolStripMenuItem.Text = "添加监测人事件";
            this.添加检测人事件ToolStripMenuItem.Click += new System.EventHandler(this.添加检测人事件ToolStripMenuItem_Click);
            // 
            // jCRDataSet
            // 
            this.jCRDataSet.DataSetName = "JCRDataSet";
            this.jCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnselect
            // 
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselect.Location = new System.Drawing.Point(758, 57);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = "查找";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnselect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 236);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(758, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "查看详细信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moreCon);
            this.groupBox1.Controls.Add(this.checkGXRY);
            this.groupBox1.Controls.Add(this.checkXJZD);
            this.groupBox1.Controls.Add(this.checkLKDW);
            this.groupBox1.Controls.Add(this.checkLKJB);
            this.groupBox1.Controls.Add(this.checkJG);
            this.groupBox1.Controls.Add(this.sqlXJZD);
            this.groupBox1.Controls.Add(this.sqlGXRY);
            this.groupBox1.Controls.Add(this.sqlLKDW);
            this.groupBox1.Controls.Add(this.sqlLKJB);
            this.groupBox1.Controls.Add(this.sqlJG);
            this.groupBox1.Controls.Add(this.sqlName);
            this.groupBox1.Controls.Add(this.checkName);
            this.groupBox1.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(49, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选条件";
            // 
            // moreCon
            // 
            this.moreCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreCon.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moreCon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moreCon.Location = new System.Drawing.Point(590, 135);
            this.moreCon.Name = "moreCon";
            this.moreCon.Size = new System.Drawing.Size(75, 23);
            this.moreCon.TabIndex = 6;
            this.moreCon.Text = "更多条件";
            this.moreCon.UseVisualStyleBackColor = true;
            this.moreCon.Click += new System.EventHandler(this.moreCon_Click);
            // 
            // checkGXRY
            // 
            this.checkGXRY.AutoSize = true;
            this.checkGXRY.Location = new System.Drawing.Point(315, 86);
            this.checkGXRY.Name = "checkGXRY";
            this.checkGXRY.Size = new System.Drawing.Size(108, 23);
            this.checkGXRY.TabIndex = 4;
            this.checkGXRY.Text = "关系人员";
            this.checkGXRY.UseVisualStyleBackColor = true;
            // 
            // checkXJZD
            // 
            this.checkXJZD.AutoSize = true;
            this.checkXJZD.Location = new System.Drawing.Point(315, 139);
            this.checkXJZD.Name = "checkXJZD";
            this.checkXJZD.Size = new System.Drawing.Size(108, 23);
            this.checkXJZD.TabIndex = 4;
            this.checkXJZD.Text = "现居住地";
            this.checkXJZD.UseVisualStyleBackColor = true;
            // 
            // checkLKDW
            // 
            this.checkLKDW.AutoSize = true;
            this.checkLKDW.Location = new System.Drawing.Point(315, 36);
            this.checkLKDW.Name = "checkLKDW";
            this.checkLKDW.Size = new System.Drawing.Size(108, 23);
            this.checkLKDW.TabIndex = 4;
            this.checkLKDW.Text = "列控单位";
            this.checkLKDW.UseVisualStyleBackColor = true;
            // 
            // checkLKJB
            // 
            this.checkLKJB.AutoSize = true;
            this.checkLKJB.Location = new System.Drawing.Point(17, 139);
            this.checkLKJB.Name = "checkLKJB";
            this.checkLKJB.Size = new System.Drawing.Size(108, 23);
            this.checkLKJB.TabIndex = 4;
            this.checkLKJB.Text = "列控级别";
            this.checkLKJB.UseVisualStyleBackColor = true;
            // 
            // checkJG
            // 
            this.checkJG.AutoSize = true;
            this.checkJG.Location = new System.Drawing.Point(17, 84);
            this.checkJG.Name = "checkJG";
            this.checkJG.Size = new System.Drawing.Size(68, 23);
            this.checkJG.TabIndex = 4;
            this.checkJG.Text = "籍贯";
            this.checkJG.UseVisualStyleBackColor = true;
            // 
            // sqlXJZD
            // 
            this.sqlXJZD.Location = new System.Drawing.Point(429, 137);
            this.sqlXJZD.Multiline = true;
            this.sqlXJZD.Name = "sqlXJZD";
            this.sqlXJZD.Size = new System.Drawing.Size(140, 21);
            this.sqlXJZD.TabIndex = 2;
            // 
            // sqlGXRY
            // 
            this.sqlGXRY.Location = new System.Drawing.Point(429, 84);
            this.sqlGXRY.Multiline = true;
            this.sqlGXRY.Name = "sqlGXRY";
            this.sqlGXRY.Size = new System.Drawing.Size(140, 21);
            this.sqlGXRY.TabIndex = 2;
            // 
            // sqlLKDW
            // 
            this.sqlLKDW.Location = new System.Drawing.Point(429, 34);
            this.sqlLKDW.Multiline = true;
            this.sqlLKDW.Name = "sqlLKDW";
            this.sqlLKDW.Size = new System.Drawing.Size(140, 21);
            this.sqlLKDW.TabIndex = 2;
            // 
            // sqlLKJB
            // 
            this.sqlLKJB.Location = new System.Drawing.Point(132, 141);
            this.sqlLKJB.Multiline = true;
            this.sqlLKJB.Name = "sqlLKJB";
            this.sqlLKJB.Size = new System.Drawing.Size(140, 21);
            this.sqlLKJB.TabIndex = 2;
            // 
            // sqlJG
            // 
            this.sqlJG.Location = new System.Drawing.Point(132, 90);
            this.sqlJG.Multiline = true;
            this.sqlJG.Name = "sqlJG";
            this.sqlJG.Size = new System.Drawing.Size(140, 21);
            this.sqlJG.TabIndex = 2;
            // 
            // sqlName
            // 
            this.sqlName.Location = new System.Drawing.Point(132, 38);
            this.sqlName.Multiline = true;
            this.sqlName.Name = "sqlName";
            this.sqlName.Size = new System.Drawing.Size(140, 21);
            this.sqlName.TabIndex = 2;
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Location = new System.Drawing.Point(17, 34);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(68, 23);
            this.checkName.TabIndex = 0;
            this.checkName.Text = "姓名";
            this.checkName.UseVisualStyleBackColor = true;
            // 
            // jCRJBXXTableAdapter
            // 
            this.jCRJBXXTableAdapter.ClearBeforeFill = true;
            // 
            // gridSql
            // 
            this.gridSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSql.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSql.Location = new System.Drawing.Point(0, 242);
            this.gridSql.Name = "gridSql";
            this.gridSql.RowTemplate.Height = 23;
            this.gridSql.Size = new System.Drawing.Size(908, 210);
            this.gridSql.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 452);
            this.Controls.Add(this.gridSql);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "主界面";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jCRDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检测人管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加检测人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除检测人ToolStripMenuItem;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Panel panel1;
        private JCRDataSet jCRDataSet;
        private JCRDataSetTableAdapters.JCRJBXXTableAdapter jCRJBXXTableAdapter;

 
        private System.Windows.Forms.DataGridViewTextBoxColumn jCRnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ16DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ17DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ18DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ19DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJ20DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 添加检测人事件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkJG;
        private System.Windows.Forms.CheckBox checkLKJB;
        private System.Windows.Forms.TextBox sqlJG;
        private System.Windows.Forms.TextBox sqlName;
        private System.Windows.Forms.CheckBox checkLKDW;
        private System.Windows.Forms.TextBox sqlLKDW;
        private System.Windows.Forms.TextBox sqlLKJB;
        private System.Windows.Forms.CheckBox checkGXRY;
        private System.Windows.Forms.CheckBox checkXJZD;
        private System.Windows.Forms.TextBox sqlXJZD;
        private System.Windows.Forms.TextBox sqlGXRY;
        private System.Windows.Forms.DataGridView gridSql;
        private System.Windows.Forms.Button moreCon;
        private System.Windows.Forms.Button button1;
    }
}