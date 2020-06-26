using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using D2S.Models;

namespace D2S.Models
{
    public class EnvioMensagem
    {
        MySqlConnection con = new MySqlConnection("server=remotemysql.com;user id=DNy7ZqW3WA;persistsecurityinfo=True;database=DNy7ZqW3WA; password=2abgrxDSfR");
        
        public string Enviar(Mensagem msg)
        {
            try
            {
                msg.hora = DateTime.Now;
                MySqlCommand com = new MySqlCommand("INSERT Into DNy7ZqW3WA.mensagens(hora,nome,email,assunto, mensagem)" + "VALUES('" + msg.hora + "','" + msg.nome + "','" + msg.email + "','" + msg.assunto + "','" + msg.texto + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return ("OK.");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    var ff = "";
                    con.Close();
                }
                return (ex.Message.ToString());

            }
        }
    }
}