using System;
using System.Windows.Forms;

namespace MercuryProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading());
        }
    }
}
