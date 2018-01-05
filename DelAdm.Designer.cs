namespace ZDRJC2
{
    partial class DelAdm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DAname = new System.Windows.Forms.TextBox();
            this.DApwd = new System.Windows.Forms.TextBox();
            this.btnDA = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文中宋", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "删除管理员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(46, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "待删除用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "待删除用户密码";
            // 
            // DAname
            // 
            this.DAname.Location = new System.Drawing.Point(206, 115);
            this.DAname.Name = "DAname";
            this.DAname.Size = new System.Drawing.Size(143, 21);
            this.DAname.TabIndex = 1;
            // 
            // DApwd
            // 
            this.DApwd.Location = new System.Drawing.Point(206, 174);
            this.DApwd.Name = "DApwd";
            this.DApwd.PasswordChar = '*';
            this.DApwd.Size = new System.Drawing.Size(143, 21);
            this.DApwd.TabIndex = 2;
            // 
            // btnDA
            // 
            this.btnDA.BackColor = System.Drawing.Color.Transparent;
            this.btnDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDA.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDA.Location = new System.Drawing.Point(50, 249);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(87, 40);
            this.btnDA.TabIndex = 3;
            this.btnDA.Text = "删除";
            this.btnDA.UseVisualStyleBackColor = false;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncancel.Location = new System.Drawing.Point(253, 249);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(87, 40);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // DelAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(393, 321);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.DApwd);
            this.Controls.Add(this.DAname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DelAdm";
            this.Text = "DelAdm";
            this.Load += new System.EventHandler(this.DelAdm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DAname;
        private System.Windows.Forms.TextBox DApwd;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btncancel;
    }
}