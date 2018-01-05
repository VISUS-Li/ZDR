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
    public partial class Login : Form
    {
        string  strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb";
        public Login()
        {
            InitializeComponent();
        }
        #region 字段
        //存储登录用户的权限
        public static string limit
        { get; set; }

        //存储验证码字段
        public string verification
        {
            set;
            get;
        }
        //存储该登录用户的用户名
        public static string LogYHM
        { get; set; }
#endregion
        //退出
        private void btnexit_Click(object sender, EventArgs e)
        {
           DialogResult dRe= MessageBox.Show("确定退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dRe==DialogResult.Yes)
            Application.Exit();
            
        }
        #region 查询函数
        /// <summary>
        /// 进行查询数据库操作
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <param name="judge">0表示返回executeScalar的结果,1表示返回记录的条数,访问数据库失败返回-1</param>
        /// <returns></returns>
        public string sqlCommand(string sql, int judge)
        {
            using (OleDbConnection conn = new OleDbConnection(strcon))
            {
                try
                {
                    OleDbCommand comm = new OleDbCommand(sql, conn);

                    conn.Open();
                    if (judge == 0)
                    {
                        object reScalar = comm.ExecuteScalar();
                        return reScalar.ToString();
                    }
                    else
                    {
                        int reQuery = comm.ExecuteNonQuery();
                        return reQuery.ToString();
                    }
                }
                catch
                {
                    return "-1";
                }
            }
        }
        #endregion
        
        //登录
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (uname.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名", "提示");
                uname.Focus();
            }
            else if (upwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "提示");
                upwd.Focus();
            }
            else if (verfication.Text.Trim()=="")
            {
                MessageBox.Show("请输入验证码","提示");
                verfication.Focus();
            }
            else if (logIdenty.SelectedIndex<0)
                MessageBox.Show("请选择登录身份","提示");
               
            else
            {
                string sql = "";
                //查询登录名是否存在
                sql = "select yhm from DLXX where yhm='"+uname.Text.Trim()+"'";
                string result=sqlCommand(sql,0);
                sql = "select dellogo from DLXX where yhm='" + uname.Text.Trim() + "'";
                string res = sqlCommand(sql,0);
              
                if (result!=null&&res=="0")
                {
                  
                    sql = "select limit from DLXX where yhm='" + uname.Text.Trim() + "'";
                 
                    string limResult = sqlCommand(sql,0);
                    //选择的权限不正确                  
                    if  (limResult != logIdenty.SelectedIndex.ToString())
                    {
                        MessageBox.Show("选择的角色和输入的用户名等级不匹配", "提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                      
                    }
                    else
                    {
                        //验证码
                        if (verification== verfication.Text.Trim())
                        {
                            
                            //查密码
                            sql = "select pwd from DLXX where yhm='" + uname.Text.Trim() + "'";
                            string pwdResult = sqlCommand(sql, 0);
                            if (upwd.Text.Trim() == pwdResult)
                            {
                               
                                //给权限
                                if (limResult == "0")
                                {
                                   
                                    limit = "0";
                                    
                                }
                                else if (limResult == "1")
                                {
                                    limit = "1";
                                    
                                }
                                else if (limResult == "2")
                                {
                                    limit = "2";
                                   
                                }
                                //登录成功后将用户名传入静态字段中
                                LogYHM = result;

                                MessageBox.Show("登录成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                MainForm MF = new MainForm();
                                MF.Show();         
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("密码错误","提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                upwd.Clear();
                                upwd.Focus();
                                verfication.Clear();
                                //重新绘制验证码
                                verification = verificationCode(verification);

                            }
                        }
                        else
                        {
                            MessageBox.Show("验证码不正确","提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            verfication.Clear();
                            //重新绘制验证码
                            verification = verificationCode(verification);
                        }
                    }   
                }
                else
                    MessageBox.Show("该用户名不存在","提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
            }//else
        }
        //注册
        private void button1_Click(object sender, EventArgs e)
        {
            //Regist registForm = new Regist();
            //registForm.ShowDialog();
            System.Environment.Exit(0);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dRe = MessageBox.Show("确认退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dRe == DialogResult.No)
                System.Environment.Exit(0);
            else
            { }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //int screenWidth=Screen.PrimaryScreen.Bounds.Width;
            //int  screenHeight = Screen.PrimaryScreen.Bounds.Height;
            //this.Height = screenHeight;
            //this.Width = screenWidth;
            verification = verificationCode(verification);
            uname.Focus();
            
        }

        private void Login_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void verificationPic_Click(object sender, EventArgs e)
        {
            verification=verificationCode( verification);
        }
        //绘制验证码
        private string verificationCode( string verCode)
        {
            Random r = new Random();
            string str = "";
            //str中存储着一个5位数
            for (int i = 0; i < 5; i++)
            {
                str += r.Next(0, 10);
            }
            verCode = str;
            //实例化一个位图
            Bitmap bmp = new Bitmap(120, 40);
            //实例化一个画图工具
            Graphics g = Graphics.FromImage(bmp);
            //随机生成数字，开始画图
            for (int i = 0; i < 5; i++)
            {
                //初始化随机数的点
                Point p = new Point(i * 20, 0);
                string[] fonts = { "", "", "", "", "" };
                Color[] cl = { Color.Black, Color.Blue, Color.Red, Color.Green, Color.Yellow };
                //绘制对str[i]产生的数字在指定的p坐标用指定的字体font和指定的笔刷brush画图
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 20, FontStyle.Bold), new SolidBrush(cl[r.Next(0, 5)]), p);

            }
            //绘制直线识别障碍
            for (int i = 0; i < 20; i++)
            {
                //实例化钢笔工具，颜色为黑色
                Pen pen = new Pen(Brushes.Black);
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                //用指定的钢笔工具画直线
                g.DrawLine(pen, p1, p2);
            }
            for (int i = 0; i < 500; i++)
            {
                bmp.SetPixel(r.Next(0, bmp.Width), r.Next(0, bmp.Height), Color.Black);
            }
            //将bmp嵌入到picturbox中
            verificationPic.Image = bmp;
            return verCode;
        }
    }
}
