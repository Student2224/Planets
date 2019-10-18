using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

//using System.Text.Json;
using Newtonsoft.Json;


namespace Particles
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static Form1 window;
        static public void Debug(string msg)
        {
            window.DebugMessage.Text = msg;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            window = new Form1();
            Application.Run(window);
        }
    }
}
