namespace ZDRJC2
{
    partial class SqlFJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlFJ));
            this.label1 = new System.Windows.Forms.Label();
            this.getName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getSFZ = new System.Windows.Forms.TextBox();
            this.btnSqlWD = new System.Windows.Forms.Button();
            this.btnSqlZP = new System.Windows.Forms.Button();
            this.btnSqlSP = new System.Windows.Forms.Button();
            this.btnSqlYY = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // getName
            // 
            this.getName.Location = new System.Drawing.Point(127, 35);
            this.getName.Name = "getName";
            this.getName.ReadOnly = true;
            this.getName.Size = new System.Drawing.Size(178, 21);
            this.getName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getName, "要查询附件的对象名");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "身份证号";
            // 
            // getSFZ
            // 
            this.getSFZ.Location = new System.Drawing.Point(127, 69);
            this.getSFZ.Name = "getSFZ";
            this.getSFZ.ReadOnly = true;
            this.getSFZ.Size = new System.Drawing.Size(178, 21);
            this.getSFZ.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getSFZ, "要查询附件的对象身份证号");
            // 
            // btnSqlWD
            // 
            this.btnSqlWD.BackColor = System.Drawing.Color.Transparent;
            this.btnSqlWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlWD.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSqlWD.Location = new System.Drawing.Point(57, 133);
            this.btnSqlWD.Name = "btnSqlWD";
            this.btnSqlWD.Size = new System.Drawing.Size(242, 47);
            this.btnSqlWD.TabIndex = 2;
            this.btnSqlWD.Text = "查看文档文件";
            this.toolTip1.SetToolTip(this.btnSqlWD, "点击查看该对象包含的文档文件");
            this.btnSqlWD.UseVisualStyleBackColor = false;
            this.btnSqlWD.Click += new System.EventHandler(this.btnSqlWD_Click);
            // 
            // btnSqlZP
            // 
            this.btnSqlZP.BackColor = System.Drawing.Color.Transparent;
            this.btnSqlZP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlZP.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSqlZP.Location = new System.Drawing.Point(57, 201);
            this.btnSqlZP.Name = "btnSqlZP";
            this.btnSqlZP.Size = new System.Drawing.Size(242, 47);
            this.btnSqlZP.TabIndex = 2;
            this.btnSqlZP.Text = "查看图片文件";
            this.toolTip1.SetToolTip(this.btnSqlZP, "点击查看该对象所包含的图片文件");
            this.btnSqlZP.UseVisualStyleBackColor = false;
            this.btnSqlZP.Click += new System.EventHandler(this.btnSqlZP_Click);
            // 
            // btnSqlSP
            // 
            this.btnSqlSP.BackColor = System.Drawing.Color.Transparent;
            this.btnSqlSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlSP.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSqlSP.Location = new System.Drawing.Point(57, 271);
            this.btnSqlSP.Name = "btnSqlSP";
            this.btnSqlSP.Size = new System.Drawing.Size(242, 47);
            this.btnSqlSP.TabIndex = 2;
            this.btnSqlSP.Text = "查看视频文件";
            this.toolTip1.SetToolTip(this.btnSqlSP, "点击查看该对象所包含的视频文件");
            this.btnSqlSP.UseVisualStyleBackColor = false;
            this.btnSqlSP.Click += new System.EventHandler(this.btnSqlSP_Click);
            // 
            // btnSqlYY
            // 
            this.btnSqlYY.BackColor = System.Drawing.Color.Transparent;
            this.btnSqlYY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlYY.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSqlYY.Location = new System.Drawing.Point(57, 340);
            this.btnSqlYY.Name = "btnSqlYY";
            this.btnSqlYY.Size = new System.Drawing.Size(242, 47);
            this.btnSqlYY.TabIndex = 2;
            this.btnSqlYY.Text = "查看音频文件";
            this.toolTip1.SetToolTip(this.btnSqlYY, "点击查看该对象所包含的音频文件");
            this.btnSqlYY.UseVisualStyleBackColor = false;
            this.btnSqlYY.Click += new System.EventHandler(this.btnSqlYY_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(57, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(242, 47);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "退            出";
            this.toolTip1.SetToolTip(this.btnCancel, "退出附件查询");
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SqlFJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(349, 460);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSqlYY);
            this.Controls.Add(this.btnSqlSP);
            this.Controls.Add(this.btnSqlZP);
            this.Controls.Add(this.btnSqlWD);
            this.Controls.Add(this.getSFZ);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SqlFJ";
            this.Text = "查看附件";
            this.Load += new System.EventHandler(this.SqlFJ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getSFZ;
        private System.Windows.Forms.Button btnSqlWD;
        private System.Windows.Forms.Button btnSqlZP;
        private System.Windows.Forms.Button btnSqlSP;
        private System.Windows.Forms.Button btnSqlYY;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}