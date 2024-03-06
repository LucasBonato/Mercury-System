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
    }
}
