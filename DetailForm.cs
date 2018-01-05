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
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=true";

        #region SqlForm字段
        public string DePhoto
        { get; set; }
        public string GetName
        { get; set; }
        public string GetSex
        { get; set; }
        public string GetBM
        { get; set; }
        public string GetCYM
        { get; set; }
        public string GetJG
        { get; set; }
        public string GetSF
        { get; set; }
        public string GetFY
        { get; set; }
        public string GetZJXY
        { get; set; }
        public string GetZY
        { get; set; }
        public string GetMZ
        { get; set; }
        public string GetJJZK
        { set; get; }
        public string GetXZ
        { set; get; }
        public string GetSXDJ
        { set; get; }
        public string GetLKDW
        { set; get; }
        public string GetSFZ
        { set; get; }
        public string GetZZMM
        { set; get; }
        public string GetFL
        { set; get; }
        public string GetLKJB
        { set; get; }
        public string GetBYYX
        { get; set; }
        public string GetHJSZD
        { set; get; }
        public string GetXJZD
        { get; set; }
        public string GetGZDW
        { set; get; }
        public string GetGXRY
        { set; get; }
        public string GetBZ
        { set; get; }
        public string GetGRJL
        { get; set; }
        public string GetGDDH
        { get; set; }
        public string GetYDDH
        { get; set; }
        public string GetDZYJ
        { get; set; }
        public string GetBGSDH
        { get; set; }
        public string GetQQ
        { get; set; }
        public string GetWX
        { get; set; }
        #endregion
        //照片路径
        public string photoPath
        { get; set; }
        //是否有照片上传
        private string flag
        { set; get; }
        //存储当前文本的集合
       // List<string> textboxInfoNow = new List<string>();
        //修改按钮
        private void change_Click(object sender, EventArgs e)
        {
            
            if (change.Text == "修改")
            {
                #region 开启修改选择
                //照片
                getPhoto.Enabled = false;
               getAdPhoto.Enabled = false;                     
                //籍贯
                getJG.Enabled = true;
               deJG.ReadOnly = false;                         
                //职业
                getZY.Enabled = true;
               deZY.ReadOnly = false;
                //民族
                getMZ.Enabled = true;
                deMZ.ReadOnly = false;
                //经济状况
                getJJZK.Enabled = true;
                deJJZK.ReadOnly = false;                
                //列控单位
                getLKDW.Enabled = true;
                deLKDW.ReadOnly = false;
                //身份证号
                getSFZ.Enabled = true;
                //政治面貌
                getZZMM.Enabled = true;
                deZZMM.ReadOnly = false;
                //分类
                getFL.Enabled = true;
                deFL.ReadOnly = false;
                //列控级别
                getLKJB.Enabled = true;
                deLKJB.ReadOnly = false;
                //毕业院校
                getBYYX.Enabled = true;
                deBYYX.ReadOnly = false;
                //户籍所在地
                getHJSZD.Enabled = true;
                deHJSZD.ReadOnly = false;
                //现居住地
                getXJZD.Enabled = true;
               deXJZD.ReadOnly = false;
                //工作单位
                getGZDW.Enabled = true;
               deGZDW.ReadOnly = false;
                //关系人员
                getGXRY.Enabled = true;
               deGXRY.ReadOnly = false;
                //个人简历
                getGRJL.Enabled = true;
               deGRJL.ReadOnly = false;
                //备注
                getBZ.Enabled = true;
               deBZ.ReadOnly = false;
                //固定电话
                getGDDH.Enabled = true;
                deGDDH.ReadOnly = false;
                //移动电话
                getYDDH.Enabled = true;
                deYDDH.ReadOnly = false;
                //电子邮件
                getDZYJ.Enabled = true;
                deDZYJ.ReadOnly = false;             
                //QQ
                getQQ.Enabled = true;
                deQQ.ReadOnly = false;
                //微信
                getWX.Enabled = true;
                deWX.ReadOnly = false;
                #endregion
                //MessageBox.Show("请勾选需要修改的信息", "提示");
                change.Text = "取消修改";
                btnSure.Text = "保存";
            }
            else
            {

                #region 关闭修改选择
                //照片
                getPhoto.Enabled = false;              
                //getAdPhoto.Enabled = false;                         
                //籍贯
                getJG.Enabled = false;
                
                deJG.Enabled = false;                               
                //职业
                getZY.Enabled = false;
                deZY.ReadOnly = true;
                //民族
                getMZ.Enabled = false;
                deMZ.ReadOnly = true;
                //经济状况
                getJJZK.Enabled = false;
                deJJZK.ReadOnly = true;
                //列控单位
                getLKDW.Enabled = false;
                deLKDW.ReadOnly = true;
                //身份证号
                getSFZ.Enabled = false;
                deSFZ.ReadOnly = true;
                //政治面貌
                getZZMM.Enabled = false;
                deZZMM.ReadOnly = true;
                //分类
                getFL.Enabled = false;
                deFL.ReadOnly = true;
                //列控级别
                getLKJB.Enabled = false;
                deLKJB.ReadOnly = true;
                //毕业院校
                getBYYX.Enabled = false;
                deBYYX.ReadOnly = true;
                //户籍所在地
                getHJSZD.Enabled = false;
                deHJSZD.ReadOnly = true;
                //现居住地
                getXJZD.Enabled = false;
                deXJZD.ReadOnly = true;
                //工作单位
                getGZDW.Enabled = false;
                deGZDW.ReadOnly = true;
                //关系人员
                getGXRY.Enabled = false;
                deGXRY.ReadOnly = true;
                //个人简历
                getGRJL.Enabled = false;
                deGRJL.ReadOnly = true;
                //备注
                getBZ.Enabled = false;
                deBZ.ReadOnly = true;
                //固定电话
                getGDDH.Enabled = false;
                deGDDH.ReadOnly = true;
                //移动电话
                getYDDH.Enabled = false;
                deYDDH.ReadOnly = true;
                //电子邮件
                getDZYJ.Enabled = false;
                deDZYJ.ReadOnly = true;            
                //QQ
                getQQ.Enabled = false;
                deQQ.ReadOnly = true;
                //微信
                getWX.Enabled = false;
                deWX.ReadOnly = true;
                #endregion
                change.Text = "修改";
                btnSure.Text = "确定";
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
                object result = comm.ExecuteScalar();
                if (result == null||result.ToString()=="0")
                {
                    return "未找到";
                }
                else
                {
                    return result.ToString();
                }

            }
        }
        public string photoGuidExist
            {set;get;}
        //string photoGuidExist = "select JCRzpbh from JCRJBXX where JCRsfz='" + SqlForm.SFZid + "'";
        private void DetailForm_Load(object sender, EventArgs e)
        {
            //判断是修改还是查看
            btnAddSJ.Visible = false;
            if (SqlForm.See_Change == "1")
            {
                change.Visible = false;
            }
            else
            {
                change.Visible = true;
            }

            #region 初始化控件不可用          
            ctrlWiget();
            #endregion
            #region 读取详细信息
            //SqlForm SF = new SqlForm();
            ////获得选取的人的身份证号，用身份证号索引
            //if ( SF.sqlIndex== "")
            //    MessageBox.Show("请选择要查看的人员", "提示");
            //else
            //{
            //    string sqlID = "";
            //    string sql = "";

            //    sqlID = SF.SFZindex;

            //    // SFZid = sqlID;
            //    #region 将详细信息显示出来
            //    //姓名
            //    sql = "select JCRname from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getName.Text = getInfo(sql);
            //    //性别
            //    sql = "select JCRsex from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getSex.Text = getInfo(sql);
            //    //别名
            //    sql = "select JCRbm from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getBM.Text = getInfo(sql);
            //    //曾用名
            //    sql = "select JCRcym from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getCYM.Text = getInfo(sql);
            //    //籍贯
            //    sql = "select JCRJG from JCRJBXX where JCRidenty='" + sqlID + "'";
            //   getJG.Text = getInfo(sql);
            //    //身份
            //    sql = "select JCRsf from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getSF.Text= getInfo(sql);
            //    //方言
            //    sql = "select JCRfy from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getFY.Text= getInfo(sql);
            //    //宗教信仰
            //    sql = "select JCRzjxy from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getZJXY.Text= getInfo(sql);
            //    //职业
            //    sql = "select JCRzy from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getZY.Text = getInfo(sql);
            //    //民族
            //    sql = "select JCRnation from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getMZ.Text= getInfo(sql);
            //    //经济状况
            //    sql = "select JCRjjzk from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getJJZK.Text= getInfo(sql);
            //    //现状
            //    sql = "select JCRxz from JCRJBXX where JCRidenty='" + sqlID + "'";
            //   getXZ.Text= getInfo(sql);
            //    //思想等级
            //    sql = "select JCRsxdj from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getSXDJ.Text = getInfo(sql);
            //    //列控单位
            //    sql = "select JCRlkdw from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getLKDW.Text= getInfo(sql);
            //    //身份证号
            //    getSFZ.Text= sqlID;
            //    //政治面貌
            //    sql = "select JCRpolity from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getZZMM.Text= getInfo(sql);
            //    //分类
            //    sql = "select JCRfl from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getFL.Text = getInfo(sql);
            //    //列控级别
            //    sql = "select JCRlkjb from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getLKJB.Text = getInfo(sql);
            //    //毕业院校
            //    sql = "select JCRbyyx from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getBYYX.Text = getInfo(sql);
            //    //户籍所在地
            //    sql = "select JCRhjszd from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getHJSZD.Text = getInfo(sql);
            //    //现居住地
            //    sql = "select JCRxjzd from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getXJZD.Text = getInfo(sql);
            //    //工作单位
            //    sql = "select JCRgzdw from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getGZDW.Text = getInfo(sql);
            //    //关系人员
            //    sql = "select JCRgxry from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getGXRY.Text = getInfo(sql);
            //    //个人简历
            //    sql = "select JCRgrjl from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getGRJL.Text = getInfo(sql);
            //    //固定电话
            //    sql = "select JCRgddh from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getGDDH.Text = getInfo(sql);
            //    //移动电话
            //    sql = "select JCRyddh from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getYDDH.Text = getInfo(sql);
            //    //电子邮件
            //    sql = "select JCRdzyj from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getDZYJ.Text = getInfo(sql);
            //    //办公室电话
            //    sql = "select JCRbgsdh from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getBGSDH.Text = getInfo(sql);
            //    //QQ
            //    sql = "select JCRqq from JCRJBXX where JCRidenty='" + sqlID + "'";
            //   getQQ.Text = getInfo(sql);
            //    //微信
            //    sql = "select JCRwx from JCRJBXX where JCRidenty='" + sqlID + "'";
            //    getWX.Text= getInfo(sql);

            //    #endregion


            //    //DI.ShowDialog();
            //}//else
            #endregion

            #region 赋值给textbox
            //照片

            //姓名
            deName.Text = GetName;
            //性别
            deSex.Text = GetSex;
            //籍贯
            deJG.Text = GetJG;
            //职业
            deZY.Text = GetZY;
            //民族
            deMZ.Text = GetMZ;
            //经济状况
            deJJZK.Text = GetJJZK;
            //列控单位
            deLKDW.Text = GetLKDW;
            //身份证
            deSFZ.Text = GetSFZ;
            //政治面貌
            deZZMM.Text = GetZZMM;
            //分类
            deFL.Text = GetFL;
            //列控级别
            deLKJB.Text = GetLKJB;
            //毕业院校
            deBYYX.Text = GetBYYX;
            //户籍所在地
            deHJSZD.Text = GetHJSZD;
            //现居住地
            deXJZD.Text = GetXJZD;
            //工作单位
            deGZDW.Text = GetGZDW;
            //关系人员
            deGXRY.Text = GetGXRY;
            //个人简历
            deGRJL.Text = GetGRJL;
            //备注
            deBZ.Text = GetBZ;
            //固定电话
            deGDDH.Text = GetGDDH;
            //移动电话
            deYDDH.Text = GetYDDH;
            //电子邮件
            deDZYJ.Text = GetDZYJ;
            //QQ
            deQQ.Text = GetQQ;
            //微信
            deWX.Text = GetWX;
            #endregion
            #region 读取照片
            photoGuidExist = "select JCRzpbh from JCRJBXX where JCRsfz='" + SqlForm.SFZid + "'";
            photoPath = Environment.CurrentDirectory + @"\\JCRphoto" + "\\" + getInfo(photoGuidExist);
            if (getInfo(photoGuidExist) != "未找到")
            {
                dePhoto.Image = Image.FromFile(photoPath);
                flag = "1";
            }
            #endregion
        }
        /// <summary>
        /// 对控件进行只可读处理
        /// </summary>
        private void ctrlWiget()
        {
            //照片
            getPhoto.Enabled = false;
            getAdPhoto.Enabled = false;
            //籍贯
            deJG.ReadOnly = true;
            getJG.Enabled = false;
            //职业
            deZY.ReadOnly = true;
            getZY.Enabled = false;
            //民族
            deMZ.ReadOnly = true;
            getMZ.Enabled = false;
            //经济状况
            deJJZK.ReadOnly = true;
            getJJZK.Enabled = false;
            //列控单位
            deLKDW.ReadOnly = true;
            getLKDW.Enabled = false;
            //身份证号            
            getSFZ.Enabled = false;
            //政治面貌
            deZZMM.ReadOnly = true;
            getZZMM.Enabled = false;
            //分类
            deFL.ReadOnly = true;
            getFL.Enabled = false;
            //列控级别
            deLKJB.ReadOnly = true;
            getLKJB.Enabled = false;
            //毕业院校
            deBYYX.ReadOnly = true;
            getBYYX.Enabled = false;
            //户籍所在地
            deHJSZD.ReadOnly = true;
            getHJSZD.Enabled = false;
            //现居住地
            deXJZD.ReadOnly = true;
            getXJZD.Enabled = false;
            //工作单位
            deGZDW.ReadOnly = true;
            getGZDW.Enabled = false;
            //关系人员
            deGXRY.ReadOnly = true;
            getGXRY.Enabled = false;
            //个人简历
            deGRJL.ReadOnly = true;
            getGRJL.Enabled = false;
            //备注
            deBZ.ReadOnly = true;
            getBZ.Enabled = false;
            //固定电话
            deGDDH.ReadOnly = true;
            getGDDH.Enabled = false;
            //移动电话
            deYDDH.ReadOnly = true;
            getYDDH.Enabled = false;
            //电子邮件
            deDZYJ.ReadOnly = true;
            getDZYJ.Enabled = false;
            //QQ
            deQQ.ReadOnly = true;
            getQQ.Enabled = false;
            //微信
            deWX.ReadOnly = true;
            getWX.Enabled = false;
        }

        //存储照片的guid
        public string photoGuid
        { get; set; }
        private void btnSure_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (change.Text == "取消修改")
            {
                newJCR NJ = new newJCR();
                sql += "update JCRJBXX set JCRsfz='" + deSFZ.Text + "' ";
                // sql += "update JCRJBXX set  ";

                #region 添加更新语句
                if (getJG.Checked == false && getZY.Checked == false && getBZ.Checked == false
                    && getMZ.Checked == false && getJJZK.Checked == false && getLKDW.Checked == false && getZZMM.Checked == false && getFL.Checked == false
                    && getLKJB.Checked == false && getBYYX.Checked == false && getHJSZD.Checked == false && getXJZD.Checked == false && getGZDW.Checked == false && getGXRY.Checked == false
                    && getGRJL.Checked == false && getGDDH.Checked == false && getDZYJ.Checked == false && getYDDH.Checked == false &&getQQ.Checked == false && getWX.Checked == false&&getPhoto.Checked==false)
                    MessageBox.Show("请至少选择一项", "提示");
                else
                {

                    //籍贯
                    if (getJG.Checked == true)
                    {
                        sql += ",JCRJG='" + deJG.Text.Trim() + "'";
                        deJG.ReadOnly = false;
                    }
                    //职业
                    if (getZY.Checked == true)
                    {
                        sql += ",JCRzy='" + deZY.Text.Trim() + "'";
                        deZY.ReadOnly = false;
                    }
                    //民族
                    if (getMZ.Checked == true)
                    {
                        sql += ",JCRnation='" + deMZ.Text.Trim() + "'";
                        deMZ.ReadOnly = false;
                    }
                    //经济状况
                    if (getJJZK.Checked == true)
                    {
                        sql += ",JCRjjzk='" + deJJZK.Text.Trim() + "'";
                        deJJZK.ReadOnly = false;
                    }
                    //列控单位
                    if (getLKDW.Checked == true)
                    {
                        sql += ",JCRlkdw='" + deLKDW.Text.Trim() + "'";
                        deLKDW.ReadOnly = false;
                    }

                    //政治面貌
                    if (getZZMM.Checked == true)
                    {
                        sql += ",JCRpolity='" + deZZMM.Text.Trim() + "'";
                        deZZMM.ReadOnly = false;
                    }
                    //分类
                    if (getFL.Checked == true)
                    {
                        sql += ",JCRfl='" + deFL.Text.Trim() + "'";
                        deFL.ReadOnly = false;
                    }
                    //列控级别
                    if (getLKJB.Checked == true)
                    {
                        sql += ",JCRlkjb='" + deLKJB.Text.Trim() + "'";
                        deLKJB.ReadOnly = false;
                    }
                    //毕业院校
                    if (getBYYX.Checked == true)
                    {
                        sql += ",JCRbyyx='" + deBYYX.Text.Trim() + "'";
                        deBYYX.ReadOnly = false;
                    }
                    //户籍所在地
                    if (getHJSZD.Checked == true)
                    {
                        sql += ",JCRhjszd='" + deHJSZD.Text.Trim() + "'";
                        deHJSZD.ReadOnly = false;
                    }
                    //现居住地
                    if (getXJZD.Checked == true)
                    {
                        sql += ",JCRxjzd='" + deXJZD.Text.Trim() + "'";
                        deXJZD.ReadOnly = false;
                    }
                    //工作单位
                    if (getGZDW.Checked == true)
                    {
                        sql += ",JCRgzdw='" + deGZDW.Text.Trim() + "'";
                        deGZDW.ReadOnly = false;
                    }
                    //关系人员
                    if (getGXRY.Checked == true)
                    {
                        sql += ",JCRgxry='" + deGXRY.Text.Trim() + "'";
                        deGXRY.ReadOnly = false;
                    }
                    //个人简历
                    if (getGRJL.Checked == true)
                    {
                        sql += ",JCRgrjl='" + deGRJL.Text.Trim() + "'";
                        deGRJL.ReadOnly = false;
                    }
                    // 备注
                    if (getBZ.Checked == true)
                    {
                        sql += " ,JCRbz='" + deBZ.Text.Trim() + "'";
                        deBZ.ReadOnly = false;
                    }
                    //固定电话
                    if (getGDDH.Checked == true)
                    {
                        sql += ",JCRgddh='" + deGDDH.Text.Trim() + "'";
                        deGDDH.ReadOnly = false;
                    }
                    //移动电话
                    if (getYDDH.Checked == true)
                    {
                        sql += ",JCRyddh='" + deYDDH.Text.Trim() + "'";
                        deYDDH.ReadOnly = false;
                    }
                    //电子邮件
                    if (getDZYJ.Checked == true)
                    {
                        sql += ",JCRdzyj='" + deDZYJ.Text.Trim() + "'";
                        deDZYJ.ReadOnly = false;
                    }
                    //qq
                    if (getQQ.Checked == true)
                    {
                        sql += ",JCRqq='" + deQQ.Text.Trim() + "'";
                        deQQ.ReadOnly = false;
                    }
                    //微信
                    if (getWX.Checked == true)
                    {
                        sql += ",JCRwx='" + deWX.Text.Trim() + "'";
                        deWX.ReadOnly = false;
                    }
                        //照片
                        #region 修改照片
                        if (getPhoto.Checked == true)
                    {
                        getAdPhoto.Enabled = true;
                        if (pathTemp != null)
                        {
                            //删除当前文件夹的照片
                            if (File.Exists(Environment.CurrentDirectory + @"\\JCRphoto" + "\\" + getInfo(photoGuidExist)))
                            {
                                File.Delete(Environment.CurrentDirectory + @"\\JCRphoto" + "\\" + getInfo(photoGuidExist));   
                                movePhoto(pathTemp);                                                             
                            }
                        }
                    }
                    

                    #endregion
                    #endregion
                    SqlForm SF = new SqlForm();
                    sql += "  where JCRsfz='" + deSFZ.Text + "'";
                   // sql += " where JCRsfz='" + SF.SFZid + "'";
                    using (OleDbConnection conn = new OleDbConnection(strcon))
                    {
                        OleDbCommand comm = new OleDbCommand(sql, conn);
                        conn.Open();
                        int result = comm.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("修改成功", "提示");
                            
                            //控件不可用处理
                            ctrlWiget();
                            change.Text = "修改";
                            #region 选项清零
                            getJG.Checked = false; getZY.Checked = false;getBZ.Checked = false;
                            getMZ.Checked = false; getJJZK.Checked = false;  getLKDW.Checked = false; getZZMM.Checked = false; getFL.Checked = false;
                            getLKJB.Checked = false; getBYYX.Checked = false; getHJSZD.Checked = false; getXJZD.Checked = false; getGZDW.Checked = false; getGXRY.Checked = false;
                            getGRJL.Checked = false; getGDDH.Checked = false; getDZYJ.Checked = false; getYDDH.Checked = false; getQQ.Checked = false; getWX.Checked = false;
                            #endregion
                        }
                        else
                            MessageBox.Show("修改失败", "提示");
                    }
                }
            }
            else
                this.Close();
        }
        //移动照片
        public void movePhoto(string path)
        {
            try
            {
                //FileInfo move = new FileInfo(path);
                //move.CopyTo(Environment.CurrentDirectory+@"\stuPhoto"+Guid.NewGuid);
                //File.Copy(path, Environment.CurrentDirectory + @"\\JCRphoto" + "\\" + getInfo(photoGuidExist));
                // string tempPath = Environment.CurrentDirectory + @"\\JCRphoto" + "\\" + getInfo(photoGuidExist) + "1";
                string guid = Guid.NewGuid().ToString();
                File.Move(path, Environment.CurrentDirectory + @"\\JCRphoto" + "\\" + guid);
                string sql = "update JCRJBXX set JCRzpbh='" + guid + ".jpg" + "'";
                bool re=in_up_SQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //新图片路径
        public string pathTemp
        { set; get; }
        //添加照片
        private void getAdPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择照片";
            ofd.Filter = "图片|*.jpg";
            ofd.ShowDialog();
            pathTemp = ofd.FileName;
            if (pathTemp == "")
            {           
                return;
            }                    
            dePhoto.Image = Image.FromFile(pathTemp);          
            
        }
        //添加事件按钮
        
        private void btnAddSJ_Click(object sender, EventArgs e)
        {
            addSJ_Sql AS = new addSJ_Sql();
            AS.showName = deName.Text.Trim();
            AS.showSFZ = deSFZ.Text.Trim();
            AS.ShowDialog();
            //addSJMethod();
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

       public string guid_SJ
        { set; get; }

   
        /// <summary>
        /// 加入按人添加事件的功能
        /// </summary>
        /// <returns>成功返回true，失败返回false</returns>
        //private bool addSJMethod()
        //{
        //    //生成guid
        //    guid_SJ = Guid.NewGuid().ToString();
        //    string sqlSJ = "select JCRsfz from JCRSJSL where JCRsfz='"+deSFZ.Text .Trim()+"'";
        //    bool re = in_up_SQL(sqlSJ);
        //    if (re == false)
        //        return false;
        //    else
        //    {
        //        sqlSJ = "select SJcount form JCRSJSL where JCRsfz='" + deSFZ.Text.Trim() + "'";
        //        string count = getInfo(sqlSJ);
        //        if (count =="未找到")
        //            return false;

        //        else
        //        {
        //            sqlSJ = "insert into JCRSJXX (SJguid,JCRname,JCRsfz,SJsj,SJdd,SJcyrw,SJgjc,SJjb,SJxs) values('" + guid_SJ +
        //                "','" + AS.getJCRname + "','" + AS.getJCRsfz + "','" + AS.getSJtime + "','" + AS.getSJdd + "','" + AS.getSJcyrw +
        //                "','" + AS.getSJgjc + "','" + AS.getSJjb + "','" + AS.getSJxs + "')";
        //            bool result = in_up_SQL(sqlSJ);
        //            if (result == true)
        //            {
        //                int Count = Convert.ToInt32(count);
        //                ++Count; 
        //                sqlSJ = "insert into JCRSJSL (SJcount) values('"+Count+"')";
        //               bool res= in_up_SQL(sqlSJ);
        //                if (res == true)
        //                    return true;
        //                else return false;
        //            }
        //            else
        //                return false;
        //        }

        //    }
        //}







    }
}
