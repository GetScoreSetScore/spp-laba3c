using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Syndication;
namespace ControlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IControl
    {
        [OperationContract]
        string GetData(string value);

        [OperationContract]
        
        SynItems ProcessFeeds(List<string> feeds, List<string> tags, List<string> mails);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ControlService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    public class SFeed
    {

        List<SyndicationItem> items = new List<SyndicationItem>();
        public List<SyndicationItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        //[DataMember]
        //public List<SyndicationItem> Items = new List<SyndicationItem>();
    }
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
