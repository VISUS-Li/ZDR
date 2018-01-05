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
    public partial class addSJ_Sql : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public addSJ_Sql()
        {
            InitializeComponent();
        }
        SqlForm SF = new SqlForm();
        //事件GUID
        public string guid_SJ
        { set; get; }
        //加载时显示的姓名
        public string showName
        { set; get; }
        //加载时显示的身份证
        public string showSFZ
        { set; get; }
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
                //判断JCRJBXX中是否有该人信息
                string sql = "select JCRsfz from JCRJBXX where JCRsfz='" + getSFZ.Text.Trim() + "'";
                string re=getInfo(sql);
                string existLog = "select JCRdellogo from JCRJBXX where JCRsfz='" + getSFZ.Text.Trim() + "'";
                string res = getInfo(existLog);
                if (re == "未找到"||res=="未找到"||res=="1")
                {
                    MessageBox.Show("请先添加该人的信息，\n再添加该人事件", "提示");
                    this.Close();
                }
                else
                {
                    addSJmethod();

                    SJtime.Clear();
                    SJdd.Clear();
                    SJcyrw.Clear();
                    SJgjc.Clear();
                    SJjb.Clear();
                    SJxs.Clear();
                    SJtime.Focus();
                }

            }
        }

        /// <summary>
        /// 添加事件，该对象曾无事件的，第一次添加，有的在原基础上添加
        /// </summary>
        /// <returns>添加成功返回true,否则返回false</returns>
        public bool addSJmethod()
        {

            guid_SJ = Guid.NewGuid().ToString();
            string sql = "";
            //查找数据库中是否有该身份证的人

            sql = "select JCRsfz from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
            //该对象无一件事件
            if (getInfo(sql) == "未找到")
            {
                //向事件数据库中添加该对象
                sql = "insert into JCRSJSL(JCRsfz,JCRname,SJRWdellogo) values('" + getSFZ.Text.Trim() + "','" + getName.Text.Trim() + "','0')";
                bool re = in_up_SQL(sql);
                #region 添加不成功,删除先前添加的信息
                //添加不成功,删除先前添加的信息
                if (re == false)
                {
                    sql = "delete from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
                    delXX(sql);
                    MessageBox.Show("添加失败","提示");
                    return false;
                }
                #endregion
                else
                {
                    //先向事件数量中添加初始化值：0
                    sql = "update  JCRSJSL set SJcount='0' where JCRsfz='" + getSFZ.Text.Trim() + "'";
                    bool res = in_up_SQL(sql);
                    #region 如果更新失败，删除添加的信息
                    //如果更新失败，删除添加的信息
                    if (res == false)
                    {
                        sql = "delete from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
                        delXX(sql);
                        MessageBox.Show("添加失败","提示");
                        return false;
                    }
                    #endregion
                    //数量更新成功，向JCRSJXX添加事件
                    else
                    {
                        string timeNow = DateTime.Now.ToString();
                        sql = "insert into JCRSJXX (SJguid,JCRname,JCRsfz,SJsj,SJdd,SJcyrw,SJgjc,SJjb,SJxs,SJdellogo,SJAddTime) values('" + guid_SJ +
                         "','" + getName.Text.Trim() + "','" + getSFZ.Text.Trim() + "','" + SJtime.Text.Trim() + "','" + SJdd.Text.Trim() + "','" + SJcyrw.Text.Trim() +
                         "','" + SJgjc.Text.Trim() + "','" + SJjb.Text.Trim() + "','" + SJxs.Text.Trim() + "','0','"+timeNow+"')";
                        bool resu = in_up_SQL(sql);
                        #region  添加事件失败，删除JCRSJSL和JCRSJXX两表该对象的信息
                        if (resu == false)
                        {
                            sql = "delete from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
                            delXX(sql);
                            sql = "delete from JCRSJXX where JCRsfz='" + getSFZ.Text.Trim() + "'";
                            delXX(sql);
                            MessageBox.Show("添加失败","提示");
                            return false;
                        }
                        #endregion
                        else
                        {
                            //获得现在的SJcount
                            sql = "select SJcount from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
                            string count=getInfo(sql);
                            int Count = Convert.ToInt32(count);
                            ++Count;
                            sql = "update JCRSJSL set SJcount='" + Count.ToString() + "'";
                            bool resul = in_up_SQL(sql);
                            #region 添加count时错误
                            if (resul == false)
                            {
                                sql = "delete from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
                                delXX(sql);
                                sql = "delete from JCRSJXX where JCRsfz='" + getSFZ.Text.Trim() + "'";
                                delXX(sql);
                                MessageBox.Show("添加失败","提示");
                                return false;
                            }
                            #endregion
                            else
                            {
                                MessageBox.Show("添加成功!","提示");
                                return true;
                            }
                        }
                    }
                }

            }
            //该对象已有事件
            else
            {
                //查找到该JCRSJSL中的姓名和身份证和count
                sql = "select JCRsfz from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
                string SLsfz=getInfo(sql);
                sql = "select JCRname from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
                string SLname = getInfo(sql);
                sql = "select SJcount from JCRSJSL where JCRsfz='" + getSFZ.Text.Trim() + "'";
                string SLcount = getSJcount(sql);
                guid_SJ = Guid.NewGuid().ToString();
                //添加时间
                string timeNow = DateTime.Now.ToString();
                //向JCRSJXX 添加信息
                sql = "insert into JCRSJXX (SJguid,JCRname,JCRsfz,SJsj,SJdd,SJcyrw,SJgjc,SJjb,SJxs,SJdellogo,SJAddTime) values('" + guid_SJ +
                         "','" + getName.Text.Trim() + "','" + getSFZ.Text.Trim() + "','" + SJtime.Text.Trim() + "','" + SJdd.Text.Trim() + "','" + SJcyrw.Text.Trim() +
                         "','" + SJgjc.Text.Trim() + "','" + SJjb.Text.Trim() + "','" + SJxs.Text.Trim() + "','0','"+timeNow+"')";
                bool resu = in_up_SQL(sql);
                #region  添加事件失败，删除JCRSJXX该对象的信息
                if (resu == false)
                {
                    sql = "delete from JCRSJXX where JCRsfz='" + getSFZ.Text.Trim() + "'";
                    delXX(sql);
                    MessageBox.Show("添加失败", "提示");
                    return false;
                }
                #endregion
                else
                {
                   
                    int Count = Convert.ToInt32(SLcount);
                    ++Count;
                    sql = "update JCRSJSL set SJcount='"+Count+"' where JCRsfz='"+getSFZ.Text.Trim()+"'";
                    bool resul = in_up_SQL(sql);
                    #region 添加count时错误,删除JCRSJXX信息
                    if (resul == false)
                    {
                        sql = "delete from JCRSJXX where JCRsfz='" + getSFZ.Text.Trim() + "'";
                        delXX(sql);
                        MessageBox.Show("添加失败","提示");
                        return false;
                    }
                    #endregion
                    else { MessageBox.Show("添加成功","提示"); return true; }
                }
            }
        
          
        }//adSJmethod
        /// <summary>
        /// 删除先前添加的信息，保证删除时不出错
        /// </summary>
        /// <param name="sql">sql字符串</param>
        public void delXX(string sql)
        {
            try
            { in_up_SQL(sql); }
            catch { }
        }
        
        /// <summary>
        /// 查询指定信息
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <returns>返回查找到的信息，若未找到返回“未找到”</returns>
        public string getInfo(string sql)

        {
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                OleDbCommand comm = new OleDbCommand(sql, conn);
                conn.Open();
                object result = comm.ExecuteScalar();
                //if (result == null || result.ToString() == "0")
                if (result == null)
                {
                    return "未找到";
                }
                else
                {
                    return result.ToString();
                }

            }
        }

        //查找事件count的函数
        public string getSJcount(string sql)

        {
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                OleDbCommand comm = new OleDbCommand(sql, conn);
                conn.Open();
                object result = comm.ExecuteScalar();
                if (result == null)
                {
                    return "未找到";
                }
                else
                {
                    return result.ToString();
                }

            }
        }
        /// <summary>
        /// 执行插入或更新语句
        /// </summary>
        /// <param name="sql">插入或更新字符串</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool in_up_SQL(string sql)
        {
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                OleDbCommand comm = new OleDbCommand(sql, conn);
                try
                {
                    conn.Open();
                }
                catch
                { return false; }
                try
                {
                    object result = comm.ExecuteNonQuery();
                    if (result != null)
                        return true;
                    else return false;
                }
                catch { return false; }
            }
        }
        //加载时
        private void addSJ_Sql_Load(object sender, EventArgs e)
        {
            //getName.Text = SF.GName;
            //getSFZ.Text = SqlForm.SFZid;
            getName.Text = showName;
            getSFZ.Text = showSFZ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (SJtime.Text.Trim() != "" || SJdd.Text.Trim() != "" || SJcyrw.Text.Trim() != "" || SJgjc.Text.Trim() != "" || SJjb.Text.Trim() != "" || SJxs.Text.Trim() != "")
            {
                DialogResult re = MessageBox.Show("信息未保存，确认退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                    this.Close();
                else
                { }
            }
            else
                this.Close();
        }
    }
}
