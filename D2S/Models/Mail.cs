using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace D2S.Models
{
    public abstract class Mail
    {

        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void iniciosmtpclient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void enviarmail (string subject, string body, string mail)
        {
            var mailmessage = new MailMessage();

            try
            {
                mailmessage.From = new MailAddress(senderMail);
                mailmessage.To.Add(mail);
                mailmessage.Subject = subject;
                mailmessage.Body = body;
                mailmessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailmessage);
                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mailmessage.Dispose();
                smtpClient.Dispose();
            }

        }
            


    }
}
