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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            modifyFlow.Value = Properties.Settings.Default.m流量;
            modifyHammer.Value = Properties.Settings.Default.m冲击力;
            modifyPressure.Value = Properties.Settings.Default.m压力;
            modifyTemperature.Value = Properties.Settings.Default.m温度;
        }

        private void modifyPressure_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.m压力= modifyPressure.Value;
            Properties.Settings.Default.Save();
        }

        private void modifyHammer_ValueChanged(object sender, EventArgs e)
        {
              Properties.Settings.Default.m冲击力=modifyHammer.Value;
            Properties.Settings.Default.Save();
        }

        private void modifyFlow_ValueChanged(object sender, EventArgs e)
        {
              Properties.Settings.Default.m流量=modifyFlow.Value;
            Properties.Settings.Default.Save();
        }

        private void modifyTemperature_ValueChanged(object sender, EventArgs e)
        {
              Properties.Settings.Default.m温度=modifyTemperature.Value;
            Properties.Settings.Default.Save();
        }

        private void Modify_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
