using System;
using System.Drawing;
using System.Windows.Forms;

namespace MercuryProject
{
    public partial class Loading : Form
    {
        private int pbValue = 5;
        public Loading()
        {
            InitializeComponent();
            progressBar.ForeColor = Color.FromArgb(236, 53, 64);
            progressBar.Style = ProgressBarStyle.Continuous;
            picBoxCar.BackColor = Color.Transparent;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100) {
                progressBar.Value += pbValue;
                picBoxCar.Location = new Point(picBoxCar.Location.X + (pbValue * 7), picBoxCar.Location.Y);
            } else {
                timerLoading.Enabled = false;
                this.Visible = false;
                Login login = new Login();
                login.Show();
            }
        }
    }
}