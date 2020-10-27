using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ControlServiceReference;
using CommonLibrary;
namespace ConsoleClient
{
    class ClientMain
    {
        static void Main(string[] args)
        {
            List<string> urls = new List<string>();
            List<string> recipients = new List<string>();
            List<string> tags = new List<string>();
            urls.Add("https://www.ibm.com/developerworks/views/global/rss/libraryview.jsp");
            recipients.Add("andy844551@gmail.com");
            tags.Add("development");
            ControlClient controlClient = new ControlClient();
            Console.ReadLine();

            SynItems items = controlClient.ProcessFeeds(urls.ToArray(), tags.ToArray(),  recipients.ToArray());
            Console.ReadLine();
        }
    }
}
