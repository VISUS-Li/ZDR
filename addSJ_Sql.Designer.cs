namespace ZDRJC2
{
    partial class addSJ_Sql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSJ_Sql));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SJxs = new System.Windows.Forms.TextBox();
            this.SJjb = new System.Windows.Forms.TextBox();
            this.SJgjc = new System.Windows.Forms.TextBox();
            this.SJcyrw = new System.Windows.Forms.TextBox();
            this.SJdd = new System.Windows.Forms.TextBox();
            this.SJtime = new System.Windows.Forms.TextBox();
            this.getSFZ = new System.Windows.Forms.TextBox();
            this.getName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(550, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 34);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(190, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 34);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "确定";
            this.toolTip1.SetToolTip(this.btnSave, "添加该事件");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SJxs
            // 
            this.SJxs.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJxs.Location = new System.Drawing.Point(456, 77);
            this.SJxs.Multiline = true;
            this.SJxs.Name = "SJxs";
            this.SJxs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SJxs.Size = new System.Drawing.Size(330, 283);
            this.SJxs.TabIndex = 62;
            this.toolTip1.SetToolTip(this.SJxs, "事件发生的详细情况");
            // 
            // SJjb
            // 
            this.SJjb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJjb.Location = new System.Drawing.Point(138, 339);
            this.SJjb.Multiline = true;
            this.SJjb.Name = "SJjb";
            this.SJjb.Size = new System.Drawing.Size(132, 21);
            this.SJjb.TabIndex = 61;
            this.toolTip1.SetToolTip(this.SJjb, "事件严重性级别");
            // 
            // SJgjc
            // 
            this.SJgjc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJgjc.Location = new System.Drawing.Point(138, 296);
            this.SJgjc.Multiline = true;
            this.SJgjc.Name = "SJgjc";
            this.SJgjc.Size = new System.Drawing.Size(132, 21);
            this.SJgjc.TabIndex = 60;
            this.toolTip1.SetToolTip(this.SJgjc, "可概括事件整个过程的关键词，用于后续搜索，必填");
            // 
            // SJcyrw
            // 
            this.SJcyrw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJcyrw.Location = new System.Drawing.Point(138, 252);
            this.SJcyrw.Multiline = true;
            this.SJcyrw.Name = "SJcyrw";
            this.SJcyrw.Size = new System.Drawing.Size(132, 21);
            this.SJcyrw.TabIndex = 59;
            this.toolTip1.SetToolTip(this.SJcyrw, "事件参与的人物，没有可不用填");
            // 
            // SJdd
            // 
            this.SJdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJdd.Location = new System.Drawing.Point(138, 213);
            this.SJdd.Multiline = true;
            this.SJdd.Name = "SJdd";
            this.SJdd.Size = new System.Drawing.Size(132, 21);
            this.SJdd.TabIndex = 58;
            this.toolTip1.SetToolTip(this.SJdd, "事件发生的地点，未知课不用填");
            // 
            // SJtime
            // 
            this.SJtime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJtime.Location = new System.Drawing.Point(138, 169);
            this.SJtime.Multiline = true;
            this.SJtime.Name = "SJtime";
            this.SJtime.Size = new System.Drawing.Size(132, 21);
            this.SJtime.TabIndex = 57;
            this.toolTip1.SetToolTip(this.SJtime, "事件发生的时间,未知可不用填");
            // 
            // getSFZ
            // 
            this.getSFZ.BackColor = System.Drawing.SystemColors.Window;
            this.getSFZ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getSFZ.Location = new System.Drawing.Point(138, 120);
            this.getSFZ.Multiline = true;
            this.getSFZ.Name = "getSFZ";
            this.getSFZ.ReadOnly = true;
            this.getSFZ.Size = new System.Drawing.Size(132, 21);
            this.getSFZ.TabIndex = 56;
            this.toolTip1.SetToolTip(this.getSFZ, "对象身份证，不可修改");
            // 
            // getName
            // 
            this.getName.BackColor = System.Drawing.SystemColors.Window;
            this.getName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getName.Location = new System.Drawing.Point(138, 73);
            this.getName.Multiline = true;
            this.getName.Name = "getName";
            this.getName.ReadOnly = true;
            this.getName.Size = new System.Drawing.Size(132, 21);
            this.getName.TabIndex = 46;
            this.toolTip1.SetToolTip(this.getName, "事件对象，不可修改");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(361, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "事件详述";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(50, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 53;
            this.label9.Text = "级别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(30, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "关键词";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(10, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "参与人物";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(50, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "地点";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(50, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "身份证";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(305, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "添加事件";
            // 
            // addSJ_Sql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(820, 449);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.SJxs);
            this.Controls.Add(this.SJjb);
            this.Controls.Add(this.SJgjc);
            this.Controls.Add(this.SJcyrw);
            this.Controls.Add(this.SJdd);
            this.Controls.Add(this.SJtime);
            this.Controls.Add(this.getSFZ);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addSJ_Sql";
            this.Text = "添加事件";
            this.Load += new System.EventHandler(this.addSJ_Sql_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox SJxs;
        private System.Windows.Forms.TextBox SJjb;
        private System.Windows.Forms.TextBox SJgjc;
        private System.Windows.Forms.TextBox SJcyrw;
        private System.Windows.Forms.TextBox SJdd;
        private System.Windows.Forms.TextBox SJtime;
        private System.Windows.Forms.TextBox getSFZ;
        private System.Windows.Forms.TextBox getName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}