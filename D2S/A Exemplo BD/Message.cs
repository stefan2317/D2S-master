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
    public class Menssagem
    {
        MySqlConnection con = new MySqlConnection("server=remotemysql.com;user id=DNy7ZqW3WA;persistsecurityinfo=True;database=DNy7ZqW3WA; password=2abgrxDSfR");

        public string Save(EmpClass msg)
        {
            try
            {
                MySqlCommand com = new MySqlCommand("INSERT Into DNy7ZqW3WA.chat(data,nome,texto,hora)" + "VALUES('" + msg.data + "','" + msg.nome + "','" + msg.texto + "','" + msg.hora + "')", con);
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
