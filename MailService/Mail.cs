using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CommonLibrary;
using System.Net.Mail;
using System.Net;
namespace MailService
{
    public class Mail : IMail
    {
        public void SendMail(SynItems items, List<string> recipients)
        {
            try
            {
                string message = message = string.Join(string.Empty,
                    items.Links.Zip(items.Titles, (first, second) => "<a href=\"" + first + "\">" + second + "</a><br>"));

                string subject = "Selected RSS feed at " + DateTime.Now;
                string sender = "phpmailerlaba@gmail.com";
                string password = "phplabapass";
                foreach (var recipient in recipients)
                {
                    Send(sender, password, recipient, message, subject);
                }
            }
            catch { }
        }
        public void Send(string mailFrom, string password, string mailTo, string message, string subject)
        {
            string username = mailFrom.Split('@')[0];
            MailMessage mailmessage = new MailMessage(mailFrom, mailTo, subject, message);
            mailmessage.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(username, password)

                };
                client.Send(mailmessage);
                client.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            mailmessage.Dispose();
        }
    }
}
