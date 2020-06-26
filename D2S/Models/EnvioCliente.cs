using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using D2S.Models;
using System.IO;

namespace D2S.Models
{
    public class EnvioCliente
    {
        MySqlConnection con = new MySqlConnection("server=remotemysql.com;user id=DNy7ZqW3WA;persistsecurityinfo=True;database=DNy7ZqW3WA; password=2abgrxDSfR");
      
        public string addcliente(Cliente model)
        {
            try
            {
                con.Open();
                MySqlCommand mail = new MySqlCommand("Select * From DNy7ZqW3WA.clientes WHERE email = '"+model.email+"'",con);
                MySqlDataReader cmd = mail.ExecuteReader();
                if (cmd.HasRows)
                {
                    Random num = new Random();
                    int veri = num.Next();
                    try
                    {
                        string passfinal = Encriptar.encriptar(model.confpass);
                        MySqlCommand com = new MySqlCommand("INSERT Into DNy7ZqW3WA.clientes(nome,telefone,email,sexo, datadenascimento,nif,pass,verificar,id_Morada,id_Morada2)" + "VALUES('" + model.nome + "','" + model.telefone + "','" + model.email + "','" + model.sexo + "','" + model.datadenascimento + "','" + model.nif + "','" + passfinal + "','" + veri + "','0','0')", con);
                        com.ExecuteNonQuery();
                        con.Close();
                        var mailservice = new EnviarMail();
                        mailservice.enviarmail(subject: "System: Email de confirmacao", body: "Utilize este código para verificar a existencia do seu e-mail\nO código é:  " + veri, mail: model.email);
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
                else
                {
                    return ("Este email ja se encontra a ser usado por outra conta");
                }
            }
            catch (Exception ex)
            {
                return (ex.Message.ToString());
            }

           
        }




    }
}
