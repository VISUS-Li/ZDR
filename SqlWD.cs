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
using System.Diagnostics;
using System.IO;

namespace ZDRJC2
{
    public partial class SqlWD : Form
    {

        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public SqlWD()
        {
            InitializeComponent();
        }

        #region  字段
        //显示的姓名
        public string getName
        { set; get; }
        //显示身份证号
        public string getSFZ
        { set; get; }
        //显示需要查看什么文件
        public string FJflag
        { set; get; }
        //指示要刷新的是什么
        public string RefreshFlag
        { set; get; }
        //导出的目标路径
        public string DCTargetPath
        { set; get; }

        #endregion
        private void SqlWD_Load(object sender, EventArgs e)
        {
            if (FJflag == null)
                return;

            //如果点击文档按钮，查询文档
            if (FJflag == "文档")
            {
                string sqlCount = "select WDCount from JCRFJ where JCRsfz='" + getSFZ + "'";
                string sqlTable = "select JCRname as 姓名,JCRsfz as 身份证号, WDname as 文件名,WDAddTime as 添加时间 from FJWD where JCRsfz='" + getSFZ + "' and WDdellogo='0' ";
                bool re = queryMethod(sqlCount, sqlTable);
                if(re!=true)
                MessageBox.Show("该对象没有文档文件", "提示");
                RefreshFlag = "文档";
            }
            if (FJflag == "照片")
            {
                string sqlCount = "select ZPCount from JCRFJ where JCRsfz='" + getSFZ + "'";
                string sqlTable = "select JCRname as 姓名,JCRsfz as 身份证号,ZPname as 文件名,ZPAddTime as 添加时间 from FJZP where JCRsfz='" + getSFZ + "' and ZPdellogo='0'";
                bool re=queryMethod(sqlCount, sqlTable);
                if (re != true)
                    MessageBox.Show("该对象没有照片文件","提示");
                RefreshFlag = "照片";
            }
            if (FJflag == "视频")
            {
                string sqlCount = "select SPCount from JCRFJ where JCRsfz='" + getSFZ + "'";
                string sqlTable = "select JCRname as 姓名,JCRsfz as 身份证号,SPname as 文件名,SPAddTime as 添加时间 from FJSP where JCRsfz='" + getSFZ + "' and SPdellogo='0'";
               bool re= queryMethod(sqlCount, sqlTable);
                if (re == false)
                    MessageBox.Show("该对象没有视频文件","提示");
                RefreshFlag = "视频";
            }
            if (FJflag == "音频")
            {
                string sqlCount = "select YYCount from JCRFJ where JCRsfz='" + getSFZ + "'";
                string sqlTable = "select JCRname as 姓名,JCRsfz as 身份证号,YYname as 文件名,YYAddTime as 添加时间 from FJYY where JCRsfz='" + getSFZ + "' and YYdellogo='0'";
                bool re = queryMethod(sqlCount, sqlTable);
                if(re==false)
                MessageBox.Show("该对象没有音频文件","提示");
                RefreshFlag = "音频";
            }
        }
        //查询附件方法
        public bool queryMethod(string sqlCount, string sqlTable)
        {
            //获取该对象文档数量的数量

            string countStr = sqlMethod(sqlCount, 1);
            if (Convert.ToInt32(countStr) == 0)
            {
                return false;
            }
            sqlMethod(sqlTable, 0);
            return true;
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
                        dataGridWD.DataSource = ds.Tables["dt"];
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
        //确定按钮
        private void btnSrue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //添加右键菜单
        private void dataGridWD_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    if (dataGridWD.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridWD.ClearSelection();
                        dataGridWD.Rows[e.RowIndex].Selected = true;
                    }
                    if (dataGridWD.SelectedRows.Count == 1)
                    {
                        dataGridWD.CurrentCell = dataGridWD.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出菜单
                    if (Login.limit == "2")
                    {
                        DCThisFJ.Visible = false;
                        DelThisFJ.Visible = false;
                    }
                    WDrightMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
        //删除附件
        private void DelThisFJ_Click(object sender, EventArgs e)
        {
            delPwd DP = new delPwd();
            DP.ShowDialog();
            if (DP.rightYH != "1")
                return;
            string delJCRsfz = dataGridWD[1, dataGridWD.CurrentCell.RowIndex].Value.ToString();
            string delName = dataGridWD[2, dataGridWD.CurrentCell.RowIndex].Value.ToString();
            if (FJflag == "文档")
            {
                string sql = "update FJWD set WDdellogo='1' where JCRsfz='" + delJCRsfz + "' and WDname='" + delName + "'";
                string re = sqlMethod(sql, 2);
                if (re == "-1")
                { MessageBox.Show("删除失败", "提示"); return; }
                else
                MessageBox.Show("删除成功", "提示");
                string sqlCount = "select WDCount from JCRFJ where JCRsfz='" + getSFZ + "'";
                string sqlTable = "select JCRname as 姓名,JCRsfz as 身份证号, WDname as 文件名,WDAddTime as 添加时间 from FJWD where JCRsfz='" + getSFZ + "' and WDdellogo='0' ";
                if (queryMethod(sqlCount, sqlTable) == false)
                {
                    MessageBox.Show("已无更多附件显示", "提示");
                    return;
                }
            }
            if (FJflag == "照片")
            {
                string sql = "update FJZP set ZPdellogo='1' where JCRsfz='" + delJCRsfz + "' and ZPname='" + delName + "'";
                string re = sqlMethod(sql, 2);
                if (re == "-1")
                { MessageBox.Show("删除失败", "提示"); return; }
                else
                MessageBox.Show("删除成功", "提示");
                string sqlCount = "select ZPCount from JCRFJ where JCRsfz='" + getSFZ + "'";
                string sqlTable = "select JCRname as 姓名,JCRsfz as 身份证号, ZPname as 文件名,ZPAddTime as 添加时间 from FJZP where JCRsfz='" + getSFZ + "' and ZPdellogo='0' ";
                if (queryMethod(sqlCount, sqlTable) == false)
                {
                    MessageBox.Show("已无更多附件显示", "提示");
                    return;
                }
            }
            if (FJflag == "视频")
            {
                string sql = "update FJSP set SPdellogo='1' where JCRsfz='" + delJCRsfz + "' and SPname='" + delName + "'";
                string re = sqlMethod(sql, 2);
                if (re == "-1")
                { MessageBox.Show("删除失败", "提示"); return; }
                else
                MessageBox.Show("删除成功", "提示");
                string sqlCount = "select SPCount from JCRFJ where JCRsfz='" + getSFZ + "'";
                string sqlTable = "select JCRname as 姓名,JCRsfz as 身份证号, SPname as 文件名,SPAddTime as 添加时间 from FJSP where JCRsfz='" + getSFZ + "' and SPdellogo='0' ";
                if (queryMethod(sqlCount, sqlTable) == false)
                {
                    MessageBox.Show("已无更多附件显示", "提示");
                    return;
                }
            }
            if (FJflag == "音频")
            {
                string sql = "update FJYY set YYdellogo='1' where JCRsfz='" + delJCRsfz + "' and YYname='" + delName + "'";
                string re = sqlMethod(sql, 2);
                if (re == "-1")
                { MessageBox.Show("删除失败", "提示"); return; }
                else
                MessageBox.Show("删除成功", "提示");
                string sqlCount = "select YYCount from JCRFJ where JCRsfz='" + getSFZ + "'";
                string sqlTable = "select JCRname as 姓名,JCRsfz as 身份证号, YYname as 文件名,YYAddTime as 添加时间 from FJYY where JCRsfz='" + getSFZ + "' and YYdellogo='0' ";
                if (queryMethod(sqlCount, sqlTable) == false)
                {
                    MessageBox.Show("已无更多附件显示", "提示");
                    return;
                }
            }
        }
        /// <summary>
        /// 打开文件方法
        /// </summary>
        /// <param name="path">存储文件路径的字段名</param>
        /// <param name="whereName">查找的条件字段</param>
        /// <param name="tabelName">查找的表名</param>
        private void OpenFJMethod(string path, string whereName, string tabelName)
        {
            //拿到文件名
            string getWJM = dataGridWD[2, dataGridWD.CurrentCell.RowIndex].Value.ToString();
            string sql = "select " + path + " from " + tabelName + " where " + whereName + "='" + getWJM + "' ";
            string getPath = sqlMethod(sql, 1);
            if (getPath == null)
                return;
            ////获得后缀名的在文件名的索引
            //int index = getWJM.IndexOf(".");
            ////获得文件后缀名
            //string getHZM = getWJM.Substring(index);
            Process Pr = new Process();
            Process.Start(getPath);
        }

        private void OpenThisFJ_Click(object sender, EventArgs e)
        {
            if (FJflag == "文档")
            {
                OpenFJMethod("WDpath", "WDname", "FJWD");
            }
            if (FJflag == "照片")
            {
                OpenFJMethod("ZPpath", "ZPname", "FJZP");
            }
            if (FJflag == "视频")
            {
                OpenFJMethod("SPpath", "SPname", "FJSP");
            }
            if (FJflag == "音频")
            {
                OpenFJMethod("YYpath", "YYname", "FJYY");
            }
        }
        //导出附件
        private void DCThisFJ_Click(object sender, EventArgs e)
        {
            if (FJflag == "文档")
            {
                bool re=DCFJMethod("WDPath", "FJWD", "WDname");
                if (re == false)
                {
                    MessageBox.Show("导出失败","提示");
                }
                else
                MessageBox.Show("导出成功","提示");
            }
            if (FJflag == "视频")
            {
                bool re = DCFJMethod("SPpath", "FJSP", "SPname");
                if (re == false)
                {
                    MessageBox.Show("导出失败", "提示");
                }
                else
                    MessageBox.Show("导出成功", "提示");

            }
            if (FJflag == "照片")
            {
                bool re = DCFJMethod("ZPPath", "FJZP", "ZPname");
                if (re == false)
                {
                    MessageBox.Show("导出失败", "提示");
                }
                else
                    MessageBox.Show("导出成功", "提示");
            }
            if (FJflag == "音频")
            {
                bool re = DCFJMethod("YYPath", "FJYY", "YYname");
                if (re == false)
                {
                    MessageBox.Show("导出失败", "提示");
                }
                else
                    MessageBox.Show("导出成功", "提示");
            }
        }
        //导出附件方法
        private bool DCFJMethod(string SourceField,string SourceTable,string SourceFileName)
        {
            
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            //设置初始目录
            FBD.RootFolder = System.Environment.SpecialFolder.Desktop;
            FBD.Description = "选择导出地址";
            if (FBD.ShowDialog() != DialogResult.OK)
            { return false; }
            //拿到选择的目标路径
           DCTargetPath= FBD.SelectedPath.ToString();           
            string getWJM = dataGridWD[2, dataGridWD.CurrentCell.RowIndex].Value.ToString();
            //拿到文件原路径
            string sql = "select " + SourceField + " from " + SourceTable + " where JCRsfz='" + getSFZ + "' and " + SourceFileName + "='" + getWJM + "'";
            string DCSourcePath = sqlMethod(sql, 1);
            if (DCSourcePath == null && DCSourcePath == "")
                return false;
            DCTargetPath += "\\" + getWJM;
            try
            {
                File.Copy(DCSourcePath,DCTargetPath);           
                return true;
            }
            catch { return false; }

        }

        private void dataGridWD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FJflag == "文档")
            {
                OpenFJMethod("WDpath", "WDname", "FJWD");
            }
            if (FJflag == "照片")
            {
                OpenFJMethod("ZPpath", "ZPname", "FJZP");
            }
            if (FJflag == "视频")
            {
                OpenFJMethod("SPpath", "SPname", "FJSP");
            }
            if (FJflag == "音频")
            {
                OpenFJMethod("YYpath", "YYname", "FJYY");
            }
        }
    }
}
