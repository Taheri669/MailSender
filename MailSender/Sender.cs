using Google.Apis.Admin.Directory.directory_v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MailSender.MailSender
{
    public class EmailSender 
    {

        public static string SendEmail()
        {

            try
            {
                // Credentials
                var credentials = new NetworkCredential("user-name@gmail.com", "password");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("user-name@gmail.com"), //sender
                    Subject = "Email Sender App",
                    Body = "It Is Test."
                };
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress("receiver@gmail.com"));
                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "your-host.com",
                    EnableSsl = false,
                    Credentials = credentials
                };
                client.Send(mail);
                return "Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }

        }

    }
}