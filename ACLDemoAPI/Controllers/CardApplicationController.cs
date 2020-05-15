using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACLDemoAPI.Controllers
{
    public class CardApplicationController : ApiController
    {
        // GET: api/CardApplication
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CardApplication/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CardApplication
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CardApplication/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CardApplication/5
        public void Delete(int id)
        {
        }
    }
}
