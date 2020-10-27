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
    public class Load : ILoad
    {
        public SynItems LoadFeed(string url)
        {
            SynItems result = new SynItems();
            try
            {
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                result.Summaries = feed.Items.Select(item => (item.Summary?.Text) ?? "").ToList();
                result.Titles = feed.Items.Select(item => item.Title.Text).ToList();
                result.Links = feed.Items.Select(item => item.Links[0].Uri.ToString()).ToList();
            }
            catch { }
            return result;
        }
    }
}
