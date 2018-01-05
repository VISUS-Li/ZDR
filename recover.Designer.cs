namespace ZDRJC2
{
    partial class recover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recover));
            this.recoverAdm = new System.Windows.Forms.RadioButton();
            this.recoverJCR = new System.Windows.Forms.RadioButton();
            this.recoverSJ = new System.Windows.Forms.RadioButton();
            this.sqlGJC = new System.Windows.Forms.TextBox();
            this.btnSql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // recoverAdm
            // 
            this.recoverAdm.AutoSize = true;
            this.recoverAdm.BackColor = System.Drawing.Color.Transparent;
            this.recoverAdm.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recoverAdm.Location = new System.Drawing.Point(41, 42);
            this.recoverAdm.Name = "recoverAdm";
            this.recoverAdm.Size = new System.Drawing.Size(123, 25);
            this.recoverAdm.TabIndex = 0;
            this.recoverAdm.TabStop = true;
            this.recoverAdm.Text = "恢复管理员";
            this.toolTip1.SetToolTip(this.recoverAdm, "恢复已删除的修改权限和查看权限的管理员，只有最高权限的用户能操作");
            this.recoverAdm.UseVisualStyleBackColor = false;
            // 
            // recoverJCR
            // 
            this.recoverJCR.AutoSize = true;
            this.recoverJCR.BackColor = System.Drawing.Color.Transparent;
            this.recoverJCR.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recoverJCR.Location = new System.Drawing.Point(194, 42);
            this.recoverJCR.Name = "recoverJCR";
            this.recoverJCR.Size = new System.Drawing.Size(123, 25);
            this.recoverJCR.TabIndex = 0;
            this.recoverJCR.TabStop = true;
            this.recoverJCR.Text = "恢复监测人";
            this.toolTip1.SetToolTip(this.recoverJCR, "恢复已经删除的监测人信息");
            this.recoverJCR.UseVisualStyleBackColor = false;
            // 
            // recoverSJ
            // 
            this.recoverSJ.AutoSize = true;
            this.recoverSJ.BackColor = System.Drawing.Color.Transparent;
            this.recoverSJ.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recoverSJ.Location = new System.Drawing.Point(363, 42);
            this.recoverSJ.Name = "recoverSJ";
            this.recoverSJ.Size = new System.Drawing.Size(104, 25);
            this.recoverSJ.TabIndex = 0;
            this.recoverSJ.TabStop = true;
            this.recoverSJ.Text = "恢复事件";
            this.toolTip1.SetToolTip(this.recoverSJ, "恢复已经删除的监测人事件信息");
            this.recoverSJ.UseVisualStyleBackColor = false;
            // 
            // sqlGJC
            // 
            this.sqlGJC.Location = new System.Drawing.Point(110, 92);
            this.sqlGJC.Multiline = true;
            this.sqlGJC.Name = "sqlGJC";
            this.sqlGJC.Size = new System.Drawing.Size(312, 28);
            this.sqlGJC.TabIndex = 1;
            this.toolTip1.SetToolTip(this.sqlGJC, "查询需要恢复的对象的关键词");
            // 
            // btnSql
            // 
            this.btnSql.BackColor = System.Drawing.Color.Transparent;
            this.btnSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSql.Location = new System.Drawing.Point(451, 88);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(75, 33);
            this.btnSql.TabIndex = 2;
            this.btnSql.Text = "查询";
            this.toolTip1.SetToolTip(this.btnSql, "若关键词无信息，查询所有可恢复对象");
            this.btnSql.UseVisualStyleBackColor = false;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "关键词";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(572, 176);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnRecover
            // 
            this.btnRecover.BackColor = System.Drawing.Color.Transparent;
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecover.Location = new System.Drawing.Point(32, 139);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(75, 33);
            this.btnRecover.TabIndex = 2;
            this.btnRecover.Text = "恢复";
            this.toolTip1.SetToolTip(this.btnRecover, "恢复所选中的对象");
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(451, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // recover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(572, 354);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.sqlGJC);
            this.Controls.Add(this.recoverSJ);
            this.Controls.Add(this.recoverJCR);
            this.Controls.Add(this.recoverAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "recover";
            this.Text = "恢复";
            this.Load += new System.EventHandler(this.recover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton recoverAdm;
        private System.Windows.Forms.RadioButton recoverJCR;
        private System.Windows.Forms.RadioButton recoverSJ;
        private System.Windows.Forms.TextBox sqlGJC;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}