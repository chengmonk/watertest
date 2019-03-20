using Automation.BDaq;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace 冲水阀水力特性测试机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
        }
        bool startFlag = false;
        bool pushFlag = false;
        bool pushedFlag = false;
        private void hslButton1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            //hslCurve1.RemoveCurve("A");
            startFlag = true;
            systemInfo.Text = "系统信息：";
            pushWork.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
            

        }
        void pushWorkThread(object source,System.Timers.ElapsedEventArgs e)
        {
            doData[0] = set_bit(doData[0], 3, true);
            daq.InstantDo_Write(doData);
            //System.Console.WriteLine("push:" + doData[0]);
            for (; true;)
            {
                if (pushFlag) break;
            }
            double t= 1000 * (double)numericUpDown1.Value;
            System.Threading.Thread.Sleep((int)t);//
            doData[0] = set_bit(doData[0], 3, false);
            daq.InstantDo_Write(doData);
            pushedFlag = true;
            pushFlag = false;
            // System.Console.WriteLine("push:" + doData[0]);
        }
        private delegate void myDelegate(double[] data);//声明委托   
        private delegate void alarmDelegate(byte[] data,byte diData);//声明委托   

        private Automation.BDaq.WaveformAiCtrl waveformAiCtrl1;
        DAQ_profile daq;
        private config c;
        public const int CHANNEL_COUNT_MAX = 16;
        private double[] m_dataScaled = new double[CHANNEL_COUNT_MAX];
        private DataTable dt;
        private byte[] doData;
        public void WaveformAi()
        {
            waveformAiCtrl1 = new Automation.BDaq.WaveformAiCtrl();
            waveformAiCtrl1.SelectedDevice = new DeviceInformation(0);
            waveformAiCtrl1.LoadProfile(c.profilePath);
           // System.Console.WriteLine(c.profilePath);
            // waveformAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("waveformAiCtrl1._StateStream")));

            Conversion conversion = waveformAiCtrl1.Conversion;
            
            conversion.ChannelStart = c.startChannel;
            conversion.ChannelCount = c.channelCount;
            conversion.ClockRate = c.convertClkRate;
            Record record = waveformAiCtrl1.Record;
            record.SectionCount = c.sectionCount;//The 0 means setting 'streaming' mode.
            record.SectionLength = c.sectionLength;

            this.waveformAiCtrl1.Overrun += new System.EventHandler<Automation.BDaq.BfdAiEventArgs>(this.waveformAiCtrl1_Overrun);
            this.waveformAiCtrl1.CacheOverflow += new System.EventHandler<Automation.BDaq.BfdAiEventArgs>(this.waveformAiCtrl1_CacheOverflow);
            this.waveformAiCtrl1.DataReady += new System.EventHandler<Automation.BDaq.BfdAiEventArgs>(this.waveformAiCtrl1_DataReady);

        }
        public void waveformAiCtrl1_Stop()
        {
            ErrorCode err = ErrorCode.Success;
            err = waveformAiCtrl1.Stop();
            if (err != ErrorCode.Success)
            {
                HandleError(err);
                return;
            }
            Array.Clear(m_dataScaled, 0, m_dataScaled.Length);
        }
        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                MessageBox.Show("Sorry ! some errors happened, the error code is: " + err.ToString(), "AI_InstantAI");
            }
        }
        public void waveformAiCtrl1_Start()
        {
            ErrorCode err = ErrorCode.Success;
            err = waveformAiCtrl1.Prepare();//准备缓存区
            if (err == ErrorCode.Success)
            {
                err = waveformAiCtrl1.Start();
            }

            if (err != ErrorCode.Success)
            {
                HandleError(err);
                return;
            }
            //System.Console.WriteLine(m_dataScaled.Length.ToString());
        }
        private void waveformAiCtrl1_DataReady(object sender, BfdAiEventArgs args)
        {
            ErrorCode err = ErrorCode.Success;
            try
            {
                //The WaveformAiCtrl has been disposed.
                if (waveformAiCtrl1.State == ControlState.Idle)
                {
                    return;
                }
                if (m_dataScaled.Length < args.Count)
                {
                    m_dataScaled = new double[args.Count];
                }

                int chanCount = waveformAiCtrl1.Conversion.ChannelCount;
                int sectionLength = waveformAiCtrl1.Record.SectionLength;
                err = waveformAiCtrl1.GetData(args.Count, m_dataScaled);//读取数据     
                DateTime t = DateTime.Now;
                //
                t.ToString("yyyy-MM-dd hh:mm:ss:fff");
                for (int i = 0; i < m_dataScaled.Length; i += 4)
                {
                    if (startFlag)
                    {
                        dt.Rows.Add(t.ToString("yyyy-MM-dd hh:mm:ss:fff"),
                            Math.Round(m_dataScaled[i], 2),
                            Math.Round(m_dataScaled[i + 1], 2),
                            Math.Round(m_dataScaled[i + 2], 2));
                        if (Math.Round(m_dataScaled[i], 2) > 0.1)//当压力大于某个数值开始 计按下工件的延时
                            pushFlag = true;
                    
                    if(maxPressure < Math.Round(m_dataScaled[i], 2)) { maxPressure = Math.Round(m_dataScaled[i], 2); }
                    if(maxHammer< Math.Round(m_dataScaled[i + 1], 2)) { maxHammer = Math.Round(m_dataScaled[i + 1], 2); }
                    if(pushedFlag&& Math.Round(m_dataScaled[i], 2)<=0)//当压力小于等于某个数值，停止向缓冲区写数据
                        {
                            startFlag = false;
                            pushFlag = false;
                            pushedFlag = false;                           
                            exit = true;
                            
                        }
                    }
                    t = t.AddMilliseconds(1.0); 
                }
                
                myDelegate md = new myDelegate(setText);
                this.Invoke(md, new object[] { m_dataScaled });
                if (err != ErrorCode.Success && err != ErrorCode.WarningRecordEnd)
                {
                    HandleError(err);
                    return;
                }
                System.Diagnostics.Debug.WriteLine(args.Count.ToString());

            }
            catch (System.Exception) { HandleError(err); }
        }
        bool exit = false;
        public void setText(double[] data)
        {
            //textBox1.Text = waveformAiCtrl1.Features.ValueRanges.SetValue();
            //textBox1.Text += data.Length;
            if (exit)
            {
                systemInfo.Text = "系统信息：测试已完成！！！请及时保存数据。";
                hslPlay1.Text = "自动运行";
                hslPlay1.Played = false;
            }
            if (startFlag)
            {
                for (int i = 0; i < data.Length; i += 2)
                {

                    hslCurve1.AddCurveData(
                        new string[] { "A", "B" },
                        new float[]
                        {
                   (float)data[i],
                   (float)data[i+1]
                        }
                    );
                }
                waterHammerMax.Text = "最大水冲击力：" + maxHammer;
                pressureMax.Text = "最大压力：" + maxPressure;
               
            }

            bpqreturn.Text = Math.Round( m_dataScaled[m_dataScaled.Length - 1],2).ToString();
            waterHammer.Text = "水冲击力：" + Math.Round(data[data.Length - 1],2)+" N";
            waterPresuer.Text = "压力：" + Math.Round( data[data.Length - 2],2)+" Bar";
            waterTemperature.Text = "温度：" +Math.Round( data[data.Length - 3],2)+" ℃";
           
        }
        private void waveformAiCtrl1_CacheOverflow(object sender, BfdAiEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void waveformAiCtrl1_Overrun(object sender, BfdAiEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void hslButton2_Click(object sender, EventArgs e)
        {
            startFlag = false;
            pushedFlag = false;
        }

        private void hslButton3_Click(object sender, EventArgs e)
        {
            if (workName.TextLength == 0)
            {
                MessageBox.Show("工件名称不能为空", "警报！！", MessageBoxButtons.OK);
            }
            else
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "文档|*.csv";
                fileDialog.FileName = workName.Text + ".csv";
                fileDialog.InitialDirectory = Application.StartupPath;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataTableToCsvT(dt, fileDialog.FileName);
                    MessageBox.Show("保存成功!");
                }
                fileDialog.Dispose();
            }
        }
        /// <summary>
        /// DataTable导出为CSV
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="strFilePath">路径</param>
        public static void dataTableToCsvT(System.Data.DataTable dt, string strFilePath)
        {
            if (dt == null || dt.Rows.Count == 0)   //确保DataTable中有数据
                return;
            string strBufferLine = "";
            StreamWriter strmWriterObj = new StreamWriter(strFilePath, false, System.Text.Encoding.Default);
            //写入列头
            foreach (System.Data.DataColumn col in dt.Columns)
                strBufferLine += col.ColumnName + ",";
            strBufferLine = strBufferLine.Substring(0, strBufferLine.Length - 1);
            strmWriterObj.WriteLine(strBufferLine);
            //写入记录
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strBufferLine = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (j > 0)
                        strBufferLine += ",";
                    strBufferLine += dt.Rows[i][j].ToString().Replace(",", "");   //因为CSV文件以逗号分割，在这里替换为空
                }
                strmWriterObj.WriteLine(strBufferLine);
            }
            strmWriterObj.Close();
        }

        /// <summary>
        /// 读取CSV
        /// </summary>
        /// <param name="filePath">CSV路径</param>
        /// <param name="n">表示第n行是字段title,第n+1行是记录开始</param>
        /// <returns></returns>
        public static System.Data.DataTable CsvToDataTable(string filePath, int n)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            StreamReader reader = new StreamReader(filePath, System.Text.Encoding.Default, false);
            int m = 0;

            while (!reader.EndOfStream)
            {
                m = m + 1;
                string str = reader.ReadLine();
                string[] split = str.Split(',');
                if (m == n)
                {
                    System.Data.DataColumn column; //列名
                    for (int c = 0; c < split.Length; c++)
                    {
                        column = new System.Data.DataColumn();
                        column.DataType = System.Type.GetType("System.String");
                        column.ColumnName = split[c];
                        if (dt.Columns.Contains(split[c]))                 //重复列名处理
                            column.ColumnName = split[c] + c;
                        dt.Columns.Add(column);
                    }
                }
                if (m >= n + 1)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    for (int i = 0; i < split.Length; i++)
                    {
                        dr[i] = split[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            reader.Close();
            return dt;
        }
        //System.Timers.Timer alarm;
        System.Timers.Timer pushWork;
        System.Timers.Timer monitor;
        double maxPressure, maxHammer;
        private void Form1_Load(object sender, EventArgs e)
        {
            pushedFlag = false;
            startFlag = false;
            pushFlag = false;
            maxHammer = -1;
            maxPressure = -1;
            c = new config();
            c.channelCount = 4;//开启通道个数
            //通道0  压力 pressure
            //通道1  水冲击力  waterHammer
            //通道2  温度
            //通道3  变频器返回值
            //通道4  流量
            c.convertClkRate = 1000;//每个通道的时钟频率
            c.deviceDescription = "DemoDevice,BID#0";
            c.profilePath = "D:/demo.xml";
            c.sectionCount = 0;//The 0 means setting 'streaming' mode.
            c.sectionLength = 1000;//每个通道的缓冲区长度
            c.startChannel = 0;

            //初始化研华板卡的功能
            daq = new DAQ_profile(0, c);
            daq.InstantAo();
            daq.InstantDi();
            daq.InstantDo();
            doData = new byte[2] { 0x00,0x00};
            
            
            bpqzt.Text = "变频器当前状态：变频";
            sbzt.Text = "水泵当前状态：";
            sbyali.Value = Properties.Settings.Default.水泵压力;
            numericUpDown1.Value = Properties.Settings.Default.保持时间;

            hslCurve1.SetLeftCurve("A", null, Color.DodgerBlue);
            hslCurve1.SetLeftCurve("B", null, Color.DarkOrange);
            
            hslCurve1.ValueMaxLeft = 10;
            hslCurve1.ValueMaxRight = 10;
            hslCurve1.StrechDataCountMax = 1000;//设置显示数据量
            //hslCurve1.IsAbscissaStrech = true;//这是数据全部显示
            BindingSource bs = new BindingSource();

            bs.DataSource = dt;
            monitor = new System.Timers.Timer(50);
            monitor.Elapsed += new System.Timers.ElapsedEventHandler(theout);//到达时间的时候执行事件； 
            monitor.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            monitor.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件； 

            pushWork = new System.Timers.Timer(1);
            pushWork.Elapsed += new System.Timers.ElapsedEventHandler(pushWorkThread);//到达时间的时候执行事件； 
            pushWork.AutoReset = false;//设置是执行一次（false）还是一直执行(true)；

            dt.Columns.Add("时间", typeof(string));
            dt.Columns.Add("压力", typeof(double));   //新建第一列
            dt.Columns.Add("冲击力", typeof(double));      //新建第二列   
            dt.Columns.Add("温度", typeof(double));

            WaveformAi();
            waveformAiCtrl1_Start();

        }

       
        /// <summary>
        /// 获取数据中某一位的值
        /// </summary>
        /// <param name="input">传入的数据类型,可换成其它数据类型,比如Int</param>
        /// <param name="index">要获取的第几位的序号,从0开始 0-7</param>
        /// <returns>返回值为-1表示获取值失败</returns>
        private int GetbitValue(byte input, int index)
        {
            //if (index > sizeof(byte))
            //{
            //    return -1;
            //}
            
            return ((input & (1 << index)) > 0) ? 1 : 0;
        }
        void theout(object source, System.Timers.ElapsedEventArgs e) {
            byte diData = daq.InstantDi_Read();
                alarmDelegate md = new alarmDelegate(alarmactive);
            // daq.EventCount_Read();
            if (this.IsHandleCreated)
                this.Invoke(md, new object[] {doData ,diData});
            
        }
        void alarmactive(byte[] data,byte diData)
        { 
            if (GetbitValue(data[0], 1) == 1)
            {
                bpqzt.Text = "变频器当前状态：定频";
            }
            else
            {
                bpqzt.Text = "变频器当前状态：变频";
            }

            if (GetbitValue(data[0], 0) == 1)
            {
                //sbzt.Text = "水泵当前状态：运行中...";
                hslBlower1.MoveSpeed = (float)aoData[0] / 2;
                hslBlower1.Text = "水泵运行中...";
            }
            else
            {
                // sbzt.Text = "水泵当前状态：关闭";
                hslBlower1.MoveSpeed = 0;
                hslBlower1.Text = "水泵已关闭";
            }

            if (GetbitValue(data[0], 2) == 1)
            {
                qdfstatus.Text = "气动阀当前状态：已按下...";
                hslSwitch2.SwitchStatus = true;
            }else
            {
                hslSwitch2.SwitchStatus = false;
                qdfstatus.Text = "气动阀当前状态：关闭";
            }

            //变频器报警
            //重置所有设置
            if (GetbitValue(diData, 0) == 1)
            {
                //startFlag = false;
                //pushFlag = false;
                //pushedFlag = false;

                //doData[0] = set_bit(doData[0], 1, false);
                //daq.InstantDo_Write(doData);
                //open.Text = "打开水泵";

                //systemInfo.Text += "警报！！变频器报警！！！";
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("关闭窗体后，程序会退出！！", "提示！！", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                e.Cancel = false;
                System.Environment.Exit(0);
            }
            else
            {
                waveformAiCtrl1_Stop();
                monitor.Dispose();
                pushWork.Dispose();
                //e.Cancel = true;
            }
        }

        private void hslCurve1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void hslButton4_Click(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// 设置某一位的值
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index">要设置的位， 值从低到高为 1-8</param>
        /// <param name="flag">要设置的值 true / false</param>
        /// <returns></returns>
        byte set_bit(byte data, int index, bool flag)
        {
            if (index > 8 || index < 1)
                throw new ArgumentOutOfRangeException();
            int v = index < 2 ? index : (2 << (index - 2));
            return flag ? (byte)(data | v) : (byte)(data & ~v);
        }
        
        private void hslButton5_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            aoData[0] = (double)sbyali.Value;
            Properties.Settings.Default.水泵压力 = sbyali.Value;
            Properties.Settings.Default.Save();
            daq.InstantAo_Write(aoData);
        }

        private void bp_Click(object sender, EventArgs e)
        {
            doData[0] = set_bit(doData[0], 2, false);
            daq.InstantDo_Write(doData);
           
            //bpqzt.Text = "变频器当前状态：变频";
        }

        private void dp_Click(object sender, EventArgs e)
        {
            doData[0] = set_bit(doData[0], 2, true);
            daq.InstantDo_Write(doData);

            aoData[0] = Convert.ToDouble( bpqreturn.Text);
            daq.InstantAo_Write(aoData);

       
        }
        double[] aoData = new double[1];
        private void hslButton4_Click_1(object sender, EventArgs e)
        {
            if (open.Text == "打开水泵")
            {
                doData[0] = set_bit(doData[0], 1, true);
                daq.InstantDo_Write(doData);
                
                 aoData[0] =   (double)sbyali.Value ;
                daq.InstantAo_Write(aoData);
                open.Text = "关闭水泵";
                //sbzt.Text = "水泵当前状态：运行中...";
            }
            else
            {
                doData[0] = set_bit(doData[0], 1, false);
                daq.InstantDo_Write(doData);
                //sbzt.Text = "水泵当前状态：关闭";
                open.Text = "打开水泵";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.保持时间 = numericUpDown1.Value;
            Properties.Settings.Default.Save();
        }

        private void hslButton4_Click_2(object sender, EventArgs e)
        {
            Modify m = new Modify();
            m.Show();
        }

        private void hslSwitch1_OnSwitchChanged(object arg1, bool arg2)
        {
            if (arg2)//定频
            {
                doData[0] = set_bit(doData[0], 2, true);
                daq.InstantDo_Write(doData);

                aoData[0] = Convert.ToDouble(bpqreturn.Text);
                daq.InstantAo_Write(aoData);
            }
            else//变频
            {
                aoData[0] = (double)sbyali.Value;
                daq.InstantAo_Write(aoData);
                doData[0] = set_bit(doData[0], 2, false);
                daq.InstantDo_Write(doData);
            }
        }

        private void hslBlower1_Click(object sender, EventArgs e)
        {
            if (open.Text == "打开水泵")
            {
                doData[0] = set_bit(doData[0], 1, true);
                daq.InstantDo_Write(doData);

                aoData[0] = (double)sbyali.Value;
                daq.InstantAo_Write(aoData);
                open.Text = "关闭水泵";
                //sbzt.Text = "水泵当前状态：运行中...";
            }
            else
            {
                doData[0] = set_bit(doData[0], 1, false);
                daq.InstantDo_Write(doData);
                //sbzt.Text = "水泵当前状态：关闭";
                open.Text = "打开水泵";
            }
        }

        private void hslButton5_Click_1(object sender, EventArgs e)
        {

          
        }

        private void hslSwitch2_OnSwitchChanged(object arg1, bool arg2)
        {
            if (arg2)
            {
                doData[0] = set_bit(doData[0], 3, true);
                daq.InstantDo_Write(doData);

            }
            else
            {
                doData[0] = set_bit(doData[0], 3, false);
                daq.InstantDo_Write(doData);

            }
        }

        private void hslPlay1_OnPlayChanged(object arg1, bool arg2)
        {
            if (arg2)
            {
                exit = false;
                pushedFlag = false;
                pushFlag = false;
                dt.Clear();
                //hslCurve1.RemoveCurve("A");
                startFlag = true;
                systemInfo.Text = "系统信息：";
                pushWork.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；

            }
            else
            {
                startFlag = false;
                pushedFlag = false;
            }
        }

        private void workName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
