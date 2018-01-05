using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDRJC2
{
    public partial class SqlFJ : Form
    {
        public SqlFJ()
        {
            InitializeComponent();
        }

        #region 字段
        public string initName
        { set; get; }
        public string initSFZ
        { set; get; }
        #endregion
        //点击查看文档
        private void btnSqlWD_Click(object sender, EventArgs e)
        {
            SqlWD SW = new SqlWD();
            SW.getName = initName;
            SW.getSFZ = initSFZ;
            SW.FJflag = "文档";
            //getName.Text = initName;
            //getSFZ.Text = initSFZ;
            SW.ShowDialog();

        }

        private void SqlFJ_Load(object sender, EventArgs e)
        {
            getName.Text = initName;
            getSFZ.Text = initSFZ;
        }
        //查看图片文件
        private void btnSqlZP_Click(object sender, EventArgs e)
        {
            SqlWD SW = new SqlWD();
            SW.getName = initName;
            SW.getSFZ = initSFZ;
            SW.FJflag = "照片";       
            SW.ShowDialog();
        }
        //查看视频文件
        private void btnSqlSP_Click(object sender, EventArgs e)
        {
            SqlWD SW = new SqlWD();
            SW.getName = initName;
            SW.getSFZ = initSFZ;
            SW.FJflag = "视频";
            SW.ShowDialog();
        }
        //查看音频文件
        private void btnSqlYY_Click(object sender, EventArgs e)
        {
            SqlWD SW = new SqlWD();
            SW.getName = initName;
            SW.getSFZ = initSFZ;
            SW.FJflag = "音频";
            SW.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
