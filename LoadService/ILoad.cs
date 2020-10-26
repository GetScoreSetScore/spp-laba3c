using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Syndication;
using CommonLibrary;
namespace LoadService
{
    [ServiceContract]
    public interface ILoad
    {
        [OperationContract]
        SynItems LoadFeed(string url);
    }
}
