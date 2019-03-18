using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 冲水阀水力特性测试机
{
    public partial class Curve : Form
    {
        public Curve()
        {
            InitializeComponent();
        }

        private void Curve_Load(object sender, EventArgs e)
        {
            load_Data();
            //EN 6L流量统计图



            //EN 9L流量统计图


            //BSEN 流量统计图


        }

        private void load_Data()
        {
            //总流量达到6L加载数据
            if (!(totalFlow<6)) {

            }
            else
            {
                hslCurveHistory1.Text = "正在加载数据...";
                hslCurveHistory1.RemoveAllCurve();
                new Thread(new ThreadStart(ThreadReadExample1)) { IsBackground = true }.Start();
            }
        }
        //计算特征点
        PointF Qmin = new PointF();
        PointF Qs = new PointF();
        PointF A = new PointF();//2s以后 横轴上的点
        PointF B = new PointF();//累计流量到达6L
        PointF C = new PointF();//累计流量到达9L
        PointF D = new PointF();//0.85*Qmin（E点）
        PointF E = new PointF();//Qmin 
        PointF H = new PointF();
        PointF M = new PointF();
        PointF N = new PointF();
        PointF O = new PointF();
        double totalFlow = 0;
        private void ThreadReadExample1()
        {

            DataTable dt = Form2.dt;
            float[] flow = new float[dt.Rows.Count];
            DateTime[] dateTime = new DateTime[dt.Rows.Count];
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd hh:mm:ss:fff";           

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                flow[i] = (float)Convert.ToDouble(dt.Rows[i][2]);
                // dateTime[i] = Convert.ToDateTime(dt.Rows[i][0],dtFormat);
                dateTime[i] = DateTime.ParseExact((string)dt.Rows[i][0], "yyyy-MM-dd hh:mm:ss:fff",dtFormat);
                //Console.WriteLine((array[i, 0]));
            }



            // 我们假定从数据库中获取到了这些数据信息
            float[] steps = new float[2000];
            float[] data = new float[2000];
            float[] press = new float[2000];
            DateTime[] times = new DateTime[2000];
            Random random = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                steps[i] = random.Next(10);
                data[i] = Convert.ToSingle(random.NextDouble() * 40 + 100);
                times[i] = DateTime.Now.AddSeconds(i - 2000);
                press[i] = Convert.ToSingle(random.NextDouble() * 0.5d + 4);
            }


            DateTime start = dateTime[0];
            DateTime PointA=dateTime[0].AddSeconds(2);
            TimeSpan ts = new TimeSpan(1);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dateTime[i].Second - PointA.Second==0&& dateTime[i].Millisecond - PointA.Millisecond< 100)
                {
                    A.X = i;

                    Console.WriteLine("A.X:" + A.X);
                    Console.WriteLine("PointA:" + PointA);                    
                    Console.WriteLine("dateTime[i]:" + dateTime[i]);
                    Console.WriteLine("i:" + i);
                    break;
                }
            }

            A.Y = 0;
            B.X = A.X * 2;
            C.X = A.X * 3;
            E.Y = 6;
            //暂未赋值的点 ：B 、C、E
            //D
            D.X = 0;
            D.Y = (float)0.85 * E.Y;
            //H 
            H.X = A.X;
            H.Y = E.Y;
            //M
            M.X = B.X;
            M.Y = D.Y;
            //N
            N.X = C.X;
            N.Y = D.Y;

            // 显示出数据信息来
            Invoke(new Action(() =>
            {

                hslCurveHistory1.SetLeftCurve("流量", flow, Color.DodgerBlue, true, "{0:F1} L/s");
                hslCurveHistory1.SetDateTimes(dateTime);
                //hslCurveHistory1.SetLeftCurve("步序", steps);
                //hslCurveHistory1.SetLeftCurve("温度", data, Color.DodgerBlue, true, "{0:F1} ℃");
                //hslCurveHistory1.SetRightCurve("压力", press, Color.Tomato, true, "{0:F2} Mpa");
                //hslCurveHistory1.SetDateTimes(times);
                //hslCurveHistory1.AddMarkForeSection(new HslControls.HslMarkForeSection()
                //{
                //    StartIndex = 900,
                //    EndIndex = 1300,
                //    StartHeight = 0.2f,
                //    Height = 0.8f,
                //});
                //hslCurveHistory1.AddMarkForeSection(new HslControls.HslMarkForeSection()
                //{
                //    StartIndex = 500,
                //    EndIndex = 700,
                //    StartHeight = 0.3f,
                //    Height = 0.7f,
                //    IsRenderTimeText = false,
                //    LinePen = Pens.Orange,
                //    MarkText = "报警区域"
                //});

                // 增加一个三角形的线段标记示例 Points的每个点的X是数据索引，Y是数据值（需要选对参考坐标轴，默认为左坐标轴）                             
                //增加EHAO矩阵
                hslCurveHistory1.AddMarkLine(new HslControls.HslMarkLine()
                {
                    CircleBrush = Brushes.Yellow,
                    IsLeftFrame = true,
                    IsLineClosed = false,
                    LinePen = Pens.Yellow,
                    TextBrush = Brushes.Yellow,
                    Points = new PointF[]
                    {
                         E,H,A
                    },
                    Marks = new string[] { "        E(Qmin)", "H", "A" },
                });
                //HMBA
                hslCurveHistory1.AddMarkLine(new HslControls.HslMarkLine()
                {
                    CircleBrush = Brushes.Yellow,
                    IsLeftFrame = true,
                    IsLineClosed = false,
                    LinePen = Pens.Yellow,
                    TextBrush = Brushes.Yellow,
                    Points = new PointF[]
                   {
                         H,M,B
                   },
                    Marks = new string[] { "H", "M", "B" },
                });
                //DM
                Console.WriteLine();
                hslCurveHistory1.AddMarkLine(new HslControls.HslMarkLine()
                {
                    CircleBrush = Brushes.Yellow,
                    IsLeftFrame = true,
                    IsLineClosed = true,
                    LinePen = Pens.Yellow,
                    TextBrush = Brushes.Yellow,
                    Points = new PointF[]
                   {
                         D,M
                   },
                    Marks = new string[] { "         D(Qs)", "" },
                });

                // 添加一个活动的标记
                HslControls.HslMarkForeSection active = new HslControls.HslMarkForeSection()
                {
                    StartIndex = 1000,
                    EndIndex = 1500,
                    Height = 0.9f,
                };
                //active.CursorTexts.Add("条码", "A123123124ashdiahsd是的iahsidasd");
                //active.CursorTexts.Add("工号", "asd2sd123dasf");
                //hslCurveHistory1.AddMarkActiveSection(active);

                //hslCurveHistory1.SetCurveVisible("步序", false);   // 步序不是曲线信息，不用显示出来
                hslCurveHistory1.ValueMaxLeft = 10;
                hslCurveHistory1.ValueMinLeft = 0;
                hslCurveHistory1.SetScaleByXAxis(7);
                hslCurveHistory1.RenderCurveUI();
                Console.WriteLine("AY:" + A.Y + ":" + A.X);

                if (totalFlow >= 9)//总流量达到9L加载数据
                { 
                    //9L 流量图
                    hslCurveHistory2.SetLeftCurve("温度", flow, Color.DodgerBlue, true, "{0:F1} ℃");
                hslCurveHistory2.SetDateTimes(dateTime);

                // 增加一个三角形的线段标记示例 Points的每个点的X是数据索引，Y是数据值（需要选对参考坐标轴，默认为左坐标轴）                             
                //增加EHAO矩阵
                hslCurveHistory2.AddMarkLine(new HslControls.HslMarkLine()
                {
                    CircleBrush = Brushes.Yellow,
                    IsLeftFrame = true,
                    IsLineClosed = false,
                    LinePen = Pens.Yellow,
                    TextBrush = Brushes.Yellow,
                    Points = new PointF[]
                    {
                         E,H,A
                    },
                    Marks = new string[] { "        E(Qmin)", "H", "A" },
                });
                //HMBA
                hslCurveHistory2.AddMarkLine(new HslControls.HslMarkLine()
                {
                    CircleBrush = Brushes.Yellow,
                    IsLeftFrame = true,
                    IsLineClosed = false,
                    LinePen = Pens.Yellow,
                    TextBrush = Brushes.Yellow,
                    Points = new PointF[]
                   {
                         H,N,C
                   },
                    Marks = new string[] { "H", "N", "C" },
                });
                //DM
                Console.WriteLine();
                hslCurveHistory2.AddMarkLine(new HslControls.HslMarkLine()
                {
                    CircleBrush = Brushes.Yellow,
                    IsLeftFrame = true,
                    IsLineClosed = true,
                    LinePen = Pens.Yellow,
                    TextBrush = Brushes.Yellow,
                    Points = new PointF[]
                   {
                         D,N
                   },
                    Marks = new string[] { "         D(Qs)", "" },
                });


                hslCurveHistory2.ValueMaxLeft = 10;
                hslCurveHistory2.ValueMinLeft = 0;
                hslCurveHistory2.SetScaleByXAxis(xAxis);

                hslCurveHistory2.RenderCurveUI();

            }
            }
            ));            
        }
    

        private void hslButton1_Click(object sender, EventArgs e)
        {           
      
            Bitmap map = new Bitmap(hslCurveHistory1.Width, hslCurveHistory1.Height);
            hslCurveHistory1.DrawToBitmap(map, hslCurveHistory1.ClientRectangle);
            map.Save("D:/EN 6L.bmp");
            //Graphics graph = hslCurveHistory1.CreateGraphics();
            //Size s = hslCurveHistory1.Size;
            //Bitmap memoryImage = new Bitmap(s.Width, s.Height, graph);
            //Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            //Point screen = hslCurveHistory1.PointToScreen(hslCurveHistory1.Location);
            //graph.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
            //memoryGraphics.CopyFromScreen(screen.X, screen.Y, 0, 0, s);
            //memoryImage.Save("D:/EN 6L.bmp");

        }

        private void hslButton2_Click(object sender, EventArgs e)
        {        
            Bitmap map = new Bitmap(hslCurveHistory2.Width, hslCurveHistory2.Height);
            hslCurveHistory2.DrawToBitmap(map, hslCurveHistory2.ClientRectangle);
            map.Save("D:/EN 9L.bmp");       
        }
        float xAxis=7;
        private void hslButton3_Click(object sender, EventArgs e)
        {
            hslCurveHistory1.SetScaleByXAxis(++xAxis>0?xAxis: (xAxis = 1));            
            hslCurveHistory1.RenderCurveUI();
        }

        private void hslButton4_Click(object sender, EventArgs e)
        {
            hslCurveHistory1.SetScaleByXAxis(--xAxis > 0 ? xAxis : (xAxis=1));
            hslCurveHistory1.RenderCurveUI();
        }

        private void hslButton6_Click(object sender, EventArgs e)
        {
            hslCurveHistory2.SetScaleByXAxis(++xAxis > 0 ? xAxis : (xAxis = 1));
            hslCurveHistory2.RenderCurveUI();
        }

        private void hslButton5_Click(object sender, EventArgs e)
        {
            hslCurveHistory2.SetScaleByXAxis(--xAxis > 0 ? xAxis : (xAxis = 1));
            hslCurveHistory2.RenderCurveUI();
        }

        private void hslCurveHistory2_Load(object sender, EventArgs e)
        {

        }
    }
}
