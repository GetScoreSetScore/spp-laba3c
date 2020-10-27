using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlService;
using LoadService;
using FilterService;
using MailService;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace ServiceHostNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost ControlHost = InitializeHost("http://localhost:8733/ControlService/",typeof(IControl),typeof(Control));
            ServiceHost LoadHost = InitializeHost("http://localhost:8733/LoadService/", typeof(ILoad), typeof(Load));
            ServiceHost FilterHost = InitializeHost("http://localhost:8733/FilterService/", typeof(IFilter), typeof(Filter));
            ServiceHost MailHost = InitializeHost("http://localhost:8733/MailService/", typeof(IMail), typeof(Mail));
            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press  key to stop");
            Console.ReadLine();
            ControlHost.Close();
            LoadHost.Close();
            FilterHost.Close();
            MailHost.Close();
        }
        static ServiceHost InitializeHost(string BaseUri,Type Itype, Type type)
        {
            ServiceHost host = new ServiceHost(type, new Uri(BaseUri));
            host.AddServiceEndpoint(Itype, new WSHttpBinding() { MaxReceivedMessageSize = 2000000000, MaxBufferPoolSize = 2000000000 }, "");
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            host.Open();
            return host;
        }
    }
}
