using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int cd_cliente { get; set; }
        public int cd_login { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string nm_cliente { get; set; }
        public string no_CPF { get; set; }
        public string email { get; set; }
        public string no_telefone { get; set; }
        public DateTime dt_nascimento { get; set; }
        public string nm_logradouro { get; set; }
        public string no_logradouro { get; set; }
        public string nm_cidade { get; set; }
        public string nm_bairro { get; set; }
        public string no_CEP { get; set; }
        public string sg_UF { get; set; }
    }
}
