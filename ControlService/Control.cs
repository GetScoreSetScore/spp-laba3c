using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlService.FilterServiceReferenceCon;
using ControlService.LoadServiceReferenceCon;
using ControlService.MailServiceReferenceCon;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Net.Mail;
using System.Net;
using CommonLibrary;
namespace ControlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Control : IControl
    {
        public SynItems ProcessFeeds(List<string> feedurls, List<string> tags, List<string> recipients)
        {
            LoadClient loadClient = new LoadClient(new WSHttpBinding() { MaxReceivedMessageSize = 2000000000, MaxBufferPoolSize = 2000000000 }, new EndpointAddress("http://localhost:8733/LoadService/"));
            SynItems filtereditems = new SynItems();
            foreach (string feedurl in feedurls)
            {
                SynItems items = loadClient.LoadFeed(feedurl);
                items = FilterItems(items, tags);
                filtereditems.Summaries.AddRange(items.Summaries);
                filtereditems.Links.AddRange(items.Links);
                filtereditems.Titles.AddRange(items.Titles);
            }
            SendMail(filtereditems, recipients);
            return filtereditems;
        }
        public SynItems FilterItems(SynItems items, List<string> tags)
        {
            SynItems result = new SynItems();
            for(int i =0;i<items.Summaries.Count;i++)
            {
                if (tags.Any())
                {
                    foreach (string t in tags)
                    {
                        if (items.Summaries[i].ToUpper().Contains(t.ToUpper()))
                        {
                            result.Summaries.Add(items.Summaries[i]);
                            result.Links.Add(items.Links[i]);
                            result.Titles.Add(items.Titles[i]);

                            break;
                        }
                    }
                }
                else
                {
                    result.Summaries.Add(items.Summaries[i]);
                    result.Links.Add(items.Links[i]);
                    result.Titles.Add(items.Titles[i]);
                }
            }
            return result;
        }
        public void SendMail(SynItems items, List<string> recipients)
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
