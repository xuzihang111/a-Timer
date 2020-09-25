namespace 计时器
{
    partial class display
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(display));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_satar = new System.Windows.Forms.Button();
            this.btn_clrTime = new System.Windows.Forms.Button();
            this.btn_would = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_clrTB2 = new System.Windows.Forms.Button();
            this.btn_folding = new System.Windows.Forms.Button();
            this.btn_senior = new System.Windows.Forms.Button();
            this.textBox_afterPop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_fx = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(81, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "计时弹出";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 64);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "00:00:00.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_satar
            // 
            this.btn_satar.Location = new System.Drawing.Point(162, 65);
            this.btn_satar.Name = "btn_satar";
            this.btn_satar.Size = new System.Drawing.Size(75, 23);
            this.btn_satar.TabIndex = 2;
            this.btn_satar.Text = "启动";
            this.btn_satar.UseVisualStyleBackColor = true;
            this.btn_satar.Click += new System.EventHandler(this.btn_satar_Click);
            // 
            // btn_clrTime
            // 
            this.btn_clrTime.Location = new System.Drawing.Point(243, 65);
            this.btn_clrTime.Name = "btn_clrTime";
            this.btn_clrTime.Size = new System.Drawing.Size(75, 23);
            this.btn_clrTime.TabIndex = 2;
            this.btn_clrTime.Text = "清零";
            this.btn_clrTime.UseVisualStyleBackColor = true;
            this.btn_clrTime.Click += new System.EventHandler(this.btn_clrTime_Click);
            // 
            // btn_would
            // 
            this.btn_would.Location = new System.Drawing.Point(81, 65);
            this.btn_would.Name = "btn_would";
            this.btn_would.Size = new System.Drawing.Size(75, 23);
            this.btn_would.TabIndex = 2;
            this.btn_would.Text = "计次";
            this.btn_would.UseVisualStyleBackColor = true;
            this.btn_would.Click += new System.EventHandler(this.btn_would_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(243, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "置于顶层";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "倒计时";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(75, 21);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 25, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1, 118);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(317, 67);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_clrTB2
            // 
            this.btn_clrTB2.Location = new System.Drawing.Point(243, 191);
            this.btn_clrTB2.Name = "btn_clrTB2";
            this.btn_clrTB2.Size = new System.Drawing.Size(75, 23);
            this.btn_clrTB2.TabIndex = 6;
            this.btn_clrTB2.Text = "清空计次";
            this.btn_clrTB2.UseVisualStyleBackColor = true;
            this.btn_clrTB2.Click += new System.EventHandler(this.btn_clrTB2_Click);
            // 
            // btn_folding
            // 
            this.btn_folding.Location = new System.Drawing.Point(162, 191);
            this.btn_folding.Name = "btn_folding";
            this.btn_folding.Size = new System.Drawing.Size(75, 23);
            this.btn_folding.TabIndex = 7;
            this.btn_folding.Text = "折叠";
            this.btn_folding.UseVisualStyleBackColor = true;
            this.btn_folding.Click += new System.EventHandler(this.btn_folding_Click);
            // 
            // btn_senior
            // 
            this.btn_senior.Location = new System.Drawing.Point(81, 191);
            this.btn_senior.Name = "btn_senior";
            this.btn_senior.Size = new System.Drawing.Size(75, 23);
            this.btn_senior.TabIndex = 8;
            this.btn_senior.Text = "高级";
            this.btn_senior.UseVisualStyleBackColor = true;
            this.btn_senior.Visible = false;
            this.btn_senior.Click += new System.EventHandler(this.btn_senior_Click);
            // 
            // textBox_afterPop
            // 
            this.textBox_afterPop.Location = new System.Drawing.Point(76, 192);
            this.textBox_afterPop.Name = "textBox_afterPop";
            this.textBox_afterPop.Size = new System.Drawing.Size(41, 21);
            this.textBox_afterPop.TabIndex = 9;
            this.textBox_afterPop.Text = "0";
            this.textBox_afterPop.TextChanged += new System.EventHandler(this.textBox_afterPop_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "提前弹出(s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox_fx
            // 
            this.checkBox_fx.AutoSize = true;
            this.checkBox_fx.Location = new System.Drawing.Point(160, 96);
            this.checkBox_fx.Name = "checkBox_fx";
            this.checkBox_fx.Size = new System.Drawing.Size(72, 16);
            this.checkBox_fx.TabIndex = 11;
            this.checkBox_fx.Text = "反向计时";
            this.checkBox_fx.UseVisualStyleBackColor = true;
            this.checkBox_fx.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(327, 241);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.checkBox_fx);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.textBox_afterPop);
            this.tabPage1.Controls.Add(this.btn_satar);
            this.tabPage1.Controls.Add(this.btn_senior);
            this.tabPage1.Controls.Add(this.btn_would);
            this.tabPage1.Controls.Add(this.btn_folding);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btn_clrTB2);
            this.tabPage1.Controls.Add(this.btn_clrTime);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(319, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "定时器";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(319, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "工具";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(179, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "分组数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "值";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 30);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(310, 81);
            this.textBox4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "计算";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 134);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "display";
            this.Text = "定时器 V1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_satar;
        private System.Windows.Forms.Button btn_clrTime;
        private System.Windows.Forms.Button btn_would;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_clrTB2;
        private System.Windows.Forms.Button btn_folding;
        private System.Windows.Forms.Button btn_senior;
        private System.Windows.Forms.TextBox textBox_afterPop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_fx;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}

