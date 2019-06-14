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
           if(HslControls.Authorization.SetAuthorizationCode("c30a230c-07bb-417b-95e1-bd1cc587744e"))
            {
               
            }
            else
            {
                MessageBox.Show("系统激活失败！！！");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
