

namespace DripDemo1.Business.CreateResponseObject.Transactions
{
    internal class Request
    {
        internal Entities.Models.Web_Service.Response ExecuteWebService(string data, string input)
        {
            var getString = new DripDemo1.Services.Web_Services.Request();
            var encodedData = new Business.Conversions.Conversions(new Business.Conversions.Transaction.StringToHexExecute()).StringToHex8(getString.WebServiceValue(data, input));
            return new Entities.Models.Web_Service.Response()
            {
                EncData = encodedData,
                InData = data
            };
        }
    }
}
