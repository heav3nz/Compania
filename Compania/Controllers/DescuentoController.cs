using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Compania.Controllers
{
    public class DescuentoController : ApiController
    {
        // GET: api/Descuento
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Descuento/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Descuento
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Descuento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Descuento/5
        public void Delete(int id)
        {
        }
    }
}
