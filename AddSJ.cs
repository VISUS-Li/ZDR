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
    public partial class AddSJ : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public AddSJ()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (adsjtime.Text.Trim() == "")
            {
                adsjtime.Text = "无";
            }
            else if (adsjpla.Text.Trim() == "")
                adsjpla.Text = "无";
            else if (adsjperson.Text.Trim() == "")
                adsjperson.Text = "无";
           
            if (adjcrname.Text.Trim() == "")
            {
                MessageBox.Show("请输入监测人姓名", "提示");
                adjcrname.Focus();
            }
            else if (adsjkeyword.Text.Trim() == "")
            {
                MessageBox.Show("请输入关键字", "提示");
                adsjkeyword.Focus();
            }
            else if (adsjdescribe.Text.Trim() == "")
            {
                MessageBox.Show("请输入事件描述", "提示");
                adsjdescribe.Focus();
            }
            else if (adsjlevel.SelectedIndex < 0)
            {
                MessageBox.Show("请选择事件等级", "提示");
            }
            else
            {
                using (OleDbConnection conn = new OleDbConnection(strcon))
                {
                    string sql = "select JCRname from JCRJBXX where JCRname='" + adjcrname.Text.Trim() + "'";
                    OleDbCommand comm = new OleDbCommand(sql, conn);
                    try
                    {
                        conn.Open();
                    }
                    catch { }
                    int result = comm.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("输入的姓名不存在,无法添加事件", "提示");

                    }
                    else
                    {
                        string inName = "insert into JCRSJ (JCRname) values('"+adjcrname.Text.Trim()+"')";
                        comm.CommandText = inName;
                        int inNameRe = comm.ExecuteNonQuery();
                        if (inNameRe != 0)
                        {
                            //录入事件字符串
                            string adStr = "时间:" + adsjtime.Text.Trim() + ",\t地点：" + adsjpla.Text.Trim()
                                + ",\t涉及人物:" + adsjperson.Text.Trim() + ",\t事件关键字:" + adsjkeyword.Text.Trim()
                                + ",\t事件描述:" + adsjdescribe.Text.Trim() + ",\t事件等级:" + adsjlevel.Text.Trim();
                            for (int i = 1; i <= 20; i++)
                            {
                                //如果能添加
                                if (isExData("SJ"+i, adjcrname.Text.Trim()) == false)
                                {
                                    comm.CommandText = adStr;
                                    int inResult = comm.ExecuteNonQuery();
                                    if (inResult != 0)
                                    {
                                        MessageBox.Show("添加成功", "提示");
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("添加失败", "提示");
                                        break;
                                    }
                                }
                                //如果不能添加
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }//using
            }//else
        }//btn
        /// <summary>
        /// 判断JCRSJ表中哪些列有数据
        /// </summary>
        /// <param name="column">列的编号</param>
        /// <param name="jcrName">查询的JCRname</param>
        /// <returns>若存在，返回true，表示不能在此列中添加，若不存在，返回false</returns>
        public bool isExData(string column,string jcrName)
        {
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                string sql = "select  "+column+" from JCRSJ where JCRname='"+jcrName+"'";
                conn.Open();
                OleDbCommand comm = new OleDbCommand(sql,conn);
                object result = comm.ExecuteScalar();
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
