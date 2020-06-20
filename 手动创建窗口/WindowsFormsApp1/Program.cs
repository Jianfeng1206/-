using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Form1 myform = new Form1();

          //  Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
          // 回调的是这个class 
            Application.Run(myform);
      //
        }
    }
}
