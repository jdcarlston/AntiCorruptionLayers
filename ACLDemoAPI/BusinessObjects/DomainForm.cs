using ACLDemoAPI.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACLDemoAPI.BusinessObjects
{
    public abstract class DomainForm : IDomainForm
    {
        private DateTime _datesubmitted = DateTime.MinValue;

        private DateTime _dateprocessed = DateTime.MinValue;



        private bool _isvalid = false;
        private string _notes = String.Empty;



        public DateTime DateSubmitted { get { return _datesubmitted; } set { _datesubmitted = value; } }

        public DateTime DateProcessed { get { return _dateprocessed; } set { _dateprocessed = value; } }


        public string Notes { get { return _notes; } set { _notes = value; } }


        public virtual bool IsValidDomain

        {

            get

            {

                if (!(DateSubmitted.Equals(DateTime.MinValue)))

                    return true;



                return false;

            }

        }



        public virtual bool IsValid
        {

            get { Validate(); return _isvalid; }

            set { _isvalid = value; }

        }



        public DomainForm() { }



        public string Clean(string value)

        {

            return value.Clean();

        }



        public abstract void Validate();
    }
}