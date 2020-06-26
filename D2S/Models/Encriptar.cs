using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2S.Models
{
        public static class Encriptar
        {
            public static string encriptar(string texto)
            {
                string resultado = string.Empty;
                Byte[] encriptarmetodo = System.Text.Encoding.Unicode.GetBytes(texto);
                resultado = Convert.ToBase64String(encriptarmetodo);
                return resultado;
            }
        }
    
}
