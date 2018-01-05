using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ZDRJC2
{
    public partial class addSJForm : Form
    {
        public addSJForm()
        {
            InitializeComponent();
        }

        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        #region 字段
        //姓名
        public string getJCRname
        { set; get; }
        //身份证
        public string getJCRsfz
        { set; get; }
        //时间
        public string getSJtime
        { set; get; }
        //地点
        public string getSJdd
        { set; get; }
        //参与人物
        public string getSJcyrw
        { set; get; }
        //  关键词
        public string getSJgjc
        { set; get; }
        //级别
        public string getSJjb
        { set; get; }
        //事件详述
        public string getSJxs
        { set; get; }
        //标识，为1表示事件窗口已经存储相应的信息
        public int flag
        { set; get; }
        #endregion

        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <param name="judge">0代表将查询结果集存入dataset中，显示到datagirdview中，1代表返回查询的结果,2代表返回记录条数</param>
        /// <returns>返回0代表查询失败，其余数字代表查询到的记录条数，其余字符串为查询到的具体记录</returns>
        public string sqlMethod(string sql, int judge)
        {

            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                OleDbCommand comm = new OleDbCommand(sql, conn);
                conn.Open();
                //if (judge == 0)
                //{
                //    OleDbDataAdapter da = new OleDbDataAdapter(comm);
                //    DataSet ds = new DataSet();

                //    int result = da.Fill(ds, "dt");
                //    if (result != 0)
                //    {
                //        sqlDataView.DataSource = ds.Tables["dt"];
                //        return result.ToString();
                //    }
                //    else
                //        return "0";
                //}
                if (judge == 1)
                {
                    object result = comm.ExecuteScalar();
                    if (result == null)
                        return "0";
                    else
                        return result.ToString();
                }
                else
                {
                    int result = comm.ExecuteNonQuery();
                    if (result > 0)
                        return result.ToString();
                    else
                        return "0";
                }
            }

        }
        //加载窗体
        private void addSJForm_Load(object sender, EventArgs e)
        {
            //string sql = "select JCRname from JCRJBXX where JCRsfz='"+SqlForm.SFZid+"'";
            //string reName= sqlMethod(sql, 1);
            getName.Text = newJCR.addingName;
            getSFZ.Text = newJCR.addingSFZ;
        }
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 不能为空

            if (SJtime.Text.Trim() == "")
                MessageBox.Show("请输入时间", "提示");
            else if (SJdd.Text.Trim() == "")
                MessageBox.Show("请输入地点", "提示");
            else if (SJcyrw.Text.Trim() == "")
                MessageBox.Show("请输入参与人物", "提示");
            else if (SJjb.Text.Trim() == "")
                MessageBox.Show("请输入级别", "提示");
            else if (SJxs.Text.Trim() == "")
                MessageBox.Show("请输入事件详述", "提示");

            #endregion
            else
            {
                getJCRname = getName.Text.Trim();
                getJCRsfz = getSFZ.Text.Trim();
                getSJtime = SJtime.Text.Trim();
                getSJdd = SJdd.Text.Trim();
                getSJcyrw = SJcyrw.Text.Trim();
                getSJgjc = SJgjc.Text.Trim();
                getSJjb = SJjb.Text.Trim();
                getSJxs = SJxs.Text.Trim();
                flag = 1;
                this.Hide();
            }
        }
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (SJtime.Text.Trim() != "" || SJdd.Text.Trim() != "" || SJcyrw.Text.Trim() != "" || SJgjc.Text.Trim() != "" || SJjb.Text.Trim() != "" || SJxs.Text.Trim() != "")
            {
                DialogResult dr = MessageBox.Show("有未保存的信息，确定退出？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                    this.Close();
                else
                {
                    
                }
                
            }
            else
            this.Close();
        }

        private void addSJForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SJtime.Text.Trim() != "" || SJdd.Text.Trim() != "" || SJcyrw.Text.Trim() != "" || SJgjc.Text.Trim() != "" || SJjb.Text.Trim() != "" || SJxs.Text.Trim() != "")
            {
                DialogResult dr = MessageBox.Show("有未保存的信息，确定退出？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                    this.Close();
                else
                {
                    e.Cancel = true;
                }

            }
            else
                this.Close();
        }
    }
}
