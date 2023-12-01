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
using Final_ProjectJob;

namespace Final_ProjectJob.Controllers
{
    public class JobsAPIController : ApiController
    {
        private MyModel db = new MyModel();

        // GET: api/JobsAPI
        public IQueryable<Jobs> GetJobs()
        {
            Uri host = new Uri(Request.RequestUri.ToString());
            string url = host.GetLeftPart(UriPartial.Authority);

            var prod = db.Jobs.ToList();
            foreach(var item in prod)
            {
                item.CompanyImage = url + "/Content/images/" + item.CompanyImage;
            }
            return db.Jobs;
        }

        // GET: api/JobsAPI/5
        [ResponseType(typeof(Jobs))]
        public IHttpActionResult GetJobs(int id)
        {
            Uri host = new Uri(Request.RequestUri.ToString());
            string url = host.GetLeftPart(UriPartial.Authority);

            Jobs jobs = db.Jobs.Find(id);
            if (jobs == null)
            {
                return NotFound();
            }
            jobs.CompanyImage = url + "/Content/images/" + jobs.CompanyImage;


            return Ok(jobs);
        }

        // PUT: api/JobsAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutJobs(int id, Jobs jobs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != jobs.JobId)
            {
                return BadRequest();
            }

            db.Entry(jobs).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobsExists(id))
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

        // POST: api/JobsAPI
        [ResponseType(typeof(Jobs))]
        public IHttpActionResult PostJobs(Jobs jobs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Jobs.Add(jobs);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = jobs.JobId }, jobs);
        }

        // DELETE: api/JobsAPI/5
        [ResponseType(typeof(Jobs))]
        public IHttpActionResult DeleteJobs(int id)
        {
            Jobs jobs = db.Jobs.Find(id);
            if (jobs == null)
            {
                return NotFound();
            }

            db.Jobs.Remove(jobs);
            db.SaveChanges();

            return Ok(jobs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JobsExists(int id)
        {
            return db.Jobs.Count(e => e.JobId == id) > 0;
        }
    }
}