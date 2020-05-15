using ACLDemoAPI.BusinessObjects;
using ACLDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACLDemoAPI.Controllers
{
    public class SolicitationController : ApiController
    {
        List<Solicitation> solicitations = new List<Solicitation>();

        // GET: api/Solicitation
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Solicitation/5
        public Solicitation Get(int id)
        {
            return solicitations.Where(x => x.Id == id).FirstOrDefault();
        }

        // GET: api/Solicitation/5
        public Solicitation Get(string number, string lastname)
        {
            //TODO: Log Request to DB

            return solicitations.Where(x => x.Number == number
                                         && x.LastName == lastname).FirstOrDefault();
        }

        // POST: api/Solicitation
        public void Post(Solicitation solicitation)
        {
            //TODO: EventLog Add to DB

            solicitations.Add(solicitation);
        }

        // PUT: api/Solicitation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Solicitation/5
        public void Delete(int id)
        {
        }
    }
}
