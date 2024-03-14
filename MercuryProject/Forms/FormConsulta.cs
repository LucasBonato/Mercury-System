using DAO;
using System;
using System.Windows.Forms;

namespace MercuryProject.Forms
{
    public partial class FormConsulta : Form
    {
        AllDAO DAO = new AllDAO();
        private string[] arrayTables;
        public FormConsulta()
        {
            InitializeComponent();
            arrayTables = new string[] { "TblCliente", "TblFuncionario", "TblVeiculos" };
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int indexComboBox = comBoxModel.SelectedIndex;
            if (indexComboBox < 0)
            {
                MessageBox.Show("Selecione um campo antes de fazer a consulta!", "Error: Campo não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvDados.DataSource = DAO.Select_Data_Table(arrayTables[indexComboBox]);
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            if(Program.isDark) {
                label1.ForeColor = Program.darkColors["BaseText"];
                this.BackColor = Program.darkColors["BackContent"];
                dgvDados.BackgroundColor = Program.darkColors["BackMenu"];
            } else {
                label1.ForeColor = Program.lightColors["BaseText"];
                this.BackColor = Program.lightColors["BackContent"];
                dgvDados.BackgroundColor = Program.lightColors["BackMenu"];
            }
        }
    }
}
