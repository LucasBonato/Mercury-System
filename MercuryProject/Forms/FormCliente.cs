using DAO;
using MercuryProject.Properties;
using Models;
using System;
using System.Windows.Forms;

namespace MercuryProject.Forms
{
    public partial class FormCliente : Form
    {
        readonly AllDAO DAO = new AllDAO();
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Texts.Trim(),
                login = txtBoxLogin.Texts.Trim(),
                senha = txtBoxSenha.Texts.Trim(),
                email = txtBoxEmail.Texts.Trim(),
                CEP = txtBoxCEP.Texts.Trim(),
                CPF = txtBoxCPF.Texts.Trim(),
                telefone = txtBoxTelefone.Texts.Trim(),
                dataNasc = txtBoxDataNasc.Texts.Trim(),
                logradouro = txtBoxLogradouro.Texts.Trim(),
                noLogradouro = txtBoxNoLogradouro.Texts.Trim(),
                cidade = txtBoxCidade.Texts.Trim(),
                bairro = txtBoxBairro.Texts.Trim(),
                UF = cmbBoxUF.Texts.Trim();

            string msgError = "";
            if (string.IsNullOrEmpty(name) || name == "" || name.Length > 40)
            {
                msgError = "Preencha o campo Nome";
            } 
            else if (string.IsNullOrEmpty(dataNasc) || dataNasc == "" || dataNasc.Length > 10)
            {
                msgError = "Preencha o campo Data de nascimento";
            }
            else if (string.IsNullOrEmpty(telefone) || telefone == "" || telefone.Length != 11)
            {
                msgError = "Preencha o campo Telefone";
            }
            else if (string.IsNullOrEmpty(CPF) || CPF == "" || CPF.Length != 11)
            {
                msgError = "Preencha o campo CPF";
            }
            else if (string.IsNullOrEmpty(email) || email == "" || email.Length > 50)
            {
                msgError = "Preencha o campo Email";
            }
            else if (string.IsNullOrEmpty(login) || login == "" || login.Length > 20)
            {
                msgError = "Preencha o campo Login";
            }
            else if (string.IsNullOrEmpty(senha) || senha == "" || senha.Length > 15)
            {
                msgError = "Preencha o campo Senha";
            }
            else if (string.IsNullOrEmpty(UF) || UF == "" || cmbBoxUF.SelectedIndex == -1)
            {
                msgError = "Preencha o campo UF";
            }
            else if (string.IsNullOrEmpty(cidade) || cidade == "" || cidade.Length > 30)
            {
                msgError = "Preencha o campo Cidade";
            }
            else if (string.IsNullOrEmpty(bairro) || bairro == "" || bairro.Length > 30)
            {
                msgError = "Preencha o campo Bairro";
            }
            else if (string.IsNullOrEmpty(logradouro) || logradouro == "" || logradouro.Length > 60)
            {
                msgError = "Preencha o campo Logradouro";
            }
            else if (string.IsNullOrEmpty(noLogradouro) || noLogradouro == "" || noLogradouro.Length > 4)
            {
                msgError = "Preencha o campo Número Logradouro";
            }
            else if (string.IsNullOrEmpty(CEP) || CEP == "" || CEP.Length != 8)
            {
                msgError = "Preencha o campo CEP";
            }
            else
            {
                if (!DateTime.TryParse(dataNasc, out DateTime dataNascFinal))
                {
                    txtBoxDataNasc.Texts = "";
                    txtBoxDataNasc.Focus();
                    MessageBox.Show("Digite a data no formato correto. (dd/mm/YYYY)", "Error: Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DAO.Select_Login_Verification(login))
                {
                    txtBoxLogin.Texts = "";
                    txtBoxLogin.Focus();
                    MessageBox.Show("O login digitado já existe!", "Error: Login já existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                Cliente cliente = new Cliente
                {
                    login = login,
                    senha = senha,
                    nm_cliente = name,
                    no_CPF = CPF,
                    email = email,
                    no_telefone = telefone,
                    dt_nascimento = dataNascFinal,
                    nm_logradouro = logradouro,
                    no_logradouro = noLogradouro,
                    nm_cidade = cidade,
                    nm_bairro = bairro,
                    no_CEP = CEP,
                    sg_UF = UF,
                };

                DAO.Insert_Cadastro(cliente);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro bem sucedido", MessageBoxButtons.OK, MessageBoxIcon.None);

                limparFormulario();

                return;
            }
            MessageBox.Show(msgError, "Error: Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limparFormulario()
        {
            txtBoxName.Texts = "";
            txtBoxLogin.Texts = "";
            txtBoxSenha.Texts = "";
            txtBoxEmail.Texts = "";
            txtBoxCEP.Texts = "";
            txtBoxCPF.Texts = "";
            txtBoxTelefone.Texts = "";
            cmbBoxUF.SelectedIndex = -1;
            txtBoxDataNasc.Texts = "";
            txtBoxLogradouro.Texts = "";
            txtBoxNoLogradouro.Texts = "";
            txtBoxCidade.Texts = "";
            txtBoxBairro.Texts = "";
        }
    }
}