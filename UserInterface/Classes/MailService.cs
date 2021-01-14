using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace UserInterface.Classes
{
    class MailService
    {

        #region Func
        private void SendEmailInternal(Email email)
        {

            try
            {
                var smtpClient = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("horticalctest@gmail.com", "Qwerty1@"),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                smtpClient.Send(email.From, email.To, email.Subject, email.Body);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void SendEmail(Action<EmailBuilder> builder)
        {
            var email = new Email();
            builder(new EmailBuilder(email));
            SendEmailInternal(email);
        }
        #endregion

    }
}
