using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ControlServiceReference;
using ConsoleClient.FilterServiceReference;
using ConsoleClient.LoadServiceReference;
using ConsoleClient.MailServiceReference;
namespace ConsoleClient
{
    class ClientMain
    {
        static void Main(string[] args)
        {
            ControlClient controlClient = new ControlClient();
            FilterClient filterClient = new FilterClient();
            LoadClient loadClient = new LoadClient();
            MailClient mailClient = new MailClient();
            Console.ReadLine();
            Console.WriteLine(controlClient.GetData("test"));
            Console.WriteLine(filterClient.GetData("test"));
            Console.WriteLine(loadClient.GetData("test"));
            Console.WriteLine(mailClient.GetData("test"));
            Console.ReadLine();

        }
    }
}
