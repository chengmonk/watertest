using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace 冲水阀水力特性测试机
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
           if(HslControls.Authorization.SetAuthorizationCode("d896f94e-8ba6-461c-a5df-b19dfbdc871e"))
            {
               
            }
            else
            {
                MessageBox.Show("系统激活失败！！！");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
