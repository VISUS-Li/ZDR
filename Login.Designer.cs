namespace ZDRJC2
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.upwd = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regist = new System.Windows.Forms.Button();
            this.logIdenty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.verificationPic = new System.Windows.Forms.PictureBox();
            this.verfication = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.verificationPic)).BeginInit();
            this.SuspendLayout();
            // 
            // upwd
            // 
            this.upwd.Location = new System.Drawing.Point(162, 237);
            this.upwd.Name = "upwd";
            this.upwd.PasswordChar = '*';
            this.upwd.Size = new System.Drawing.Size(172, 21);
            this.upwd.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Location = new System.Drawing.Point(67, 385);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(96, 44);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(979, 484);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(70, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(96, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "密码";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(162, 188);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(172, 21);
            this.uname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(80, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户名";
            // 
            // regist
            // 
            this.regist.BackColor = System.Drawing.Color.Transparent;
            this.regist.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.regist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regist.Location = new System.Drawing.Point(229, 385);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(96, 44);
            this.regist.TabIndex = 6;
            this.regist.Text = "退出";
            this.regist.UseVisualStyleBackColor = false;
            this.regist.Click += new System.EventHandler(this.button1_Click);
            // 
            // logIdenty
            // 
            this.logIdenty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logIdenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logIdenty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logIdenty.FormattingEnabled = true;
            this.logIdenty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logIdenty.Items.AddRange(new object[] {
            "root",
            "管理员",
            "用户"});
            this.logIdenty.Location = new System.Drawing.Point(162, 140);
            this.logIdenty.Name = "logIdenty";
            this.logIdenty.Size = new System.Drawing.Size(172, 20);
            this.logIdenty.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(64, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "身份选择";
            // 
            // verificationPic
            // 
            this.verificationPic.Location = new System.Drawing.Point(16, 278);
            this.verificationPic.Name = "verificationPic";
            this.verificationPic.Size = new System.Drawing.Size(124, 42);
            this.verificationPic.TabIndex = 12;
            this.verificationPic.TabStop = false;
            this.verificationPic.Click += new System.EventHandler(this.verificationPic_Click);
            // 
            // verfication
            // 
            this.verfication.Location = new System.Drawing.Point(162, 299);
            this.verfication.Name = "verfication";
            this.verfication.Size = new System.Drawing.Size(172, 21);
            this.verfication.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("新宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(150, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "登录";
            // 
            // Login
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.test2;
            this.CancelButton = this.regist;
            this.ClientSize = new System.Drawing.Size(404, 459);
            this.Controls.Add(this.verificationPic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logIdenty);
            this.Controls.Add(this.regist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.verfication);
            this.Controls.Add(this.upwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "登录到查询系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Login_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.verificationPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox upwd;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox logIdenty;
        private System.Windows.Forms.PictureBox verificationPic;
        private System.Windows.Forms.TextBox verfication;
        private System.Windows.Forms.Label label3;
    }
}

