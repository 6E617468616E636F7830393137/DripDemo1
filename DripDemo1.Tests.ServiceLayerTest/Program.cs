using System;
using System.Configuration;
using Log = Log4net.Helper.Logging.Logger;

namespace DripDemo1.Tests.ServiceLayerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(": : : : : DripDemo1.Test for Service Layer : : : : :");
            Log.Info(": : : : : DripDemo1.Test for Service Layer : : : : :");
            Console.Write("Input string to encode : ");
            var input = Console.ReadLine();
            //Log.Xml(": : : : : DripDemo1.Test for Service Layer : : : : :");
            var keyValue = ConfigurationManager.AppSettings["ServiceKey"];
            Console.WriteLine($"Service Key : {keyValue}");
            var webServiceRequest = new Business.CreateResponseObject.Communications(new Business.CreateResponseObject.Transaction.WebServiceTransaction()).WebServiceCall(keyValue, input);
            Console.WriteLine($"Encoded Key (UTF-8) : {webServiceRequest.EncData}");
            Log.Info($"Encoded Key (UTF-8) : {webServiceRequest.EncData}");
            //Log.Xml($"Encoded Key (UTF-8) : {webServiceRequest.EncData}");
            Log.Info(": : : : : End of DripDemo1.Test for Service Layer : : : : :");            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
