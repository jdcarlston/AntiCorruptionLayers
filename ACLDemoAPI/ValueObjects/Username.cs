using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACLDemoAPI.ValueObjects
{
    public class Username
    {
        private readonly string value;

        // Domain-only (internal) constructor.
        internal Username(string value)
        {
            this.value = value;
        }

        // Public factory method.
        // Enforces business constraints. Used by consumers of the domain (application layer etc.)
        // to create new instances of the value object.
        public static Username Create(string value)
        {
           
            // Business constraints. These will evolve and grow over time.
            if (value == null)
            {
                throw new Exception("Username cannot be null.");
            }

            if (value.Length < 2)
            {
                throw new Exception("Invalid Username created.");
            }

            return new Username(value);
        }

        public override string ToString()
        {
            return value;
        }
    }
}