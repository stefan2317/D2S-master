using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Serialization;

namespace D2S.Models
{
    public class Mensagem
    {
        [Key]
        public int id { get; set; }
        public DateTime hora { get; set; }

        [StringLength(100, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 10)]
        [Required(ErrorMessage ="Tem que inserir um assunto")]
        public string assunto { get; set; }

        [StringLength(255, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 3)]
        [Required]
        public string nome { get; set; }

        [EmailAddress]
        [StringLength(255, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 8)]
        [Required]
        public string email { get; set; }

        [StringLength(15000, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 20)]
        [Required]
        public string texto { get; set; }
    }
}
