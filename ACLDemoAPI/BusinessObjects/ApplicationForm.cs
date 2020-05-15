using ACLDemoAPI.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Web;
using System.Xml;

namespace ACLDemoAPI.BusinessObjects
{
    public class ApplicationForm : DomainForm
    {
        private readonly JsonDocument value;

        // Domain-only (internal) constructor.
        internal ApplicationForm(JsonDocument value)
        {
            this.value = value;
        }

        // Public factory method.
        // Enforces business constraints. Used by consumers of the domain (application layer etc.)
        // to create new instances of the value object.
        public static ApplicationForm Create(JsonDocument doc)
        {
            //Parse Document based on business logic

            // Business constraints. These will evolve and grow over time.
            if (doc == null)
            {
                throw new Exception("CardApplicationForm cannot be null.");
            }

            return new ApplicationForm(doc);
        }


        private string _partnerurlid = string.Empty;

        private string _solicitation = string.Empty;

        private string _lastname = string.Empty;

        private string _email = string.Empty;



        public string PartnerUrlId { get { return _partnerurlid; } set { _partnerurlid = Clean(value); } }

        public string Solicitation { get { return _solicitation; } set { _solicitation = Clean(value); } }

        public string LastName { get { return _lastname; } set { _lastname = Clean(value); } }

        public string Email { get { return _email; } set { _email = Clean(value).ToLower(); } }


        public override void Validate()
        {

            if (StringCheck.IsValidSolicitation(this.Solicitation)

                && StringCheck.IsValidLastName(this.LastName))

                IsValid = IsValidDomain;

            else

                IsValid = false;

        }
    }
}