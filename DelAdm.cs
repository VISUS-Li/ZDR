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
    public partial class DelAdm : Form
    {

        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public DelAdm()
        {
            InitializeComponent();
        }
        //删除按钮
        private void btnDA_Click(object sender, EventArgs e)
        {
            //如果是管理员，不允许删除

            if (DAname.Text.Trim() == "")
            {
                MessageBox.Show("请输入待删除用户名", "提示");
                DAname.Focus();
            }
            else if (DApwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入待删除用户密码", "提示");
                DApwd.Focus();
            }
            //else if (DAid.Text.Trim() == "")
            //{
            //    MessageBox.Show("请输入待删除用户工号", "提示");
            //    DAid.Focus();
            //}
            else
            {
                string ISadm = "select limit from DLXX where yhm='" + DAname.Text.Trim() + "'";
                string rree = sqlMethod(ISadm, 1);
                if (rree == "0")
                { MessageBox.Show("不能删除管理员"); }
                else
                {
                    string sql = "select yhm from DLXX where yhm='" + DAname.Text.Trim() + "'";
                string re = sqlMethod(sql, 1);
                sql = "select dellogo from DLXX where yhm='" + DAname.Text.Trim() + "'";
                string logo0 = sqlMethod(sql, 1);
                //不存在待删除用户或该用户已被删除
                if (re == "-1" || logo0 == "-1" || logo0 == "1")
                {
                    MessageBox.Show("不存在该删除用户");
                    DApwd.Clear();

                }

                else
                {
                    //获得密码
                    sql = "select pwd from DLXX where yhm='" + DAname.Text.Trim() + "'";
                    string res = sqlMethod(sql, 1);

                    if (res == "-1")
                        MessageBox.Show("密码错误");
                    else
                    {
                        #region 密码正确，删除
                        if (res == DApwd.Text.Trim())
                        {
                            DialogResult DR = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            //确认删除
                            if (DR == DialogResult.Yes)
                            {
                                sql = "update DLXX set dellogo='1' where yhm='" + DAname.Text.Trim() + "'";
                                string resu = sqlMethod(sql, 2);
                                if (resu != "-1")
                                {
                                    MessageBox.Show("删除成功", "提示");
                                    DAname.Clear();
                                    DApwd.Clear();
                                    DAname.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("删除失败", "提示");
                                    DApwd.Focus(); ;
                                    DApwd.Clear();
                                }

                            }

                            else
                            {
                                DApwd.Clear();
                                DApwd.Focus();
                            }
                        }
                        #endregion
                        #region 密码错误
                        else
                        {
                            MessageBox.Show("密码错误", "提示");
                            DApwd.Clear();
                            DApwd.Focus();
                        }
                        #endregion
                    }
                }
                #region 最开始的代码

                //using (OleDbConnection conn = new OleDbConnection(strcon))
                //{
                //    //查询是否存在待删除用户
                //    //string sqlADexist = "select yhm from DLXX where yhm='" + DAname.Text.Trim() + "'";
                //    //OleDbCommand comm = new OleDbCommand(sqlADexist, conn);
                //    //try
                //    //{
                //    //    conn.Open();
                //    //}
                //    //catch (Exception ex)
                //    //{
                //    //    string temp = ex.Message;
                //    //    MessageBox.Show(temp);
                //    //}
                //    //输入的字符串不在数据库表中，转入catch
                //    try
                //    {

                //        object existResult = comm.ExecuteScalar();
                //        //如果不存在待删除用户
                //        if (existResult.ToString() == "")
                //        {
                //            MessageBox.Show("不存在该用户", "警告");
                //            DAname.Focus();
                //        }
                //        //如果存在
                //        else
                //        {
                //            //拿到DLXX中的ID号
                //            string sqlID = "select id from DLXX where yhm='"+DAname.Text.Trim()+"'";
                //            comm.CommandText = sqlID;
                //            object idReuslt=comm.ExecuteScalar();
                //            string sqlPwd = "select pwd from DLXX where yhm='" + DAname.Text.Trim() + "'";
                //            comm.CommandText = sqlPwd;
                //            object pwdResult = comm.ExecuteScalar();
                //            if (DApwd.Text.Trim() != pwdResult.ToString())
                //            {
                //                MessageBox.Show("密码错误", "提示");
                //                DApwd.Focus();
                //            }
                //            else if (DAid.Text.Trim() != idReuslt.ToString())
                //            {
                //                MessageBox.Show("工号错误", "提示");
                //                DAid.Focus();
                //            }
                //            //开始删除
                //            else
                //            {
                //                string DA = "delete from DLXX where yhm='"+DAname.Text.Trim()+"'";
                //                comm.CommandText = DA;
                //                int delResult=comm.ExecuteNonQuery();
                //                try
                //                {
                //                    if (delResult == 1)
                //                    {
                //                        MessageBox.Show("删除成功");
                //                        DAname.Clear();
                //                        DApwd.Clear();
                //                        DAid.Clear();
                //                        DAname.Focus();
                //                    }
                //                }
                //                catch (Exception ex)
                //                {
                //                    string temp = ex.Message;
                //                    MessageBox.Show("删除失败!"+temp);
                //                    DAname.Clear();
                //                    DApwd.Clear();
                //                    DAid.Clear();
                //                    DAname.Focus();
                //                }

                //            }

                //        }


                //    }//try
                //    catch(Exception ex)
                //    {
                //        string temp = ex.Message;
                //        MessageBox.Show(temp);
                //    }//catch
                //    }//using
                #endregion
            }
            }//else

        }//brnDA_Click
        //取消按钮
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //加载窗体
        private void DelAdm_Load(object sender, EventArgs e)
        {
            DAname.Focus();
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
    }
}
