using DAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MercuryProject
{
    public partial class Cadastro : Form
    {
        AllDAO DAO = new AllDAO();
        public Cadastro()
        {
            InitializeComponent();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxEyeSenha_Click(object sender, EventArgs e)
        {
            if (txtBoxSenha.PasswordChar)
            {
                txtBoxSenha.PasswordChar = false;
                picBoxEyeSenha.Image = Properties.Resources.visible;
            }
            else
            {
                txtBoxSenha.PasswordChar = true;
                picBoxEyeSenha.Image = Properties.Resources.hide;
            }
        }

        private void picBoxConfirmaSenha_Click(object sender, EventArgs e)
        {
            if (txtBoxConfirmaSenha.PasswordChar)
            {
                txtBoxConfirmaSenha.PasswordChar = false;
                picBoxConfirmaSenha.Image = Properties.Resources.visible;
            }
            else
            {
                txtBoxConfirmaSenha.PasswordChar = true;
                picBoxConfirmaSenha.Image = Properties.Resources.hide;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string username = txtBoxLogin.Texts.Trim(),
                senha = txtBoxSenha.Texts.Trim(),
                confirmaSenha = txtBoxConfirmaSenha.Texts.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmaSenha))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar!", "Error: Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (username.Length > 20 || senha.Length > 15)
            {
                MessageBox.Show("Tamanho dos campos excedido! (username: 20 caracteres e senha: 15 caracteres)", "Error: Tamanho maior que o permitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DAO.Select_Login_Verification(username))
            {
                MessageBox.Show("Username indisponivel!", "Error: Campo já existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (senha != confirmaSenha)
            {
                MessageBox.Show("As senhas não batem!", "Error: Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DAO.Insert_Login(username, senha);
            MessageBox.Show($"Usuário {username} cadastrado com sucesso!", "Cadastrado", MessageBoxButtons.OK);
            this.Visible = false;
            Login login = new Login();
            login.Show();
        }
    }
}
