namespace ZDRJC2
{
    partial class addSJForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getSFZ = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SJtime = new System.Windows.Forms.TextBox();
            this.SJdd = new System.Windows.Forms.TextBox();
            this.SJcyrw = new System.Windows.Forms.TextBox();
            this.SJgjc = new System.Windows.Forms.TextBox();
            this.SJjb = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SJxs = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(330, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加事件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(63, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // getName
            // 
            this.getName.BackColor = System.Drawing.SystemColors.Window;
            this.getName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getName.Location = new System.Drawing.Point(151, 89);
            this.getName.Multiline = true;
            this.getName.Name = "getName";
            this.getName.ReadOnly = true;
            this.getName.Size = new System.Drawing.Size(132, 21);
            this.getName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.getName, "事件对象，不可修改");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(43, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "身份证";
            // 
            // getSFZ
            // 
            this.getSFZ.BackColor = System.Drawing.SystemColors.Window;
            this.getSFZ.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getSFZ.Location = new System.Drawing.Point(151, 136);
            this.getSFZ.Multiline = true;
            this.getSFZ.Name = "getSFZ";
            this.getSFZ.ReadOnly = true;
            this.getSFZ.Size = new System.Drawing.Size(132, 21);
            this.getSFZ.TabIndex = 0;
            this.toolTip1.SetToolTip(this.getSFZ, "对象身份证，不可修改");
            // 
            // SJtime
            // 
            this.SJtime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJtime.Location = new System.Drawing.Point(151, 185);
            this.SJtime.Multiline = true;
            this.SJtime.Name = "SJtime";
            this.SJtime.Size = new System.Drawing.Size(132, 21);
            this.SJtime.TabIndex = 1;
            this.toolTip1.SetToolTip(this.SJtime, "事件发生的时间,未知可不用填");
            // 
            // SJdd
            // 
            this.SJdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJdd.Location = new System.Drawing.Point(151, 229);
            this.SJdd.Multiline = true;
            this.SJdd.Name = "SJdd";
            this.SJdd.Size = new System.Drawing.Size(132, 21);
            this.SJdd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.SJdd, "事件发生的地点，未知课不用填");
            // 
            // SJcyrw
            // 
            this.SJcyrw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJcyrw.Location = new System.Drawing.Point(151, 268);
            this.SJcyrw.Multiline = true;
            this.SJcyrw.Name = "SJcyrw";
            this.SJcyrw.Size = new System.Drawing.Size(132, 21);
            this.SJcyrw.TabIndex = 3;
            this.toolTip1.SetToolTip(this.SJcyrw, "事件参与的人物，没有可不用填");
            // 
            // SJgjc
            // 
            this.SJgjc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJgjc.Location = new System.Drawing.Point(151, 312);
            this.SJgjc.Multiline = true;
            this.SJgjc.Name = "SJgjc";
            this.SJgjc.Size = new System.Drawing.Size(132, 21);
            this.SJgjc.TabIndex = 4;
            this.toolTip1.SetToolTip(this.SJgjc, "可概括事件整个过程的关键词，用于后续搜索，必填");
            // 
            // SJjb
            // 
            this.SJjb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJjb.Location = new System.Drawing.Point(151, 355);
            this.SJjb.Multiline = true;
            this.SJjb.Name = "SJjb";
            this.SJjb.Size = new System.Drawing.Size(132, 21);
            this.SJjb.TabIndex = 45;
            this.toolTip1.SetToolTip(this.SJjb, "事件严重性级别");
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(203, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "确定";
            this.toolTip1.SetToolTip(this.btnSave, "暂时存储，只有在点击添加监测人界的保存按钮时才能保存");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(63, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(63, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "地点";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(23, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "参与人物";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(43, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "关键词";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(374, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "事件详述";
            // 
            // SJxs
            // 
            this.SJxs.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SJxs.Location = new System.Drawing.Point(469, 93);
            this.SJxs.Multiline = true;
            this.SJxs.Name = "SJxs";
            this.SJxs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SJxs.Size = new System.Drawing.Size(330, 283);
            this.SJxs.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(563, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(63, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "级别";
            // 
            // addSJForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 461);
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
            this.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "addSJForm";
            this.Text = "addSJForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addSJForm_FormClosing);
            this.Load += new System.EventHandler(this.addSJForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox getName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox getSFZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SJtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SJdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SJcyrw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SJgjc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SJxs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SJjb;
    }
}