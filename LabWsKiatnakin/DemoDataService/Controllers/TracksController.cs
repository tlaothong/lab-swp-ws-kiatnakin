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
    builder.EntitySet<Track>("Tracks");
    builder.EntitySet<Album>("Albums"); 
    builder.EntitySet<Genre>("Genres"); 
    builder.EntitySet<InvoiceLine>("InvoiceLines"); 
    builder.EntitySet<MediaType>("MediaTypes"); 
    builder.EntitySet<Playlist>("Playlists"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class TracksController : ODataController
    {
        private ChinookEntities db = new ChinookEntities();

        // GET: odata/Tracks
        [EnableQuery]
        public IQueryable<Track> GetTracks()
        {
            return db.Tracks;
        }

        // GET: odata/Tracks(5)
        [EnableQuery]
        public SingleResult<Track> GetTrack([FromODataUri] int key)
        {
            return SingleResult.Create(db.Tracks.Where(track => track.TrackId == key));
        }

        // PUT: odata/Tracks(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Track> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Track track = db.Tracks.Find(key);
            if (track == null)
            {
                return NotFound();
            }

            patch.Put(track);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(track);
        }

        // POST: odata/Tracks
        public IHttpActionResult Post(Track track)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tracks.Add(track);
            db.SaveChanges();

            return Created(track);
        }

        // PATCH: odata/Tracks(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Track> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Track track = db.Tracks.Find(key);
            if (track == null)
            {
                return NotFound();
            }

            patch.Patch(track);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(track);
        }

        // DELETE: odata/Tracks(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Track track = db.Tracks.Find(key);
            if (track == null)
            {
                return NotFound();
            }

            db.Tracks.Remove(track);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Tracks(5)/Album
        [EnableQuery]
        public SingleResult<Album> GetAlbum([FromODataUri] int key)
        {
            return SingleResult.Create(db.Tracks.Where(m => m.TrackId == key).Select(m => m.Album));
        }

        // GET: odata/Tracks(5)/Genre
        [EnableQuery]
        public SingleResult<Genre> GetGenre([FromODataUri] int key)
        {
            return SingleResult.Create(db.Tracks.Where(m => m.TrackId == key).Select(m => m.Genre));
        }

        // GET: odata/Tracks(5)/InvoiceLines
        [EnableQuery]
        public IQueryable<InvoiceLine> GetInvoiceLines([FromODataUri] int key)
        {
            return db.Tracks.Where(m => m.TrackId == key).SelectMany(m => m.InvoiceLines);
        }

        // GET: odata/Tracks(5)/MediaType
        [EnableQuery]
        public SingleResult<MediaType> GetMediaType([FromODataUri] int key)
        {
            return SingleResult.Create(db.Tracks.Where(m => m.TrackId == key).Select(m => m.MediaType));
        }

        // GET: odata/Tracks(5)/Playlists
        [EnableQuery]
        public IQueryable<Playlist> GetPlaylists([FromODataUri] int key)
        {
            return db.Tracks.Where(m => m.TrackId == key).SelectMany(m => m.Playlists);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TrackExists(int key)
        {
            return db.Tracks.Count(e => e.TrackId == key) > 0;
        }
    }
}
