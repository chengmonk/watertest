using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 冲水阀水力特性测试机
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("关闭窗体后，程序会退出！！", "提示！！", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void hslButton1_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form1 f1 = new Form1())
            {
                f1.ShowDialog();
            }
            System.Threading.Thread.Sleep(200);
            Show();
        }

        private void hslButton2_Click(object sender, EventArgs e)
        {
            
           
            Hide();
            using (Form2 f2 = new Form2())
            {
                f2.ShowDialog();
            }
            System.Threading.Thread.Sleep(200);
            Show();
        }
        M_485Rtu mr;
        private void hslButton3_Click(object sender, EventArgs e)
        {
            COMconfig conf;
            conf.botelv = "9600";
            conf.zhanhao = "1";
            conf.shujuwei = "8";
            conf.tingzhiwei = "1";
            conf.dataFromZero = true;
            conf.stringReverse = false;
            conf.COM_Name = "COM11";
            conf.checkInfo = 0;
          mr = new M_485Rtu(conf);
            mr.connect();
        }

        private void hslButton4_Click(object sender, EventArgs e)
        {
            readRtuDataCMD cmd;
            cmd.zijidizhi = "01";
            cmd.gongnengma = "04";
            cmd.adress = "0001";

            cmd.readNum = "0001";
            string cm = cmd.zijidizhi + cmd.gongnengma + cmd.adress + cmd.readNum;
            label4.Text = cm;
            //label3.Text= mr.ReadFrame(cm);
            byte[] b = HslCommunication.BasicFramework.SoftBasic.HexStringToBytes(mr.ReadFrame(cm));
            //label3.Text = "长度：" + b.Length;
            label3.Text = "长度："+mr.bytes2Dec(b[3],b[4]);
        }
    }
}
