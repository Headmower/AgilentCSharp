using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AgilentCSharp
{
    static class Program
    {
        static Agilent agilent = null;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            form1.FormClosed += Connected;
            Application.Run(form1);
        }

        static void Connected(object sender, EventArgs e)
        {
            if (agilent == null)
            {
            }
        }
    }
}
