namespace ZDRJC2
{
    partial class Regist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regist));
            this.admname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admpwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readmpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnregsit = new System.Windows.Forms.Button();
            this.registLimit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admname
            // 
            this.admname.Location = new System.Drawing.Point(144, 163);
            this.admname.Name = "admname";
            this.admname.Size = new System.Drawing.Size(154, 21);
            this.admname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(57, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // admpwd
            // 
            this.admpwd.Location = new System.Drawing.Point(144, 212);
            this.admpwd.Name = "admpwd";
            this.admpwd.Size = new System.Drawing.Size(154, 21);
            this.admpwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(57, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // readmpwd
            // 
            this.readmpwd.Location = new System.Drawing.Point(144, 263);
            this.readmpwd.Name = "readmpwd";
            this.readmpwd.Size = new System.Drawing.Size(154, 21);
            this.readmpwd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(57, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认密码";
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Location = new System.Drawing.Point(257, 316);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(146, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "注册";
            // 
            // btnregsit
            // 
            this.btnregsit.BackColor = System.Drawing.Color.Transparent;
            this.btnregsit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregsit.Location = new System.Drawing.Point(35, 316);
            this.btnregsit.Name = "btnregsit";
            this.btnregsit.Size = new System.Drawing.Size(75, 23);
            this.btnregsit.TabIndex = 5;
            this.btnregsit.Text = "注册";
            this.btnregsit.UseVisualStyleBackColor = false;
            this.btnregsit.Click += new System.EventHandler(this.btnregsit_Click);
            // 
            // registLimit
            // 
            this.registLimit.FormattingEnabled = true;
            this.registLimit.Items.AddRange(new object[] {
            "修改",
            "查看"});
            this.registLimit.Location = new System.Drawing.Point(144, 113);
            this.registLimit.Name = "registLimit";
            this.registLimit.Size = new System.Drawing.Size(154, 20);
            this.registLimit.TabIndex = 1;
            this.registLimit.SelectedIndexChanged += new System.EventHandler(this.registLimit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(57, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "权限";
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(365, 362);
            this.Controls.Add(this.registLimit);
            this.Controls.Add(this.btnregsit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.readmpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.admpwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Regist";
            this.Text = "Regist";
            this.Load += new System.EventHandler(this.Regist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox admname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox readmpwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnregsit;
        private System.Windows.Forms.ComboBox registLimit;
        private System.Windows.Forms.Label label4;
    }
}