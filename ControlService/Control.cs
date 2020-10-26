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
namespace ControlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Control : IControl
    {
        public string GetData(string value)
        {
            LoadClient loadClient = new LoadClient(new WSHttpBinding(), new EndpointAddress("http://localhost:8733/LoadService/"));
            FilterClient filterClient = new FilterClient(new WSHttpBinding(), new EndpointAddress("http://localhost:8733/FilterService/"));
            MailClient mailClient = new MailClient(new WSHttpBinding(), new EndpointAddress("http://localhost:8733/MailService/"));
            value = loadClient.GetData(value);
            value = filterClient.GetData(value);
            value = mailClient.GetData(value);
            return value +"Control";
        }
        public SynItems ProcessFeeds(List<string> feedurls, List<string> tags, List<string> recipients)
        {
            SFeed filtereditems = new SFeed();
            foreach(string feedurl in feedurls)
            {
                SFeed items=LoadFeed(feedurl);
                items = FilterItems(items, tags);
                filtereditems.Items.AddRange(items.Items);
            }
            SendMail(filtereditems, recipients);
            SynItems res = new SynItems();
            res.Summaries = filtereditems.Items.Select(item=>item.Summary.Text).ToList();
            res.Links = filtereditems.Items.Select(item => item.Links[0].Uri.ToString()).ToList();
            res.Titles = filtereditems.Items.Select(item => item.Title.Text).ToList();
            return res;
        }
        public SFeed LoadFeed(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            SFeed result = new SFeed();
            result.Items = feed.Items.ToList();
            return result;
        }
        public SFeed FilterItems(SFeed items, List<string> tags)
        {
            SFeed result = new SFeed();
            foreach (SyndicationItem item in items.Items)
            {
                if (tags.Any())
                {
                    foreach (string t in tags)
                    {
                        if (item.Summary?.Text.ToUpper().Contains(t.ToUpper()) ?? false)
                        {
                            result.Items.Add(item);
                            break;
                        }
                    }
                }
                else
                    result.Items.Add(item);
            }
            return result;
        }
        public void SendMail(SFeed items, List<string> recipients)
        {
            string message = message = string.Join(string.Empty,
                items.Items.Select(item => "<a href=\"" + item.Links.First().Uri + "\">" + item.Title.Text + "</a>" + "<br>").ToArray());

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
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
