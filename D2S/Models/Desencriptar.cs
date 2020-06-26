using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2S.Models
{
    public static class Desencriptar
    {
        public static string desencriptar(string texto)
        {
            string resultado = string.Empty;
            Byte[] desencriptametodo = Convert.FromBase64String(texto);
            resultado = System.Text.Encoding.Unicode.GetString(desencriptametodo);
            return resultado;
        }

    }
}
