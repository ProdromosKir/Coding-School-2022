using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionRequest
    {

       


        public Guid RequestID { get; set; }
        public string Input { get; set; }

        public ActionEnumType Action { get; set; }

        public ActionRequest()
        {
            RequestID = Guid.NewGuid();
        }
    }
}
