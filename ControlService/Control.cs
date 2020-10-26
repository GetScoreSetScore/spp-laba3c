using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlService.FilterServiceReferenceCon;
using ControlService.LoadServiceReferenceCon;
using ControlService.MailServiceReferenceCon;
namespace ControlService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Control : IControl
    {
        public string GetData(string value)
        {
            LoadClient loadClient = new LoadClient(new WSHttpBinding(), new EndpointAddress("http://localhost:8733/LoadService/"));
            FilterClient filterClient = new FilterClient(new WSHttpBinding(), new EndpointAddress("http://localhost:8733/FilterService/"));
            MailClient mailClient = new MailClient(new WSHttpBinding(), new EndpointAddress("http://localhost:8733/MailService/"));
            value = loadClient.GetData(value);
            value = filterClient.GetData(value);
            value = mailClient.GetData(value);
            return value +"Control";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
