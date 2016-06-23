using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using System.Data.Odbc;
using System.IO;
using System.Web.Security;

namespace RepairDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitItem();
            CheckMysql();
        }
        private void InitItem()
        {
            //获取mysql路径
            textBox_mysqlpath.Text = GetMysqlPath();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("order_detail");
            comboBox1.Items.Add("order_head");
            comboBox1.Items.Add("history_order_detail");
            comboBox1.Items.Add("history_order_head");

            textBox_id.Text = Str_char(10, true);
        }
        public string Str_char(int Length, bool Sleep)
        {
            if (Sleep) System.Threading.Thread.Sleep(3);
            char[] Pattern = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string result = "";
            int n = Pattern.Length;
            System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
            for (int i = 0; i < Length; i++)
            {
                int rnd = random.Next(0, n);
                result += Pattern[rnd];
            }
            return result;
        }
        public String GetMysqlPath()
        {
            String re = "";
            RegistryKey regKey;
            try
            {
                regKey = Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Services").OpenSubKey("COOLROID_SQL");
                re = regKey.GetValue("ImagePath", "").ToString();
            }
            catch (System.Exception e)
            {
                e.GetBaseException();
            }
            if (re == "")//如果没找到，则找HKEY_LOCAL_MACHINE, 'SYSTEM\CurrentControlSet\Services\mysqlnt
            {
                try
                {
                    regKey = Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Services").OpenSubKey("mysqlnt");
                    re = regKey.GetValue("ImagePath", "").ToString();
                }
                catch (System.Exception e)
                {
                    e.GetBaseException();
                }
            }
            try
            {
                if (re.Length >0)
                {
                    re = re.Substring(0, re.LastIndexOf("\\"));
                    re = re.Substring(0, re.LastIndexOf("\\"))+"\\data";
                    if (re.Substring(0,1)=="\"")
                    {
                        re = re.Substring(1);
                    }
                }
            }
            catch (System.Exception e)
            {
                e.GetBaseException();
            }
            return re;
        }
        //清除日志
        private void button_clearlog_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(textBox_mysqlpath.Text))
                {
                    MessageBox.Show("mysql数据库的data文件夹不存在");
                    return;
                }  
                DirectoryInfo theFolder = new DirectoryInfo(textBox_mysqlpath.Text);

                FileInfo[] fileInfo = theFolder.GetFiles();        
                foreach (FileInfo NextFile in fileInfo)  //遍历文件
                {
                    String filename = NextFile.Name;
                    if (!filename.Contains("ibdata1"))
                    {
                        if (File.Exists(textBox_mysqlpath.Text+"\\"+filename))
                        {
                            //如果存在则删除
                            File.Delete(textBox_mysqlpath.Text + "\\" + filename);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(ex.ToString());         
            }
            
        }
        //运行指定的cmd命令
        public void RunCmd(String param)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.StandardInput.WriteLine(param);
                p.StandardInput.WriteLine("exit");
                //string strRst = p.StandardOutput.ReadToEnd();

            }
            catch (System.Exception e)
            {
                e.GetBaseException();
                MessageBox.Show(e.ToString());
            }

        }
        //根据进程名检测是否开启
        public bool CheckExeRun(String exeName)
        {
            //bool exist = false;
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName(exeName);
            if (process.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //检测数据库服务是否启动
        private void CheckMysql()
        {
            bool re = CheckExeRun("mysqld");
            if (re)
            {
                label_isstart_mysql.Text = "已启动数据库服务";
            }
            else
            {
                label_isstart_mysql.Text = "未启动数据库服务";
            }
        }
        //启动数据库服务
        private void button_startmysql_Click(object sender, EventArgs e)
        {
            //RunCmd("net start mysql");
            RunCmd("net start COOLROID_SQL");
            RunCmd("net start mysqlnt");
            
            Thread.Sleep(1000);
            CheckMysql();
        }
        public string MD5_10(string source)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(source, "MD5").Substring(0, 10);
        }
        //修复表结构
        private void button_repairtable_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请输入要修复的表名称");
                return;
            }
            if (textBox_auth.Text.Trim() != MD5_10(textBox_id.Text + "coolroid"))
            {
                MessageBox.Show("非法的授权");
                return;
            }
            string sql_conn_str = "DSN=agile_pos";
            OdbcConnection gConn = new OdbcConnection(sql_conn_str);
            try
            {
                gConn.Open();
                if (gConn.State != ConnectionState.Open)
                {
                    MessageBox.Show("打开ODBC失败");
                    return;
                }
                DataSet ds = new DataSet();
                ds.Tables.Add("result");
                try
                {
                    string str = "drop table " + comboBox1.Text+";";
                    //str = "create table "+comboBox1.Text+" like coolroid_train."+comboBox1.Text+";";
                    try
                    {
                        OdbcDataAdapter da = new OdbcDataAdapter(str, gConn);
                        da.Fill(ds, "result");
                    }
                    catch (System.Exception exx)
                    {
                        exx.GetBaseException();
                    }                                        
                    
                    str = "create table " + comboBox1.Text + " like coolroid_train." + comboBox1.Text + ";";

                    OdbcDataAdapter da1 = new OdbcDataAdapter(str, gConn);
                    da1.Fill(ds, "result");
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    MessageBox.Show(ex.ToString());
                    return;
                }

            }
            catch (System.Exception exx)
            {
                exx.GetBaseException();
                MessageBox.Show(exx.ToString());
                return;
            }
            MessageBox.Show("成功修复");
        }
        //结束指定的进程
        public void KillExe(String exeName)
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName(exeName);
            foreach (System.Diagnostics.Process p in process)
            {
                p.Kill();
            }


        }
        private void button_stopmysql_Click(object sender, EventArgs e)
        {
            //RunCmd("net stop COOLROID_SQL");
            //RunCmd("net stop mysqlnt");
            KillExe("mysqld");

            Thread.Sleep(1000);
            CheckMysql();
        }
        //第一种修复方式:先删除错误的frm,再从培训数据库中拷贝一个过来
        private void button_repair_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("请输入要修复的表名称");
                    return;
                }
                //
                String filedir = textBox_mysqlpath.Text + "\\coolroid";
                String backfiledir = textBox_mysqlpath.Text + "\\coolroid_train";
                if (!Directory.Exists(filedir))
                {
                    MessageBox.Show("mysql数据库的data文件夹下不存在coolroid");
                    return;
                }
                if (!Directory.Exists(backfiledir))
                {
                    MessageBox.Show("mysql数据库的data文件夹下不存在coolroid_train");
                    return;
                }
                DirectoryInfo theFolder = new DirectoryInfo(filedir);

                FileInfo[] fileInfo = theFolder.GetFiles();
                foreach (FileInfo NextFile in fileInfo)  //遍历文件
                {
                    String filename = NextFile.Name;
                    if (filename.Contains("#sql"))
                    {
                        if (File.Exists(filedir + "\\" + filename))
                        {
                            //如果存在则删除
                            File.Delete(filedir + "\\" + filename);
                        }
                    }
                }
                //将文件从培训数据库拷贝过来
                DateTime dtnow = DateTime.Now;
                String dtnowstr=dtnow.ToString("yyyy-MM-dd_HH-mm-ss");
                String tempfile = "\\" + comboBox1.Text+".frm";
                try
                {
                    File.Copy(filedir + tempfile, filedir + tempfile + "_back"+dtnowstr, true);
                }
                catch (System.Exception exx)
                {
                    exx.GetBaseException();
                }
                
                File.Copy(backfiledir + tempfile, filedir + tempfile, true);
            }
            catch (System.Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(ex.ToString());
                return;
            }
            MessageBox.Show("成功修复");
        }
    }
}