using DAO;
using MercuryProject.CustomControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MercuryProject.Forms
{
    public partial class FormConsulta : Form
    {
        AllDAO DAO = new AllDAO();
        private string[] arrayTables;
        static int indexSelecionado = 0;
        int indexComboBox;
        public FormConsulta()
        {
            InitializeComponent();
            arrayTables = new string[] { "TblCliente", "TblFuncionario", "TblVeiculos" };
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            indexComboBox = comBoxModel.SelectedIndex;
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

        private void dgvDados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RoundedButton button = new RoundedButton
            {
                Size = new Size(150, 30),
                Location = new Point(660, 102),
                BackColor = Program.darkColors["Vermelho"],
                ForeColor = Color.White,
                TextColor = Color.White,
                Text = "Deletar",
                BorderColor = Color.Transparent,
                BorderRadius = 10,
                Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point),
                Name = "btnDelete"
            };
            button.Click += new EventHandler(this.btnDelete_Click);
            Controls.Add(button);
            indexSelecionado = (int)dgvDados.Rows[e.RowIndex].Cells[0].Value;
        }

        private void btnDelete_Click(object sennder, EventArgs e)
        {
            switch (indexComboBox)
            {
                case 0:
                    DAO.Delete_Cliente(indexSelecionado);
                    break;
                case 1:
                    DAO.Delete_Funcionario(indexSelecionado);
                    break;
                case 2:
                    DAO.Delete_Veiculo(indexSelecionado);
                    break;
            }
            dgvDados.DataSource = DAO.Select_Data_Table(arrayTables[indexComboBox]);
        }
    }
}
