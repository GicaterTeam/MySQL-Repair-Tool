namespace RepairDatabase
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mysqlpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_clearlog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_startmysql = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_repairtable = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_auth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_isstart_mysql = new System.Windows.Forms.Label();
            this.button_stopmysql = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_repair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "第一步:mysql数据库data路径(如果已经自动填写，请不要修改)";
            // 
            // textBox_mysqlpath
            // 
            this.textBox_mysqlpath.Location = new System.Drawing.Point(85, 62);
            this.textBox_mysqlpath.Name = "textBox_mysqlpath";
            this.textBox_mysqlpath.Size = new System.Drawing.Size(412, 21);
            this.textBox_mysqlpath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "第二步:清空mysql日志(需先停止数据库服务,清空后启动数据库服务)";
            // 
            // button_clearlog
            // 
            this.button_clearlog.Location = new System.Drawing.Point(389, 130);
            this.button_clearlog.Name = "button_clearlog";
            this.button_clearlog.Size = new System.Drawing.Size(108, 23);
            this.button_clearlog.TabIndex = 2;
            this.button_clearlog.Text = "清空日志";
            this.button_clearlog.UseVisualStyleBackColor = true;
            this.button_clearlog.Click += new System.EventHandler(this.button_clearlog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "第三步:启动mysql数据库服务";
            // 
            // button_startmysql
            // 
            this.button_startmysql.Location = new System.Drawing.Point(85, 204);
            this.button_startmysql.Name = "button_startmysql";
            this.button_startmysql.Size = new System.Drawing.Size(108, 23);
            this.button_startmysql.TabIndex = 2;
            this.button_startmysql.Text = "启动数据库服务";
            this.button_startmysql.UseVisualStyleBackColor = true;
            this.button_startmysql.Click += new System.EventHandler(this.button_startmysql_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "第四步:修复表结构 ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // button_repairtable
            // 
            this.button_repairtable.Location = new System.Drawing.Point(272, 57);
            this.button_repairtable.Name = "button_repairtable";
            this.button_repairtable.Size = new System.Drawing.Size(108, 23);
            this.button_repairtable.TabIndex = 2;
            this.button_repairtable.Text = "修复表结构";
            this.button_repairtable.UseVisualStyleBackColor = true;
            this.button_repairtable.Click += new System.EventHandler(this.button_repairtable_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(78, 15);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(121, 21);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_auth
            // 
            this.textBox_auth.Location = new System.Drawing.Point(273, 15);
            this.textBox_auth.Name = "textBox_auth";
            this.textBox_auth.Size = new System.Drawing.Size(107, 21);
            this.textBox_auth.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "授权";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "将ID发送给我司客服，客服提供授权码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "修复表";
            // 
            // label_isstart_mysql
            // 
            this.label_isstart_mysql.AutoSize = true;
            this.label_isstart_mysql.Location = new System.Drawing.Point(341, 208);
            this.label_isstart_mysql.Name = "label_isstart_mysql";
            this.label_isstart_mysql.Size = new System.Drawing.Size(41, 12);
            this.label_isstart_mysql.TabIndex = 6;
            this.label_isstart_mysql.Text = "未启动";
            // 
            // button_stopmysql
            // 
            this.button_stopmysql.Location = new System.Drawing.Point(85, 130);
            this.button_stopmysql.Name = "button_stopmysql";
            this.button_stopmysql.Size = new System.Drawing.Size(111, 23);
            this.button_stopmysql.TabIndex = 7;
            this.button_stopmysql.Text = "停止数据库服务";
            this.button_stopmysql.UseVisualStyleBackColor = true;
            this.button_stopmysql.Click += new System.EventHandler(this.button_stopmysql_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "服务状态:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_auth);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.button_repairtable);
            this.groupBox1.Location = new System.Drawing.Point(85, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第二种(请不要随意修复表结构，修复后该表内容将清空)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button_repair);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(85, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第一种";
            // 
            // button_repair
            // 
            this.button_repair.Location = new System.Drawing.Point(272, 50);
            this.button_repair.Name = "button_repair";
            this.button_repair.Size = new System.Drawing.Size(103, 23);
            this.button_repair.TabIndex = 1;
            this.button_repair.Text = "修复";
            this.button_repair.UseVisualStyleBackColor = true;
            this.button_repair.Click += new System.EventHandler(this.button_repair_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(26, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(453, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "点击修复，再打开收银软件试试是否已修复。如果未修复请使用第二种";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::RepairDatabase.Properties.Resources.bkg;
            this.ClientSize = new System.Drawing.Size(654, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_stopmysql);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_isstart_mysql);
            this.Controls.Add(this.button_startmysql);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_clearlog);
            this.Controls.Add(this.textBox_mysqlpath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库修复工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mysqlpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_clearlog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_startmysql;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_repairtable;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_auth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_isstart_mysql;
        private System.Windows.Forms.Button button_stopmysql;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_repair;
        private System.Windows.Forms.Label label10;
    }
}

