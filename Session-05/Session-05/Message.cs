using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {

        public Guid ID { get; set; }

        public DateTime TimeStamp { get; set; }

        //TODO: Message idio onoma
        public string Message_ { get; set; }

        public Message()
        {
            TimeStamp = DateTime.Now;
            ID = Guid.NewGuid();

        }
    }
}
