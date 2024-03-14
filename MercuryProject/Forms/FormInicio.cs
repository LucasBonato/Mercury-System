using MercuryProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercuryProject.Forms
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            if (Program.isDark) {
                lblTitulo.ForeColor = Program.darkColors["BaseText"];
                lblSlogan.ForeColor = Program.darkColors["BaseText"];
                this.BackColor = Program.darkColors["BackContent"];
                pictureBox1.Image = Resources.Jaguar_claro;
                pictureBox2.Image = Resources.Mercedez_claro;
                pictureBox3.Image = Resources.Audi_claro;
                pictureBox4.Image = Resources.BMW_claro;
                pictureBox5.Image = Resources.Ferrari_claro;
                pictureBox6.Image = Resources.Lambo_claro;
                pictureBox7.Image = Resources.Porsche_claro;
                pictureBox8.Image = Resources.Bugatti_claro;
            } else {
                lblTitulo.ForeColor = Program.lightColors["BaseText"];
                lblSlogan.ForeColor = Program.lightColors["BaseText"];
                this.BackColor = Program.lightColors["BackContent"];
                pictureBox1.Image = Resources.Jaguar;
                pictureBox2.Image = Resources.Mercedez;
                pictureBox3.Image = Resources.Audi;
                pictureBox4.Image = Resources.BMW;
                pictureBox5.Image = Resources.Ferrari;
                pictureBox6.Image = Resources.Lambo;
                pictureBox7.Image = Resources.Porsche;
                pictureBox8.Image = Resources.Bugatti;
            }
        }
    }
}
