using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计时器
{

    public partial class display : Form
    {
        struct Jieguo
        {
            public int i;
            public int x1;
            public int x2;
            public int x3;
            public int e;
        };
        bool timeRecycle = true;
        bool timeIsSatar = false;
        bool timeDown = false;
        bool enPop = false;
        bool senior = false;
        bool seniorLock = false;
        bool upTimeLock = false;
        int wouldCtn = 0;
        long afterTime = 0;
        DateTime dateSatar;
        TimeSpan tsNow, tsLast, tsCountdown, lastWord;
        TimeSpan afterTickStyle;
        TimeSpan upTime;
        public display()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.Date;
        }

        //定时器事件
        private void timer1_Tick(object sender, EventArgs e)
        {

            if(!timeDown)
            {
                DateTime dateTime = DateTime.Now;
                TimeSpan timeSpan = dateTime - dateSatar;
                
                


                dateSatar = dateTime;
                tsNow += timeSpan;
                if (!upTimeLock)
                {
                    
                    if (tsNow >= (upTime - afterTickStyle))
                    {
                        upTimeLock = true;
                        this.TopMost = true;
                        this.WindowState = FormWindowState.Normal;
                        this.Activate();

                        checkBox2.Checked = true;
                    }
                }


                
                string st;
                st = tsNow.ToString();
                if (st.Length >= 11)
                    st = st.Substring(0, 11);
                textBox1.Text = st;
            }
            else
            {
                DateTime dateTime = DateTime.Now;
                TimeSpan timeSpan = dateTime - dateSatar;
                dateSatar = dateTime;

                tsCountdown -= timeSpan;

                if (afterTickStyle != new TimeSpan(0))
                {
                    if (tsCountdown <= afterTickStyle)
                    {
                        if (enPop && !seniorLock)
                        {
                            seniorLock = true;
                            this.TopMost = true;
                            this.WindowState = FormWindowState.Normal;
                            this.Activate();

                            checkBox2.Checked = true;
                        }
                    }
                }

                if(tsCountdown <= new TimeSpan(0))
                {
                    if (enPop)
                    {
                        this.TopMost = true;
                        this.WindowState = FormWindowState.Normal;
                        this.Activate();

                        checkBox2.Checked = true;
                    }
                    tsCountdown = new TimeSpan(0);
                    timeDown = false;
                    btn_satar.Enabled = true;
                    btn_clrTime.Enabled = true;
                    button1.Text = "倒计时";
                    checkBox_fx.Enabled = true;
                    timer1.Stop();
                    timer1.Enabled = false;
                    
                }
                string st;
                st = tsCountdown.ToString();
                if (st.Length >= 11)
                    st = st.Substring(0, 11);
                textBox1.Text = st;
            }

            

 
        }

        //清零按钮
        private void btn_clrTime_Click(object sender, EventArgs e)
        {

            if (timeIsSatar)
            {
                dateSatar = DateTime.Now;
                tsNow = new TimeSpan(0);
                if (checkBox_fx.Checked)
                {
                    DateTime limitTime = dateTimePicker1.Value;
                    upTime = limitTime - DateTime.Now.Date;
                    upTimeLock = false;
                }
            }
            else
            {
                
                dateSatar = DateTime.Now;
                tsNow = new TimeSpan(0);
                textBox1.Text = "00:00:00.00";
                timeRecycle = true;
            }
        }

        //启动按钮
        private void btn_satar_Click(object sender, EventArgs e)
        {
            if (!timeIsSatar)
            {
                timeIsSatar = true;
                if (timeRecycle)
                {
                    timeRecycle = false;
                    dateSatar = DateTime.Now;
                    tsNow = new TimeSpan(0);
                }
                else
                {
                    dateSatar = DateTime.Now;
                    tsNow = tsLast;
                }

                if(checkBox_fx.Checked)
                {
                    DateTime limitTime = dateTimePicker1.Value;
                    upTime = limitTime - DateTime.Now.Date;
                    upTimeLock = false;
                }

                timer1.Enabled = true;
                timer1.Start();
                btn_satar.Text = "暂停";
                button1.Enabled = false;
            }
            else
            {
                timeIsSatar = false;
                timer1.Stop();
                timer1.Enabled = false;
                btn_satar.Text = "启动";
                tsLast = tsNow;
                button1.Enabled = true;
            }
            
        }

        //计次按钮
        private void btn_would_Click(object sender, EventArgs e)
        {
            Size size = new Size(340, 275);
            this.Size = size;
            wouldCtn++;
            TimeSpan timeSpan = tsNow - lastWord;
            lastWord = tsNow;

            string st;
            st = timeSpan.ToString();
            if (st.Length >= 11)
                st = st.Substring(0, 11);

            textBox2.AppendText(wouldCtn.ToString() + ": " + textBox1.Text+ 
                                 "  /   " + st + "\r\n");
        }

        //倒计时按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timeDown)
            {
                seniorLock = false;
                timeDown = true;
                btn_satar.Enabled = false;
                btn_clrTime.Enabled = false;
                DateTime dateTime = dateTimePicker1.Value;
                tsCountdown = dateTime - DateTime.Now.Date;
                textBox1.Text = tsCountdown.ToString();
                button1.Text = "停止";
                dateSatar = DateTime.Now;
                checkBox_fx.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();

            }
            else
            {
                timeDown = false;
                btn_satar.Enabled = true;
                btn_clrTime.Enabled = true;
                timer1.Stop();
                timer1.Enabled = false;
                button1.Text = "倒计时";
                checkBox_fx.Enabled = true ;
            }
        }

        //折叠
        private void btn_folding_Click(object sender, EventArgs e)
        {
            Size size = new Size(340, 174);
            this.Size = size;
            textBox2.Text = "";
            wouldCtn = 0;
            lastWord = new TimeSpan(0);
            senior = false;
        }

        //高级设置
        private void btn_senior_Click(object sender, EventArgs e)
        {
            if (senior)
            {
                senior = false;
                Size size = new Size(340, 275);
                this.Size = size;
            }
            else
            {
                senior = true;
                Size size = new Size(340, 295);
                this.Size = size;
            }
        }

        private void textBox_afterPop_TextChanged(object sender, EventArgs e)
        {
            string after = textBox_afterPop.Text;

            try
            {
                afterTime = Convert.ToInt32(after);
                if (afterTime > 1000)
                    afterTime = 1000;
                afterTickStyle = new TimeSpan(afterTime * TimeSpan.TicksPerSecond);



            }
            catch
            {
                afterTime = 0;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_fx.Checked)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            if (textBox3.Text != null)
            {
                string text = textBox3.Text;
                long number = 0;
                int item = 0;
                textBox4.Text = "";
                try
                {
                    number = Convert.ToInt64(text);
                    item = Convert.ToInt32(comboBox1.Text);
                }
                catch
                {
                    textBox4.Text = "请输入正确的数字";
                    return;
                }

                if(item == 2)
                {
                    int intNumberCtn = 0;
                    if(number > 65535)
                    {
                        textBox4.Text = "建议选择更大的分组数\r\n";
                    }
                    for (int i = 1; i < 255; i++)
                    {
                        double x;
                        x = (double)number / i;
                        if (x <= 255)
                        {
                            if (x == (int)x)
                            {
                                intNumberCtn++;
                                textBox4.AppendText(i.ToString() + "\t" + x.ToString() + "\r\n");
                            }
                        }
                    }
                    if (intNumberCtn == 0)
                    {
                        int minValue = 255;
                        Jieguo[] jieguo = new Jieguo[50];



                        for (int i = 0; i < 255; i++)
                        {
                            int t;

                            double x;
                            x = (double)number / i;
                            if (x <= 255)
                            {
                                if (x - (int)x >= 0.5)
                                    t = (int)x + 1;
                                else
                                    t = (int)x;
                                if(minValue >= Math.Abs(t * i - number))
                                {
                                    minValue = (int)Math.Abs(t * i - number);
                                    jieguo[intNumberCtn].i = i;
                                    jieguo[intNumberCtn].x1 = t;
                                    jieguo[intNumberCtn].e = minValue;
                                }
                            }
                        }

                        for (int i = 0; i < jieguo.Length; i++)
                        {
                            if(jieguo[i].e == minValue)
                            {
                                textBox4.AppendText(
                                    jieguo[i].i.ToString() + "\t" + 
                                    jieguo[i].x1.ToString() + "\t" +
                                    jieguo[i].e.ToString() + "\r\n");
                            }
                        }
                    }
                    TimeSpan timeSpan = DateTime.Now - dateTime1;
                    textBox4.AppendText("用时:" + timeSpan.TotalSeconds.ToString());
                }
                else if(item == 3)
                {

                }
                else if(item == 4)
                {

                }
                else
                {
                    textBox4.Text = "请输入分组数";
                }




            }
        }

        private void btn_clrTB2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            wouldCtn = 0;
            lastWord = new TimeSpan(0);
        }

        //至于最上方
        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                enPop = true;
            }
            else
            {
                enPop = false;
            }
        }
    }
}
