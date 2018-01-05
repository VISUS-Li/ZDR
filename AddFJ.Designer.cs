namespace ZDRJC2
{
    partial class AddFJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFJ));
            this.label1 = new System.Windows.Forms.Label();
            this.initalName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.initalSFZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getPaWD = new System.Windows.Forms.TextBox();
            this.btnBroWD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.getPaZP = new System.Windows.Forms.TextBox();
            this.btnBrowZP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.getPaSP = new System.Windows.Forms.TextBox();
            this.btnBroSP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.getPaYY = new System.Windows.Forms.TextBox();
            this.btnBroYY = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // initalName
            // 
            this.initalName.Location = new System.Drawing.Point(117, 70);
            this.initalName.Name = "initalName";
            this.initalName.ReadOnly = true;
            this.initalName.Size = new System.Drawing.Size(157, 21);
            this.initalName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.initalName, "添加附件的对象姓名名");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "身份证号";
            // 
            // initalSFZ
            // 
            this.initalSFZ.Location = new System.Drawing.Point(117, 122);
            this.initalSFZ.Name = "initalSFZ";
            this.initalSFZ.ReadOnly = true;
            this.initalSFZ.Size = new System.Drawing.Size(157, 21);
            this.initalSFZ.TabIndex = 1;
            this.toolTip1.SetToolTip(this.initalSFZ, "添加附件的对象身份证号");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(113, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "添加附件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "文档文件";
            // 
            // getPaWD
            // 
            this.getPaWD.Location = new System.Drawing.Point(117, 175);
            this.getPaWD.Name = "getPaWD";
            this.getPaWD.ReadOnly = true;
            this.getPaWD.Size = new System.Drawing.Size(157, 21);
            this.getPaWD.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getPaWD, "要上传文档的原始路径");
            // 
            // btnBroWD
            // 
            this.btnBroWD.BackColor = System.Drawing.Color.Transparent;
            this.btnBroWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBroWD.Location = new System.Drawing.Point(199, 202);
            this.btnBroWD.Name = "btnBroWD";
            this.btnBroWD.Size = new System.Drawing.Size(75, 23);
            this.btnBroWD.TabIndex = 2;
            this.btnBroWD.Text = "浏览";
            this.toolTip1.SetToolTip(this.btnBroWD, "选择要上传的文件");
            this.btnBroWD.UseVisualStyleBackColor = false;
            this.btnBroWD.Click += new System.EventHandler(this.btnBroWD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(24, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "照片文件";
            // 
            // getPaZP
            // 
            this.getPaZP.Location = new System.Drawing.Point(117, 239);
            this.getPaZP.Name = "getPaZP";
            this.getPaZP.ReadOnly = true;
            this.getPaZP.Size = new System.Drawing.Size(157, 21);
            this.getPaZP.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getPaZP, "要上传照片档的原始路径");
            // 
            // btnBrowZP
            // 
            this.btnBrowZP.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowZP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowZP.Location = new System.Drawing.Point(199, 266);
            this.btnBrowZP.Name = "btnBrowZP";
            this.btnBrowZP.Size = new System.Drawing.Size(75, 23);
            this.btnBrowZP.TabIndex = 2;
            this.btnBrowZP.Text = "浏览";
            this.toolTip1.SetToolTip(this.btnBrowZP, "选择要上传的文件");
            this.btnBrowZP.UseVisualStyleBackColor = false;
            this.btnBrowZP.Click += new System.EventHandler(this.btnBrowZP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(24, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "视频文件";
            // 
            // getPaSP
            // 
            this.getPaSP.Location = new System.Drawing.Point(117, 300);
            this.getPaSP.Name = "getPaSP";
            this.getPaSP.ReadOnly = true;
            this.getPaSP.Size = new System.Drawing.Size(157, 21);
            this.getPaSP.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getPaSP, "要上传视频的原始路径");
            // 
            // btnBroSP
            // 
            this.btnBroSP.BackColor = System.Drawing.Color.Transparent;
            this.btnBroSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBroSP.Location = new System.Drawing.Point(199, 327);
            this.btnBroSP.Name = "btnBroSP";
            this.btnBroSP.Size = new System.Drawing.Size(75, 23);
            this.btnBroSP.TabIndex = 2;
            this.btnBroSP.Text = "浏览";
            this.toolTip1.SetToolTip(this.btnBroSP, "选择要上传的文件");
            this.btnBroSP.UseVisualStyleBackColor = false;
            this.btnBroSP.Click += new System.EventHandler(this.btnBroSP_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(24, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "音乐文件";
            // 
            // getPaYY
            // 
            this.getPaYY.Location = new System.Drawing.Point(117, 366);
            this.getPaYY.Name = "getPaYY";
            this.getPaYY.ReadOnly = true;
            this.getPaYY.Size = new System.Drawing.Size(157, 21);
            this.getPaYY.TabIndex = 1;
            this.toolTip1.SetToolTip(this.getPaYY, "要上传音乐的原始路径");
            // 
            // btnBroYY
            // 
            this.btnBroYY.BackColor = System.Drawing.Color.Transparent;
            this.btnBroYY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBroYY.Location = new System.Drawing.Point(199, 393);
            this.btnBroYY.Name = "btnBroYY";
            this.btnBroYY.Size = new System.Drawing.Size(75, 23);
            this.btnBroYY.TabIndex = 2;
            this.btnBroYY.Text = "浏览";
            this.toolTip1.SetToolTip(this.btnBroYY, "选择要上传的文件");
            this.btnBroYY.UseVisualStyleBackColor = false;
            this.btnBroYY.Click += new System.EventHandler(this.btnBroYY_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(28, 443);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(199, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddFJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZDRJC2.Properties.Resources.main_new;
            this.ClientSize = new System.Drawing.Size(313, 484);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBroYY);
            this.Controls.Add(this.btnBroSP);
            this.Controls.Add(this.btnBrowZP);
            this.Controls.Add(this.btnBroWD);
            this.Controls.Add(this.getPaYY);
            this.Controls.Add(this.getPaSP);
            this.Controls.Add(this.getPaZP);
            this.Controls.Add(this.getPaWD);
            this.Controls.Add(this.initalSFZ);
            this.Controls.Add(this.initalName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddFJ";
            this.Text = "添加附件";
            this.Load += new System.EventHandler(this.AddFJ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initalName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initalSFZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox getPaWD;
        private System.Windows.Forms.Button btnBroWD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox getPaZP;
        private System.Windows.Forms.Button btnBrowZP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox getPaSP;
        private System.Windows.Forms.Button btnBroSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox getPaYY;
        private System.Windows.Forms.Button btnBroYY;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}