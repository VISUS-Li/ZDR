namespace ZDRJC2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sqlPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSql = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn制作人 = new System.Windows.Forms.Button();
            this.btnExiAdm = new System.Windows.Forms.Button();
            this.btnDeAdm = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnAddJCR = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sqlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // sqlPanel
            // 
            this.sqlPanel.BackColor = System.Drawing.Color.Transparent;
            this.sqlPanel.Controls.Add(this.label2);
            this.sqlPanel.Controls.Add(this.btnSql);
            this.sqlPanel.Controls.Add(this.btnExit);
            this.sqlPanel.Location = new System.Drawing.Point(52, 36);
            this.sqlPanel.Name = "sqlPanel";
            this.sqlPanel.Size = new System.Drawing.Size(843, 323);
            this.sqlPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("隶书", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(261, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 64);
            this.label2.TabIndex = 2;
            this.label2.Text = "查询系统";
            // 
            // btnSql
            // 
            this.btnSql.BackColor = System.Drawing.Color.Transparent;
            this.btnSql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSql.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSql.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSql.Location = new System.Drawing.Point(35, 218);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(181, 64);
            this.btnSql.TabIndex = 1;
            this.btnSql.Text = "查询";
            this.toolTip1.SetToolTip(this.btnSql, "打开查询界面");
            this.btnSql.UseVisualStyleBackColor = false;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(627, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 64);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出";
            this.toolTip1.SetToolTip(this.btnExit, "退出程序");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn制作人);
            this.panel1.Controls.Add(this.btnExiAdm);
            this.panel1.Controls.Add(this.btnDeAdm);
            this.panel1.Controls.Add(this.btnRegist);
            this.panel1.Controls.Add(this.btnRecover);
            this.panel1.Controls.Add(this.btnAddJCR);
            this.panel1.Location = new System.Drawing.Point(-7, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 84);
            this.panel1.TabIndex = 3;
            // 
            // btn制作人
            // 
            this.btn制作人.BackColor = System.Drawing.Color.Transparent;
            this.btn制作人.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn制作人.Location = new System.Drawing.Point(934, 56);
            this.btn制作人.Name = "btn制作人";
            this.btn制作人.Size = new System.Drawing.Size(11, 17);
            this.btn制作人.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn制作人, "查看制作人");
            this.btn制作人.UseVisualStyleBackColor = false;
            this.btn制作人.Click += new System.EventHandler(this.btn制作人_Click);
            // 
            // btnExiAdm
            // 
            this.btnExiAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExiAdm.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExiAdm.Location = new System.Drawing.Point(778, 10);
            this.btnExiAdm.Name = "btnExiAdm";
            this.btnExiAdm.Size = new System.Drawing.Size(100, 63);
            this.btnExiAdm.TabIndex = 3;
            this.btnExiAdm.Text = "注销";
            this.toolTip1.SetToolTip(this.btnExiAdm, "注销当前登录");
            this.btnExiAdm.UseVisualStyleBackColor = true;
            this.btnExiAdm.Click += new System.EventHandler(this.btnExiAdm_Click);
            // 
            // btnDeAdm
            // 
            this.btnDeAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeAdm.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeAdm.Location = new System.Drawing.Point(244, 10);
            this.btnDeAdm.Name = "btnDeAdm";
            this.btnDeAdm.Size = new System.Drawing.Size(100, 63);
            this.btnDeAdm.TabIndex = 3;
            this.btnDeAdm.Text = "删除登录账号";
            this.btnDeAdm.UseVisualStyleBackColor = true;
            this.btnDeAdm.Click += new System.EventHandler(this.btnDeAdm_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegist.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegist.Location = new System.Drawing.Point(598, 10);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(100, 63);
            this.btnRegist.TabIndex = 3;
            this.btnRegist.Text = "注册";
            this.toolTip1.SetToolTip(this.btnRegist, "添加登录者");
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecover.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecover.Location = new System.Drawing.Point(416, 10);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(100, 63);
            this.btnRecover.TabIndex = 3;
            this.btnRecover.Text = "恢复";
            this.toolTip1.SetToolTip(this.btnRecover, "删除已有监测人信息");
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnAddJCR
            // 
            this.btnAddJCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJCR.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddJCR.Location = new System.Drawing.Point(58, 10);
            this.btnAddJCR.Name = "btnAddJCR";
            this.btnAddJCR.Size = new System.Drawing.Size(100, 63);
            this.btnAddJCR.TabIndex = 3;
            this.btnAddJCR.Text = "添加监测人";
            this.toolTip1.SetToolTip(this.btnAddJCR, "添加检测人信息");
            this.btnAddJCR.UseVisualStyleBackColor = true;
            this.btnAddJCR.Click += new System.EventHandler(this.btnAddJCR_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(943, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sqlPanel);
            this.Font = new System.Drawing.Font("隶书", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "主操作界面                                                                            " +
    "                                                                                " +
    "版本：16_11_11_1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sqlPanel.ResumeLayout(false);
            this.sqlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel sqlPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExiAdm;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnAddJCR;
        private System.Windows.Forms.Button btnDeAdm;
        private System.Windows.Forms.Button btn制作人;
    }
}