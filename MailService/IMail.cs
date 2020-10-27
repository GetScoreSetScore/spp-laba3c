using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Syndication;
using CommonLibrary;
namespace MailService
{
    [ServiceContract]
    public interface IMail
    {
        [OperationContract]
        void SendMail(SynItems items, List<string> recipients);
    }
}
