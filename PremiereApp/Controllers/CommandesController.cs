using PremiereApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PremiereApp.Controllers
{
    public class CommandesController : ApiController
    {
        // GET: api/Commandes
        public IEnumerable<MyOrder> Get()
        {
            using (AWContext db = new AWContext())
            {
                return db.GetOrders(30072);
            }
        }

        // GET: api/Commandes/5
        public IEnumerable<MyOrder> Get(int id, string nom, string prenom )
        {
            using (AWContext db = new AWContext())
            {
                return db.GetOrders(id);
            }
        }

        // POST: api/Commandes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Commandes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Commandes/5
        [HttpDelete]
        public void toto(int id)
        {
        }
    }
}
