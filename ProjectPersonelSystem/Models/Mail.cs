using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPersonelSystem.Models
{
    public class Mail
    {

        public int ID { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Msg { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}