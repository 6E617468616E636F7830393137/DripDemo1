using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DripDemo1.Business.CreateResponseObject
{
    public class Communications
    {
        //Declarations
        private readonly ICommunications communications;
        //Constructor
        public Communications(ICommunications concreteImplementation)
        {
            communications = concreteImplementation;
        }
        public Entities.Models.Web_Service.Response WebServiceCall(string data)
        {
            return communications.ExecuteWebService(data);
        }
    }
}
