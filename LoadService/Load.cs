using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;
using CommonLibrary;
namespace LoadService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Load : ILoad
    {
        public SynItems LoadFeed(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            SynItems result = new SynItems();
            result.Summaries = feed.Items.Select(item => (item.Summary?.Text) ?? "").ToList();
            result.Titles = feed.Items.Select(item => item.Title.Text).ToList();
            result.Links = feed.Items.Select(item => item.Links[0].Uri.ToString()).ToList();
            return result;
        }
    }
}
