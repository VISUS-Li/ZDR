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
    public partial class AddFJ : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "\\JCR.accdb; Persist Security Info=False";
        public AddFJ()
        {
            InitializeComponent();
        }


        #region 字段
        //获得初始姓名
        public string getInitName
        { set; get; }
        //获得初始身份证
        public string getInitSFZ
        { set; get; }
        //文档浏览到的路径
        public string WDpathSource
        { set; get; }
        //照片浏览到的路径
        public string ZPpathSource
        { set; get; }
        //视频浏览到的路径
        public string SPpathSource
        { set; get; }
        //音频浏览到的路径
        public string YYpathSource
        { set; get; }
        //目标文档路径
        public string WDpathTarget
        { set; get; }
        //目标照片路径
        public string ZPpathTarget
        { set; get;}
        //目标视频路径
        public string SPpathTarget
        { set; get; }
        //目标音频路径
        public string YYpathTarget
        { set; get;}
        //文档文件名
        public string WDname
        { set; get; }
        //照片文件名
        public string ZPname
        { set; get; }
        //视频文件名
        public string SPname
        { set; get; }
        //音频文件名
        public string YYname
        { set; get; }
        #endregion
        private void AddFJ_Load(object sender, EventArgs e)
        {
            initalName.Text = getInitName;
            initalSFZ.Text = getInitSFZ;
        }
        #region 按钮
        //文档浏览按钮
        private void btnBroWD_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "选择文档文件";
            OFD.Filter = "文本文件|*.txt|word文件|*.doc|excel文件|*.xls";
            OFD.ShowDialog();
            //获得源文件地址
            WDpathSource = OFD.FileName;
            //获得源文件名
            WDname = Path.GetFileName(WDpathSource);
            getPaWD.Text = WDpathSource;
        }
        //照片浏览按钮
        private void btnBrowZP_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "选择图片文件";
            OFD.Filter = "图片|*.jpg;*.png;*.gif";
            OFD.ShowDialog();
            //获得源文件地址
            ZPpathSource = OFD.FileName;
            //获得源文件地址
            ZPname = Path.GetFileName(ZPpathSource);
            getPaZP.Text = ZPpathSource;
        }
        //视频浏览按钮
        private void btnBroSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "选择视频文件";
            OFD.Filter = "视频|*.mp4;*.rmvb;*.wmv";
            OFD.ShowDialog();
            //获得源文件地址
            SPpathSource = OFD.FileName;
            //获得源文件名
            SPname = Path.GetFileName(SPpathSource);
            getPaSP.Text = SPpathSource;
        }
        //音频浏览按钮
        private void btnBroYY_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "选择音频文件";
            OFD.Filter = "音频|*.mp3;*.wav";
            OFD.ShowDialog();
            //获得源文件地址
            YYpathSource = OFD.FileName;
            //获得源文件名
            YYname = Path.GetFileName(YYpathSource);
            getPaYY.Text = YYpathSource;
        }
        #endregion
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sql">查询字符串</param>
        /// <param name="judge">0代表将查询结果集存入dataset中，显示到datagirdview中，1代表返回查询的结果,2代表返回记录条数,3代表返回查询到该记录有几条</param>
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
                        // sqlDataView.DataSource = ds.Tables["dt"];
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
                else if (judge == 2)
                {
                    int result = comm.ExecuteNonQuery();
                    if (result > 0)
                        return result.ToString();
                    else
                        return "-1";
                }
                else 
                {
                    int count=0;
                    OleDbDataReader myreader = comm.ExecuteReader();
                    while (myreader.Read())
                    {
                        ++count;
                    }
                    return count.ToString();
                }
            }

        }

        //添加文档文件的方法
        private bool addWDmethod()
        {
            //查询是否有同名文件存在
            string sqlSameName = "select WDname from FJWD ";
            string sameResult = sqlMethod(sqlSameName, 1);
            if (sameResult == WDname)
            {
                MessageBox.Show("文档名已存在，请改名后添加","提示");
                return false;
            }
            
           // string WDguid = Guid.NewGuid().ToString();
            //若不存在该联系人的文件夹则创建该文件夹
            if (Directory.Exists(Environment.CurrentDirectory + "\\JCRFJ\\FJWD\\" + getInitSFZ) == false)
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\JCRFJ\\FJWD\\" + getInitSFZ);
            string WDextension = Path.GetExtension(WDpathSource);
            string WDextFlag = "";
            //判断选择的是什么文件
            switch (WDextension)
            {
                case ".txt":WDextFlag = "txt";break;
                case ".doc":WDextFlag = "word";break;
                case ".xls":WDextFlag = "excel";break;
                default:WDextFlag = "-1";break;
            }
            //赋值给目标路径
            if (WDextFlag == "txt")
                WDpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJWD\\" + getInitSFZ + "\\" + WDname;
            else if (WDextFlag == "word")
                WDpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJWD\\" + getInitSFZ + "\\" + WDname;
            else if (WDextFlag == "excel")
                WDpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJWD\\" + getInitSFZ + "\\" +WDname;
            else
                WDextFlag = "-1";
            //复制文件到目标目录
            try
            {
                File.Copy(WDpathSource, WDpathTarget);              
            }
            catch { return false; }
            #region 将路径放入数据库中
            //保存当前时间
            string timeNow = DateTime.Now.ToString();
            //先查询JCRFJ表中有无该对象
            string sql = "select JCRsfz from JCRFJ where JCRsfz='" + getInitSFZ + "'";
            //如果没有，则添加
            if (sqlMethod(sql, 1) == "-1")
            {
                sql = "insert into JCRFJ (JCRname,JCRsfz,WDCount,ZPCount,SPCount,YYCount) values('" + getInitName + "','" + getInitSFZ + "','0','0','0','0')";
                string inJCRFJ = sqlMethod(sql, 2);

                //添加JCRFJ表失败
                if (inJCRFJ == "-1")
                    return false;
            }
            //拿到当前对象文档数量
             sql = "select WDCount from JCRFJ where JCRsfz='" + getInitSFZ + "'";
            string countStr = sqlMethod(sql, 1);
            //未拿到当前文档数量
            if (countStr == "-1")
                return false;
            //向FJWD表插入文档地址
            int count = Convert.ToInt32(countStr);
            sql = "insert into FJWD(JCRname,JCRsfz,WDname,WDpath,WDAddTime,WDdellogo) values('" + getInitName + "','" + getInitSFZ + "','"+WDname+"','" + WDpathTarget + "','" + timeNow + "','0')";
            string inFJWD = sqlMethod(sql, 2);
            if (inFJWD == "-1")
                return false;
            else
            {
                sql = "update JCRFJ set WDCount='" + ++count + "' ";
                sqlMethod(sql, 1);
                return true;
            }
                

                #endregion

        }

        //添加照片方法
        private bool addZPmethod()
        {
            //查询是否有同名文件存在
            string sqlSameName = "select ZPname from FJZP ";
            string sameResult = sqlMethod(sqlSameName, 1);
            if (sameResult ==ZPname)
            {
                MessageBox.Show("照片名已存在，请改名后添加", "提示");
                return false;
            }

            string WDguid = Guid.NewGuid().ToString();
            //若不存在该联系人的文件夹则创建该文件夹
            if (Directory.Exists(Environment.CurrentDirectory + "\\JCRFJ\\FJZP\\" + getInitSFZ) == false)
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\JCRFJ\\FJZP\\" + getInitSFZ);
            string ZPextension = Path.GetExtension(ZPpathSource);
            string ZPextFlag = "";
            //判断选择的是什么文件
            switch (ZPextension)
            {
                case ".jpg": ZPextFlag = "jpg"; break;
                case ".png": ZPextFlag = "png"; break;
                case ".gif": ZPextFlag = "gif"; break;
                default: ZPextFlag = "-1"; break;
            }
            //赋值给目标路径
            if (ZPextFlag == "jpg")
                ZPpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJZP\\" + getInitSFZ + "\\" + ZPname;
            else if (ZPextFlag == "png")
                ZPpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJZP\\" + getInitSFZ + "\\" + ZPname;
            else if (ZPextFlag == "gif")
                ZPpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJZP\\" + getInitSFZ + "\\" + ZPname;
            else
                ZPextFlag = "-1";
            //复制文件到目标目录
            try
            {
                File.Copy(ZPpathSource, ZPpathTarget);
            }
            catch { return false; }
            #region 将路径放入数据库中
            //保存当前时间
            string timeNow = DateTime.Now.ToString();
            //先查询JCRFJ表中有无该对象
            string sql = "select JCRsfz from JCRFJ where JCRsfz='" + getInitSFZ + "'";
            //如果没有，则添加
            if (sqlMethod(sql, 1) == "-1")
            {
                sql = "insert into JCRFJ (JCRname,JCRsfz,WDCount,ZPCount,SPCount,YYCount) values('" + getInitName + "','" + getInitSFZ + "','0','0','0','0')";
                string inJCRFJ = sqlMethod(sql, 2);

                //添加JCRFJ表失败
                if (inJCRFJ == "-1")
                    return false;
            }
            //拿到当前对象文档数量
            sql = "select ZPcount from JCRFJ where JCRsfz='" + getInitSFZ + "'";
            string countStr = sqlMethod(sql, 1);
            //未拿到当前文档数量
            if (countStr == "-1")
                return false;
            //向FJZP表插入照片地址
            int count = Convert.ToInt32(countStr);
            sql = "insert into FJZP(JCRname,JCRsfz,ZPname,ZPpath,ZPAddTime,ZPdellogo) values('" + getInitName + "','" + getInitSFZ + "','" + ZPname + "','" + ZPpathTarget + "','" + timeNow + "','0')";
            string inFJZP = sqlMethod(sql, 2);
            if (inFJZP == "-1")
                return false;
            else
            {
                sql = "update JCRFJ set ZPCount='" + ++count + "' ";
                sqlMethod(sql, 1);
                return true;
            }
            #endregion
        }

        //添加视频方法
        private bool addSPmethod()
        {
            //查询是否有同名文件存在
            string sqlSameName = "select SPname from FJSP ";
            string sameResult = sqlMethod(sqlSameName, 1);
            if (sameResult ==SPname)
            {
                MessageBox.Show("视频名已存在，请改名后添加", "提示");
                return false;
            }

            //string WDguid = Guid.NewGuid().ToString();
            //若不存在该联系人的文件夹则创建该文件夹
            if (Directory.Exists(Environment.CurrentDirectory + "\\JCRFJ\\FJSP\\" + getInitSFZ) == false)
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\JCRFJ\\FJSP\\" + getInitSFZ);
            string SPextension = Path.GetExtension(SPpathSource);
            string SPextFlag = "";
            //判断选择的是什么文件
            switch (SPextension)
            {//"视频|*.mp4;*.rmvb;*.wmv
                case ".mp4": SPextFlag = "mp4"; break;
                case ".rmvb": SPextFlag = "rmvb"; break;
                case ".wmv": SPextFlag = "wmv"; break;
                default: SPextFlag = "-1"; break;
            }
            //赋值给目标路径
            if (SPextFlag == "mp4")
                SPpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJSP\\" + getInitSFZ + "\\" + SPname;
            else if (SPextFlag == "rmvb")
                SPpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJSP\\" + getInitSFZ + "\\" + SPname;
            else if (SPextFlag == "wmv")
                SPpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJSP\\" + getInitSFZ + "\\" + SPname;
            else
                SPextFlag = "-1";
            //复制文件到目标目录
            try
            {
                File.Copy(SPpathSource, SPpathTarget);
            }
            catch { return false; }
            #region 将路径放入数据库中
            //保存当前时间
            string timeNow = DateTime.Now.ToString();
            //先查询JCRFJ表中有无该对象
            string sql = "select JCRsfz from JCRFJ where JCRsfz='" + getInitSFZ + "'";
            //如果没有，则添加
            if (sqlMethod(sql, 1) == "-1")
            {
                sql = "insert into JCRFJ (JCRname,JCRsfz,WDCount,ZPCount,SPCount,YYCount) values('" + getInitName + "','" + getInitSFZ + "','0','0','0','0')";
                string inJCRFJ = sqlMethod(sql, 2);

                //添加JCRFJ表失败
                if (inJCRFJ == "-1")
                    return false;
            }
            //拿到当前对象文档数量
            sql = "select SPcount from JCRFJ where JCRsfz='" + getInitSFZ + "'";
            string countStr = sqlMethod(sql, 1);
            //未拿到当前文档数量
            if (countStr == "-1")
                return false;
            //向FJSP表插入视频地址
            int count = Convert.ToInt32(countStr);
            sql = "insert into FJSP(JCRname,JCRsfz,SPname,SPpath,SPAddTime,SPdellogo) values('" + getInitName + "','" + getInitSFZ + "','" + SPname + "','" + SPpathTarget + "','" + timeNow + "','0')";
            string inFJSP = sqlMethod(sql, 2);
            if (inFJSP == "-1")
                return false;
            else
            {
                sql = "update JCRFJ set SPCount='" + ++count + "' ";
                sqlMethod(sql, 1);
                return true;
            }
            #endregion
        }

        //添加音频方法
        private bool addYYmethod()
        {
            //查询是否有同名文件存在
            string sqlSameName = "select YYname from FJYY ";
            string sameResult = sqlMethod(sqlSameName, 1);
            if (sameResult == YYname)
            {
                MessageBox.Show("音频名已存在，请改名后添加", "提示");
                return false;
            }

            //string WDguid = Guid.NewGuid().ToString();
            //若不存在该联系人的文件夹则创建该文件夹
            if (Directory.Exists(Environment.CurrentDirectory + "\\JCRFJ\\FJYY\\" + getInitSFZ) == false)
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\JCRFJ\\FJYY\\" + getInitSFZ);
            string YYextension = Path.GetExtension(YYpathSource);
            string YYextFlag = "";
            //判断选择的是什么文件
            switch (YYextension)
            {
                case ".mp3": YYextFlag = "mp3"; break;
                case ".wav": YYextFlag = "wav"; break;
                //case ".wmv": YYextFlag = "wmv"; break;
                default: YYextFlag = "-1"; break;
            }
            //赋值给目标路径
            if (YYextFlag == "mp3")
                YYpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJYY\\" + getInitSFZ + "\\" + YYname;
            else if (YYextFlag == "wav")
                YYpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJYY\\" + getInitSFZ + "\\" + YYname;
            //else if (YYextFlag == "wmv")
            //    SPpathTarget = Environment.CurrentDirectory + "\\JCRFJ\\FJYY\\" + getInitSFZ + "\\" + ZPname;
            else
                YYextFlag = "-1";
            //复制文件到目标目录
            try
            {
                File.Copy(YYpathSource, YYpathTarget);
            }
            catch { return false; }
            #region 将路径放入数据库中
            //保存当前时间
            string timeNow = DateTime.Now.ToString();
            //先查询JCRFJ表中有无该对象
            string sql = "select JCRsfz from JCRFJ where JCRsfz='" + getInitSFZ + "'";
            //如果没有，则添加
            if (sqlMethod(sql, 1) == "-1")
            {
                sql = "insert into JCRFJ (JCRname,JCRsfz,WDCount,ZPCount,SPCount,YYCount) values('" + getInitName + "','" + getInitSFZ + "','0','0','0','0')";
                string inJCRFJ = sqlMethod(sql, 2);

                //添加JCRFJ表失败
                if (inJCRFJ == "-1")
                    return false;
            }
            //拿到当前对象文档数量
            sql = "select YYcount from JCRFJ where JCRsfz='" + getInitSFZ + "'";
            string countStr = sqlMethod(sql, 1);
            //未拿到当前文档数量
            if (countStr == "-1")
                return false;
            //向FJSP表插入视频地址
            int count = Convert.ToInt32(countStr);
            sql = "insert into FJYY(JCRname,JCRsfz,YYname,YYpath,YYAddTime,YYdellogo) values('" + getInitName + "','" + getInitSFZ + "','" + YYname + "','" + YYpathTarget + "','" + timeNow + "','0')";
            string inFJYY = sqlMethod(sql, 2);
            if (inFJYY == "-1")
                return false;
            else
            {
                sql = "update JCRFJ set YYCount='" + ++count + "' ";
                sqlMethod(sql, 1);
                return true;
            }
            #endregion
        }

        //添加按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (WDpathSource == null && ZPpathSource == null && SPpathSource == null && YYpathSource == null)
            {
                MessageBox.Show("请选择要添加的文件","提示");
                return;
            }

            if (getPaWD.Text == "" && getPaZP.Text == "" && getPaSP.Text == "" && getPaYY.Text == "")
            {
                MessageBox.Show("请选择要添加的文件","提示");
                return;
            }
            #region 添加文档       
            //判断是否有文档文件需要上传
            if (WDpathSource != null)
            {
                bool WDOK = addWDmethod();
                if (WDOK == true)
                {
                    MessageBox.Show("添加文档成功", "提示");
                    WDpathSource = "";
                    WDpathTarget = "";
                    WDname = "";
                    getPaWD.Clear();
                }
                else
                {
                    MessageBox.Show("添加文档失败","提示");
                    WDpathSource = "";
                    WDpathTarget = "";
                    WDname = "";
                    getPaWD.Clear();
                }      
             }
            #endregion
            #region 添加照片
            //添加附件
            if (ZPpathSource != null)
            {
                bool ZPOK = addZPmethod();
                if (ZPOK == true)
                {
                    MessageBox.Show("添加照片成功", "提示");
                    ZPpathSource = "";
                    ZPpathTarget = "";
                    ZPname = "";
                    getPaZP.Clear();
                }
                else
                {
                    MessageBox.Show("添加照片失败", "提示");
                    ZPpathSource = "";
                    ZPpathTarget = "";
                    ZPname = "";
                    getPaZP.Clear();
                }
            }
            #endregion
            #region 添加视频
            if (SPpathSource != null)
            {
                bool SPOK = addSPmethod();
                if (SPOK == true)
                {
                    MessageBox.Show("添加视频成功", "提示");
                    SPpathSource = "";
                    SPpathTarget = "";
                    SPname = "";
                    getPaSP.Clear();
                }
                else
                {
                    MessageBox.Show("添加视频失败", "提示");
                    SPpathSource = "";
                    SPpathTarget = "";
                    SPname = "";
                    getPaSP.Clear();
                }
            }
            #endregion
            #region 添加音频
            if (YYpathSource != null)
            {
                bool YYOK = addYYmethod();
                if (YYOK == true)
                {
                    MessageBox.Show("添加音频成功", "提示");
                    YYpathSource = "";
                    YYpathTarget = "";
                    YYname = "";
                    getPaYY.Clear();
                }
                else
                {
                    MessageBox.Show("添加音频失败", "提示");
                    YYpathSource = "";
                    YYpathTarget = "";
                    YYname = "";
                    getPaYY.Clear();
                }
            }
            #endregion
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
