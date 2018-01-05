namespace ZDRJC2
{
    partial class SqlWD
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
            this.dataGridWD = new System.Windows.Forms.DataGridView();
            this.btnSrue = new System.Windows.Forms.Button();
            this.WDrightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenThisFJ = new System.Windows.Forms.ToolStripMenuItem();
            this.DCThisFJ = new System.Windows.Forms.ToolStripMenuItem();
            this.DelThisFJ = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWD)).BeginInit();
            this.WDrightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridWD
            // 
            this.dataGridWD.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridWD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridWD.Location = new System.Drawing.Point(0, 0);
            this.dataGridWD.Name = "dataGridWD";
            this.dataGridWD.RowTemplate.Height = 23;
            this.dataGridWD.Size = new System.Drawing.Size(441, 261);
            this.dataGridWD.TabIndex = 5;
            this.dataGridWD.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridWD_CellMouseDown);
            this.dataGridWD.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridWD_MouseDoubleClick);
            // 
            // btnSrue
            // 
            this.btnSrue.BackColor = System.Drawing.Color.Transparent;
            this.btnSrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrue.Location = new System.Drawing.Point(171, 282);
            this.btnSrue.Name = "btnSrue";
            this.btnSrue.Size = new System.Drawing.Size(75, 23);
            this.btnSrue.TabIndex = 6;
            this.btnSrue.Text = "确定";
            this.btnSrue.UseVisualStyleBackColor = false;
            this.btnSrue.Click += new System.EventHandler(this.btnSrue_Click);
            // 
            // WDrightMenu
            // 
            this.WDrightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenThisFJ,
            this.DCThisFJ,
            this.DelThisFJ});
            this.WDrightMenu.Name = "WDrightMenu";
            this.WDrightMenu.Size = new System.Drawing.Size(137, 70);
            // 
            // OpenThisFJ
            // 
            this.OpenThisFJ.Name = "OpenThisFJ";
            this.OpenThisFJ.Size = new System.Drawing.Size(136, 22);
            this.OpenThisFJ.Text = "打开该附件";
            this.OpenThisFJ.Click += new System.EventHandler(this.OpenThisFJ_Click);
            // 
            // DCThisFJ
            // 
            this.DCThisFJ.Name = "DCThisFJ";
            this.DCThisFJ.Size = new System.Drawing.Size(136, 22);
            this.DCThisFJ.Text = "导出该附件";
            this.DCThisFJ.Click += new System.EventHandler(this.DCThisFJ_Click);
            // 
            // DelThisFJ
            // 
            this.DelThisFJ.Name = "DelThisFJ";
            this.DelThisFJ.Size = new System.Drawing.Size(136, 22);
            this.DelThisFJ.Text = "删除该附件";
            this.DelThisFJ.Click += new System.EventHandler(this.DelThisFJ_Click);
            // 
            // SqlWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(441, 317);
            this.ControlBox = false;
            this.Controls.Add(this.btnSrue);
            this.Controls.Add(this.dataGridWD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SqlWD";
            this.Text = "查看文件";
            this.Load += new System.EventHandler(this.SqlWD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWD)).EndInit();
            this.WDrightMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridWD;
        private System.Windows.Forms.Button btnSrue;
        private System.Windows.Forms.ContextMenuStrip WDrightMenu;
        private System.Windows.Forms.ToolStripMenuItem DCThisFJ;
        private System.Windows.Forms.ToolStripMenuItem DelThisFJ;
        private System.Windows.Forms.ToolStripMenuItem OpenThisFJ;
    }
}