using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MercuryProject
{
    public partial class Menu : Form
    {
        Button btnAtual;
        Form formAtual;
        public Menu()
        {
            InitializeComponent();
            btnInicio_Click(btnInicio, new EventArgs());
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirNovoPanel(new Forms.FormInicio(), sender);
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirNovoPanel(new Forms.FormCliente(), sender);
        }
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirNovoPanel(new Forms.FormFuncionario(), sender);
        }
        private void btnVeículos_Click(object sender, EventArgs e)
        {
            AbrirNovoPanel(new Forms.FormVeiculos(), sender);
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AbrirNovoPanel(new Forms.FormConsulta(), sender);
        }
        private void AbrirNovoPanel(Form novoForm, object sender)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }
            ButtonAtivado(sender);
            formAtual = novoForm;
            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(novoForm);
            this.contentPanel.Tag = novoForm;
            novoForm.BringToFront();
            novoForm.Show();
        }
        private void ButtonAtivado(object sender)
        {
            if (sender != null)
            {
                if (btnAtual != (Button)sender)
                {
                    DesativarButtonAnterior();
                    btnAtual = (Button)sender;
                    btnAtual.ForeColor = Color.FromArgb(236, 53, 64);
                }
            }
        }
        private void DesativarButtonAnterior()
        {
            foreach (Control buttonAnterior in menuPanel.Controls)
            {
                if (buttonAnterior.GetType() == typeof(Button))
                {
                    buttonAnterior.ForeColor = Color.Black;
                }
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}