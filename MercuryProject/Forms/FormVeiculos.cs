using Models;
using System;
using System.Windows.Forms;
using DAO;
using MercuryProject.Properties;
using System.Reflection.Emit;

namespace MercuryProject.Forms
{
    public partial class FormVeiculos : Form
    {
        AllDAO DAO = new AllDAO();
        public FormVeiculos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string chassi = txtBoxChassi.Texts.Trim(),
                marca = txtBoxMarca.Texts.Trim(),
                descVeiculo = txtBoxDescVeiculo.Texts.Trim(),
                modelo = txtBoxModelo.Texts.Trim(),
                cor = txtBoxCor.Texts.Trim(),
                placa = txtBoxPlaca.Texts.Trim(),
                fabricante = txtBoxFabricante.Texts.Trim();

            string msgError = "";
            if (string.IsNullOrEmpty(chassi) || chassi == "" || chassi.Length != 17)
            {
                msgError = "Preencha o campo Chassi";
            }
            else if (string.IsNullOrEmpty(marca) || marca == "" || marca.Length > 25)
            {
                msgError = "Preencha o campo Marca";
            }
            else if (string.IsNullOrEmpty(descVeiculo) || descVeiculo == "" || descVeiculo.Length > 60)
            {
                msgError = "Preencha o campo Descrição Veículo";
            }
            else if (string.IsNullOrEmpty(modelo) || modelo == "" || modelo.Length > 20)
            {
                msgError = "Preencha o campo Modelo";
            }
            else if (string.IsNullOrEmpty(cor) || cor == "" || cor.Length > 25)
            {
                msgError = "Preencha o campo Cor";
            }
            else if (string.IsNullOrEmpty(placa) || placa == "" || placa.Length != 7)
            {
                msgError = "Preencha o campo Placa";
            }
            else if (string.IsNullOrEmpty(fabricante) || fabricante == "" || fabricante.Length > 30)
            {
                msgError = "Preencha o campo Fabricante";
            }
            else
            {
                if (DAO.Select_Chassi_Verification(chassi))
                {
                    txtBoxChassi.Texts = "";
                    txtBoxChassi.Focus();
                    MessageBox.Show("O chassi digitado já no sistema!", "Error: Chassi já exixtente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DAO.Select_Placa_Verification(placa))
                {
                    txtBoxPlaca.Texts = "";
                    txtBoxPlaca.Focus();
                    MessageBox.Show("A Placa digitada já no sistema, considere alterar o valor existente!", "Error: Placa já exixtente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Veiculo veiculo = new Veiculo
                {
                    chassi = chassi,
                    modelo = modelo,
                    cor = cor,
                    marca = marca,
                    noPlaca = placa,
                    fabricante = fabricante,
                    ds_veiculo = descVeiculo
                };
                DAO.Insert_Cadastro(veiculo);

                MessageBox.Show("Veículo cadastrado com sucesso!", "Cadastro bem sucedido", MessageBoxButtons.OK, MessageBoxIcon.None);

                limparFormulario();

                return;
            }
            MessageBox.Show(msgError, "Error: Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void limparFormulario()
        {
            txtBoxChassi.Texts = "";
            txtBoxMarca.Texts = "";
            txtBoxDescVeiculo.Texts = "";
            txtBoxModelo.Texts = "";
            txtBoxCor.Texts = "";
            txtBoxPlaca.Texts = "";
            txtBoxFabricante.Texts = "";
        }

        private void FormVeiculos_Load(object sender, EventArgs e)
        {
            if (Program.isDark)
            {
                label1.ForeColor = Program.darkColors["BaseText"];
                lbl.ForeColor = Program.darkColors["BaseText"];
                this.BackColor = Program.darkColors["BackContent"];
                pictureBox3.Image = Resources.Linha_Divisoo_escuro;
            }
            else
            {
                label1.ForeColor = Program.lightColors["BaseText"];
                lbl.ForeColor = Program.lightColors["BaseText"];
                this.BackColor = Program.lightColors["BackContent"];
                pictureBox3.Image = Resources.Linha_Divisoo;
            }
        }
    }
}
