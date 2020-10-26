using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLibrary
{
    [DataContract]
    public class SynItems
    {
        [DataMember]
        public List<string> Summaries = new List<string>();

        [DataMember]
        public List<string> Titles = new List<string>();

        [DataMember]
        public List<string> Links = new List<string>();
    }
}
