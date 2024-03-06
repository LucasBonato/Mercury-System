using DAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MercuryProject
{
    public partial class Login : Form
    {
        AllDAO DAO = new AllDAO();
        public Login()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string login = txtBoxLogin.Texts.Trim(),
                senha = txtBoxSenha.Texts.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar!", "Error: Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (login.Length > 20 || senha.Length > 15)
            {
                MessageBox.Show("Tamanho dos campos excedido! (login: 20 caracteres e senha: 15 caracteres)", "Error: Tamanho maior que o permitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DAO.Login(login, senha) == 0)
            {
                MessageBox.Show("Login ou senha inválidos!", "Error: Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxEye_Click(object sender, EventArgs e)
        {
            if (txtBoxSenha.PasswordChar)
            {
                txtBoxSenha.PasswordChar = false;
                picBoxEye.Image = Properties.Resources.visible;
            }
            else
            {
                txtBoxSenha.PasswordChar = true;
                picBoxEye.Image = Properties.Resources.hide;
            }
        }
    }
}
