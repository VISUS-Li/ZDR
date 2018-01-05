using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ZDRJC2
{
    public partial class newJCR : Form
    {
        //数据库连接字符串
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb";
        public newJCR()
        {
            InitializeComponent();
        }
        #region 字段
        //添加时输入的身份证号
        public static string addingSFZ
        { set; get; }
        //添加时输入的姓名
        public static string addingName
        { set; get; }
        //人员guid
        public string JCRguid
        { set; get; }
        //照片guid
        public static string photoGuid
        { set; get; }
        //人员出生年月
        public string birth
        { set; get; }
        //人员年龄
        public string age
        { set; get; }


        
        //存储照片临时目录
        public string pathTemp
        { set; get; }
        //判断必填项是否填完
        private int textCount = 0;
        //判断是否经过恢复的过程
        private int recoverCount = 0;
        #endregion
        #region 监测人字段,用于做下拉框
        //籍贯
        public string JG
        { set; get; }
        //身份
        public string SF
        { set; get; }
        //方言
        public string FY
        { set; get; }
        //宗教信仰
        public string ZJXY
        { set; get; }
        //思想等级
        public string SXDJ
        { set; get; }
        //列控单位
        public string LKDW
        { set; get; }
        //民族
        public string MZ
        { set; get; }
        //经济状况
        public string JJZK
        { set; get; }
        //现状
        public string XZ
        { set; get; }
        //政治面貌
        public string ZZMM
        { set; get; }
        //分类
        public string FL
        { set; get; }
        //列控级别
        public string LKJB
        { set; get; }
        //毕业院校
        public string BYYX
        { set; get; }
        //户籍所在地
        public string HJSZD
        { set; get; }
        //现居住地
        public string XJZD
        { set; get; }
        //工作单位
        public string GZDW
        { set; get; }
        //职业
        public string ZY
        { set; get; }
        #endregion
        //加载“添加监测人”界面
        private void newJCR_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i >= 1949; i--)
            {
                year.Items.Add(i);
            }
            #region 一大堆下拉框来袭/获取以前输入过的数据
            //籍贯下拉框
            string sql = "select distinct JCRJG from JCRJBXX";
            getComInfo(sql, comJG);
            //民族
            sql = "select distinct JCRnation from JCRJBXX";
            getComInfo(sql, comMZ);
            //分类
            sql = "select distinct JCRfl from JCRJBXX";
            getComInfo(sql, comFL);                          
            //列控单位
            sql = "select distinct JCRlkdw from JCRJBXX";
            getComInfo(sql, comLKDW);
          
            //经济状况
            sql = "select distinct JCRjjzk from JCRJBXX";
            getComInfo(sql, comJJZK);
          
            //列控级别
            sql = "select distinct JCRlkjb from JCRJBXX";
            getComInfo(sql, comLKJB);
            //毕业院校
            sql = "select distinct JCRbyyx from JCRJBXX";
            getComInfo(sql, comBYYX);
            //户籍所在地
            sql = "select distinct JCRhjszd from JCRJBXX";
            getComInfo(sql, comHJSZD);
            //现居住地
            sql = "select distinct JCRxjzd from JCRJBXX";
            getComInfo(sql, comXJZD);
            //工作单位
            sql = "select distinct JCRgzdw from JCRJBXX";
            getComInfo(sql, comGZDW);
            //职业
            sql = "select distinct JCRzy from JCRJBXX";
            getComInfo(sql, comZY);
            #endregion

        }
        #region 添加年月日
        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            month.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                month.Items.Add(i);
            }
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            day.Items.Clear();
            int tempDay;
            int tempMonth = month.SelectedIndex;
            int tempYear = year.SelectedIndex;
            switch (tempMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    tempDay = 31;
                    break;

                case 2:
                    if (tempYear % 400 == 0 || (tempYear % 4 == 0 && tempYear % 100 != 0))
                    {
                        tempDay = 29;
                        break;
                    }
                    else
                    {
                        tempDay = 28;
                        break;
                    }
                default:
                    tempDay = 30;
                    break;
            }
            for (int j = 1; j <= tempDay; j++)
            {
                day.Items.Add(j);
            }
        }
        #endregion

        //取消按钮
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        addSJ_Sql AS = new addSJ_Sql();


        //保存
        private void btnsave_Click(object sender, EventArgs e)
        {   //必填框是否填完       
            if (MonComNull() != 0)
            {
                return;
            }
            //将值赋予属性
            MonComText();

#region 向数据库添加信息
            if (jcrname.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空", "提示");              
                jcrname.Focus();
                return;
            }           
                string sqlJCRexist = "select JCRsfz from JCRJBXX where JCRsfz='" + JCRSFZ.Text.Trim() + "'";
                string exResult = getInfo(sqlJCRexist);
                    //object exResult = comm.ExecuteScalar();
                    //查询是否被删除标志
                    sqlJCRexist = "select JCRdellogo from JCRJBXX where JCRsfz='" + JCRSFZ.Text.Trim() + "'";
                    string res = getInfo(sqlJCRexist);

            if (exResult == "-1" || res == "1" )
                //不存在这个监测人,可以添加
                {
                   if (res == "1"&&recoverCount==0)
                   {
                    string sqlDEL = "delete * from JCRJBXX where JCRsfz='" + JCRSFZ.Text.Trim() + "'";
                    in_up_SQL(sqlDEL);
                   }

                    #region 插入数据
                    //获得出生年月
                    birth = year.SelectedItem.ToString() + "-" + month.SelectedItem.ToString() + "-" + day.SelectedItem.ToString();
                    //计算年龄
                    int stuAge;
                    if (Convert.ToInt32(month.SelectedItem) <= Convert.ToInt32(DateTime.Now.Month))
                    {
                        stuAge = (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(year.SelectedItem)) ;

                    }
                    else
                        stuAge = (Convert.ToInt32(year.SelectedItem) - Convert.ToInt32(DateTime.Now.Year)) -1;

                    //获取当前时间
                    JCRguid = Guid.NewGuid().ToString();
                    string dateNow = DateTime.Now.ToString();
                    string sql = "insert into" +
                    " JCRJBXX(JCRnl,JCRbrith,JCRid,JCRname,JCRsex,JCRnation,JCRpolity,JCRxjzd,JCRsfz,JCRyddh,JCRfl,JCRjg,JCRlkdw,JCRjjzk,JCRlkjb,JCRbyyx,JCRhjszd,JCRgzdw,JCRzy,JCRgxry,JCRgddh,JCRbz,JCRqq,JCRwx,JCRdzyj,JCRgrjl,JCRzpbh,JCRdellogo,JCRAddTime)"
                            + "  values('" + stuAge.ToString() + "','" + birth + "','" + JCRguid + "','" + jcrname.Text.Trim() + "','" + jcrsex.SelectedItem.ToString() + "','" + MZ + "','" + ZZMM + "','" + XJZD + "','" + JCRSFZ.Text + "','"
                            + JCRYDDH.Text + "','" + FL + "','" + JG + "','" + LKDW + "','" +
                            JJZK + "','" + LKJB + "','" + BYYX + "','" + HJSZD + "','" + GZDW + "','" + ZY + "','" + JCRGXRY.Text.Trim() + "','" + JCRGDDH.Text.Trim()
                          + "','"+JCRbz.Text.Trim()+"','" + JCRQQ.Text.Trim() + "','" + JCRWX.Text.Trim() + "','" + JCRDZYJ.Text.Trim() + "','" + JCRGRJL.Text.Trim() + "','0','0','" + dateNow + "')";
                
                    bool inResult = in_up_SQL(sql);
                    if (inResult == true)
                    {
                        //没有照片
                        if (jcrphoto.Image == null)
                        {
                            sql = "update JCRJBXX set JCRzpbh='0' where JCRsfz='" + JCRSFZ.Text.Trim() + "'";
                            in_up_SQL(sql);
                            recoverCount = 0;
                            MessageBox.Show("添加成功", "提示");
                        }
                        //有照片
                        else
                        {
                            photoGuid = Guid.NewGuid().ToString();
                            sql = "update JCRJBXX set JCRzpbh='" + photoGuid + ".jpg" + "' where JCRid='" + JCRSFZ.Text.Trim() + "' ";
                            //comm.CommandText = sql;
                            //int result = comm.ExecuteNonQuery();
                            bool result = in_up_SQL(sql);
                            if (result == true)
                            {
                                //将图片移动到JCRphoto文件夹
                                movePhoto(pathTemp);
                                recoverCount = 0;
                                MessageBox.Show("添加成功", "提示");                             
                                return;
                            }                          
                            else
                            {   //重置照片状态为无
                                sql = "update JCRJBXX set JCRzpbh='0' where JCRsfz='" + JCRSFZ.Text.Trim() + "'";
                                in_up_SQL(sql);
                                recoverCount = 0;
                                MessageBox.Show("添加失败", "提示");
                            }
                        }
                    }//if
                    else
                    {
                        sql = "delete * from JCRJBXX where JCRsfz='" + JCRSFZ.Text.Trim() + "'";
                        in_up_SQL(sql);
                        recoverCount = 0;
                        MessageBox.Show("添加失败", "提示");
                    }               
                    #endregion
                  //}
                }              
                    else
                    {
                        recoverCount = 0;
                        MessageBox.Show("已存在该身份证号", "提示");
                        jcrname.Focus();
                    }
#endregion                           
        }//btnsave

        //保存按钮的插入方法
        private void saveInertMethod()
        {
            birth = year.SelectedItem.ToString() + "-" + month.SelectedItem.ToString() + "-" + day.SelectedItem.ToString();
            //计算年龄
            int stuAge;
            if (Convert.ToInt32(month.SelectedItem) <= Convert.ToInt32(DateTime.Now.Month))
            {
                stuAge = (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(year.SelectedItem)) + 1;

            }
            else
                stuAge = (Convert.ToInt32(year.SelectedItem) - Convert.ToInt32(DateTime.Now.Year)) + 2;

            //获取当前时间
            string dateNow = DateTime.Now.ToString();
            string sql = "insert into" +
            " JCRJBXX(JCRnl,JCRbrith,JCRid,JCRname,JCRsex,JCRnation,JCRpolity,JCRxjzd,JCRsfz,JCRyddh,JCRfl,JCRjg,JCRlkdw,JCRjjzk,JCRlkjb,JCRbyyx,JCRhjszd,JCRgzdw,JCRzy,JCRgxry,JCRgddh,JCRqq,JCRwx,JCRdzyj,JCRgrjl,JCRzpbh,JCRdellog,JCRAddTime)"
                    + "  values('" + stuAge.ToString() + "','" + birth + "','" + JCRguid + "','" + jcrname.Text.Trim() + "','" + jcrsex.SelectedItem.ToString() + "','" + MZ + "','" + comZZMM.SelectedItem.ToString() + "','" + XJZD + "','" + JCRSFZ.Text + "','"
                    + JCRYDDH.Text + "','" + FL + "','" + JG + "','" + LKDW + "','" +
                    JJZK + "','" + LKJB + "','" + BYYX + "','" + HJSZD + "','" + GZDW + "','" + ZY + "','" + JCRGXRY.Text.Trim() + "','" + JCRGDDH.Text.Trim()
                  + "','" + JCRQQ.Text.Trim() + "','" + JCRWX.Text.Trim() + "','" + JCRDZYJ.Text.Trim() + "','" + JCRGRJL.Text.Trim() + "','0','0','" + dateNow + "')";

            //try
            //{
            //comm.CommandText = sql;
            //int inResult = comm.ExecuteNonQuery();
            bool inResult = in_up_SQL(sql);
            if (inResult == true)
            {
                //没有照片
                if (jcrphoto.Image == null)
                {
                    MessageBox.Show("添加成功", "提示");
                }
                //有照片
                else
                {
                    photoGuid = Guid.NewGuid().ToString();
                    sql = "update JCRJBXX set JCRzpbh='" + photoGuid + ".jpg" + "' where JCRid='" + JCRSFZ.Text.Trim() + "' ";
                    //comm.CommandText = sql;
                    //int result = comm.ExecuteNonQuery();
                    bool result = in_up_SQL(sql);
                    if (result == true)
                    {
                        movePhoto(pathTemp);
                        MessageBox.Show("添加成功", "提示");
                        return;
                    }
                    //将图片移动到JCRphoto文件夹
                    else
                    {
                        sql = "update JCRJBXX set JCRzpbh='0' where JCRsfz='" + JCRSFZ.Text.Trim() + "'";
                        in_up_SQL(sql);
                        MessageBox.Show("添加失败", "提示");
                    }
                }
            }//if
            else
            {
                sql = "delete * from JCRJBXX where JCRsfz='" + JCRSFZ.Text.Trim() + "'";
                in_up_SQL(sql);
                MessageBox.Show("添加失败", "提示");
            }
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
                try
                {
                    object result = comm.ExecuteScalar();
                    if (result == null )
                    {
                        return "-1";
                    }
                    else
                    {
                        return result.ToString();
                    }
                }
                catch
                {
                    return "-2";
                }


            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (jcrname.Text.Trim() != "" && JCRSFZ.Text.Trim() != "")
            {
                AS.showName = jcrname.Text.Trim();
                AS.showSFZ = JCRSFZ.Text.Trim();
                AS.ShowDialog();
            }
            else
                MessageBox.Show("请先输入姓名或身份证号", "提示");

        }

        private void jcrname_TextChanged(object sender, EventArgs e)
        {
            //获取输入的名字
            addingName = jcrname.Text.Trim();
        }

        private void addphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择照片";
            ofd.Filter = "图片|*.jpg";
            ofd.ShowDialog();
            pathTemp = ofd.FileName;
            if (pathTemp == "")
            {
                MessageBox.Show("未选择，请重新选择", "提示");
                return;
            }
            jcrphoto.Image = Image.FromFile(pathTemp);

        }
        public void movePhoto(string path)
        {
            try
            {

                //FileInfo move = new FileInfo(path);
                //move.CopyTo(Environment.CurrentDirectory+@"\stuPhoto"+Guid.NewGuid);
                File.Copy(path, Environment.CurrentDirectory + @"\JCRphoto\\" + photoGuid + ".jpg");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "请先改照片文件名后上传");
            }
        }

        private void JCRSFZ_TextChanged(object sender, EventArgs e)
        {
            //获取添加时输入的身份证
            addingSFZ = JCRSFZ.Text.Trim();
        }

        #region 初始化窗体时获取下拉框数据的方法
        public void getComInfo(string sql, ComboBox com)
        {
            // string sql = "select distinct JCRJG from JCRJBXX";
            List<string> list = getTrack(sql);
            foreach (var item in list)
            {
                com.Items.Add(item);
            }


        }
        #endregion
        //用readeradapt依次读取查询的记录
        public List<string> getTrack(string sql)
        {
            List<string> list = new List<string>();
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader myReader = comm.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader[0].ToString());
                }
                return list;
            }
        }


        #region 修改下拉框选项
        /// <summary>
        /// 获取文本框中必填项是否有值
        /// </summary>
        /// <returns>若无值返回的textCount!=0</returns>
        private int MonComNull()
        {
            if (comJG.SelectedItem == null && comJG.Text.Trim() == "")
            {
                MessageBox.Show("请输入籍贯", "提示");
                return ++textCount;
            }                  
            else if (comLKDW.SelectedItem == null && comLKDW.Text.Trim() == "")
            {
                MessageBox.Show("请输入列控单位", "提示");
                return ++textCount;
            }

            else if (comMZ.SelectedItem == null && comMZ.Text.Trim() == "")
            {
                MessageBox.Show("请输入民族", "提示");
                return ++textCount;
            }

            else if (comZZMM.SelectedItem == null && comZZMM.Text.Trim() == "")
            {
                MessageBox.Show("请输入政治面貌", "提示");
                return ++textCount;
            }

            else if (comFL.SelectedItem == null && comFL.Text.Trim() == "")
            {
                MessageBox.Show("请输入分类", "提示");
                return ++textCount;
            }

            else if (comLKJB.SelectedItem == null && comLKJB.Text.Trim() == "")
            {
                MessageBox.Show("请输入列控级别", "提示");
                return ++textCount;
            }
            else if (comHJSZD.SelectedItem == null && comHJSZD.Text.Trim() == "")
            {
                MessageBox.Show("请输入户籍所在地", "提示");
                return ++textCount;
            }
            else if (comXJZD.SelectedItem == null && comXJZD.Text.Trim() == "")
            {
                MessageBox.Show("请输入现居住地", "提示");
                return ++textCount;
            }
            else if (comZY.SelectedItem == null && comZY.Text.Trim() == "")
            {
                MessageBox.Show("请输入职业", "提示");
                return ++textCount;
            }
            else if (jcrsex.SelectedItem == null)
            {
                MessageBox.Show("请选择性别", "提示");
                return ++textCount;
            }
            else if (year.SelectedItem == null)
            {
                MessageBox.Show("请选择年", "提示");
                return ++textCount;
            }
            else if (month.SelectedItem == null)
            {
                MessageBox.Show("请选择月", "提示");
                return ++textCount;
            }
            else if (day.SelectedItem == null)
            {
                MessageBox.Show("请选择天", "提示");
                return ++textCount;
            }
            else if (JCRGRJL.Text.Trim() == "")
            {
                MessageBox.Show("请输入个人简历", "提示");
                return ++textCount;
            }
            else if (JCRGXRY.Text.Trim() == "")
            {
                MessageBox.Show("请输入关系人员", "提示");
                return ++textCount;
            }
            else if (JCRYDDH.Text.Trim() == "")
            {
                MessageBox.Show("请输入移动电话", "提示");
                return ++textCount;
            }
            else
                return textCount = 0;
            
        }
        /// <summary>
        /// 获取文本框中的值
        /// </summary>
        public void MonComText()
        { 
            //籍贯，必填
            if (comJG.SelectedItem != null || comJG.Text.Trim() != "")
            {
                if (comJG.SelectedItem != null)
                    JG = comJG.SelectedItem.ToString();
                else if (comJG.Text.Trim() != "")
                    JG = comJG.Text.Trim();
            }                                   
            //列控单位,必填

            if (comLKDW.SelectedItem != null || comLKDW.Text.Trim() != "")
            {
                if (comLKDW.SelectedItem != null)
                    LKDW = comLKDW.SelectedItem.ToString();
                else
                    LKDW = comLKDW.Text.Trim();
            }

            //民族，必填

            if (comMZ.SelectedItem != null || comMZ.Text.Trim() != "")
            {
                if (comMZ.SelectedItem != null)
                    MZ = comMZ.SelectedItem.ToString();
                else
                    MZ = comMZ.Text.Trim();
            }

            //经济状况，非必填
            if (comJJZK.SelectedItem == null &&comJJZK.Text.Trim() == "")
                JJZK = "无";
            else
            {
                if (comJJZK.SelectedItem != null)
                    JJZK = comJJZK.SelectedItem.ToString();
                else
                    JJZK = comJJZK.Text.Trim();
            }       
            //政治面貌，必填

            if (comZZMM.SelectedItem != null || comZZMM.Text.Trim() != "")
            {
                if (comZZMM.SelectedItem != null)
                    ZZMM = comZZMM.SelectedItem.ToString();
                else
                    ZZMM = comZZMM.Text.Trim();
            }

            //分类,必填

            if (comFL.SelectedItem != null || comFL.Text.Trim() != "")
            {
                if (comFL.SelectedItem != null)
                    FL = comFL.SelectedItem.ToString();
                else
                    FL = comFL.Text.Trim();
            }

            //列控级别，必填

            if (comLKJB.SelectedItem != null || comLKJB.Text.Trim() != "")
            {
                if (comLKJB.SelectedItem != null)
                    LKJB = comLKJB.SelectedItem.ToString();
                else
                    LKJB = comLKJB.Text.Trim();
            }

            //毕业院校，非必填
            if (comBYYX.SelectedItem == null && comBYYX.Text.Trim() == "")
                BYYX = "无";
            else
            {
                if (comBYYX.SelectedItem != null)
                    BYYX = comBYYX.SelectedItem.ToString();
                else
                    BYYX = comBYYX.Text.Trim();
            }

            //户籍所在地，必填

            if (comHJSZD.SelectedItem != null || comHJSZD.Text.Trim() != "")
            {
                if (comHJSZD.SelectedItem != null)
                    HJSZD = comHJSZD.SelectedItem.ToString();
                else
                    HJSZD = comHJSZD.Text.Trim();
            }

            //现居住地，必填

            if (comXJZD.SelectedItem != null || comXJZD.Text.Trim() != "")
            {
                if (comXJZD.SelectedItem != null)
                    XJZD = comXJZD.SelectedItem.ToString();
                else
                    XJZD = comXJZD.Text.Trim();
            }

            //工作单位，非必填
            if (comGZDW.SelectedItem == null && comGZDW.Text.Trim() == "")
                GZDW = "无";
            else
            {
                if (comGZDW.SelectedItem != null)
                    GZDW = comGZDW.SelectedItem.ToString();
                else
                    GZDW = comGZDW.Text.Trim();
            }

            //职业,必填

            if (comZY.SelectedItem != null || comZY.Text.Trim() != "")
            {
                if (comZY.SelectedItem != null)
                    ZY = comZY.SelectedItem.ToString();
                else
                    ZY = comZY.Text.Trim();
            }
            //固定电话，非必填
            if (JCRGDDH.Text.Trim() == "")
            { JCRGDDH.Text = "无"; }      
            //QQ,非必填
            if (JCRQQ.Text.Trim() == "")
                JCRQQ.Text = "无";
            //电子邮件,非必填
            if (JCRDZYJ.Text.Trim() == "")
                JCRDZYJ.Text = "无";
            //微信，非必填
            if (JCRWX.Text.Trim() == "")
                JCRWX.Text = "无";
        }

        #endregion
        //添加附件按钮
        private void btnAddFJ_Click(object sender, EventArgs e)
        {
            if (jcrname.Text.Trim() == "")
            {
                MessageBox.Show("请先输入姓名", "提示");
                return;
            }
            else if (JCRSFZ.Text.Trim() == "")
            {
                MessageBox.Show("请输入身份证号", "提示");
                return;
            }
            AddFJ AF = new AddFJ();
            AF.getInitName = jcrname.Text.Trim();
            AF.getInitSFZ = JCRSFZ.Text.Trim();
            AF.ShowDialog();
        }

        private void comSXDJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
