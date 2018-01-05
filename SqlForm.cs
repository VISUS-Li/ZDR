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
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using System.Threading;

namespace ZDRJC2
{
    public partial class SqlForm : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public SqlForm()
        {
            InitializeComponent();
        }
        #region 字段
        //dataView下标
        public string sqlIndex
        { set; get; }
        //dataView身份证的下标
        public string SFZindex
        { set; get; }
        //给定值标记监测人详细信息窗口是打开还是修改,打开为1，修改为2
        public static string See_Change
        { set; get; }
        //删除时确认的密码字段
        public string surePWD
        { set; get; }
        //导出信息的身份证号
        public string DCSFZ
        { set; get; }
        //判断导出表时选择了多少行
        public int DCRows
        { set; get; }
        //集合存储要导出的人的身份证
        List<string> DCinfo = new List<string>();
        #endregion
        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MF = new MainForm();
            MF.Show();
        }
        //更多
        MoreCon MC = new MoreCon();

        private void btnMore_Click(object sender, EventArgs e)
        {

            MC.ShowDialog();
        }
        //查询
        private void btnSql_Click(object sender, EventArgs e)
        {
            sql = "";
            singleQuery();
            string sqlID = "";
            try
            {
                //身份证号
                sqlID = sqlDataView[7, sqlDataView.CurrentCell.RowIndex].Value.ToString();
                if (sqlID != null)
                    SFZid = sqlID;
                else
                    SFZid = "0";
                return;
            }
            catch { return; }
        }

        private void SqlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm MF = new MainForm();
            MF.Show();

        }

        //存储姓名
        public string GName
        { set; get; }

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

            /*sql = "select JCRname as 姓名, JCRsex as 性别 ,JCRnation as 民族, JCRpolity as 政治面貌 ,JCRLiPla as 现居住地, JCRidenty as 身份证号 ,"
                   + "JCRphone as 联系电话, JCRbm as 别名, JCRfl as 分类, JCRJG as 籍贯,JCRsf as 身份,JCRfy as 方言,JCRzjxy as 宗教信仰, JCRsxdj as 思想等级,JCRlkdw as 列控单位,JCRjjzk as 经济状况,JCRxz as 现状,JCRlkjb as 列控级别,"
                   + "JCRbyyx as 毕业院校,JCRhjszd as 户籍所在地, JCRgzdw as 工作单位,JCRzy as 职业,JCRgxry as 关系人员,JCRgddh as 固定电话,JCRbgsdh as 办公室电话,JCRyddh as 移动电话,JCRqq as QQ,JCRwx as 微信,JCRdzyj as 电子邮件,JCRgrjl as 个人简历 "
                   + " from JCRJBXX where 1=1  ";*/
            sql = "select JCRname as 姓名,JCRsex as 性别,JCRnl as 年龄,JCRJG as 籍贯,JCRlkdw as 列控单位, JCRlkjb as 列控级别,JCRyddh as 联系电话,JCRsfz as 身份证号,JCRAddTime as 添加时间 from JCRJBXX where 1=1 and JCRdellogo='0' ";

            #region 选择的条件将筛选条件加入sql字符串
            //if (checkName.Checked == false && checkJG.Checked == false && checkLKDW.Checked == false && checkLKJB.Checked == false && checkSFZ.Checked == false && MC.boolNL == false && MC.boolMZ == false && MC.boolZZMM == false && MC.boolGXRY == false && MC.boolSF == false && MC.boolZJXY == false && MC.boolZY == false && MC.boolFL == false)
            //{ MessageBox.Show("请至少选择一项", "提示"); return 0; }

            //else
            //{
            //姓名
            if (sqlName.Text.Trim() != "")
            {

                sql += " and JCRname like '%" + sqlName.Text.Trim() + "%'";
            }

            //籍贯
            if (sqlJG.Text.Trim() != "")
            {

                sql += " and JCRJG like'%" + sqlJG.Text.Trim() + "%'";
            }
            //列控级别
            if (sqlLKJB.Text.Trim() != "")
            {

                sql += " and  JCRlkjb like'%" + sqlLKJB.Text.Trim() + "%'";
            }
            //列控单位
            if (sqlLKDW.Text.Trim() != "")
            {

                sql += " and JCRlkdw like'%" + sqlLKDW.Text.Trim() + "%'";

            }
            //年龄
            if (MC.addNL != ""&&MC.addNL!=null)
            {

                sql += " and JCRnl like '%" + MC.addNL + "%'";
            }
            //民族
            if (MC.addMZ != "" && MC.addMZ != null)
            {

                sql += " and JCRnation like '%" + MC.addMZ + "%'";
            }
            //政治面貌
            if (MC.addZZMM != ""&&MC.addZZMM!=null)
            {

                sql += " and JCRpolity like '%" + MC.addZZMM + "%'";
            }
            //关系人员
            if (MC.addGXRY != ""&&MC.addGXRY!=null)
            {

                sql += " and JCRgxry like '%" + MC.addGXRY + "%'";
            }
            //毕业院校
            if (MC.addBYYX != ""&&MC.addBYYX!=null)
            {

                sql += " and JCRbyyx like '%" + MC.addBYYX + "%'";
            }
            //工作单位
            if (MC.addGZDW != ""&&MC.addGZDW!=null)
            {
                sql += " and JCRgzdw like '%" + MC.addGZDW + "%'";
            }
            //职业
            if (MC.addZY != ""&&MC.addZY!=null)
            {

                sql += " and JCRzy like '%" + MC.addZY + "%'";
            }
            //分类
            if (MC.addFL != ""&&MC.addFL!=null)
            {

                sql += " and JCRfl like '%" + MC.addFL + "%'";
            }
            //身份证号
            if (sqlSFZ.Text.Trim() != "")
            {

                sql += " and JCRsfz like '%" + sqlSFZ.Text.Trim() + "%'";
            }



            #endregion

            string result = sqlMethod(sql, 0);
            if (result == "-1")
            {
                MessageBox.Show("无相关人员信息", "提示");
                sql = "";
                return 0;
            }
            else
            {
                sql = "";
                return Convert.ToInt32(result);
            }
            //}
        }
        #endregion

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
                        sqlDataView.DataSource = ds.Tables["dt"];
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
        /// <summary>
        /// 存选择的人的身份证信息,无身份证信息存储0
        /// </summary>  
        public static string SFZid
        { set; get; }


        /// <summary>
        /// 查询指定信息
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <returns>返回查找到的信息，若未找到返回"未找到"</returns>
        public string getInfo(string sql)

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
        //照片存储目录
        public string photoPath
        { set; get; }
        //照片guid
        public string photoGuid
        { get; set; }
        //查看详细信息

        private void btnShowDe_Click(object sender, EventArgs e)
        {
           
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
                object result = comm.ExecuteNonQuery();
                if (result != null)
                    return true;
                else return false;
            }
        }

        //要引用的其他窗口对象
        #region 要引用的其他窗口对象
        // sqlSJ SS = new sqlSJ();
        //DetailForm DI = new DetailForm();
        #endregion


        #region 右键功能
        /// <summary>
        /// 记录选中的行
        /// </summary>
        /// <returns>选中行的行号</returns>
        private int[] RowCount()
        {
            
            string [] ss = new string[sqlDataView.SelectedCells.Count];

            for (int i = sqlDataView.SelectedCells.Count - 1; i >= 0; i--)
            {
                ss[i] = sqlDataView.SelectedCells[i].RowIndex.ToString();
            }
            string[] ssNo=ss.Distinct().ToArray();
            int[] ssInt = new int[ssNo.Length];
            for (int j = 0; j < ssNo.Length ; j++)
            {
                ssInt[j] = Convert.ToInt32(ssNo[j]);
            }

            return ssInt;           
        }



        //给datagridview添加右击事件
        private void sqlDataView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //点击左键直接return
            if (e.Button == MouseButtons.Left)
                return;
            //当前行未选择
            if (sqlDataView.Rows[e.RowIndex].Selected == false)
            {               
                sqlDataView.Rows[e.RowIndex].Selected = true;
            }
            int[] ssInt = RowCount();
            //将选中的行的身份证给DCinfo集合
            for (int i = 0; i < ssInt.Length; i++)
            {
                DCinfo.Add(sqlDataView[7, ssInt[i]].ToString());
            }
            #region 只选择了一行
            if (ssInt.Length <= 1)
            {
                
                btnSeeDetail.Visible = true;
                btnSeeSJ.Visible = true;
                btnQueryFJ.Visible = true;
                changeObjInfo.Visible = true;
                delObj.Visible = true;
                添加事件ToolStripMenuItem.Visible = true;
                添加附件ToolStripMenuItem.Visible = true;
                link1.Visible = true;
                link2.Visible = true;
                link3.Visible = true;
                DCOneRow.Visible = true;
                DCselected.Visible = false;
                //权限不够
                if (Login.limit == "2")
                {
                    changeObjInfo.Visible = false;
                    delObj.Visible = false;
                    添加事件ToolStripMenuItem.Visible = false;
                    添加附件ToolStripMenuItem.Visible = false;
                    link1.Visible = false;
                    gridViewMenu.Show(MousePosition.X, MousePosition.Y);
                }
                else
                {
                    gridViewMenu.Show(MousePosition.X, MousePosition.Y);
                }

            }
            #endregion
            else
            {
                if (e.Button == MouseButtons.Left)
                    return;
                for (int i = ssInt.Length - 1; i >= 0; i--)
                {
                    sqlDataView.Rows[ssInt[i]].Selected = true;
                }
                btnSeeDetail.Visible = false;
                btnSeeSJ.Visible = false;
                btnQueryFJ.Visible = false;
                changeObjInfo.Visible = false;
                delObj.Visible = false;
                添加事件ToolStripMenuItem.Visible = false;
                添加附件ToolStripMenuItem.Visible = false;
                link1.Visible = false;
                link2.Visible = false;
                link3.Visible = false;
                DCOneRow.Visible = false;
                DCselected.Visible = true;
                gridViewMenu.Show(MousePosition.X, MousePosition.Y);
            }          
        }


        //查看详细信息按钮
        private void btnSeeDetail_Click(object sender, EventArgs e)
        {
            fillAssignment("1");
        }


        //查看事件按钮
        private void btnSeeSJ_Click(object sender, EventArgs e)
        {
            sqlSJ SS = new sqlSJ();
            string getName = sqlDataView[0, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            string getSFZ = sqlDataView[7, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            SS.sqlSFZ = getSFZ;
            SS.sqlName = getName;
            SS.Show();
        }


        //修改对象信息按钮
        private void changeObjInfo_Click(object sender, EventArgs e)
        {
            DetailForm DI = new DetailForm();
            string sqlID = "";
            //身份证号
            sqlID = sqlDataView[7, sqlDataView.CurrentCell.RowIndex].Value.ToString();

            SFZid = sqlID;
            delPwd DP = new delPwd();
            if (Login.limit == "2")
            {
                MessageBox.Show("对不起，您没有权限访问", "提示");
            }
            else
            {
                DP.ShowDialog();
                if (DP.rightYH == "1")
                {
                    #region 将详细信息显示出来
                    //姓名
                    sql = "select JCRname from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetName = getInfo(sql);
                    //性别
                    sql = "select JCRsex from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetSex = getInfo(sql);                               
                    //籍贯
                    sql = "select JCRJG from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetJG = getInfo(sql);                                                       
                    //职业
                    sql = "select JCRzy from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetZY = getInfo(sql);
                    //民族
                    sql = "select JCRnation from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetMZ = getInfo(sql);
                    //经济状况
                    sql = "select JCRjjzk from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetJJZK = getInfo(sql);                                 
                    //列控单位
                    sql = "select JCRlkdw from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetLKDW = getInfo(sql);
                    //身份证号
                    DI.GetSFZ = sqlID;
                    //政治面貌
                    sql = "select JCRpolity from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetZZMM = getInfo(sql);
                    //分类
                    sql = "select JCRfl from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetFL = getInfo(sql);
                    //列控级别
                    sql = "select JCRlkjb from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetLKJB = getInfo(sql);
                    //毕业院校
                    sql = "select JCRbyyx from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetBYYX = getInfo(sql);
                    //户籍所在地
                    sql = "select JCRhjszd from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetHJSZD = getInfo(sql);
                    //现居住地
                    sql = "select JCRxjzd from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetXJZD = getInfo(sql);
                    //工作单位
                    sql = "select JCRgzdw from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetGZDW = getInfo(sql);
                    //关系人员
                    sql = "select JCRgxry from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetGXRY = getInfo(sql);
                    //个人简历
                    sql = "select JCRgrjl from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetGRJL = getInfo(sql);
                    //固定电话
                    sql = "select JCRgddh from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetGDDH = getInfo(sql);
                    //备注
                    sql = "select JCRbz from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetBZ = getInfo(sql);
                    //移动电话
                    sql = "select JCRyddh from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetYDDH = getInfo(sql);
                    //电子邮件
                    sql = "select JCRdzyj from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetDZYJ = getInfo(sql);               
                    //QQ
                    sql = "select JCRqq from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetQQ = getInfo(sql);
                    //微信
                    sql = "select JCRwx from JCRJBXX where JCRsfz='" + sqlID + "'";
                    DI.GetWX = getInfo(sql);
                    #endregion
                    See_Change = "2";
                    DI.Show();
                }

            }
        }


        //删除监测人
        private void delObj_Click(object sender, EventArgs e)
        {
            delPwd DP = new delPwd();
            string sql = "";
            string getName = sqlDataView[0, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            string getSFZ = sqlDataView[7, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            DP.ShowDialog();
            //执行删除
            if (DP.rightYH == "1")
            {
                DialogResult res = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    sql = "update JCRJBXX set JCRdellogo='1' where JCRsfz='" + getSFZ + "' ";
                    string re = sqlMethod(sql, 2);
                    if (re != "-1")
                    {
                        MessageBox.Show("删除成功", "提示");
                        singleQuery();

                    }
                    else
                    {
                        MessageBox.Show("删除失败", "提示");
                    }
                }
            }
        }
        #endregion

        //加载时
        private void SqlForm_Load(object sender, EventArgs e)
        {
            sqlName.Clear();
            sqlJG.Clear();
            sqlLKDW.Clear();
            sqlLKJB.Clear();
            sqlSFZ.Clear();           
            //toolStripMenuItem4.Visible = false;
        }


        //datagridview单元格双击事件
        private void sqlDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fillAssignment("1"); 
        }


        /// <summary>
        /// 给detailform赋值
        /// </summary>
        private void fillAssignment(string judge)
        {
            DetailForm DI = new DetailForm();
            string sqlID = "";
            //身份证号
            sqlID = sqlDataView[7, sqlDataView.CurrentCell.RowIndex].Value.ToString();

            SFZid = sqlID;
            #region 将详细信息显示出来
            //姓名
            sql = "select JCRname from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetName = getInfo(sql);
            //性别
            sql = "select JCRsex from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetSex = getInfo(sql);
            //籍贯
            sql = "select JCRJG from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetJG = getInfo(sql);
            //职业
            sql = "select JCRzy from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetZY = getInfo(sql);
            //民族
            sql = "select JCRnation from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetMZ = getInfo(sql);
            //经济状况
            sql = "select JCRjjzk from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetJJZK = getInfo(sql);
            //列控单位
            sql = "select JCRlkdw from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetLKDW = getInfo(sql);
            //身份证号
            DI.GetSFZ = sqlID;
            //政治面貌
            sql = "select JCRpolity from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetZZMM = getInfo(sql);
            //分类
            sql = "select JCRfl from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetFL = getInfo(sql);
            //列控级别
            sql = "select JCRlkjb from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetLKJB = getInfo(sql);
            //毕业院校
            sql = "select JCRbyyx from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetBYYX = getInfo(sql);
            //户籍所在地
            sql = "select JCRhjszd from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetHJSZD = getInfo(sql);
            //现居住地
            sql = "select JCRxjzd from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetXJZD = getInfo(sql);
            //工作单位
            sql = "select JCRgzdw from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetGZDW = getInfo(sql);
            //关系人员
            sql = "select JCRgxry from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetGXRY = getInfo(sql);
            //个人简历
            sql = "select JCRgrjl from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetGRJL = getInfo(sql);
            //备注
            sql = "select JCRbz from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetBZ = getInfo(sql);
            //固定电话
            sql = "select JCRgddh from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetGDDH = getInfo(sql);
            //移动电话
            sql = "select JCRyddh from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetYDDH = getInfo(sql);
            //电子邮件
            sql = "select JCRdzyj from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetDZYJ = getInfo(sql);
            //QQ
            sql = "select JCRqq from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetQQ = getInfo(sql);
            //微信
            sql = "select JCRwx from JCRJBXX where JCRsfz='" + sqlID + "'";
            DI.GetWX = getInfo(sql);
            #endregion
            See_Change = judge;
            DI.Show();
        }


        //为当前对象添加事件
        private void 添加事件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string getName = sqlDataView[0, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            string getSFZ = sqlDataView[7, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            addSJ_Sql AS = new addSJ_Sql();
            AS.showName = getName;
            AS.showSFZ = getSFZ;
            AS.ShowDialog();
        }


        //为当前对象添加附件
        private void 添加附件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string getName = sqlDataView[0, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            string getSFZ = sqlDataView[7, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            AddFJ AF = new AddFJ();
            AF.getInitName = getName;
            AF.getInitSFZ = getSFZ;
            AF.ShowDialog();
        }


        //查看附件
        private void btnQueryFJ_Click(object sender, EventArgs e)
        {
            string getName = sqlDataView[0, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            string getSFZ = sqlDataView[7, sqlDataView.CurrentCell.RowIndex].Value.ToString();
            SqlFJ SF = new SqlFJ();
            SF.initName = getName;
            SF.initSFZ = getSFZ;
            SF.Show();
        }


        #region 未完成的直接导入excel
        /// <summary>
        /// 导出选中行的方法，若未选择任何行，可以导出整个表格
        /// </summary>
        /// <param name="datagridview">要导出的表格</param>
        /// <param name="judge">若为0则导出整个表格，否则导出选中行</param>
        /// <param name="rows">选中的行数</param>
        /// <param name="fileName">要保存的文件名</param>
        public void DCMethod(DataGridView datagridview,string judge,int rows,string fileName)
        {
            //if (rows<=0)
            //{
            //    MessageBox.Show("零行被选中，请选择要导出的行","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    return;
            //}      
            string saveFileName = "";
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.DefaultExt = "xls";
            SFD.Filter = "Exccel表格|*.xls";
            SFD.FileName = fileName;
            SFD.ShowDialog();
            saveFileName = SFD.FileName;
            
            //创建表
            System.Data.DataTable tempTable = SXInfoToTempTable(datagridview, judge, rows);
            //导出到excel中           
                DCToExcel(datagridview, tempTable, saveFileName);           
            //}

        }

        /// <summary>
        /// 筛选datagridview中的信息的方法,导出到临时表中
        /// </summary>
        /// <param name="datagridview">要导出的源表</param>
        /// <param name="judge">若为0，导出整个表；若为1，导出选中的表</param>
        /// <param name="selectedCount">选择的行数</param>
        private System.Data.DataTable SXInfoToTempTable(DataGridView datagridview, string judge, int selectedCount)
        {
            #region 导出datagridview的信息
            //表，存储要导出的信息
            System.Data.DataTable tempTable = new System.Data.DataTable("tempTable");
            //表，存储列名
            System.Data.DataTable modelTable = new System.Data.DataTable("modelTable");
            //创建列
            for (int column = 0; column < datagridview.Columns.Count; column++)
            {

                DataColumn tempColumn = new DataColumn(datagridview.Columns[column].HeaderText, typeof(string));
                tempTable.Columns.Add(tempColumn);
                DataColumn modelColumn = new DataColumn(datagridview.Columns[column].Name, typeof(string));
                modelTable.Columns.Add(modelColumn);
            }
            //导出整个表
            if (judge == "0")
            {
                //添加dataview中的数据到临时表中
                for (int row = 0; row < datagridview.Rows.Count; row++)
                {
                    if (datagridview.Rows[row].Visible == false)
                        continue;

                    DataRow tempRow = tempTable.NewRow();
                    for (int i = 0; i < tempTable.Columns.Count; i++)
                    {
                        tempRow[i] = datagridview.Rows[row].Cells[modelTable.Columns[i].ColumnName].Value;
                    }
                    tempTable.Rows.Add(tempRow);
                }
                return tempTable;
            }
            //导出选中的表
            if (judge == "1")
            {
                //添加dataview中的数据到临时表中
                for (int row = 0; row < selectedCount; row++)
                {
                    if (datagridview.Rows[row].Visible == false)
                        continue;

                    DataRow tempRow = tempTable.NewRow();
                    for (int i = 0; i < tempTable.Columns.Count; i++)
                    {
                        tempRow[i] = datagridview.Rows[row].Cells[modelTable.Columns[i].ColumnName].Value;
                    }
                    tempTable.Rows.Add(tempRow);
                }
                return tempTable;
            }
            #endregion
            return null;
        }
        /// <summary>
        /// 将临时表导出到excel中
        /// </summary>
        /// <param name="datagridview">要导出的datagridview</param>
        /// <param name="tempTable">要导出的源表</param>
        /// <param name="saveFileName">要保存的文件位置</param>
        private void DCToExcel(DataGridView datagridview, System.Data.DataTable tempTable, string saveFileName)
        {          
            Microsoft.Office.Interop.Excel.ApplicationClass myExcel;
            Microsoft.Office.Interop.Excel.Workbooks myWorkBooks;
            Microsoft.Office.Interop.Excel.Workbook myWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet myWorkSheet;
            char myColumns;
            Microsoft.Office.Interop.Excel.Range myRange;
            object[,] myData = new object[500, 35];
            int i, j;//j代表行,i代表列
            myExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            //显示EXCEL
            myExcel.Visible = true;
            if (myExcel == null)
            {
                MessageBox.Show("本地Excel程序无法启动!请检查您的Microsoft Office正确安装并能正常使用", "提示");
                return;
            }
            myWorkBooks = myExcel.Workbooks;
            myWorkBook = myWorkBooks.Add(Missing.Value);
            myWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)myWorkBook.Worksheets[1];//获取sheet1
            myColumns = (char)(tempTable.Columns.Count + 64);//设置列
            myRange = myWorkSheet.get_Range("A4", myColumns.ToString() + "5");//设置列宽
            int count = 0;
            //设置列名
            //foreach (DataColumn myNewColumn in tempTable.Columns)
            //{
            //    myData[0, count] = myNewColumn.ColumnName;
            //    count = count + 1;
            //}
            foreach (DataColumn myNewColumn in tempTable.Columns)
            {
                myWorkSheet.Cells[1, count + 1] = myNewColumn.ColumnName;
                ++count;
            }
            //输出datagridview中的数据记录并放在一个二维数组中
            j = 1;
            //foreach (DataRow myRow in tempTable.Rows)//循环行
            //{
            //  for (i = 0; i < tempTable.Columns.Count; i++)//循环列
            //    {
            //        myData[j, i] = myRow[i].ToString();
            //    }
            //    j++;
            //}
            foreach (DataRow myRow in tempTable.Rows)
            {
                for (i = 0; i < tempTable.Columns.Count; i++)
                {
                    myWorkSheet.Cells[j + 1, i + 1] = myRow[i].ToString();
                }
                System.Windows.Forms.Application.DoEvents();//?
            }
            //保存
            if (saveFileName == "" & saveFileName == null)
            {
                myExcel.Quit();
                GC.Collect();
                MessageBox.Show("保存的路径选择失败，导出失败","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                myWorkBook.Saved = true;
                myWorkBook.SaveCopyAs(saveFileName);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            ////将二维数组中的数据写到Excel中
            //myRange = myRange.get_Resize(tempTable.Rows.Count + 1, tempTable.Columns.Count);//创建列和行
            //myRange.Value2 = myData;
            //myRange.EntireColumn.AutoFit();
        }

        //导出基本信息
        private void DCJCRJBXX_Click(object sender, EventArgs e)
        {
            //delPwd DP = new delPwd();
            //DP.ShowDialog();
            //if (DP.rightYH != "1")
            //{
            //    return;
            //}
            //else
            //{
                string guid = Guid.NewGuid().ToString();
                if (sqlDataView.SelectedRows.Count <= 0)
                {
                    DialogResult DR = MessageBox.Show("要导出整个表格吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        DCMethod(sqlDataView, "0", sqlDataView.Rows.Count, guid + "导出的表格_整个表格");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("请选择要导出的行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                //DCMethod(sqlDataView, "1", DCRows, guid + "导出的表格_选中的行");
                DCMethod(sqlDataView, "0", sqlDataView.Rows.Count, guid + "导出的表格_整个表格");
            }
      //  }

        //datareader查询方法
        private List<string> readSqlMethod(string sql)
        {
            List<string> list = new List<string>();
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                OleDbCommand comm = new OleDbCommand(sql, conn);
                conn.Open();
                OleDbDataReader myReader = comm.ExecuteReader();
                int i = 0;
                while (myReader.Read())
                {

                    list.Add(myReader.GetValue(i).ToString());
                    ++i;
                }
                return list;

            }
        }
        #region 未完成的按集合导出
        //导出信息到txt
        private void readInfoToTxt()
        {
            
            //System.Data.DataTable tempTable = SXInfoToTempTable(sqlDataView, "1", DCRows);
            //string[] getHead;
            //for (int i = 0; i < tempTable.Columns.Count; i++)
            //{
            //    getHead[i] = tempTable.Columns[i].ToString();
            //}

        }
        //导出信息按钮
        private void DCInfo_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion


        //通过传入的参数查询信息，供导出时的参数
        private string info(string value, string sfz)
        {
            string sql = "select ";
            switch (value)
            {
                case "SFZ":sql += " JCRsfz ";break;
                case "name":sql += " JCRname ";break;
                case "sex":sql += " JCRsex ";break;
                case "NL":sql += " JCRnl ";break;
                case "MZ":sql += " JCRnation ";break;
                case "ZZMM":sql += " JCRpolity "; break;
                case "JG":sql += " JCRJG ";break;
                case "HJSZD":sql += " JCRhjszd ";break;
                case "XJZD":sql += " JCRxjzd ";break;
                case "FL":sql += " JCRfl ";break;
                case "LKDW":sql += " JCRlkdw ";break;
                case "LKJB":sql += " JCRLKJB "; break;
                case "YDDH":sql += " JCRyddh "; break;
                case "AddTime":sql += " JCRAddTime "; break;
                case "BYYX":sql += " JCRbyyx ";break;
                case "ZY":sql += " JCRzy ";break;
                case "GZDW":sql += " JCRgzdw ";break;
                case "JJZK":sql += " JCRjjzk ";break;
                case "HDQK":sql += " JCRgrjl ";break;
                case "BZ":sql += " JCRbz "; break;
                case "GDDH":sql += " JCRgddh ";break;
                case "QQ":sql += " JCRqq ";break;
                case "WX":sql += " JCRwx ";break;
                case "DZYJ":sql += " JCRdzyj ";break;                                    
            }//switch
            sql += " from JCRJBXX where JCRsfz='" + sfz + "'";
           string re= sqlMethod(sql, 1);
            return re;
        }

        /// <summary>
        /// 导出单行数据
        /// </summary>
        /// <param name="path">导出路径</param>
        /// <param name="countCount">指示导出指定字段的表还是全部字段的值，1表示导出指定字段，其余表示导出全部字段</param>
        /// <param name="sfz">导出的对象的身份证</param>
        /// <param name="flag">如果传入参数为1，表示在新文件中导入信息，否则表示在同一文件导入信息</param>
        /// <returns>导出成功返回true，否则返回false</returns>
        private bool saveAsExcelMode_OneRow(string path,int countCount,string sfz,int flag)
        {
            #region 字段
            // info("HJSZD", sfz) + "','" + info("XJZD", sfz)+ "','" + info("BYYX", sfz) + "','" + info("ZY", sfz) + "','" 
            // + info("GZDW", sfz) + "','" + info("JJZK", sfz) + "','" + info("FL", sfz)+ "','" + info("LKDW", sfz) + "','"
           //  + info("LKJB", sfz) + "','" + info("HDQK", sfz) + "','" + info("BZ", sfz) + "','" + info("GDDH", sfz)+ "','" 
           // + info("QQ", sfz) + "','" + info("WX", sfz) + "','" + info("DZYJ", sfz) + "','" + info("YDDH", sfz) + "','" + info("AddTime", sfz) + "')";
            string name = info("name", sfz);
            string sex = info("sex", sfz);
            string NL = info("NL", sfz);
            string MZ = info("MZ", sfz);
            string ZZMM = info("ZZMM", sfz);
            string JG = info("JG", sfz);
            string HJSZD= info("HJSZD", sfz);
            string XJZD= info("XJZD", sfz);
            string BYYX= info("BYYX", sfz);
            string ZY= info("ZY", sfz);
            string GZDW= info("GZDW", sfz);
            string JJZK= info("JJZK", sfz);
            string FL= info("FL", sfz);
            string LKDW= info("LKDW", sfz);
            string LKJB= info("LKJB", sfz);
            string HDQK= info("HDQK", sfz);
            string BZ= info("BZ", sfz);
            string GDDH= info("GDDH", sfz);
            string QQ= info("QQ",sfz);
            string WX= info("WX", sfz);
            string DZYJ= info("DZYJ", sfz);
            string YDDH= info("YDDH", sfz);
            string AddTime= info("AddTime", sfz);
            #endregion

            try
            {
                #region 导出单行
                    // 导出指定字段的表
                    if (countCount == 1)
                    {
                    //如果传入参数为1，表示在新文件中导入信息，否则表示在同一文件导入信息
                        if (flag == 1)
                        {
                             File.Copy(Environment.CurrentDirectory + "\\SheetMode\\mode_part.xls", path);
                        }
                        string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
                        using (OleDbConnection conn = new OleDbConnection(strCon))
                        {
                            conn.Open();
                            OleDbCommand comm = new OleDbCommand();
                            comm.Connection = conn;
                            string sql= "insert into [Sheet1$](身份证号,姓名,性别,年龄,民族,政治面貌,籍贯,户籍所在地,现居住地,类别,列控单位,列控级别,联系电话,添加时间) values('" + sfz + "','" + info("name", sfz) + "','" + info("sex", sfz) + "','" + info("NL", sfz)+ "','" + info("MZ", sfz) + "','" + info("ZZMM", sfz) + "','" + info("JG", sfz) + "','" + info("HJSZD", sfz) + "','" + info("XJZD", sfz) + "','" + info("FL", sfz) + "','" + info("LKDW", sfz) + "','" + info("LKJB", sfz) + "','" + info("YDDH", sfz) + "','" + info("AddTime", sfz) + "')";
                            comm.CommandText = sql;
                            try
                            {
                                comm.ExecuteNonQuery();
                                return true;
                            }
                            catch { return false; }

                        }
                    }
                    //导出全部字段
                    else
                    {
                    if (File.Exists(path) == false)
                    {
                        File.Copy(Environment.CurrentDirectory + "\\SheetMode\\mode_all.xls", path);
                    }
                        string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
                        using (OleDbConnection conn = new OleDbConnection(strCon))
                        {
                            conn.Open();
                            OleDbCommand comm = new OleDbCommand();
                            comm.Connection = conn;
                        // string sql="insert into [Sheet1$](身份证号,姓名,性别,年龄,民族,政治面貌,籍贯,户籍所在地,现居住地,毕业院校,职业,工作单位.经济状况,类别,列控单位,列控级别,活动情况,备注,固定电话,QQ,微信,电子邮件,联系电话,添加时间) values( '"+ sfz + "','" + info("name", sfz) + "','" + info("sex", sfz) + "','" + info("NL", sfz)+ "','" + info("MZ", sfz) + "','" + info("ZZMM", sfz) + "','" + info("JG", sfz) + "','" + info("HJSZD", sfz) + "','" + info("XJZD", sfz)+ "','" + info("BYYX", sfz) + "','" + info("ZY", sfz) + "','" + info("GZDW", sfz) + "','" + info("JJZK", sfz) + "','" + info("FL", sfz)+ "','" + info("LKDW", sfz) + "','" + info("LKJB", sfz) + "','" + info("HDQK", sfz) + "','" + info("BZ", sfz) + "','" + info("GDDH", sfz)+ "','" + info("QQ", sfz) + "','" + info("WX", sfz) + "','" + info("DZYJ", sfz) + "','" + info("YDDH", sfz) + "','" + info("AddTime", sfz) + "')";
                        string sql = "insert into [Sheet1$](身份证号,姓名,性别,年龄,民族,政治面貌,籍贯,户籍所在地,现居住地,毕业院校,职业,工作单位,经济状况,类别,列控单位,列控级别,活动情况,备注,固定电话,QQ,微信,电子邮件,联系电话,添加时间) values( '" + sfz + "','" + name + "','" + sex + "','" + NL + "','" + MZ + "','" + ZZMM + "','" + JG + "','" + HJSZD + "','" + XJZD + "','" + BYYX + "','" + ZY + "','" + GZDW + "','" + JJZK + "','" + FL + "','" +LKDW +"','"+LKJB+"','"+HDQK+"','"+BZ+"','"+GDDH+"','"+QQ+"','"+WX+"','"+DZYJ+"','"+YDDH+"','"+AddTime+"')";
                          comm.CommandText = sql;
                            try
                            {
                                comm.ExecuteNonQuery();
                                return true;
                            }
                            catch(Exception ex)
                           {
                                MessageBox.Show(ex.Message);
                                return false;
                           }
                        }
                    }          
                #endregion
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }


        /// <summary>
        /// 导出多行信息
        /// </summary>
        /// <param name="path">导出的路径</param>
        /// <param name="RowsCount">导出的行数</param>
        /// <param name="countCount">指示导出固定字段还是全部导出,1表示导出固定字段，其余表示导出全部字段</param>
        /// <param name="sfz">导出的人的身份证集合</param>
        /// <returns>导出成功返回true，导出失败返回false</returns>
        private bool saveAsExcelMode_MulRows(string path, int RowsCount,int countCount, List<string> sfz)
        {
            //第一次导出在新文件中导入           
            bool res=saveAsExcelMode_OneRow(path, countCount, sfz[0], 1);
            if (res == false)
                return false;
            foreach (string item in sfz)
            {
                //保证第一个不重复
                if (item == sfz[0])
                { continue; }
                //调用单行导出依次导出每一行信息              
                bool re=saveAsExcelMode_OneRow(path, countCount, item, 2);
                if (re == false)
                    return false;
            }
            return true;           
        }
        //声明线程引用
        Thread mythread;
        //设置托管线程
        public delegate void DCinfo_Thread();//定义委托
        //对指定线程托管
        public void SetDCinfo()
        {
            this.Invoke(new DCinfo_Thread(RunDCinfo));
        }
        //设置线程
        public void RunDCinfo()
        {
            delPwd DP = new delPwd();
            DP.Show();
            if (DP.rightYH != "1")
                return;
            DialogResult DR = MessageBox.Show("导出该对象的全部信息吗？", "提示：选择否则导出部分信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //获得要导出的对象的身份证集合
            List<string> listSFZ = new List<string>();
            for (int i = 0; i < sqlDataView.SelectedRows.Count; i++)
            {
                listSFZ.Add(sqlDataView[7, sqlDataView.CurrentRow.Index].Value.ToString());
            }
            string path = "";
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "选择存储地址";
            SFD.Filter = "Excel文件|*.xls";
            bool re = false;
            if (DR == DialogResult.No)
            {
                SFD.FileName = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" +
                    DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_部分基本信息";
                //SFD.ShowDialog();
                if (SFD.ShowDialog() == DialogResult.Cancel)
                { return; }
                path = SFD.FileName;
                re = saveAsExcelMode_MulRows(path, listSFZ.Count, 1, listSFZ);
            }
            else
            {
                SFD.FileName = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" +
                   DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_全部基本信息";
               // SFD.ShowDialog();
                if (SFD.ShowDialog() == DialogResult.Cancel)
                { return; }
                path = SFD.FileName;
                re = saveAsExcelMode_MulRows(path, listSFZ.Count, 2, listSFZ);
            }
            if (re == true)
            {
                MessageBox.Show("导出成功", "提示");
                sqlDataView.ClearSelection();
            }
            else
            {
                MessageBox.Show("导出失败", "提示");
                sqlDataView.ClearSelection();
            }

            //持起主线程
            Thread.Sleep(0);
            //执行线程
            mythread.Abort();
        }
        //导出选中的单行信息
        private void DCOneRow_Click(object sender, EventArgs e)
        {
            mythread = new Thread(new ThreadStart(SetDCinfo));
            mythread.Start();
        }

        private void DCselected_Click(object sender, EventArgs e)
        {
            delPwd DP = new delPwd();
            DP.Show();
            if (DP.rightYH != "1")
                return;
            DialogResult DR = MessageBox.Show("导出该对象的全部信息吗？", "提示：选择否则导出部分信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //获得要导出的对象的身份证集合
            List<string> listSFZ = new List<string>();
            List< int> RowsIndex = new List<int>();//记录选中行的集合
            //MessageBox.Show(sqlDataView.SelectedRows[1].Index.ToString());
            for (int j =sqlDataView.SelectedRows.Count-1; j>=0 ; j--)
            {
              RowsIndex.Add(sqlDataView.SelectedRows[j].Index);
            }

            foreach (int item in RowsIndex)
            {
                try
                {
                    listSFZ.Add(sqlDataView[7, item].Value.ToString());
                }
                catch
                { MessageBox.Show("请勿选择空行", "提示"); return; }
            }
            //for (int i = 0; i < sqlDataView.SelectedRows.Count; i++)
            //{
            //    try
            //    {
            //        listSFZ.Add(sqlDataView[7, sqlDataView.CurrentRow.Index + i].Value.ToString());
            //    }
            //    catch
            //    { MessageBox.Show("请勿选择空行", "提示");return; }

                //}
                string path = "";
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "选择存储地址";
            SFD.Filter = "Excel文件|*.xls";
            bool re = false;
            if (DR == DialogResult.No)
            {
                SFD.FileName = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" +
                    DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_部分基本信息";
                //SFD.ShowDialog();
                if (SFD.ShowDialog() == DialogResult.Cancel)
                { return; }
                path = SFD.FileName;
                re = saveAsExcelMode_MulRows(path, listSFZ.Count, 1, listSFZ);
            }
            else
            {
                SFD.FileName = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" +
                   DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_全部基本信息";
                //SFD.ShowDialog();
                if (SFD.ShowDialog() == DialogResult.Cancel)
                { return; }
                path = SFD.FileName;
                re = saveAsExcelMode_MulRows(path, listSFZ.Count, 2, listSFZ);
            }
            if (re == true)
            {
                MessageBox.Show("导出成功", "提示");
                sqlDataView.ClearSelection();
            }
            else
            {
                MessageBox.Show("导出失败", "提示");
                sqlDataView.ClearSelection();
            }
        }


        //添加行号
        private void sqlDataView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //设置画笔颜色
            SolidBrush b = new SolidBrush(this.sqlDataView.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.sqlDataView.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
        }
    }
}

