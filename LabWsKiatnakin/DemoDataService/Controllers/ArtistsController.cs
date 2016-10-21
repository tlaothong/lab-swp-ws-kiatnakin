using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using DemoDataService.Models;

namespace DemoDataService.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using DemoDataService.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Artist>("Artists");
    builder.EntitySet<Album>("Albums"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ArtistsController : ODataController
    {
        private ChinookEntities db = new ChinookEntities();

        // GET: odata/Artists
        [EnableQuery]
        public IQueryable<Artist> GetArtists()
        {
            return db.Artists;
        }

        // GET: odata/Artists(5)
        [EnableQuery]
        public SingleResult<Artist> GetArtist([FromODataUri] int key)
        {
            return SingleResult.Create(db.Artists.Where(artist => artist.ArtistId == key));
        }

        // PUT: odata/Artists(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Artist> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Artist artist = db.Artists.Find(key);
            if (artist == null)
            {
                return NotFound();
            }

            patch.Put(artist);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(artist);
        }

        // POST: odata/Artists
        public IHttpActionResult Post(Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Artists.Add(artist);
            db.SaveChanges();

            return Created(artist);
        }

        // PATCH: odata/Artists(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Artist> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Artist artist = db.Artists.Find(key);
            if (artist == null)
            {
                return NotFound();
            }

            patch.Patch(artist);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(artist);
        }

        // DELETE: odata/Artists(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Artist artist = db.Artists.Find(key);
            if (artist == null)
            {
                return NotFound();
            }

            db.Artists.Remove(artist);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Artists(5)/Albums
        [EnableQuery]
        public IQueryable<Album> GetAlbums([FromODataUri] int key)
        {
            return db.Artists.Where(m => m.ArtistId == key).SelectMany(m => m.Albums);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArtistExists(int key)
        {
            return db.Artists.Count(e => e.ArtistId == key) > 0;
        }
    }
}
