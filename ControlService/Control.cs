using System.Collections.Generic;
using System.ServiceModel;
using ControlService.FilterServiceReferenceCon;
using ControlService.LoadServiceReferenceCon;
using ControlService.MailServiceReferenceCon;
using CommonLibrary;
using System;
namespace ControlService
{
    public class Control : IControl
    {
        public SynItems ProcessFeeds(List<string> feedurls, List<string> tags, List<string> recipients)
        {
            SynItems filtereditems = new SynItems();
            //try
            //{
                LoadClient loadClient = new LoadClient(new WSHttpBinding() { MaxReceivedMessageSize = 2000000000, MaxBufferPoolSize = 2000000000 },
                    new EndpointAddress("http://localhost:8733/LoadService/"));
                FilterClient filterClient = new FilterClient(new WSHttpBinding() { MaxReceivedMessageSize = 2000000000, MaxBufferPoolSize = 2000000000 },
                    new EndpointAddress("http://localhost:8733/FilterService/"));
                MailClient mailClient = new MailClient(new WSHttpBinding() { MaxReceivedMessageSize = 2000000000, MaxBufferPoolSize = 2000000000 },
                    new EndpointAddress("http://localhost:8733/MailService/"));
                foreach (string feedurl in feedurls)
                {
                    SynItems items = loadClient.LoadFeed(feedurl);
                    items = filterClient.FilterItems(items, tags.ToArray());
                    filtereditems.Summaries.AddRange(items.Summaries);
                    filtereditems.Links.AddRange(items.Links);
                    filtereditems.Titles.AddRange(items.Titles);
                }
                mailClient.SendMail(filtereditems, recipients.ToArray());
            //}
            //catch(Exception ex) 
            //{
            //}
            return filtereditems;
        }
    }
}
