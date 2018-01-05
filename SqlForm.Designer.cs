namespace ZDRJC2
{
    partial class SqlForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlForm));
            this.sqlConditon = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlLKDW = new System.Windows.Forms.TextBox();
            this.sqlSFZ = new System.Windows.Forms.TextBox();
            this.sqlJG = new System.Windows.Forms.TextBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.sqlLKJB = new System.Windows.Forms.TextBox();
            this.sqlName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSql = new System.Windows.Forms.Button();
            this.sqlDataView = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.gridViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSeeDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSeeSJ = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQueryFJ = new System.Windows.Forms.ToolStripMenuItem();
            this.link1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeObjInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.delObj = new System.Windows.Forms.ToolStripMenuItem();
            this.link2 = new System.Windows.Forms.ToolStripMenuItem();
            this.添加事件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加附件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.link3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DCOneRow = new System.Windows.Forms.ToolStripMenuItem();
            this.DCselected = new System.Windows.Forms.ToolStripMenuItem();
            this.DCInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.DCJCRJBXX = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlConditon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataView)).BeginInit();
            this.gridViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlConditon
            // 
            this.sqlConditon.BackColor = System.Drawing.Color.Transparent;
            this.sqlConditon.Controls.Add(this.label5);
            this.sqlConditon.Controls.Add(this.label4);
            this.sqlConditon.Controls.Add(this.label3);
            this.sqlConditon.Controls.Add(this.label2);
            this.sqlConditon.Controls.Add(this.label1);
            this.sqlConditon.Controls.Add(this.sqlLKDW);
            this.sqlConditon.Controls.Add(this.sqlSFZ);
            this.sqlConditon.Controls.Add(this.sqlJG);
            this.sqlConditon.Controls.Add(this.btnMore);
            this.sqlConditon.Controls.Add(this.sqlLKJB);
            this.sqlConditon.Controls.Add(this.sqlName);
            this.sqlConditon.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlConditon.Location = new System.Drawing.Point(27, 31);
            this.sqlConditon.Name = "sqlConditon";
            this.sqlConditon.Size = new System.Drawing.Size(551, 188);
            this.sqlConditon.TabIndex = 0;
            this.sqlConditon.TabStop = false;
            this.sqlConditon.Text = "筛选条件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "身份证号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "列控级别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "列控单位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "籍贯";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名";
            // 
            // sqlLKDW
            // 
            this.sqlLKDW.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlLKDW.Location = new System.Drawing.Point(123, 138);
            this.sqlLKDW.Multiline = true;
            this.sqlLKDW.Name = "sqlLKDW";
            this.sqlLKDW.Size = new System.Drawing.Size(122, 21);
            this.sqlLKDW.TabIndex = 2;
            // 
            // sqlSFZ
            // 
            this.sqlSFZ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlSFZ.Location = new System.Drawing.Point(401, 93);
            this.sqlSFZ.Multiline = true;
            this.sqlSFZ.Name = "sqlSFZ";
            this.sqlSFZ.Size = new System.Drawing.Size(122, 21);
            this.sqlSFZ.TabIndex = 2;
            // 
            // sqlJG
            // 
            this.sqlJG.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlJG.Location = new System.Drawing.Point(123, 93);
            this.sqlJG.Multiline = true;
            this.sqlJG.Name = "sqlJG";
            this.sqlJG.Size = new System.Drawing.Size(122, 21);
            this.sqlJG.TabIndex = 2;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMore.Location = new System.Drawing.Point(348, 136);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(122, 31);
            this.btnMore.TabIndex = 1;
            this.btnMore.Text = "更 多";
            this.toolTip1.SetToolTip(this.btnMore, "显示更多筛选信息");
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // sqlLKJB
            // 
            this.sqlLKJB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlLKJB.Location = new System.Drawing.Point(401, 46);
            this.sqlLKJB.Multiline = true;
            this.sqlLKJB.Name = "sqlLKJB";
            this.sqlLKJB.Size = new System.Drawing.Size(122, 21);
            this.sqlLKJB.TabIndex = 2;
            // 
            // sqlName
            // 
            this.sqlName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlName.Location = new System.Drawing.Point(123, 46);
            this.sqlName.Multiline = true;
            this.sqlName.Name = "sqlName";
            this.sqlName.Size = new System.Drawing.Size(122, 21);
            this.sqlName.TabIndex = 2;
            // 
            // btnSql
            // 
            this.btnSql.BackColor = System.Drawing.Color.Transparent;
            this.btnSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSql.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSql.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSql.Location = new System.Drawing.Point(622, 44);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(122, 31);
            this.btnSql.TabIndex = 1;
            this.btnSql.Text = "查 询";
            this.toolTip1.SetToolTip(this.btnSql, "未填写筛选条件则为全部查询");
            this.btnSql.UseVisualStyleBackColor = false;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // sqlDataView
            // 
            this.sqlDataView.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.sqlDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sqlDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sqlDataView.Location = new System.Drawing.Point(0, 246);
            this.sqlDataView.Name = "sqlDataView";
            this.sqlDataView.RowTemplate.Height = 23;
            this.sqlDataView.Size = new System.Drawing.Size(807, 221);
            this.sqlDataView.TabIndex = 2;
            this.sqlDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sqlDataView_CellDoubleClick);
            this.sqlDataView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sqlDataView_CellMouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(622, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 31);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "取 消";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gridViewMenu
            // 
            this.gridViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSeeDetail,
            this.btnSeeSJ,
            this.btnQueryFJ,
            this.link1,
            this.changeObjInfo,
            this.delObj,
            this.link2,
            this.添加事件ToolStripMenuItem,
            this.添加附件ToolStripMenuItem,
            this.link3,
            this.DCOneRow,
            this.DCselected,
            this.DCInfo,
            this.DCJCRJBXX});
            this.gridViewMenu.Name = "gridViewMenu";
            this.gridViewMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.gridViewMenu.Size = new System.Drawing.Size(185, 334);
            // 
            // btnSeeDetail
            // 
            this.btnSeeDetail.Name = "btnSeeDetail";
            this.btnSeeDetail.Size = new System.Drawing.Size(184, 22);
            this.btnSeeDetail.Text = "查看详细信息";
            this.btnSeeDetail.Click += new System.EventHandler(this.btnSeeDetail_Click);
            // 
            // btnSeeSJ
            // 
            this.btnSeeSJ.Name = "btnSeeSJ";
            this.btnSeeSJ.Size = new System.Drawing.Size(184, 22);
            this.btnSeeSJ.Text = "查看事件";
            this.btnSeeSJ.Click += new System.EventHandler(this.btnSeeSJ_Click);
            // 
            // btnQueryFJ
            // 
            this.btnQueryFJ.Name = "btnQueryFJ";
            this.btnQueryFJ.Size = new System.Drawing.Size(184, 22);
            this.btnQueryFJ.Text = "查看附件";
            this.btnQueryFJ.Click += new System.EventHandler(this.btnQueryFJ_Click);
            // 
            // link1
            // 
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(184, 22);
            this.link1.Text = "————————";
            // 
            // changeObjInfo
            // 
            this.changeObjInfo.Name = "changeObjInfo";
            this.changeObjInfo.Size = new System.Drawing.Size(184, 22);
            this.changeObjInfo.Text = "修改该对象信息";
            this.changeObjInfo.Click += new System.EventHandler(this.changeObjInfo_Click);
            // 
            // delObj
            // 
            this.delObj.Name = "delObj";
            this.delObj.Size = new System.Drawing.Size(184, 22);
            this.delObj.Text = "删除该对象";
            this.delObj.Click += new System.EventHandler(this.delObj_Click);
            // 
            // link2
            // 
            this.link2.Name = "link2";
            this.link2.Size = new System.Drawing.Size(184, 22);
            this.link2.Text = "————————";
            // 
            // 添加事件ToolStripMenuItem
            // 
            this.添加事件ToolStripMenuItem.Name = "添加事件ToolStripMenuItem";
            this.添加事件ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.添加事件ToolStripMenuItem.Text = "添加事件";
            this.添加事件ToolStripMenuItem.Click += new System.EventHandler(this.添加事件ToolStripMenuItem_Click);
            // 
            // 添加附件ToolStripMenuItem
            // 
            this.添加附件ToolStripMenuItem.Name = "添加附件ToolStripMenuItem";
            this.添加附件ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.添加附件ToolStripMenuItem.Text = "添加附件";
            this.添加附件ToolStripMenuItem.Click += new System.EventHandler(this.添加附件ToolStripMenuItem_Click);
            // 
            // link3
            // 
            this.link3.Name = "link3";
            this.link3.Size = new System.Drawing.Size(184, 22);
            this.link3.Text = "————————";
            // 
            // DCOneRow
            // 
            this.DCOneRow.Name = "DCOneRow";
            this.DCOneRow.Size = new System.Drawing.Size(184, 22);
            this.DCOneRow.Text = "导出选中行的信息";
            this.DCOneRow.Click += new System.EventHandler(this.DCOneRow_Click);
            // 
            // DCselected
            // 
            this.DCselected.Name = "DCselected";
            this.DCselected.Size = new System.Drawing.Size(184, 22);
            this.DCselected.Text = "导出选中人的信息";
            this.DCselected.Click += new System.EventHandler(this.DCselected_Click);
            // 
            // DCInfo
            // 
            this.DCInfo.Name = "DCInfo";
            this.DCInfo.Size = new System.Drawing.Size(184, 22);
            this.DCInfo.Text = "导出该对象信息";
            this.DCInfo.Visible = false;
            this.DCInfo.Click += new System.EventHandler(this.DCInfo_Click);
            // 
            // DCJCRJBXX
            // 
            this.DCJCRJBXX.Name = "DCJCRJBXX";
            this.DCJCRJBXX.Size = new System.Drawing.Size(184, 22);
            this.DCJCRJBXX.Text = "导出该对象基本信息";
            this.DCJCRJBXX.Visible = false;
            this.DCJCRJBXX.Click += new System.EventHandler(this.DCJCRJBXX_Click);
            // 
            // SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(807, 467);
            this.Controls.Add(this.sqlDataView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.sqlConditon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SqlForm";
            this.Text = "查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SqlForm_FormClosing);
            this.Load += new System.EventHandler(this.SqlForm_Load);
            this.sqlConditon.ResumeLayout(false);
            this.sqlConditon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataView)).EndInit();
            this.gridViewMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sqlConditon;
        private System.Windows.Forms.TextBox sqlName;
        private System.Windows.Forms.TextBox sqlLKDW;
        private System.Windows.Forms.TextBox sqlSFZ;
        private System.Windows.Forms.TextBox sqlJG;
        private System.Windows.Forms.TextBox sqlLKJB;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.DataGridView sqlDataView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip gridViewMenu;
        private System.Windows.Forms.ToolStripMenuItem btnSeeDetail;
        private System.Windows.Forms.ToolStripMenuItem btnSeeSJ;
        private System.Windows.Forms.ToolStripMenuItem changeObjInfo;
        private System.Windows.Forms.ToolStripMenuItem delObj;
        private System.Windows.Forms.ToolStripMenuItem 添加事件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加附件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQueryFJ;
        private System.Windows.Forms.ToolStripMenuItem link1;
        private System.Windows.Forms.ToolStripMenuItem link2;
        private System.Windows.Forms.ToolStripMenuItem link3;
        private System.Windows.Forms.ToolStripMenuItem DCJCRJBXX;
        private System.Windows.Forms.ToolStripMenuItem DCInfo;
        private System.Windows.Forms.ToolStripMenuItem DCselected;
        private System.Windows.Forms.ToolStripMenuItem DCOneRow;
    }
}