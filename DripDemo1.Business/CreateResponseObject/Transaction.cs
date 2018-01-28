using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DripDemo1.Entities.Models.Web_Service;

namespace DripDemo1.Business.CreateResponseObject
{
    public class Transaction
    {
        public class WebServiceTransaction : ICommunications
        {
            public Response ExecuteWebService(string data, string input)
            {
                return new Transactions.Request().ExecuteWebService(data, input);
            }
        }
    }
}
