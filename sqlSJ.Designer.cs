namespace ZDRJC2
{
    partial class sqlSJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sqlSJ));
            this.label1 = new System.Windows.Forms.Label();
            this.getName = new System.Windows.Forms.TextBox();
            this.getSFZ = new System.Windows.Forms.TextBox();
            this.alreadySql = new System.Windows.Forms.RadioButton();
            this.sqlConditon = new System.Windows.Forms.RadioButton();
            this.sqlSelGroup = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlCongroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getDD = new System.Windows.Forms.TextBox();
            this.getGJC = new System.Windows.Forms.TextBox();
            this.getJB = new System.Windows.Forms.TextBox();
            this.getCYRW = new System.Windows.Forms.TextBox();
            this.getTime = new System.Windows.Forms.TextBox();
            this.btnSql = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlSJMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delSJ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDCSJ_one = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDCSJ_Selected = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlSelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sqlCongroup.SuspendLayout();
            this.sqlSJMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("隶书", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(301, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "事件查询";
            // 
            // getName
            // 
            this.getName.Location = new System.Drawing.Point(105, 75);
            this.getName.Multiline = true;
            this.getName.Name = "getName";
            this.getName.ReadOnly = true;
            this.getName.Size = new System.Drawing.Size(125, 21);
            this.getName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.getName, "发生事件的对象名");
            // 
            // getSFZ
            // 
            this.getSFZ.Location = new System.Drawing.Point(105, 112);
            this.getSFZ.Multiline = true;
            this.getSFZ.Name = "getSFZ";
            this.getSFZ.ReadOnly = true;
            this.getSFZ.Size = new System.Drawing.Size(125, 21);
            this.getSFZ.TabIndex = 2;
            this.toolTip1.SetToolTip(this.getSFZ, "发生事件对象身份证号");
            // 
            // alreadySql
            // 
            this.alreadySql.AutoSize = true;
            this.alreadySql.BackColor = System.Drawing.Color.Transparent;
            this.alreadySql.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alreadySql.Location = new System.Drawing.Point(91, 20);
            this.alreadySql.Name = "alreadySql";
            this.alreadySql.Size = new System.Drawing.Size(122, 20);
            this.alreadySql.TabIndex = 3;
            this.alreadySql.TabStop = true;
            this.alreadySql.Text = "已有对象查询";
            this.toolTip1.SetToolTip(this.alreadySql, "默认查看加载时的对象的事件");
            this.alreadySql.UseVisualStyleBackColor = false;
            this.alreadySql.CheckedChanged += new System.EventHandler(this.alreadySql_CheckedChanged);
            // 
            // sqlConditon
            // 
            this.sqlConditon.AutoSize = true;
            this.sqlConditon.BackColor = System.Drawing.Color.Transparent;
            this.sqlConditon.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlConditon.Location = new System.Drawing.Point(329, 20);
            this.sqlConditon.Name = "sqlConditon";
            this.sqlConditon.Size = new System.Drawing.Size(90, 20);
            this.sqlConditon.TabIndex = 3;
            this.sqlConditon.TabStop = true;
            this.sqlConditon.Text = "条件查询";
            this.toolTip1.SetToolTip(this.sqlConditon, "按需要查询事件");
            this.sqlConditon.UseVisualStyleBackColor = false;
            this.sqlConditon.CheckedChanged += new System.EventHandler(this.sqlConditon_CheckedChanged);
            // 
            // sqlSelGroup
            // 
            this.sqlSelGroup.BackColor = System.Drawing.Color.Transparent;
            this.sqlSelGroup.Controls.Add(this.alreadySql);
            this.sqlSelGroup.Controls.Add(this.sqlConditon);
            this.sqlSelGroup.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlSelGroup.Location = new System.Drawing.Point(276, 75);
            this.sqlSelGroup.Name = "sqlSelGroup";
            this.sqlSelGroup.Size = new System.Drawing.Size(468, 58);
            this.sqlSelGroup.TabIndex = 4;
            this.sqlSelGroup.TabStop = false;
            this.sqlSelGroup.Text = "查询方式";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(801, 249);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // sqlCongroup
            // 
            this.sqlCongroup.BackColor = System.Drawing.Color.Transparent;
            this.sqlCongroup.Controls.Add(this.label8);
            this.sqlCongroup.Controls.Add(this.label7);
            this.sqlCongroup.Controls.Add(this.label6);
            this.sqlCongroup.Controls.Add(this.label5);
            this.sqlCongroup.Controls.Add(this.label4);
            this.sqlCongroup.Controls.Add(this.getDD);
            this.sqlCongroup.Controls.Add(this.getGJC);
            this.sqlCongroup.Controls.Add(this.getJB);
            this.sqlCongroup.Controls.Add(this.getCYRW);
            this.sqlCongroup.Controls.Add(this.getTime);
            this.sqlCongroup.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlCongroup.Location = new System.Drawing.Point(30, 156);
            this.sqlCongroup.Name = "sqlCongroup";
            this.sqlCongroup.Size = new System.Drawing.Size(759, 135);
            this.sqlCongroup.TabIndex = 6;
            this.sqlCongroup.TabStop = false;
            this.sqlCongroup.Text = "查询条件";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(541, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "级别判定";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(256, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "关键词";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(256, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "参与人物";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "发生地点";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "发生时间\r\n\r\n";
            // 
            // getDD
            // 
            this.getDD.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getDD.Location = new System.Drawing.Point(125, 73);
            this.getDD.Multiline = true;
            this.getDD.Name = "getDD";
            this.getDD.Size = new System.Drawing.Size(99, 21);
            this.getDD.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getDD, "事件发生的地点");
            // 
            // getGJC
            // 
            this.getGJC.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getGJC.Location = new System.Drawing.Point(356, 72);
            this.getGJC.Multiline = true;
            this.getGJC.Name = "getGJC";
            this.getGJC.Size = new System.Drawing.Size(99, 21);
            this.getGJC.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getGJC, "描述该事件的关键词");
            // 
            // getJB
            // 
            this.getJB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getJB.Location = new System.Drawing.Point(634, 28);
            this.getJB.Multiline = true;
            this.getJB.Name = "getJB";
            this.getJB.Size = new System.Drawing.Size(99, 21);
            this.getJB.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getJB, "对事件的级别判定");
            // 
            // getCYRW
            // 
            this.getCYRW.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getCYRW.Location = new System.Drawing.Point(356, 28);
            this.getCYRW.Multiline = true;
            this.getCYRW.Name = "getCYRW";
            this.getCYRW.Size = new System.Drawing.Size(99, 21);
            this.getCYRW.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getCYRW, "事件发生时参与的人物");
            // 
            // getTime
            // 
            this.getTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getTime.Location = new System.Drawing.Point(125, 28);
            this.getTime.Multiline = true;
            this.getTime.Name = "getTime";
            this.getTime.Size = new System.Drawing.Size(99, 21);
            this.getTime.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getTime, "事件发生的时间");
            // 
            // btnSql
            // 
            this.btnSql.BackColor = System.Drawing.Color.Transparent;
            this.btnSql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSql.Location = new System.Drawing.Point(58, 297);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(84, 40);
            this.btnSql.TabIndex = 7;
            this.btnSql.Text = "查询";
            this.toolTip1.SetToolTip(this.btnSql, "未填信息则查询所有事件");
            this.btnSql.UseVisualStyleBackColor = false;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(660, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "退出";
            this.toolTip1.SetToolTip(this.btnCancel, "取消事件查询");
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(37, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "身份证\r\n";
            // 
            // sqlSJMenu
            // 
            this.sqlSJMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delSJ});
            this.sqlSJMenu.Name = "sqlSJMenu";
            this.sqlSJMenu.Size = new System.Drawing.Size(125, 26);
            // 
            // delSJ
            // 
            this.delSJ.Name = "delSJ";
            this.delSJ.Size = new System.Drawing.Size(124, 22);
            this.delSJ.Text = "删除事件";
            this.delSJ.Click += new System.EventHandler(this.delSJ_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDCSJ_one,
            this.btnDCSJ_Selected});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            // 
            // btnDCSJ_one
            // 
            this.btnDCSJ_one.Name = "btnDCSJ_one";
            this.btnDCSJ_one.Size = new System.Drawing.Size(172, 22);
            this.btnDCSJ_one.Text = "导出该事件";
            this.btnDCSJ_one.Click += new System.EventHandler(this.btnDCSJ_one_Click);
            // 
            // btnDCSJ_Selected
            // 
            this.btnDCSJ_Selected.Name = "btnDCSJ_Selected";
            this.btnDCSJ_Selected.Size = new System.Drawing.Size(172, 22);
            this.btnDCSJ_Selected.Text = "导出选中所有事件";
            this.btnDCSJ_Selected.Click += new System.EventHandler(this.btnDCSJ_Selected_Click);
            // 
            // sqlSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(801, 604);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.sqlCongroup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sqlSelGroup);
            this.Controls.Add(this.getSFZ);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sqlSJ";
            this.Text = "查询事件";
            this.Load += new System.EventHandler(this.sqlSJ_Load);
            this.sqlSelGroup.ResumeLayout(false);
            this.sqlSelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sqlCongroup.ResumeLayout(false);
            this.sqlCongroup.PerformLayout();
            this.sqlSJMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getName;
        private System.Windows.Forms.TextBox getSFZ;
        private System.Windows.Forms.RadioButton alreadySql;
        private System.Windows.Forms.RadioButton sqlConditon;
        private System.Windows.Forms.GroupBox sqlSelGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox sqlCongroup;
        private System.Windows.Forms.TextBox getDD;
        private System.Windows.Forms.TextBox getGJC;
        private System.Windows.Forms.TextBox getJB;
        private System.Windows.Forms.TextBox getCYRW;
        private System.Windows.Forms.TextBox getTime;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip sqlSJMenu;
        private System.Windows.Forms.ToolStripMenuItem delSJ;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDCSJ_one;
        private System.Windows.Forms.ToolStripMenuItem btnDCSJ_Selected;
    }
}