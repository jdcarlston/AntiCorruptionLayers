using ACLDemoAPI.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;

namespace ACLDemoAPI.Models
{
    public class CardApplication
    {
        public CardApplication(int Id, Solicitation solicitation, Person person, JsonDocument form) 
        {
          
        }

        //Copy Constructor
        public CardApplication(CardApplication cardapp)
        {
            Id = cardapp.Id;
            Form = cardapp.Form;
            Solicitation = cardapp.Solicitation;
            Person = cardapp.Person;
        }

        public int Id { get; set; } = 0;
        public JsonDocument Form { get; set; }
        public Solicitation Solicitation { get; set; }
        public Person Person { get; set; }
    }
}