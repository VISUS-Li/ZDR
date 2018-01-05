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
using System.IO;

namespace ZDRJC2
{
    public partial class sqlSJ : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public sqlSJ()
        {
            InitializeComponent();
        }
        //存储姓名
        public string sqlName
        { set; get; }
        //存储身份证
        public string sqlSFZ
        { set; get; }
        
        private void sqlSJ_Load(object sender, EventArgs e)
        {           
            getName.Text = sqlName;
            getSFZ.Text = sqlSFZ;


            //如果不是在查询的地方打开的该窗体
            if (sqlName == null || sqlSFZ == null )
            {              
                alreadySql.Checked = false;
                sqlConditon.Checked = true;

            }
            else
            {
                alreadySql.Checked = true;
                sqlConditon.Checked = false;
                #region 关闭选择框
                //checkName.Enabled = false;
                //checkSFZ.Enabled = false;
                //checkTime.Enabled = false;
                //checkDD.Enabled = false;
                //checkCYRW.Enabled = false;
                //checkGJC.Enabled = false;
                //checkDJ.Enabled = false;
                //checkXS.Enabled = false;
                getName.ReadOnly = true;
                getSFZ.ReadOnly = true;
                getTime.ReadOnly = true;
                getDD.ReadOnly = true;
                getCYRW.ReadOnly = true;
                getJB.ReadOnly = true;
                getGJC.ReadOnly = true;
                //getXS.ReadOnly = true;

                #endregion
                string sql = "select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJjb as 级别,SJxs as 事件详细信息  ,SJguid as 事件编号 from JCRSJXX where JCRsfz='" + sqlSFZ + "' and SJdellogo='0'";
                sqlMethod(sql, 0);
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
        //已有对象查询选择
        private void alreadySql_CheckedChanged(object sender, EventArgs e)
        {
            if (alreadySql.Checked == true)
            {
              
                #region 关闭选择框
                //checkName.Enabled = false;
                //checkSFZ.Enabled = false;
                //checkTime.Enabled = false;
                //checkDD.Enabled = false;
                //checkCYRW.Enabled = false;
                //checkGJC.Enabled = false;
                //checkDJ.Enabled = false;
                //checkXS.Enabled = false;
                getName.ReadOnly = true;
                getSFZ.ReadOnly = true;
                getTime.ReadOnly = true;
                getDD.ReadOnly = true;
                getCYRW.ReadOnly = true;
                getJB.ReadOnly = true;
                getGJC.ReadOnly = true;
                //getXS.ReadOnly = true;
                #endregion
            }
           else
            { return; }
        }
        //条件查询
        private void sqlConditon_CheckedChanged(object sender, EventArgs e)
        {
            if (sqlConditon.Checked == true)
            {   
                             
                #region 打开选项
                //checkName.Enabled = true;
                //checkSFZ.Enabled = true;
                //checkTime.Enabled = true;
                //checkDD.Enabled = true;
                //checkCYRW.Enabled = true;
                //checkGJC.Enabled = true;
                //checkDJ.Enabled = true;
                //checkXS.Enabled = true;
                getName.ReadOnly = false;
                getSFZ.ReadOnly = false;
                getTime.ReadOnly = false;
                getDD.ReadOnly = false;
                getCYRW.ReadOnly = false;
                getGJC.ReadOnly = false;
                getJB.ReadOnly = false;
                //getXS.ReadOnly = false;
                #endregion
                getName.Clear();
                getSFZ.Clear();
                getTime.Clear();
                getDD.Clear();
                getCYRW.Clear();
                getGJC.Clear();
            }
        }
        //查询方法
        public void sqlSJMethod()
        {
            string sql;
            if (sqlConditon.Checked == true)
            {
                sql = "select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJxs as 事件详细信息, SJguid as 事件编号 ,SJAddTime as 添加时间 from JCRSJXX where SJdellogo='0' ";
                sqlMethod(sql, 0);
            }
            sql = "select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJxs as 事件详细信息, SJguid as 事件编号 ,SJAddTime as 添加时间 from JCRSJXX where 1=1 and SJdellogo='0' ";
            //if (checkName.Checked == false && checkSFZ.Checked == false && checkTime.Checked == false && checkDD.Checked == false && checkCYRW.Checked == false && checkGJC.Checked == false
            //    && checkDJ.Checked == false && checkXS.Checked == false)
            //{
            //    MessageBox.Show("请至少选择一项", "提示");
            //}
            //else
            //{
                //姓名
                if (getName.Text.Trim()!="")
                {  
                    sql += " and JCRname like '%" + getName.Text.Trim() + "%'";
                }
                if (getSFZ.Text.Trim()!="")
                {  
                    sql += " and JCRsfz like '%" + getSFZ.Text.Trim() + "%'";
                }
                if (getTime.Text.Trim()!="")
                {
                  sql += " and SJsj  like '%" + getTime.Text.Trim() + "%'";
                }
                if (getDD.Text.Trim()!="")
                {
                   sql += " and SJdd like '%" + getDD.Text.Trim() + "%'";
                }
            if (getCYRW.Text.Trim()!="")
                {
                  sql += " and SJcyrw like '%" + getCYRW.Text.Trim() + "%'";
                }
                if (getGJC.Text.Trim()!="")
                {
                  sql += " and SJgjc like '%" + getGJC.Text.Trim() + "%' or SJxs like '%" + getGJC.Text.Trim() + "%' ";
                }
                if (getJB.Text.Trim()!="")
                {
                    sql += " and SJjb like '%" + getJB.Text.Trim() + "%'";
                }
                //if (getXS.Text.Trim()!="")
                //{
                //    sql += " and SJxs like '%" + getXS.Text.Trim() + "%";
                //}

                string result = sqlMethod(sql, 0);
                if (result == "-1")
                {
                //dataGridView1.DataSource = null;
                    MessageBox.Show("无相关人员信息", "提示");
                    sql = "";
                }
                else
                {
                    sql = "";
                }
            //}
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            //if (sqlConditon.Checked == false)
            //    MessageBox.Show("请先选择条件查询选项", "提示");
            //else
            //{
                try
                {
                    sqlSJMethod();
                }
                catch { }
           // }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //删除事件
        private void btnDelSJ_Click(object sender, EventArgs e)
        {
            //delSJMethod();
        }
        //删除事件的方法
        public void delSJMethod()
        {
            if (dataGridView1.CurrentCell == null)
                MessageBox.Show("请选择要删除的事件", "提示");
            else
            {
                string selSJ = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                string sfz = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                if (selSJ == null)
                    MessageBox.Show("请选择要删除的事件");
                else
                {
                    string sql = "update JCRSJXX set SJdellogo ='1' where SJguid='" + selSJ + "'";
                    if (sqlMethod(sql, 2) != "-1")
                    {
                        MessageBox.Show("删除成功", "提示");
                        sql = "select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJjb as 级别,SJxs as 事件详细信息,  SJguid as 事件编号 from JCRSJXX where 1 = 1 and SJdellogo = '0'" +
                            " and JCRsfz='"+sfz+"'";
                      
                            sqlMethod(sql, 0); 
                       
                    }

                    else
                        MessageBox.Show("删除失败", "提示");


                }
            }
        }
        private int[] RowCount()
        {

            string[] ss = new string[dataGridView1.SelectedCells.Count];

            for (int i = dataGridView1.SelectedCells.Count - 1; i >= 0; i--)
            {
                ss[i] = dataGridView1.SelectedCells[i].RowIndex.ToString();
            }
            string[] ssNo = ss.Distinct().ToArray();
            int[] ssInt = new int[ssNo.Length];
            for (int j = 0; j < ssNo.Length; j++)
            {
                ssInt[j] = Convert.ToInt32(ssNo[j]);
            }
            return ssInt;
        }

        //集合存储要导出的人的身份证
        List<string> DCinfo = new List<string>();

        //右键
        #region 右键
        //添加右键显示
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //点击左键直接return
            if (e.Button == MouseButtons.Left)
                return;
            //当前行未选择
            if (dataGridView1.Rows[e.RowIndex].Selected == false)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
            int[] ssInt = RowCount();
            //将选中的行的身份证给DCinfo集合
            for (int i = 0; i < ssInt.Length; i++)
            {
                DCinfo.Add(dataGridView1[1, ssInt[i]].ToString());
            }
            #region 只选择了一行
            if (ssInt.Length <= 1)
            {

                btnDCSJ_one.Visible = true;
                btnDCSJ_Selected.Visible = false;
                //权限不够
                if (Login.limit == "2")
                {
                    //dataGridView1.Show(MousePosition.X, MousePosition.Y);
                    return;
                }
                else
                {
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }

            }
            #endregion
            else
            {
                if (e.Button == MouseButtons.Left)
                    return;
                for (int i = ssInt.Length - 1; i >= 0; i--)
                {
                    dataGridView1.Rows[ssInt[i]].Selected = true;
                }
                btnDCSJ_one.Visible = false;
                btnDCSJ_Selected.Visible = true;
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }

            //if (e.Button == MouseButtons.Right)
            //{
            //    if (e.RowIndex >= 0)
            //    {
            //        //如果没有选择该行，选择该行
            //        if (dataGridView1.Rows[e.RowIndex].Selected == false)
            //        {
            //            dataGridView1.ClearSelection();
            //            dataGridView1.Rows[e.RowIndex].Selected = true;
            //        }
            //        //只选择其中一行时设置单元格
            //        if (dataGridView1.SelectedRows.Count == 1)
            //        {
            //            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //        }
            //        sqlSJMenu.Show(MousePosition.X, MousePosition.Y);
            //    }

            //}
        }
            //删除事件
        private void delSJ_Click(object sender, EventArgs e)
        {
            string selSJ = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string sfz = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string sql = "update JCRSJXX set SJdellogo ='1' where SJguid='" + selSJ + "'";
            if (sqlMethod(sql, 2) != "-1")
            {
                MessageBox.Show("删除成功", "提示");
                sql = "select JCRname as 姓名,JCRsfz as 身份证, SJsj as 时间,SJdd as 地点,SJcyrw as 参与人物,SJgjc as 关键词,SJxs as 事件详细信息,  SJguid as 事件编号 from JCRSJXX where 1 = 1 and SJdellogo = '0'" +
                    " and JCRsfz='" + sfz + "'";

                sqlMethod(sql, 0);

            }

            else
                MessageBox.Show("删除失败", "提示");
        }


        #endregion
        private string info(string value, string sfz)
        {
            string sql = "select ";
            switch (value)
            {
                case "name": sql += " JCRname ";break;
                case "sfz":sql += " JCRsfz ";break;
                case "SJ":sql += " SJsj ";break;
                case "DD":sql += " SJdd ";break;
                case "CYRW":sql += " SJcyrw ";break;
                case "GJC":sql += " SJgjc ";break;
                case "XS":sql += " SJxs ";break;
            }
            sql += " from JCRSJXX where SJguid='" + sfz + "'";
            string re = sqlMethod(sql, 1);
            return re;
        }

        /// <summary>
        /// 导出单个事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool DCSJ_noeRow(int flag, string path, string sfz)
        {
            string name = info("name", sfz);
            string SJ = info("SJ", sfz);
            string DD = info("DD", sfz);
            string CYRW = info("CYRW", sfz);
            string GJC = info("GJC", sfz);
            string XS = info("XS", sfz);

            try
            {               
                //如果传入参数为1，表示在新文件中导入信息，否则表示在同一文件导入信息
                if (flag == 1)
                {
                    File.Copy(Environment.CurrentDirectory + "\\SheetMode\\SJ_mode.xls", path);
                }
                string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand();
                    comm.Connection = conn;
                    string sql = "insert into [Sheet1$](姓名,身份证号,时间,地点,参与人物,关键词,事件详细信息) values('" + name + "','" + sfz + "','" + SJ + "','" + DD + "','" + CYRW + "','" + GJC + "','" + XS + "')";
                    comm.CommandText = sql;
                    try
                    {
                        comm.ExecuteNonQuery();
                        return true;
                    }
                    catch { return false; }

                }
            }
            catch { return false; }
        }

        private bool DCSJ_selected( string path, List<string> sfz)
        {
            //第一次导出在新文件中导入           
            bool res = DCSJ_noeRow(1,path,sfz[0]);
            if (res == false)
                return false;
            foreach (string item in sfz)
            {
                //保证第一个不重复
                if (item == sfz[0])
                { continue; }
                //调用单行导出依次导出每一行信息              
                bool re = DCSJ_noeRow(2,path,item);
                if (re == false)
                    return false;
            }
            return true;
        }



        private void btnDCSJ_one_Click(object sender, EventArgs e)
        {

            delPwd DP = new delPwd();
            DP.Show();
            if (DP.rightYH != "1")
                return;
            //List<int> RowsIndex = new List<int>();
            //for (int j = dataGridView1.SelectedRows.Count - 1; j >= 0; j--)
            //{
            //    RowsIndex.Add(dataGridView1.SelectedRows[j].Index);
            //}
            //获得要导出的对象的身份证集合
            List<string> listSFZ = new List<string>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {              
                string sqlguid="select SJguid from JCRSJXX where JCRsfz='"+ dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString() + "'";
                string getGuid = sqlMethod(sqlguid, 1);
                listSFZ.Add(getGuid);
            }
            string path = "";
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "选择存储地址";
            SFD.Filter = "Excel文件|*.xls";
            bool re = false;
            SFD.FileName = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" +
                DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "SJ";
            //SFD.ShowDialog();
            if (SFD.ShowDialog() == DialogResult.Cancel)
            { return; }
            path = SFD.FileName;
            re = DCSJ_selected(path, listSFZ);
            if (re == true)
            {
                MessageBox.Show("导出成功!", "提示");
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("导出失败!", "提示");
                dataGridView1.ClearSelection();
            }
        }

        private void btnDCSJ_Selected_Click(object sender, EventArgs e)
        {
            delPwd DP = new delPwd();
            DP.Show();
            if (DP.rightYH != "1")
                return;
            List<string> listSFZ = new List<string>();
            List<int> RowsIndex = new List<int>();//记录选中行的集合
            //MessageBox.Show(sqlDataView.SelectedRows[1].Index.ToString());
            for (int j = dataGridView1.SelectedRows.Count - 1; j >= 0; j--)
            {
                RowsIndex.Add(dataGridView1.SelectedRows[j].Index);
            }

            foreach (int item in RowsIndex)
            {
                try
                {
                   
                    //listSFZ.Add(dataGridView1[1, item].Value.ToString());
                    //string sqlguid = "select SJguid from JCRSJXX where JCRsfz='" + dataGridView1[1,item].Value.ToString()+ "'";
                    //string getGuid = sqlMethod(sqlguid, 1);
                    listSFZ.Add(dataGridView1[8,item].Value.ToString());
                }
                catch
                { MessageBox.Show("请勿选择空行", "提示"); return; }
            }
            string path = "";
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "选择存储地址";
            SFD.Filter = "Excel文件|*.xls";
            bool re = false;
            SFD.FileName = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" +
                DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "SJ";
            //SFD.ShowDialog();
            if (SFD.ShowDialog() == DialogResult.Cancel)
            { return; }
            path = SFD.FileName;
            re = DCSJ_selected(path, listSFZ);
            if (re == true)
            {
                MessageBox.Show("导出成功!", "提示");
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("导出失败!", "提示");
                dataGridView1.ClearSelection();
            }
        }
    }
}
