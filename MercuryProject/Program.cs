using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MercuryProject
{
    internal static class Program
    {
        public static bool isDark = false;

        public static Dictionary<String ,Color> lightColors = new Dictionary<String, Color>();
        public static Dictionary<String ,Color> darkColors = new Dictionary<String, Color>();

        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            AddColors();
            Application.Run(new Loading());
        }

        static void AddColors()
        {
            lightColors.Add("BackContent", Color.FromArgb(235, 235, 235));
            lightColors.Add("BackMenu", Color.FromArgb(255, 255, 255));
            lightColors.Add("BaseText", Color.Black);
            lightColors.Add("Vermelho", Color.FromArgb(236, 53, 64));
            lightColors.Add("MDBC", Color.Silver);
            lightColors.Add("MOBC", Color.FromArgb(224, 224, 224));

            darkColors.Add("BackContent", Color.FromArgb(36, 37, 38));
            darkColors.Add("BackMenu", Color.FromArgb(24, 25, 26));
            darkColors.Add("BaseText", Color.White);
            darkColors.Add("Vermelho", Color.FromArgb(236, 53, 64));
        }
    }
}
