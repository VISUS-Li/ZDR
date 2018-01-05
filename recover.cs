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
    public partial class recover : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public recover()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //加载时
        private void recover_Load(object sender, EventArgs e)
        {
            recoverAdm.Checked = true;
        }

        //恢复的对象
        private string obj
        { set; get; }
        //恢复对象的表
        private string pla
        { set; get; }
        //index
        private string index
        { set; get; }
        //不同表中不同的权限
        private string dellogo
        { set; get; }

        //查询方法
        public void SQLMethod()
        {
            string sql = "";
            string logo = "";
            //恢复管理员
            if (recoverAdm.Checked == true)
            {
                if (sqlGJC.Text.Trim() == "")
                {
                    sql = "select yhm as 用户名,limit as 权限 from DLXX where dellogo='1'";
                    string sqlRe = sqlMethod(sql, 0);
                    if (sqlRe == "-1")
                    {
                        MessageBox.Show("无可恢复管理员", "提示");
                        return;
                    }
                    string selyhm = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    obj = "YHM";
                    pla = "DLXX";
                    index = selyhm;
                    dellogo = "dellogo";
                    return;
                }
                sql = "select yhm as 用户名 ,limit as 权限 from DLXX where yhm like '%" + sqlGJC.Text.Trim() + "%' and dellogo='1'";
                string sqlName = sqlMethod(sql, 0);
                if (sqlName == "-1")
                { MessageBox.Show("该关键词无法搜索到相应管理员，请调整关键词", "提示"); return; }
                else
                {
                    string selyhm = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    obj = "YHM";
                    pla = "DLXX";
                    index = selyhm;
                    dellogo = "dellogo";

                }
            }
            //恢复监测人
            else if (recoverJCR.Checked == true)
            {
                if (sqlGJC.Text.Trim() == "")
                {
                    sql = "select JCRname as 姓名,JCRsfz as 身份证,JCRsex as 性别,JCRJG as 籍贯,JCRlkdw as 列控单位,JCRlkjb as 列控级别,JCRAddTime as 添加时间 from JCRJBXX where  JCRdellogo = '1'";
                    string sqlRe = sqlMethod(sql, 0);
                    if (sqlRe == "-1")
                    {
                        MessageBox.Show("无可恢复监测人", "提示");
                        return;
                    }
                    string sfz = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    obj = "JCRsfz";
                    pla = "JCRJBXX";
                    index = sfz;
                    dellogo = "JCRdellogo";
                    return;
                }
                sql = "select JCRname as 姓名,JCRsfz as 身份证,JCRsex as 性别,JCRJG as 籍贯,JCRlkdw as 列控单位,JCRlkjb as 列控级别,JCRAddTime as 添加时间 from JCRJBXX where JCRname like '%"+sqlGJC.Text+"%' and JCRdellogo = '1'";
                string sqlName = sqlMethod(sql, 0);
                if (sqlName == "-1")
                {
                    MessageBox.Show("该关键词无法搜索到相应的监测人，关键词指监测人姓名关键字", "提示");
                    return;
                }
                else
                {
                    string sfz = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    obj = "JCRsfz";
                    pla = "JCRJBXX";
                    index = sfz;
                    dellogo = "JCRdellogo";
                }
            }
            //恢复事件
            else if (recoverSJ.Checked == true)
            {
                if (sqlGJC.Text.Trim() == "")
                {
                    sql =" select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJxs as 事件详细信息,SJguid as 事件编号 ,SJAddTime as 添加时间 from JCRSJXX where 1 = 1 and SJdellogo = '1' ";
                    string sqlRe = sqlMethod(sql, 0);
                    if (sqlRe == "-1")
                    {
                        MessageBox.Show("无可恢复事件", "提示");
                        return;
                    }
                    string sfz = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    obj = "JCRsfz";
                    pla = "JCRJBXX";
                    index = sfz;
                    dellogo = "SJdellogo";
                    return;
                }
                sql = " select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJxs as 事件详细信息, SJguid as 事件编号 ,SJAddTime as 添加时间 from JCRSJXX where  SJdellogo = '1' and (JCRname like '%" + sqlGJC.Text.Trim()+"%' or "
                    +" JCRsfz like '%"+sqlGJC.Text+"%' or SJsj like '%"+sqlGJC.Text+"%' or SJdd like '%"+sqlGJC.Text+"%' or SJcyrw like '%"+sqlGJC.Text+"%' or SJgjc like '%"+sqlGJC.Text+"%' or SJxs like '%"+sqlGJC.Text+"%' )";

                string sqlName = sqlMethod(sql, 0);
                if (sqlName == "-1")
                {
                    MessageBox.Show("该关键词无法搜索到相应的事件", "提示");
                    return;
                }
                else
                {
                    string sfz = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    obj = "JCRsfz";
                    pla = "JCRJBXX";
                    index = sfz;
                    dellogo = "SJdellogo";
                }
            }
        }
        //查询
        private void btnSql_Click(object sender, EventArgs e)
        {
                
                SQLMethod();

        }

        //恢复方法
        public void recoverMehtod(string obj,string pla,string index,string dellogo)
        {
                string sql = "";
                if (dataGridView1.CurrentCell == null)
                    MessageBox.Show("请选择要恢复的对象", "提示");
                else
                {
                //string index = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                sql = "update "+pla+" set "+dellogo+"='0' where "+obj+"='" + index + "'";
                string re= sqlMethod(sql, 2);
                if (re != "-1")
                {
                    MessageBox.Show("恢复成功！", "提示");
                    sqlGJC.Clear();
                    sqlGJC.Focus();
                    if (recoverAdm.Checked == true)
                    {
                        sql = "select yhm as 用户名,limit as 权限 from DLXX where dellogo='1'";
                        sqlMethod(sql, 0);
                        return;
                    }
                    if (recoverJCR.Checked == true)
                    {
                        sql = " select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJxs as 事件详细信息,SJguid as 事件编号 ,SJAddTime as 添加时间 from JCRSJXX where 1 = 1 and SJdellogo = '1' ";
                        string sqlRe = sqlMethod(sql, 0);
                        return;
                    }
                    if (recoverSJ.Checked == true)
                    {
                        sql = " select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJxs as 事件详细信息, SJguid as 事件编号 ,SJAddTime as 添加时间 from JCRSJXX where  SJdellogo = '1' and (JCRname like '%" + sqlGJC.Text.Trim() + "%' or "
                    + " JCRsfz like '%" + sqlGJC.Text + "%' or SJsj like '%" + sqlGJC.Text + "%' or SJdd like '%" + sqlGJC.Text + "%' or SJcyrw like '%" + sqlGJC.Text + "%' or SJgjc like '%" + sqlGJC.Text + "%' or SJxs like '%" + sqlGJC.Text + "%' )";
                        sqlMethod(sql, 0);
                        return;
                    }
                                     
                }
                else
                {
                    MessageBox.Show("恢复失败", "提示");
                    sqlGJC.Clear();
                    sqlGJC.Focus();
                }
                }
            
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
                if (judge == 0)
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(comm);
                    DataSet ds = new DataSet();

                    int result = da.Fill(ds, "dt");
                    if (result != 0)
                    {
                        dataGridView1.DataSource = ds.Tables["dt"];
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
        //恢复按钮
        private void btnRecover_Click(object sender, EventArgs e)
        {
            recoverMehtod(obj,pla,index,dellogo);
        }
    }
}
