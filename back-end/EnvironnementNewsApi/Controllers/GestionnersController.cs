using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using EnvironnementNewsApi.Data;

namespace EnvironnementNewsApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class GestionnersController : ApiController
    {
       

        // GET: api/Gestionners
        public IQueryable<Gestionner> GetGestionner()
        {
            return db.Gestionner;
        }

        // GET: api/Gestionners/5
        [ResponseType(typeof(Gestionner))]
        public IHttpActionResult GetGestionner(int id)
        {
            Gestionner gestionner = db.Gestionner.Find(id);
            if (gestionner == null)
            {
                return NotFound();
            }

            return Ok(gestionner);
        }

        // PUT: api/Gestionners/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGestionner(int id, Gestionner gestionner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gestionner.ID)
            {
                return BadRequest();
            }

            db.Entry(gestionner).State = EntityState.Modified;
            db.SaveChanges();

            

            return StatusCode(HttpStatusCode.NoContent);
        }


        // POST: api/Gestionners
        [ResponseType(typeof(Gestionner))]
        public IHttpActionResult PostGestionner(Gestionner gestionner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Gestionner.Add(gestionner);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gestionner.ID }, gestionner);
        }

        // DELETE: api/Gestionners/5
        [ResponseType(typeof(Gestionner))]
        public IHttpActionResult DeleteGestionner(int id)
        {
            Gestionner gestionner = db.Gestionner.Find(id);
            if (gestionner == null)
            {
                return NotFound();
            }

            db.Gestionner.Remove(gestionner);
            db.SaveChanges();

            return Ok(gestionner);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        
        private NEWSEntities db = new NEWSEntities();
    }
}