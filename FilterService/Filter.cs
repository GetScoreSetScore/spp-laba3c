using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CommonLibrary;
namespace FilterService
{
    public class Filter : IFilter
    {
        public SynItems FilterItems(SynItems items, List<string> tags)
        {
            SynItems result = new SynItems();
            for (int i = 0; i < items.Summaries.Count; i++)
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
    }
}
