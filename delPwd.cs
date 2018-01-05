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
    public partial class delPwd : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public delPwd()
        {
            InitializeComponent();
        }
        #region 字段
        //存储密码的字段
        public string surePWD
        { set; get; }
        //存储调用该窗体的用户的用户名
        public  string YHM
        { get; set; }
        //存储调用该窗体的用户的权限
        public string LIMIT
        { set; get; }
        //确认权限正确返回的标志,返回1
        public string rightYH
        { set; get; }
        #endregion

        private void btnSure_Click(object sender, EventArgs e)
        {
           surePWD =getPWD.Text.Trim();
            YHM = Login.LogYHM;
            LIMIT = Login.limit;
            string sql = "select pwd from DLXX where yhm='" + YHM + "'";
            string re=sqlMethod(sql, 1);
            if (LIMIT == "2")
            {
                MessageBox.Show("对不起，您没有权限", "提示");               
                getPWD.Clear();
                getPWD.Focus();
                this.Close();
            }
            else if (re != surePWD)
            {
                MessageBox.Show("对不起，密码错误", "提示");
                getPWD.Clear();
                getPWD.Focus();
            }
            else
            {
                rightYH = "1";
                this.Close();
            }
        }

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
                if (judge == 0)
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(comm);
                    DataSet ds = new DataSet();

                    int result = da.Fill(ds, "dt");
                    if (result != 0)
                    {
                        //sqlDataView.DataSource = ds.Tables["dt"];
                        return result.ToString();
                    }
                    else
                        return "-1";
                }
                else if (judge == 1)
                {
                    object result = comm.ExecuteScalar();
                    if (result == null)
                        return "-1";
                    else
                        return result.ToString();
                }
                else
                {
                    int result = comm.ExecuteNonQuery();
                    if (result > 0)
                        return result.ToString();
                    else
                        return "-1";

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
