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
    public partial class Regist : Form
    {
        string  strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public Regist()
        {
            InitializeComponent();
        }
        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //存储权限
        public string saveLimit
        { set; get; }
        //存储权限选择项
        public string saveSelect
        { set; get; }

        //注册
        private void btnregsit_Click(object sender, EventArgs e)
        {
            if (admname == null)
                MessageBox.Show("请输入用户名", "提示");
            else if (admpwd == null)
                MessageBox.Show("请输入密码", "提示");
            else if (readmpwd == null)
                MessageBox.Show("请再次输入密码", "提示");
            else if (registLimit.SelectedIndex.ToString() == null)
                MessageBox.Show("请选择权限", "提示");
            else
            {
                #region 不要的，最初的代码
                //    using (OleDbConnection conn = new OleDbConnection(strcon))
                //    {
                //        string sql = "select yhm from DLXX where yhm='" + admname.Text.Trim() + "'";
                //        OleDbCommand comm = new OleDbCommand(sql, conn);

                //        try
                //        {
                //            conn.Open();
                //        }
                //        catch (Exception)
                //        {
                //            MessageBox.Show("连接数据库未成功，请重试", "警告");
                //        }
                //        object nameResult = comm.ExecuteScalar();
                //        //该用户没有注册
                //        if (nameResult == null)
                //        {
                //            string admNUMBER;//存储待注册用户的工号

                //            //如果没有注册该用户名，从adminNum表中拿到已录入的工作人员的工号
                //            string sqlAdnum = "select NUMBER from adminNum where yhm='" + admname.Text.Trim() + "'";
                //            try//查询NUMBER，若输入yhm不在表adminNum中转入catch
                //            {
                //                try//查询结果如果不存在，转入catch
                //                {
                //                    string textAdNum = comm.CommandText = sqlAdnum;
                //                    object AdnumRes = comm.ExecuteScalar();
                //                    admNUMBER = AdnumRes.ToString();


                //                    if (admname.Text.Trim() == "")
                //                    {
                //                        MessageBox.Show("请输入用户名", "提示");
                //                        admname.Focus();
                //                    }
                //                    else if (admpwd.Text.Trim() == "")
                //                    {
                //                        MessageBox.Show("请输入密码", "提示");
                //                        admpwd.Focus();
                //                    }
                //                    else if (readmpwd.Text.Trim() != admpwd.Text.Trim())
                //                    {
                //                        MessageBox.Show("前后输入的密码不一致,请重新输入", "提示");
                //                        readmpwd.Focus();
                //                    }
                //                    else if (readmpwd.Text.Trim() == "")
                //                    {
                //                        MessageBox.Show("请再次输入密码", "提示");
                //                        readmpwd.Focus();

                //                    }
                //                    //开始往DLXX表中录入信息
                //                    else
                //                    {
                //                        //将输入的工号与从adminNum表中拿到的NUMBER比较，相同则将所有信息写入数据库
                //                        if (admid.Text.Trim() == admNUMBER)
                //                        {
                //                            string inAdall = "insert into DLXX (yhm,pwd,id) values('" + admname.Text.Trim() + "','" + admpwd.Text.Trim() + "','" + admid.Text.Trim() + "')";
                //                            comm.CommandText = inAdall;
                //                            int inResult = comm.ExecuteNonQuery();

                //                            if (inResult.ToString() != "")
                //                            {
                //                                MessageBox.Show("注册成功", "提示");
                //                                this.Close();
                //                            }
                //                            else
                //                            {
                //                                MessageBox.Show("注册失败，请重试", "提示");
                //                                admname.Clear();
                //                                admpwd.Clear();
                //                                admid.Clear();
                //                                readmpwd.Clear();
                //                                admname.Focus();
                //                            }
                //                        }
                //                        else
                //                        {
                //                            MessageBox.Show("工号错误", "提示");
                //                            admid.Clear();
                //                            admid.Focus();
                //                        }
                //                    }
                //                }
                //                catch (Exception ex)
                //                {
                //                    string temple = ex.Message;
                //                    MessageBox.Show("工号不存在!\n" + temple);
                //                }

                //            }
                //            catch (Exception ex)
                //            {
                //                string temple = ex.Message;
                //                MessageBox.Show("工号不存在!\r\n" + temple);
                //            }


                //        }
                //        //该用户已注册
                //        else
                //        {
                //            MessageBox.Show("该用户已存在", "提示");
                //            admname.Clear();
                //            admpwd.Clear();
                //            readmpwd.Clear();
                //            admid.Clear();
                //        }
                //    }//using
                //}//else
                #endregion
                registMethod();

            }
        }

        //注册方法
        public void registMethod()
        {
            string sql = "select yhm from DLXX where yhm='" + admname.Text.Trim() + "'";
            string re=sqlMethod(sql, 1);
            sql = "select dellogo from DLXX where yhm='" + admname.Text.Trim() + "'";
            string res = sqlMethod(sql,1);
            //已经有这个对象
            if (re != "-1" || res == "0")
            {
                MessageBox.Show("已存在该对象，请勿重复注册", "提示");
                admpwd.Clear();
                readmpwd.Clear();
            }
            //不存在
            else
            {
                //密码不一致
                if (admpwd.Text.Trim() != readmpwd.Text.Trim())
                {
                    MessageBox.Show("两次输入密码不一致，请重新输入", "提示");
                    admpwd.Clear();
                    readmpwd.Clear();
                    admpwd.Focus();
                }
                //密码一致
                else
                {
                    sql = "insert into DLXX (yhm,pwd,limit,dellogo) values('" + admname.Text.Trim() + "','" + admpwd.Text.Trim() + "','" + saveLimit + "','0')";
                    string result=sqlMethod(sql, 2);
                    if (result == "-1")
                    {
                        sql = "delelte * from DLXX where yhm='" + admname.Text.Trim() + "'";
                        try { sqlMethod(sql, 1); }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("注册成功","提示");
                        admname.Clear();
                        admpwd.Clear();
                        readmpwd.Clear();
                        admname.Focus();
                    }
                }
            }
        }

        private void Regist_Load(object sender, EventArgs e)
        {
            admname.Focus();
        }




        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <param name="judge">0代表将查询结果集存入dataset中，显示到datagirdview中，1代表返回查询的结果,2代表返回记录条数</param>
        /// <returns>返回-1代表查询失败，其余数字代表查询到的记录条数，其余字符串为查询到的具体记录</returns>
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

        //选择改变
        private void registLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveSelect=registLimit.SelectedItem.ToString();
            if (saveSelect == "修改")
                saveLimit = "1";
            else if (saveSelect == "查看")
                saveLimit = "2";

        }
    }
}
