using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections;

namespace D2S.Models
{
    public class Login
    {
        [Key]
        public string email { get; set; }
        public string pass { get; set; }
        public string verificar { get; set; }
    }
}
