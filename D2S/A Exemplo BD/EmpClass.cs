using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace D2S.Models
{
    public class EmpClass
    {

        [Key]
        public string data { get; set; }
        public string nome { get; set; }
        public string texto { get; set; }
        public string hora { get; set; }
    }
}