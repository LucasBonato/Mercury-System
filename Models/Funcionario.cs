using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario
    {
        public int cd_funcionario { get; set; }
        public int cd_login { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string nm_funcinario { get; set; }
        public string no_CPF { get; set; }
        public string email { get; set; }
        public string no_telefone { get; set; }
        public string nm_logradouro { get; set; }
        public string no_logradouro { get; set; }
        public string nm_cidade { get; set; }
        public string nm_bairro { get; set; }
        public string no_CEP { get; set; }
        public string sg_UF { get; set; }
    }
}
