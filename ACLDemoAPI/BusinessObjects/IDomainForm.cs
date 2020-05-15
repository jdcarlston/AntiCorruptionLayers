using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACLDemoAPI.BusinessObjects
{
    public interface IDomainForm
    {
        DateTime DateSubmitted { get; set; }
        DateTime DateProcessed { get; set; }
        bool IsValid { get; set; }

        bool IsValidDomain { get; }
        string Clean(string value);
        void Validate();
    }
}