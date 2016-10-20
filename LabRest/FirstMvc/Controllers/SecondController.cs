using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstMvc.Controllers
{
    public class SecondController : ApiController
    {
        // GET: api/Second
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Second/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Second
        public string Post([FromBody]string value)
        {
            return value;
        }

        // PUT: api/Second/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Second/5
        public void Delete(int id)
        {
        }
    }
}
