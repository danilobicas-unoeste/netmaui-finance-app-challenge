using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MeuConsultorio.ViewModels
{
    public class ConsultorioViewModel
    {
        public int con_seq {get; set; }
        public string con_nome { get; set; }
        public string con_endereco { get; set; }
        public int con_cpf { get; set; }
        public int con_cnpj { get; set; }
        public string con_telefone { get; set; }
        public string con_celular { get; set; }
        public string con_email { get; set; }
    }
}
