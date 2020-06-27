using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace D2S.Models
{
    public class Encomenda
    {
        MySqlConnection con = new MySqlConnection("server=remotemysql.com;user id=DNy7ZqW3WA;persistsecurityinfo=True;database=DNy7ZqW3WA; password=2abgrxDSfR");

        public string Save(FazerEncomenda msg)
        {
            int precisa;
            if (msg.PrecisaEmpacotamento == true)
                precisa = 1;
            else
                precisa = 0;

            try
            {
                MySqlCommand com = new MySqlCommand("INSERT Into DNy7ZqW3WA.Encomendas(id, NomeEncomendado, NomeReceber, ContactoEncomendado, ContactoReceber, ContactoAlternativo, EmailEncomendado, EmailReceber, PrecisaEmpacotamento, Comprimento, Altura, Largura, Peso, id_Morada, id_Morada2)" + "VALUES('0','" + msg.NomeEncomendado + "','" + msg.NomeReceber + "','" + msg.ContactoEncomendo + "','" + msg.ContactoReceber + "','" + msg.ContactoAlternativo + "','" + msg.EmailEncomendado + "','" + msg.EmailReceber + "','" + precisa + "','" + msg.Comprimento + "','" + msg.Altura + "','" + msg.Largura + "','" + msg.Peso + "', '0', '0')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return ("OK.");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());

            }
        }
    }
}
