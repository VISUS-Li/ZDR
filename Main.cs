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
    public partial class Main : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public Main()
        {
            InitializeComponent();
        }

        

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dRe= MessageBox.Show("确认退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dRe == DialogResult.Yes)
                Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dRe = MessageBox.Show("确认退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dRe == DialogResult.No)
                e.Cancel = true;
            else
            {
                Application.Exit();
            }
        }

        private void 添加管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regist newRegist = new Regist();
            newRegist.ShowDialog();
        }

        private void 删除管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelAdm del = new DelAdm();
            del.ShowDialog();
        }

        private void 添加检测人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newJCR op = new newJCR();
            op.Show();
        }
        /// <summary>
        /// 查找，单项和多项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnselect_Click(object sender, EventArgs e)
        {
            singleQuery();
                        
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void 添加检测人事件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSJ addsj = new AddSJ();
            addsj.Show();
        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void checkAge_CheckedChanged(object sender, EventArgs e)
        {

        }
        #region  查询模块
        //查询的全局字符串
        string sql = "";
        

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns>查询失败返回0，查询成功返回查询到的数量</returns>
        public int singleQuery()
        {
            //更多筛选条件类实例
            MoreCon MC = new MoreCon();
            /*sql = "select JCRname as 姓名, JCRsex as 性别 ,JCRnation as 民族, JCRpolity as 政治面貌 ,JCRLiPla as 现居住地, JCRidenty as 身份证号 ,"
                   + "JCRphone as 联系电话, JCRbm as 别名, JCRfl as 分类, JCRJG as 籍贯,JCRsf as 身份,JCRfy as 方言,JCRzjxy as 宗教信仰, JCRsxdj as 思想等级,JCRlkdw as 列控单位,JCRjjzk as 经济状况,JCRxz as 现状,JCRlkjb as 列控级别,"
                   + "JCRbyyx as 毕业院校,JCRhjszd as 户籍所在地, JCRgzdw as 工作单位,JCRzy as 职业,JCRgxry as 关系人员,JCRgddh as 固定电话,JCRbgsdh as 办公室电话,JCRyddh as 移动电话,JCRqq as QQ,JCRwx as 微信,JCRdzyj as 电子邮件,JCRgrjl as 个人简历 "
                   + " from JCRJBXX where 1=1  ";*/
            sql = "select JCRname as 姓名,JCRbm as 别名,JCRsex as 性别, JCRidenty as 身份证号,JCRJG as 籍贯,JCRsf as 身份 from JCRJBXX where 1=1 ";

            #region 选择的条件将筛选条件加入sql字符串
            if (checkName.Checked == false && checkJG.Checked == false && checkLKDW.Checked == false && checkLKJB.Checked == false && checkXJZD.Checked == false && checkGXRY.Checked == false && MC.boolNL == false && MC.boolMZ == false && MC.boolZZMM == false && MC.boolGXRY == false && MC.booBYYX == false && MC.boolGZDW == false && MC.boolZY == false && MC.boolFL == false)
            { MessageBox.Show("请至少选择一项", "提示"); return 0; }

            else
            {
                //姓名
                if (checkName.Checked == true)
                {
                    if (sqlName.Text.Trim() == "")
                        MessageBox.Show("请输入姓名", "提示");
                    sql += " and JCRname like '%" + sqlName.Text.Trim() + "%'";
                }

                //籍贯
                if (checkJG.Checked == true)
                {
                    if (sqlJG.Text.Trim() == "")
                        MessageBox.Show("请输入籍贯", "提示");
                    sql += " and JCRJG like'%" + sqlJG.Text.Trim() + "%'  ";
                }
                //列控级别
                if (checkLKJB.Checked == true)
                {
                    if (sqlLKJB.Text.Trim() == "")
                        MessageBox.Show("请输入列控级别", "提示");
                    sql += " and  JCRlkjb like'%" + sqlLKJB.Text.Trim() + "%' ";
                }
                //关系人员
                if (checkGXRY.Checked == true)
                {
                    if (sqlGXRY.Text.Trim() == "")
                        MessageBox.Show("请输入关系人员", "提示");
                    sql += " and JCRgxry like'%" + sqlGXRY.Text.Trim() + "%' ";

                }
                //现居住地
                if (checkXJZD.Checked == true)
                {
                    if (sqlXJZD.Text.Trim() == "")
                        MessageBox.Show("请输入现居住地", "提示");
                    sql += " and JCRLiPla like '%" + sqlXJZD.Text.Trim() + "%'";
                }
                //年龄
                if (MC.boolNL == true)
                {
                    if (MC.addNL.Trim() == "")
                        MessageBox.Show("请输入年龄", "提示");
                    sql += " and JCRnl like '%" + MC.addNL + "%'";
                }
                //民族
                if (MC.boolMZ == true)
                {
                    if (MC.addMZ.Trim() == "")
                        MessageBox.Show("请输入民族", "提示");
                    sql += " and JCRnation like '%" + MC.addMZ + "%'";
                }
                //政治面貌
                if (MC.boolZZMM == true)
                {
                    if (MC.addZZMM.Trim() == "")
                        MessageBox.Show("请输入政治面貌", "提示");
                    sql += " and JCRpolity like '%" + MC.addZZMM + "%' ";
                }
                //身份证号
                if (MC.boolGXRY == true)
                {
                    if (MC.addGXRY.Trim() == "")
                        MessageBox.Show("请输入身份证号", "提示");
                    sql += " and JCRidenty like '%" + MC.addGXRY + "%'";
                }
                //身份
                if (MC.booBYYX == true)
                {
                    if (MC.addBYYX.Trim() == "")
                        MessageBox.Show("请输入身份", "提示");
                    sql += " and JCRsf like '%" + MC.addBYYX + "%'";
                }
                //宗教信仰
                if (MC.boolGZDW == true)
                {
                    if (MC.addGZDW == "")
                        MessageBox.Show("请输入宗教信仰", "提示");
                    sql += " and JCRzjxy like '%" + MC.addGZDW + "%'";
                }
                //职业
                if (MC.boolZY == true)
                {
                    if (MC.addZY == "")
                        MessageBox.Show("请输入职业", "提示");
                    sql += " and JCRzy like '%" + MC.addZY + "%'";
                }
                //分类
                if (MC.boolFL == true)
                {
                    if (MC.addFL == "")
                        MessageBox.Show("请输入分类", "提示");
                    sql += " and JCRfl like '%" + MC.addFL + "%'";
                }


                #endregion

                int result = sqlMethod(sql);
                if (result == 0)
                {
                    MessageBox.Show("无相关人员信息", "提示");
                    sql = "";
                    return 0;
                }
                else
                {
                    sql = "";
                    return result;
                }
            }

            //单独选择姓名
            //else if (checkName.Checked == true && checkJG.Checked == false && checkLKDW.Checked == false && checkLKJB.Checked == false && checkXJZD.Checked == false && checkGXRY.Checked == false)
            //{

            //    sql += "JCRname='" + sqlName.Text.Trim() + "'";
            //    int rename = sqlMethod(sqlName.Text.Trim(), "姓名", sql);
            //    sql = string.Empty;
            //    return rename;

            //}
            ////单独选择籍贯
            //else if (checkName.Checked == false && checkJG.Checked == true && checkLKDW.Checked == false && checkLKJB.Checked == false && checkXJZD.Checked == false && checkGXRY.Checked == false)
            //{
            //    sql += " JCRJG='" + sqlJG.Text.Trim() + "'";
            //    int rename = sqlMethod(sqlJG.Text.Trim(), "籍贯", sql);
            //    sql = string.Empty;
            //    return rename;
            //}
            ////单独选择列控级别
            //else if (checkName.Checked == false && checkJG.Checked == false && checkLKDW.Checked == false && checkLKJB.Checked == true && checkXJZD.Checked == false && checkGXRY.Checked == false)
            //{
            //    sql += " JCRlkjb='" + sqlLKJB.Text.Trim() + "'";
            //    int rename = sqlMethod(sqlJG.Text.Trim(), "列控级别", sql);
            //    sql = string.Empty;
            //    return rename;
            //}
            ////单独选择列控单位
            //else if (checkName.Checked == false && checkJG.Checked == false && checkLKDW.Checked == true && checkLKJB.Checked == false && checkXJZD.Checked == false && checkGXRY.Checked == false)
            //{
            //    sql += " JCRlkdw='" + sqlLKDW.Text.Trim() + "'";
            //    int rename = sqlMethod(sqlJG.Text.Trim(), "列控单位", sql);
            //    sql = string.Empty;
            //    return rename;
            //}
            ////单独选择关系人员
            //else if (checkName.Checked == false && checkJG.Checked == false && checkLKDW.Checked == false && checkLKJB.Checked == false && checkXJZD.Checked == false && checkGXRY.Checked == true)
            //{
            //    sql += " JCRgxry='" + sqlGXRY.Text.Trim() + "'";
            //    int rename = sqlMethod(sqlJG.Text.Trim(), "关系人员", sql);
            //    sql = string.Empty;
            //    return rename;
            //}
            ////单独选择现居住地
            //else if (checkName.Checked == false && checkJG.Checked == false && checkLKDW.Checked == false && checkLKJB.Checked == false && checkXJZD.Checked == true && checkGXRY.Checked == false)
            //{
            //    sql += " JCRxjzd='" + sqlXJZD.Text.Trim() + "'";
            //    int rename = sqlMethod(sqlJG.Text.Trim(), "现居住地", sql);
            //    sql = string.Empty;
            //    return rename;
            //}
            //else { return 0; }
        }

        /// <summary>
        ///单项查询 访问数据库的方法
        /// </summary>
        /// <param name="text">要查询的textbox</param>
        /// <param name="title">要查询的check</param>
        /// <param name="sql">查询字符串</param>
        /// <returns>查询成功返回查到的条数，否则返回0</returns>
        public int sqlMethod( string sql)
        {
       
                using (OleDbConnection conn = new OleDbConnection(strcon))
                {
                    OleDbCommand comm = new OleDbCommand(sql, conn);
                    
                    OleDbDataAdapter da = new OleDbDataAdapter(comm);
                    DataSet ds = new DataSet();
                    conn.Open();
                int result = da.Fill(ds, "dt");
                if (result != 0)
                {
                    gridSql.DataSource = ds.Tables["dt"];
                    return result;
                }
                else
                    return 0;

                }
           
        }
        #endregion

        //显示更多筛选条件
        private void moreCon_Click(object sender, EventArgs e)
        {
            //更多筛选条件类实例
            MoreCon MC = new MoreCon();
            MC.ShowDialog();
        }
        /// <summary>
        /// 查询指定信息
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <returns>返回查找到的信息，若未找到返回0</returns>
        public string getInfo(string sql)

        {
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                OleDbCommand comm = new OleDbCommand(sql, conn);
                conn.Open();
                object result = comm.ExecuteScalar();
                if (result == null)
                {
                    return "0";
                }
                else
                {
                    return result.ToString();
                }

            }
        }
        //存选择的人的身份证信息
        public string SFZid
        { set; get; }

        detailInfo DI = new detailInfo();
        private void button1_Click_1(object sender, EventArgs e)
          {
            //获得选取的人的身份证号，用身份证号索引
             if (gridSql.CurrentCell==null)
                MessageBox.Show("请选择要查看的人员", "提示");
            else
            {
                string sqlID = "";

                    sqlID = gridSql[3, gridSql.CurrentCell.RowIndex].Value.ToString();

                SFZid = sqlID;
                #region 将详细信息显示出来
                //姓名
                sql = "select JCRname from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetName=getInfo(sql);
                //性别
                sql = "select JCRsex from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetSex = getInfo(sql);
                //别名
                sql = "select JCRbm from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetBM = getInfo(sql);
                //曾用名
                sql = "select JCRcym from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetCYM = getInfo(sql);
                //籍贯
                sql = "select JCRJG from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetJG = getInfo(sql);
                //身份
                sql = "select JCRsf from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetSF = getInfo(sql);
                //方言
                sql = "select JCRfy from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetFY = getInfo(sql);
                //宗教信仰
                sql = "select JCRzjxy from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetZJXY = getInfo(sql);
                //职业
                sql = "select JCRzy from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetZY = getInfo(sql);
                //民族
                sql = "select JCRnation from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetMZ = getInfo(sql);
                //经济状况
                sql = "select JCRjjzk from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetJJZK = getInfo(sql);
                //现状
                sql = "select JCRxz from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetXZ = getInfo(sql);
                //思想等级
                sql = "select JCRsxdj from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetSXDJ = getInfo(sql);
                //列控单位
                sql = "select JCRlkdw from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetLKDW = getInfo(sql);
                //身份证号
                DI.GetSFZ = sqlID;
                //政治面貌
                sql = "select JCRpolity from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetZZMM = getInfo(sql);
                //分类
                sql = "select JCRfl from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetFL = getInfo(sql);
                //列控级别
                sql = "select JCRlkjb from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetLKJB = getInfo(sql);
                //毕业院校
                sql = "select JCRbyyx from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetBYYX = getInfo(sql);
                //户籍所在地
                sql = "select JCRhjszd from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetHJSZD = getInfo(sql);
                //现居住地
                sql = "select JCRLiPla from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetXJZD = getInfo(sql);
                //工作单位
                sql = "select JCRgzdw from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetGZDW = getInfo(sql);
                //关系人员
                sql = "select JCRgxry from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetGXRY = getInfo(sql);
                //个人简历
                sql = "select JCRgrjl from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetGRJL = getInfo(sql);
                //固定电话
                sql = "select JCRgddh from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetGDDH = getInfo(sql);
                //移动电话
                sql = "select JCRphone from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetYDDH = getInfo(sql);
                //电子邮件
                sql = "select JCRdzyj from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetDZYJ  = getInfo(sql);
                //办公室电话
                sql = "select JCRbgsdh from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetBGSDH = getInfo(sql);
                //QQ
                sql = "select JCRqq from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetQQ = getInfo(sql);
                //微信
                sql = "select JCRwx from JCRJBXX where JCRidenty='" + sqlID + "'";
                DI.GetWX = getInfo(sql);
                
                #endregion
                

            //DI.ShowDialog();
        }//else
         
        }//btn
    }//class 
}//namespace
