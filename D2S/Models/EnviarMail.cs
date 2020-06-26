using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2S.Models
{
    class EnviarMail:Mail
    {
        public EnviarMail()
        {
            senderMail = "NoReplyD2S@gmail.com";
            password = "diogostefansandro";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            iniciosmtpclient();

        }



    }
}
