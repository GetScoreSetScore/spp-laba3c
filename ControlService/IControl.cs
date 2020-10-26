using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Syndication;
using CommonLibrary;
namespace ControlService
{
    [ServiceContract]
    public interface IControl
    {
        [OperationContract]
        SynItems ProcessFeeds(List<string> feeds, List<string> tags, List<string> mails);
    }
}
