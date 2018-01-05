using System;
using System.Windows.Forms;

namespace ZDRJC2
{

    /// <summary>
    /// 主界面
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

   
        //加载时
        private void MainForm_Load(object sender, EventArgs e)
        {
          
            //给权限
            if (Login.limit == "2")
            {
                //2为普通用户
                btnDeAdm.Hide();
                btnRegist.Hide();
                btnAddJCR.Hide();
                btnRecover.Hide();
            }
            else if (Login.limit == "1")
            {   //1为普通管理员
                btnDeAdm.Hide();
                btnRegist.Hide();
                btnRecover.Hide();
            }
        }
        //退出程序
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        //添加监测人
        private void btnAddJCR_Click(object sender, EventArgs e)
        {
            newJCR AdJCR = new newJCR();
            AdJCR.Show();
        }
        //删除监测人
        private void btnCancelJCR_Click(object sender, EventArgs e)
        {
            
        }
        //删除管理员
        private void btnDeAdm_Click(object sender, EventArgs e)
        {
            DelAdm deladm = new DelAdm();
            deladm.Show();
        }
        //注册管理员
        private void btnRegist_Click(object sender, EventArgs e)
        {
            Regist REG = new Regist();
            REG.Show();
        }
        //查询按钮
        private void btnSql_Click(object sender, EventArgs e)
        {
            SqlForm SF = new SqlForm();
            SF.Show();
            this.Hide();
            
        }
        //框体关闭按钮
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
        //注销
        private void btnExiAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LG = new Login();
            LG.Show();

        }
        //恢复监测人
        private void btnRecover_Click(object sender, EventArgs e)
        {
            recover RE = new recover();
            RE.Show();
        }
        //制作人       
        private void btn制作人_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作人:李宁陶\n\n完成时间:2016-11-11\n\n管理员邮箱:1183989659@qq.com","制作人");
        }
    }
}
