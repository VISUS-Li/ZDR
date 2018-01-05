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
    public partial class detailInfo : Form
    {
        public detailInfo()
        {
            InitializeComponent();
        }
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=true";
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
        { get; set;}
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

        string sql = string.Empty;

        Main MA = new  Main();
        private void getBM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (btnchange.Text == "取消修改")
            {
                sql += "update JCRJBXX set JCRidenty='" + MA.SFZid + "' ";

                #region 添加更新语句
                //照片
                //if (getPhoto.Checked == true)
                //    dePhoto.Enabled = true;
                //别名
                if (getBM.Checked == true)
                    sql += ",JCRbm='" + deBM.Text.Trim() + "'";
                //曾用名
                if (getCYM.Checked == true)
                    sql += ",JCRcym='" + deCYM.Text.Trim() + "'";
                //籍贯
                if (getJG.Checked == true)
                    sql += ",JCRJG='" + deJG.Text.Trim() + "'";
                //身份
                if (getSF.Checked == true)
                    sql += ",JCRsf='" + deSF.Text.Trim() + "'";
                //方言
                if (getFY.Checked == true)
                    sql += ",JCRfy='" + deFY.Text.Trim() + "'";
                //宗教信仰
                if (getZJXY.Checked == true)
                    sql += ",JCRzjxy='" + deZJXY.Text.Trim() + "'";
                //职业
                if (getZY.Checked == true)
                    sql += ",JCRzy='" + deZY.Text.Trim() + "'";
                //民族
                if (getMZ.Checked == true)
                    sql += ",JCRnation='" + deMZ.Text.Trim() + "'";
                //经济状况
                if (getJJZK.Checked == true)
                    sql += ",JCRjjzk='" + deJJZK.Text.Trim() + "'";
                //现状
                if (getXZ.Checked == true)
                    sql += ",JCRxz='" + deXZ.Text.Trim() + "'";
                //思想等级
                if (getSXDJ.Checked == true)
                    sql += ",JCRsxdj='" + deSXDJ.Text.Trim() + "'";
                //列控单位
                if (getLKDW.Checked == true)
                    sql += ",JCRlkdw='" + deLKDW.Text.Trim() + "'";

                //政治面貌
                if (getZZMM.Checked == true)
                    sql += ",JCRpolity='" + deZZMM.Text.Trim() + "'";
                //分类
                if (getFL.Checked == true)
                    sql += ",JCRfl='" + deFL.Text.Trim() + "'";
                //列控级别
                if (getLKJB.Checked == true)
                    sql += ",JCRlkjb='" + deLKJB.Text.Trim() + "'";
                //毕业院校
                if (getBYYX.Checked == true)
                    sql += ",JCRbyyx='" + deBYYX.Text.Trim() + "'";
                //户籍所在地
                if (getHJSZD.Checked == true)
                    sql += ",JCRhjszd='" + deHJSZD.Text.Trim() + "'";
                //现居住地
                if (getXJZD.Checked == true)
                    sql += ",JCRLiPla='" + deXJZD.Text.Trim() + "'";
                //工作单位
                if (getGZDW.Checked == true)
                    sql += ",JCRgzdw='" + deGZDW.Text.Trim() + "'";
                //关系人员
                if (getGXRY.Checked == true)
                    sql += ",JCRgxry='" + deGXRY.Text.Trim() + "'";
                //个人简历
                if (getGRJL.Checked == true)
                    sql += ",JCRgrjl='" + deGRJL.Text.Trim() + "'";
                //固定电话
                if (getGDDH.Checked == true)
                    sql += ",JCRgddh='" + deGDDH.Text.Trim() + "'";
                //移动电话
                if (getYDDH.Checked == true)
                    sql += ",JCRyddh='" + deYDDH.Text.Trim() + "'";
                //电子邮件
                if (getDZYJ.Checked == true)
                    sql += ",JCRdzyj='" + deDZYJ.Text.Trim() + "'";
                //办公室电话
                if (getBGSDH.Checked == true)
                    sql += ",JCRbgsdh='" + deBGSDH.Text.Trim() + "'";
                //qq
                if (getQQ.Checked == true)
                    sql += ",JCRqq='" + deQQ.Text.Trim() + "'";
                //微信
                if (getWX.Checked == true)
                    sql += ",JCRwx='" + deWX.Text.Trim() + "'";
                #endregion
                else
                    MessageBox.Show("请至少选择一项", "提示");
                sql += "  where JCRidenty='"+MA.SFZid+"'";
                using (OleDbConnection conn = new OleDbConnection(strcon))
                {
                    OleDbCommand comm = new OleDbCommand(sql,conn);
                    conn.Open();
                    int result=comm.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("修改成功", "提示");
                    else
                        MessageBox.Show("修改失败","提示");
                }
            }
            else
            this.Close();
        }
        //修改
        private void btnchange_Click(object sender, EventArgs e)
        {
            if (btnchange.Text == "修改")
            {
                #region 开启修改选择
                //照片
                getPhoto.Enabled = true;
                //别名
                getBM.Enabled = true;
                //曾用名
                getCYM.Enabled = true;
                //籍贯
                getJG.Enabled = true;
                //身份
                getSF.Enabled = true;
                //方言
                getFY.Enabled = true;
                //宗教信仰
                getZJXY.Enabled = true;
                //职业
                getZY.Enabled = true;
                //民族
                getMZ.Enabled = true;
                //经济状况
                getJJZK.Enabled = true;
                //现状
                getXZ.Enabled = true;
                //思想等级
                getSXDJ.Enabled = true;
                //列控单位
                getLKDW.Enabled = true;
                //身份证号
                getSFZ.Enabled = true;
                //政治面貌
                getZZMM.Enabled = true;
                //分类
                getFL.Enabled = true;
                //列控级别
                getLKJB.Enabled = true;
                //毕业院校
                getBYYX.Enabled = true;
                //户籍所在地
                getHJSZD.Enabled = true;
                //现居住地
                getXJZD.Enabled = true;
                //工作单位
                getGZDW.Enabled = true;
                //关系人员
                getGXRY.Enabled = true;
                //个人简历
                getGRJL.Enabled = true;
                //固定电话
                getGDDH.Enabled = true;
                //移动电话
                getYDDH.Enabled = true;
                //电子邮件
                getDZYJ.Enabled = true;
                //办公室电话
                getBGSDH.Enabled = true;
                //QQ
                getQQ.Enabled = true;
                //微信
                getWX.Enabled = true;
                #endregion
                MessageBox.Show("请勾选需要修改的信息", "提示");
                btnchange.Text = "取消修改";
            }
            else
            {
                #region 关闭修改选择
                //照片
                getPhoto.Enabled = false;
                //别名
                getBM.Enabled = false;
                //曾用名
                getCYM.Enabled = false;
                //籍贯
                getJG.Enabled = false;
                //身份
                getSF.Enabled = false;
                //方言
                getFY.Enabled = false;
                //宗教信仰
                getZJXY.Enabled = false;
                //职业
                getZY.Enabled = false;
                //民族
                getMZ.Enabled = false;
                //经济状况
                getJJZK.Enabled = false;
                //现状
                getXZ.Enabled = false;
                //思想等级
                getSXDJ.Enabled = false;
                //列控单位
                getLKDW.Enabled = false;
                //身份证号
                getSFZ.Enabled = false;
                //政治面貌
                getZZMM.Enabled = false;
                //分类
                getFL.Enabled = false;
                //列控级别
                getLKJB.Enabled = false;
                //毕业院校
                getBYYX.Enabled = false;
                //户籍所在地
                getHJSZD.Enabled = false;
                //现居住地
                getXJZD.Enabled = false;
                //工作单位
                getGZDW.Enabled = false;
                //关系人员
                getGXRY.Enabled = false;
                //个人简历
                getGRJL.Enabled = false;
                //固定电话
                getGDDH.Enabled = false;
                //移动电话
                getYDDH.Enabled = false;
                //电子邮件
                getDZYJ.Enabled = false;
                //办公室电话
                getBGSDH.Enabled = false;
                //QQ
                getQQ.Enabled = false;
                //微信
                getWX.Enabled = false;
                #endregion
                btnchange.Text = "修改";
            }
        }

        private void detailInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
