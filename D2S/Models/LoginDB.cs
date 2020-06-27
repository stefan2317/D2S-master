using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace D2S.Models
{
    public class LoginDB
    {

        MySqlConnection con = new MySqlConnection("server=remotemysql.com;user id=DNy7ZqW3WA;persistsecurityinfo=True;database=DNy7ZqW3WA; password=2abgrxDSfR");
        public string Save(Login log)
        {
            string dd = "";
            try
                {
                MySqlCommand com = new MySqlCommand("SELECT * FROM clientes WHERE email='" + log.email + "' AND pass='" + log.pass + "'", con);
                MySqlCommand com1 = new MySqlCommand("SELECT verificar FROM clientes WHERE email='" + log.email + "' AND pass='" + log.pass + "'", con);
                con.Open();
                MySqlDataReader dr1 = com1.ExecuteReader();
                if (dr1.Read())
                {
                    dd = dr1.GetString(0);
                }
                dr1.Dispose();
                string dd1 = "";
                if (dd == "")
                {
                    dd1 = "s";
                }
                else
                    dd1 = "n";

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    return (dd1);
                }
                else
                {
                    return ("E-mail ou Palavra-Passe incorretas.");
                }
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