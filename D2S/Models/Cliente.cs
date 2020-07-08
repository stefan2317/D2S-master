using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace D2S.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [StringLength(100, MinimumLength = 10)]
        [Required]
        public string nome { get; set; }

        
        [Required]
        public string telefone { get; set; }

        
        [EmailAddress]
        [StringLength(345, MinimumLength = 8)]
        [Required]
        public string email { get; set; }

        [Required(ErrorMessage = "The genero field is required.")]
        public string sexo { get; set; }
        [Required]
        public string datadenascimento { get; set; }

        
        public Nullable<int> nif { get; set; }

        [Required]
        public string pass { get; set; }

        
        [Compare("pass",ErrorMessage ="The 2 passwords do not match")]
        public string confpass { get; set; }
        
        public string verificar { get; set; }

        public int id_Morada { get; set; }

        public int id_Morada2 { get; set; }

       
    }
}
