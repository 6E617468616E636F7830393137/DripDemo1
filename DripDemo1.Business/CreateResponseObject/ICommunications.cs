using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DripDemo1.Business.CreateResponseObject
{
    public interface ICommunications
    {
        Entities.Models.Web_Service.Response ExecuteWebService(string data);
    }
}
