using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACLDemoAPI.BusinessObjects
{
    public class Person 
    {
        private readonly int _id;
        private readonly string _name;
        private readonly string _username;

        internal Person() { }
    
        public static Person Create(int val_id, string val_username, string val_name)
        {
            int id = val_id;
            //Can implement factory method inside person constructor if desired upon creation but can choose to pull this out
            string username = ValueObjects.Username.Create(val_username).ToString();
            string name = val_name;

            // Business constraints. These will evolve and grow over time.
            if (id <= 0)
            {
                throw new Exception("Id cannot be zero.");
            }

            if (username.Length == 0)
            {
                throw new Exception("Username is required.");
            }

            if (name.Length == 0)
            {
                throw new Exception("Name is required.");
            }

            return new Person(id, username, name);
        }

        public static Person Copy(Person person)
        {
            return Create(person.Id, person.Username, person.Name);
        }

        // Domain-only (internal) constructor.
        internal Person(int id, string username, string name)
        {
            _id = id;
            _username = username;
            _name = name;
        }

        public int Id { get; set; } = 0;
        public string Username { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
    }
}