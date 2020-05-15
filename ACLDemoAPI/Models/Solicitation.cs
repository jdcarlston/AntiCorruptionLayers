using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACLDemoAPI.BusinessObjects
{
    public class Solicitation
    {
        public Solicitation() { }

        //Copy Constructor
        public Solicitation(Solicitation solicitation)
        {
            Id = solicitation.Id;
            Number = solicitation.Number;
            MarketingCode = solicitation.MarketingCode;
            LastName = solicitation.LastName;
        }

        public int Id { get; set; } = 0;
        public string Number { get; set; } = string.Empty;
        public string MarketingCode { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}