﻿using System;
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
           if(HslControls.Authorization.SetAuthorizationCode("1043ba6f-6860-4852-ac4f-bd0b6d177b99"))
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
