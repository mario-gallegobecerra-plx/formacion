using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class PERSONAsController : ApiController
    {
        private PersonasEntities db = new PersonasEntities();

        // GET: api/PERSONAs
        [HttpGet]
        [Route("personas")]
        public IQueryable<PERSONA> GetPERSONAS()
        {
            return db.PERSONAS;
        }

        // GET: api/PERSONAs/5
        [ResponseType(typeof(PERSONA))]
        public IHttpActionResult GetPERSONA(int id)
        {
            PERSONA pERSONA = db.PERSONAS.Find(id);
            if (pERSONA == null)
            {
                return NotFound();
            }

            return Ok(pERSONA);
        }

        // PUT: api/PERSONAs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPERSONA(int id, PERSONA pERSONA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pERSONA.ID_PERSONAS)
            {
                return BadRequest();
            }

            db.Entry(pERSONA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PERSONAExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PERSONAs
        [ResponseType(typeof(PERSONA))]
        public IHttpActionResult PostPERSONA(PERSONA pERSONA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PERSONAS.Add(pERSONA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pERSONA.ID_PERSONAS }, pERSONA);
        }

        // DELETE: api/PERSONAs/5
        [ResponseType(typeof(PERSONA))]
        public IHttpActionResult DeletePERSONA(int id)
        {
            PERSONA pERSONA = db.PERSONAS.Find(id);
            if (pERSONA == null)
            {
                return NotFound();
            }

            db.PERSONAS.Remove(pERSONA);
            db.SaveChanges();

            return Ok(pERSONA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PERSONAExists(int id)
        {
            return db.PERSONAS.Count(e => e.ID_PERSONAS == id) > 0;
        }
    }
}