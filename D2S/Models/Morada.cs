using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace D2S.Models
{
    public class Morada
    {
        [Required]
        public string Rua { get; set; }

        [Required]
        public string numero { get; set; }

        [Required]
        public string Andar { get; set; }

        [Required]
        public Nullable<int> Lado { get; set; }

        [Required]
        public string Letra { get; set; }

        [Required]
        public string Cod_postal { get; set; }

        [Required]
        public string Localidade { get; set; }

        [Required]
        public string Pais { get; set; }

    }
}
