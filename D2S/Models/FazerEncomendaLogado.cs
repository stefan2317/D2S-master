using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace D2S.Models
{
    public class FazerEncomendaLogado
    {

        [Key]
        public int IDEncomenda { get; set; }
        public int id { get; set; }
        public int id_Morada { get; set; }
        public int id_Morada2 { get; set; }
        [Required(ErrorMessage = "Tem de inserir o seu nome.")]
        public string NomeEncomendado { get; set; }

        [Required(ErrorMessage = "Tem de inserir o seu nome.")]
        public string NomeReceber { get; set; }

        [StringLength(100, ErrorMessage = "O seu número de telefone tem de ter 9 caracteres", MinimumLength = 9)]
        [Required(ErrorMessage = "Tem de inserir o seu número de telefone.")]
        public string ContactoEncomendo { get; set; }

        [StringLength(100, ErrorMessage = "O número de telefone tem de ter 9 caracteres", MinimumLength = 9)]
        [Required(ErrorMessage = "Tem de inserir um número de telefone.")]
        public string ContactoReceber { get; set; }

        [StringLength(100, ErrorMessage = "O número de telefone tem de ter 9 caracteres", MinimumLength = 9)]
        [Required(ErrorMessage = "Tem de inserir um número de telefone.")]
        public string ContactoAlternativo { get; set; }

        [Required(ErrorMessage = "Tem de inserir o seu E-mail.")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "O E-mail não está correto.")]
        [StringLength(100, ErrorMessage = "O E-mail não está correto.")]
        public string EmailEncomendado { get; set; }

        [Required(ErrorMessage = "Tem de inserir o seu E-mail.")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "O E-mail não está correto.")]
        [StringLength(100, ErrorMessage = "O E-mail não está correto.")]
        public string EmailReceber { get; set; }
        public bool PrecisaEmpacotamento { get; set; }

        [Required(ErrorMessage = "Tem de inserir o comprimento da encomenda")]
        public Nullable<int> Comprimento { get; set; }

        [Required(ErrorMessage = "Tem de inserir a altura da encomenda")]
        public Nullable<int> Altura { get; set; }

        [Required(ErrorMessage = "Tem de inserir a largura da encomenda")]
        public Nullable<int> Largura { get; set; }

        [Required(ErrorMessage = "Tem de inserir o peso da encomenda")]
        public Nullable<int> Peso { get; set; }
    }
}
