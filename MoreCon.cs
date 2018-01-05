using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDRJC2
{
    public partial class MoreCon : Form
    {
        public MoreCon()
        {
            InitializeComponent();
        }

        private void MoreCon_Load(object sender, EventArgs e)
        {
            sqlAge.Clear();
            sqlMZ.Clear();
            sqlZZMM.Clear();
            sqlGXRY.Clear();
            sqlBYYX.Clear();
            sqlZY.Clear();
            sqlFL.Clear();
            sqlGZDW.Clear();
        }
        //年龄
        public string addNL
        { set; get; }
        //民族
        public string addMZ
        { set; get; }

        //政治面貌
        public string addZZMM
        { set; get; }
        //关系人员
        public string addGXRY
        { set; get; }
        //毕业院校
        public string addBYYX
        { set; get; }
        //工作单位
        public string addGZDW
        { set; get; }
        //职业
        public string addZY
        { set; get; }
        //分类
        public string addFL
        { set; get; }
        //年龄
        public bool boolNL = false;
        //民族
        public bool boolMZ = false;
        //政治面貌
        public bool boolZZMM = false;
        //关系人员
        public bool boolGXRY = false;
        //毕业院校
        public bool booBYYX = false;
        //工作单位
        public bool boolGZDW = false;
        //职业
        public bool boolZY = false;
        //分类
        public bool boolFL = false;

        
        private void btnSure_Click(object sender, EventArgs e)
        {
            if (sqlAge.Text.Trim() != "")
            {
                boolNL = true;
                addNL = sqlAge.Text.Trim();
            }
            else
                boolNL = false;
            if (sqlMZ.Text.Trim()!="")
            {
                boolMZ = true;
                addMZ = sqlMZ.Text.Trim();
            }
            else
                boolMZ = false;
            if (sqlZZMM.Text.Trim()!="")
            {
                boolZZMM = true;
                addZZMM = sqlZZMM.Text.Trim();
            }
            else
                boolZZMM = false;
            if (sqlGXRY.Text.Trim()!="")
            {
                boolGXRY = true;
                addGXRY = sqlGXRY.Text.Trim();
            }
            else
                boolGXRY = false;
            if (sqlBYYX.Text.Trim()!="")
            {
                booBYYX = true;
                addBYYX = sqlBYYX.Text.Trim();
            }
            else
                booBYYX = false;
            if (sqlGZDW.Text.Trim()!="")
            {
                boolGZDW = true;
                addGZDW = sqlGZDW.Text.Trim();
            }
            else
                boolGZDW = false;
            if (sqlZY.Text.Trim()!="")
            {
                boolZY = true;
                addZY = sqlZY.Text.Trim();
            }
            else
                boolZY = false;
            if (sqlFL.Text.Trim()!="")
            {
                boolFL = true;
                addFL = sqlFL.Text.Trim();
            }
            else
                boolFL = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
