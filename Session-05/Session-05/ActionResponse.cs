using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResponse
    {

        public Guid RequestID { get; set; }

        public Guid ResponseID { get; set; }

        public String Output { get; set; }


        public ActionResponse(Guid _requestID,string output)
        {
            ResponseID = Guid.NewGuid();
            RequestID = _requestID; 
            Output = output;
        }

        public ActionResponse()
        {
           
        }
    }
}
