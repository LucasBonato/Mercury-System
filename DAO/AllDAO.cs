using ConnectionBD;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAO
{
    public class AllDAO
    {
        Banco db = new Banco();
        /*ALL*/
        public DataTable Select_Data_Table(string table)
        {
            db.Open();
            string Select = $"SELECT * FROM {table};";
            DataTable dataTable = db.ExecuteScalarTableMySql(Select);
            db.Close();
            return dataTable;
        }
        public bool Select_Login_Verification(string login)
        {
            db.Open();
            string Select = $"SELECT count(user_login) FROM TblLogin WHERE user_login = '{login}';";
            bool res = int.Parse(db.ExecuteScalarMySql(Select)) > 0;
            db.Close();
            return res;
        }
        public void Insert_Login(string login, string senha)
        {
            db.Open();
            string Insert = $"INSERT INTO TblLogin(user_login, senha_login)VALUES('{login}', '{senha}')";
            db.ExecuteNonScalarMySql(Insert);
            db.Close();
        }

        /*LOGIN*/
        public int Login(string login, string senha)
        {
            db.Open();
            string Verify = $"SELECT count(cd_login) FROM TblLogin WHERE user_login = '{login}' AND senha_login = '{senha}';";
            int id = int.Parse(db.ExecuteScalarMySql(Verify));
            db.Close();
            return id;
        }
        private void Insert_Login(Cliente cliente)
        {
            string Insert = $"INSERT INTO TblLogin(user_login, senha_login)VALUES('{cliente.login}', '{cliente.senha}')";
            db.ExecuteNonScalarMySql(Insert);
        }
        private void Insert_Login(Funcionario funcionario)
        {
            string Insert = $"INSERT INTO TblLogin(user_login, senha_login)VALUES('{funcionario.login}', '{funcionario.senha}')";
            db.ExecuteNonScalarMySql(Insert);
        }
        private void Select_Login_cd(Cliente cliente)
        {
            string Select = $"SELECT cd_login FROM TblLogin WHERE user_login = '{cliente.login}';";
            cliente.cd_login = int.Parse(db.ExecuteScalarMySql(Select));
        }
        private void Select_Login_cd(Funcionario funcionario)
        {
            string Select = $"SELECT cd_login FROM TblLogin WHERE user_login = '{funcionario.login}';";
            funcionario.cd_login = int.Parse(db.ExecuteScalarMySql(Select));
        }

        /*CLIENTE*/
        public void Insert_Cadastro(Cliente cliente)
        {
            db.Open();

            Insert_Login(cliente);
            Select_Login_cd(cliente);
            Insert_Cliente(cliente);

            db.Close();
        }
        private void Insert_Cliente(Cliente cliente)
        {
            string Insert =
                $"INSERT INTO TblCliente(cd_login, nm_cliente, no_CPF, email, no_telefone, dt_nascimento, nm_logradouro, no_logradouro, nm_cidade, nm_bairro, no_CEP, sg_UF)" +
                $"VALUES({cliente.cd_login}, '{cliente.nm_cliente}', '{cliente.no_CPF}', '{cliente.email}', '{cliente.no_telefone}', STR_TO_DATE('{cliente.dt_nascimento}', '%d/%m/%Y %T'), '{cliente.nm_logradouro}', '{cliente.no_logradouro}', '{cliente.nm_cidade}', '{cliente.nm_bairro}', '{cliente.no_CEP}', '{cliente.sg_UF}');";
            db.ExecuteNonScalarMySql(Insert);
        }
        public void Update_Cliente(Cliente cliente)
        {
            db.Open();

            string Insert = $"UPDATE TblUser SET NomeUser = '{cliente.nm_cliente}', CargoUser = '{cliente.nm_cidade}', DataNascUser = STR_TO_DATE('{cliente.dt_nascimento}', '%d/%m/%Y %T') WHERE IdUser = {cliente.cd_cliente};";
            db.ExecuteNonScalarMySql(Insert);

            db.Close();
        }
        public void Delete_Cliente(Cliente cliente)
        {
            db.Open();
            string Delete = $"DELETE FROM TblUser WHERE IdUser = {cliente.cd_cliente};";
            db.ExecuteNonScalarMySql(Delete);

            db.Close();
        }

        /*FUNCIONARIO*/
        public void Insert_Cadastro(Funcionario funcionario)
        {
            db.Open();

            Insert_Login(funcionario);
            Select_Login_cd(funcionario);
            Insert_Funcionario(funcionario);

            db.Close();
        }
        private void Insert_Funcionario(Funcionario funcionario)
        {
            string Insert =
                $"INSERT INTO TblFuncionario(cd_login, nm_funcionario, no_CPF, email, no_telefone, nm_logradouro, no_logradouro, nm_cidade, nm_bairro, no_CEP, sg_UF)" +
                $"VALUES({funcionario.cd_login}, '{funcionario.nm_funcinario}', '{funcionario.no_CPF}', '{funcionario.email}', '{funcionario.no_telefone}', '{funcionario.nm_logradouro}', '{funcionario.no_logradouro}', '{funcionario.nm_cidade}', '{funcionario.nm_bairro}', '{funcionario.no_CEP}', '{funcionario.sg_UF}');";
            db.ExecuteNonScalarMySql(Insert);
        }

        /*VEICULO*/
        public void Insert_Cadastro(Veiculo veiculo)
        {
            db.Open();
            string Insert = $"INSERT INTO TblVeiculos(no_chassi, nm_marca, ds_veiculo, ds_modelo, ds_cor, no_placa, nm_fabricante)" +
                $"VALUES('{veiculo.chassi}', '{veiculo.marca}', '{veiculo.ds_veiculo}', '{veiculo.modelo}', '{veiculo.cor}', '{veiculo.noPlaca}', '{veiculo.fabricante}');";
            db.ExecuteNonScalarMySql(Insert);
            db.Close();
        }
        public bool Select_Chassi_Verification(string chassi)
        {
            db.Open();
            string Select = $"SELECT count(no_chassi) FROM TblVeiculos WHERE no_chassi = '{chassi}';";
            bool res = int.Parse(db.ExecuteScalarMySql(Select)) > 0;
            db.Close();
            return res;
        }
        public bool Select_Placa_Verification(string placa)
        {
            db.Open();
            string Select = $"SELECT count(no_placa) FROM TblVeiculos WHERE no_placa = '{placa}';";
            bool res = int.Parse(db.ExecuteScalarMySql(Select)) > 0;
            db.Close();
            return res;
        }
    }
}
