using HslCommunication.ModBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 冲水阀水力特性测试机
{
   public struct COMconfig
    {
        public string botelv;//波特率
        public string zhanhao;//站号
        public string shujuwei;//数据位个数
        public string tingzhiwei;//停止位个数        
        public bool dataFromZero;//数据位从零开始读
        public bool stringReverse;//字符串反转
        public string COM_Name;//串口名称
        public int checkInfo;//奇偶校验: 0:无校验 1:奇校验 2:偶校验
        
    }
   public class M_485Rtu
    {
        private static ModbusRtu busRtuClient = null;
        public static COMconfig config;
       public M_485Rtu(COMconfig c)
        {
            config = c;
        }

        public void disConnect()
        {
            busRtuClient.Close();
            MessageBox.Show("串口已关闭");
        }

       public  void connect()
        {
            if (!int.TryParse(config.botelv, out int baudRate))
            {
                MessageBox.Show(DemoUtils.BaudRateInputWrong);
                return;
            }

            if (!int.TryParse(config.shujuwei, out int dataBits))
            {
                MessageBox.Show(DemoUtils.DataBitsInputWrong);
                return;
            }

            if (!int.TryParse(config.tingzhiwei, out int stopBits))
            {
                MessageBox.Show(DemoUtils.StopBitInputWrong);
                return;
            }


            if (!byte.TryParse(config.zhanhao, out byte station))
            {
                MessageBox.Show("Station input wrong！");
                return;
            }

            busRtuClient?.Close();
            busRtuClient = new ModbusRtu(station);
            busRtuClient.AddressStartWithZero = config.dataFromZero;

            busRtuClient.IsStringReverse = config.stringReverse;

            try
            {
                busRtuClient.SerialPortInni(sp =>
                {
                    sp.PortName = config.COM_Name;
                    sp.BaudRate = baudRate;
                    sp.DataBits = dataBits;
                    sp.StopBits = stopBits == 0 ? System.IO.Ports.StopBits.None : (stopBits == 1 ? System.IO.Ports.StopBits.One : System.IO.Ports.StopBits.Two);
                    sp.Parity = config.checkInfo == 0 ? System.IO.Ports.Parity.None : (config.checkInfo == 1 ? System.IO.Ports.Parity.Odd : System.IO.Ports.Parity.Even);
                });
                busRtuClient.Open();
                MessageBox.Show("串口打开成功!!");
                // button2.Enabled = true;
                // button1.Enabled = false;
                //panel2.Enabled = true;

                //userControlCurve1.ReadWriteNet = busRtuClient;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
