using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace D2S.Models
{
    public class FazerEncomenda
    {
        [Key]
        public int IDEncomenda { get; set; }
        public int id { get; set; }
        public int id_Morada { get; set; }
        public int id_Morada2 { get; set; }
        public string NomeEncomendado { get; set; }
        public string NomeReceber { get; set; }
        public string ContactoEncomendo { get; set; }
        public string ContactoReceber { get; set; }
        public string ContactoAlternativo { get; set; }
        public string EmailEncomendado { get; set; }
        public string EmailReceber { get; set; }
        public bool PrecisaEmpacotamento { get; set; }
        public int Comprimento { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Peso { get; set; }
    }
}
